using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace ilSFV.Model.Settings
{
	public class GeneralSettings : BaseSqlSettings
	{
		public string Language { get; set; }
		public int CacheSize { get; set; }
		public bool AlwaysOnTop { get; set; }
		public bool RememberWindowPlacement { get; set; }
		public bool ReuseWindow { get; set; }
		public bool FlashWindowWhenDone { get; set; }
		public bool AutoScrollFileList { get; set; }
		public bool Recursive { get; set; }
		public bool UseLowPriorityOnHide { get; set; }
        public bool IsRecentFilesSaved { get; set; }

		public bool HideGoodFiles { get; set; }
		public bool ShowCommentsPane { get; set; }
		public bool UseCachedResults { get; set; }
		public int WindowHeight { get; set; }
		public int WindowWidth { get; set; }
		public int WindowLeft { get; set; }
		public int WindowTop { get; set; }
		public FormWindowState FormWindowState { get; set; }

		public bool CheckForUpdates { get; set; }
		public DateTime? LastUpdateCheck { get; set; }
		public int UpdateCheckFrequency { get; set; }

		public void Save()
		{
			const string updateSql = @"update General set
CheckForUpdates = @CheckForUpdates,
LastUpdateCheck = @LastUpdateCheck,
UpdateCheckFrequency = @UpdateCheckFrequency,
Language = @Language,
CacheSize = @CacheSize,
AlwaysOnTop = @AlwaysOnTop,
RememberWindowPlacement = @RememberWindowPlacement,
ReuseWindow = @ReuseWindow,
FlashWindowWhenDone = @FlashWindowWhenDone,
AutoScrollFileList = @AutoScrollFileList,
Recursive = @Recursive,
HideGoodFiles = @HideGoodFiles,
ShowCommentsPane = @ShowCommentsPane,
UseCachedResults = @UseCachedResults,
WindowHeight = @WindowHeight,
WindowWidth = @WindowWidth,
WindowLeft = @WindowLeft,
WindowTop = @WindowTop,
FormWindowState = @FormWindowState,
UseLowPriorityOnHide = @UseLowPriorityOnHide,
IsRecentFilesSaved = @IsRecentFilesSaved
";

			using (SqlCeCommand cmd = new SqlCeCommand(updateSql, Program.GetOpenSettingsConnection()))
			{
				cmd.Parameters.AddWithValue("@CheckForUpdates", CheckForUpdates);
				cmd.Parameters.AddWithValue("@LastUpdateCheck", LastUpdateCheck);
				cmd.Parameters.AddWithValue("@UpdateCheckFrequency", UpdateCheckFrequency);
				cmd.Parameters.AddWithValue("@Language", Language);
				cmd.Parameters.AddWithValue("@CacheSize", CacheSize);
				cmd.Parameters.AddWithValue("@AlwaysOnTop", AlwaysOnTop);
				cmd.Parameters.AddWithValue("@RememberWindowPlacement", RememberWindowPlacement);
				cmd.Parameters.AddWithValue("@ReuseWindow", ReuseWindow);
				cmd.Parameters.AddWithValue("@FlashWindowWhenDone", FlashWindowWhenDone);
				cmd.Parameters.AddWithValue("@AutoScrollFileList", AutoScrollFileList);
				cmd.Parameters.AddWithValue("@Recursive", Recursive);
				cmd.Parameters.AddWithValue("@HideGoodFiles", HideGoodFiles);
				cmd.Parameters.AddWithValue("@ShowCommentsPane", ShowCommentsPane);
				cmd.Parameters.AddWithValue("@UseCachedResults", UseCachedResults);
				cmd.Parameters.AddWithValue("@WindowHeight", WindowHeight);
				cmd.Parameters.AddWithValue("@WindowWidth", WindowWidth);
				cmd.Parameters.AddWithValue("@WindowLeft", WindowLeft);
				cmd.Parameters.AddWithValue("@WindowTop", WindowTop);
				cmd.Parameters.AddWithValue("@FormWindowState", FormWindowState);
				cmd.Parameters.AddWithValue("@UseLowPriorityOnHide", UseLowPriorityOnHide);
                cmd.Parameters.AddWithValue("@IsRecentFilesSaved", IsRecentFilesSaved);

				cmd.ExecuteNonQuery();
			}

            if (!IsRecentFilesSaved)
            {
                using (SqlCeCommand cmd = new SqlCeCommand("delete from RecentFile", Program.GetOpenSettingsConnection()))
                {
                    cmd.ExecuteNonQuery();
                }
            }
		}

		public void Load()
		{
			DataRow dr = GetDataRow("General");

			Language = Convert.ToString(dr["Language"]);
			CacheSize = Convert.ToInt32(dr["CacheSize"]);
			AlwaysOnTop = Convert.ToBoolean(dr["AlwaysOnTop"]);
			RememberWindowPlacement = Convert.ToBoolean(dr["RememberWindowPlacement"]);
			ReuseWindow = Convert.ToBoolean(dr["ReuseWindow"]);
			FlashWindowWhenDone = Convert.ToBoolean(dr["FlashWindowWhenDone"]);
			AutoScrollFileList = Convert.ToBoolean(dr["AutoScrollFileList"]);
			Recursive = Convert.ToBoolean(dr["Recursive"]);
			HideGoodFiles = Convert.ToBoolean(dr["HideGoodFiles"]);
			ShowCommentsPane = Convert.ToBoolean(dr["ShowCommentsPane"]);
			UseCachedResults = Convert.ToBoolean(dr["UseCachedResults"]);
			WindowHeight = Convert.ToInt32(dr["WindowHeight"]);
			WindowWidth = Convert.ToInt32(dr["WindowWidth"]);
			WindowLeft = Convert.ToInt32(dr["WindowLeft"]);
			WindowTop = Convert.ToInt32(dr["WindowTop"]);
			FormWindowState = (FormWindowState)Enum.Parse(typeof(FormWindowState), Convert.ToString(dr["FormWindowState"]));
			CheckForUpdates = Convert.ToBoolean(dr["CheckForUpdates"]);
			UpdateCheckFrequency = Convert.ToInt32(dr["UpdateCheckFrequency"]);
			UseLowPriorityOnHide = Convert.ToBoolean(dr["UseLowPriorityOnHide"]);
            IsRecentFilesSaved = Convert.ToBoolean(dr["IsRecentFilesSaved"]);

			object lastUpdateCheck = dr["LastUpdateCheck"];
			LastUpdateCheck = DBNull.Value.Equals(lastUpdateCheck) ? (DateTime?)null : Convert.ToDateTime(lastUpdateCheck);
		}
	}
}
