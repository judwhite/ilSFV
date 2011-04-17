using System;
using System.Data;
using System.Data.SqlServerCe;

namespace ilSFV.Model.Settings
{
	public class CheckSettings : BaseSqlSettings
	{
		public bool AutoFindRenames { get; set; }
		public bool UseRecyleBin { get; set; }
		public bool RenameBadFiles { get; set; }
		public bool CreateMissingMarkers { get; set; }
		public bool CleanupBadMissing { get; set; }
		public bool DeleteFailedFiles { get; set; }
		public bool AutoCloseWhenDoneChecking { get; set; }
		public bool AutoCloseWhenDoneCheckingOnlyIfAllOK { get; set; }
		public CheckRenaming Renaming { get; set; }
		public bool AutoVerify { get; set; }
		public bool PlaySoundOK { get; set; }
		public bool PlaySoundOK_OnlyIfInactive { get; set; }
		public bool PlaySoundError { get; set; }

		public void Save()
		{
			const string updateSql = @"update Checking set
AutoFindRenames = @AutoFindRenames,
AutoVerify = @AutoVerify,
UseRecyleBin = @UseRecyleBin,
RenameBadFiles = @RenameBadFiles,
CreateMissingMarkers = @CreateMissingMarkers,
CleanupBadMissing = @CleanupBadMissing,
DeleteFailedFiles = @DeleteFailedFiles,
AutoCloseWhenDoneChecking = @AutoCloseWhenDoneChecking,
AutoCloseWhenDoneCheckingOnlyIfAllOK = @AutoCloseWhenDoneCheckingOnlyIfAllOK,
Renaming = @Renaming,
PlaySoundOK = @PlaySoundOK,
PlaySoundOK_IfInactive = @PlaySoundOK_IfInactive,
PlaySoundError = @PlaySoundError
";

			using (SqlCeCommand cmd = new SqlCeCommand(updateSql, Program.GetOpenSettingsConnection()))
			{
				cmd.Parameters.AddWithValue("@AutoFindRenames", AutoFindRenames);
				cmd.Parameters.AddWithValue("@AutoVerify", AutoVerify);
				cmd.Parameters.AddWithValue("@UseRecyleBin", UseRecyleBin);
				cmd.Parameters.AddWithValue("@RenameBadFiles", RenameBadFiles);
				cmd.Parameters.AddWithValue("@CreateMissingMarkers", CreateMissingMarkers);
				cmd.Parameters.AddWithValue("@CleanupBadMissing", CleanupBadMissing);
				cmd.Parameters.AddWithValue("@DeleteFailedFiles", DeleteFailedFiles);
				cmd.Parameters.AddWithValue("@AutoCloseWhenDoneChecking", AutoCloseWhenDoneChecking);
				cmd.Parameters.AddWithValue("@AutoCloseWhenDoneCheckingOnlyIfAllOK", AutoCloseWhenDoneCheckingOnlyIfAllOK);
				cmd.Parameters.AddWithValue("@Renaming", Renaming);
				cmd.Parameters.AddWithValue("@PlaySoundOK", PlaySoundOK);
				cmd.Parameters.AddWithValue("@PlaySoundOK_IfInactive", PlaySoundOK_OnlyIfInactive);
				cmd.Parameters.AddWithValue("@PlaySoundError", PlaySoundError);

				cmd.ExecuteNonQuery();
			}
		}

		public void Load()
		{
			DataRow dr = GetDataRow("Checking");

			AutoFindRenames = Convert.ToBoolean(dr["AutoFindRenames"]);
			AutoVerify = Convert.ToBoolean(dr["AutoVerify"]);
			UseRecyleBin = Convert.ToBoolean(dr["UseRecyleBin"]);
			RenameBadFiles = Convert.ToBoolean(dr["RenameBadFiles"]);
			CreateMissingMarkers = Convert.ToBoolean(dr["CreateMissingMarkers"]);
			CleanupBadMissing = Convert.ToBoolean(dr["CleanupBadMissing"]);
			DeleteFailedFiles = Convert.ToBoolean(dr["DeleteFailedFiles"]);
			AutoCloseWhenDoneChecking = Convert.ToBoolean(dr["AutoCloseWhenDoneChecking"]);
			AutoCloseWhenDoneCheckingOnlyIfAllOK = Convert.ToBoolean(dr["AutoCloseWhenDoneCheckingOnlyIfAllOK"]);
			Renaming = (CheckRenaming)Enum.Parse(typeof(CheckRenaming), Convert.ToString(dr["Renaming"]));
			PlaySoundOK = Convert.ToBoolean(dr["PlaySoundOK"]);
			PlaySoundOK_OnlyIfInactive = Convert.ToBoolean(dr["PlaySoundOK_IfInactive"]);
			PlaySoundError = Convert.ToBoolean(dr["PlaySoundError"]);
		}
	}

	public enum CheckRenaming
	{
		None,
		MatchSet,
		Lowercase
	}
}
