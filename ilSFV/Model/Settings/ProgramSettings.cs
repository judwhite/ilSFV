using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;

namespace ilSFV.Model.Settings
{
	public class ProgramSettings
	{
		public readonly GeneralSettings General = new GeneralSettings();
		public readonly CheckSettings Check = new CheckSettings();
		public readonly CreateSettings Create = new CreateSettings();
		public readonly Statistics Statistics = new Statistics();
		public readonly CommentSettings Comments = new CommentSettings();

		private List<string> _recentFiles;
		public IEnumerable<string> GetRecentFiles()
		{
			if (_recentFiles == null)
			{
				_recentFiles = new List<string>();
				using (SqlCeCommand cmd = new SqlCeCommand("select Path from RecentFile order by ID desc", Program.GetOpenSettingsConnection()))
				using (SqlCeDataAdapter da = new SqlCeDataAdapter(cmd))
				{
					DataSet ds = new DataSet();
					da.Fill(ds);

					foreach (DataRow dr in ds.Tables[0].Rows)
					{
						_recentFiles.Add(Convert.ToString(dr[0]));
						if (_recentFiles.Count >= 4)
							break;
					}
				}
			}

			return _recentFiles;
		}

		public void AddRecentFile(string path)
		{
			GetRecentFiles();

			List<string> found = _recentFiles.Where(p => p.ToLower() == path.ToLower()).ToList();
			if (found.Count >= 1)
			{
				_recentFiles.Remove(found[0]);
			}
			else
			{
				while (_recentFiles.Count >= 4)
					_recentFiles.RemoveAt(3);
			}

			_recentFiles.Insert(0, path);
		}

		public void Save()
		{
			if (_recentFiles == null)
				return;

			using (SqlCeCommand cmd = new SqlCeCommand("delete from RecentFile", Program.GetOpenSettingsConnection()))
			{
				cmd.ExecuteNonQuery();
			}

			List<string> list = new List<string>(_recentFiles);
			list.Reverse();

			foreach (string path in list)
			{
				using (SqlCeCommand cmd = new SqlCeCommand("insert into RecentFile (Path) values(@Path)", Program.GetOpenSettingsConnection()))
				{
					cmd.Parameters.AddWithValue("@Path", path);
					cmd.ExecuteNonQuery();
				}
			}
		}

		public ProgramSettings()
		{
			UpgradeSettingsDatabase();
			UpgradeCacheDatabase();
		}

		private static void UpgradeCacheDatabase()
		{
			int version;
			int initialVersion;

			// Get DatabaseSetting Version
			using (SqlCeCommand cmd = new SqlCeCommand("select Version from DatabaseSetting", Program.GetOpenCacheConnection()))
			using (SqlCeDataAdapter da = new SqlCeDataAdapter(cmd))
			{
				DataSet ds = new DataSet();
				da.Fill(ds);

				if (ds.Tables[0].Rows.Count == 0)
				{
					initialVersion = version = 0;
				}
				else
				{
					initialVersion = version = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
				}
			}

			// Run Upgrades
			if (version == 0)
			{
				Program.RegisterFileTypes(false); // add .sha1

				try
				{
					using (SqlCeCommand cmd = new SqlCeCommand("create table SHA1FileCache (ID bigint primary key identity, FileName nvarchar(1024) not null, LastWriteUtc datetime not null, FileLength bigint not null, SHA1 nvarchar(40) not null);", Program.GetOpenCacheConnection()))
					{
						cmd.ExecuteNonQuery();
					}
				}
				catch (Exception ex)
				{
					if (!ex.Message.ToLower().Contains("table already exists"))
						throw;
				}

				version++;
			}

			// Update DatabaseSetting Version
			if (initialVersion != version)
			{
				if (initialVersion == 0)
				{
					using (SqlCeCommand cmd = new SqlCeCommand("insert into DatabaseSetting (Version) values(@Version);", Program.GetOpenCacheConnection()))
					{
						cmd.Parameters.AddWithValue("@Version", version);
						cmd.ExecuteNonQuery();
					}
				}
				else
				{
					using (SqlCeCommand cmd = new SqlCeCommand("update DatabaseSetting set Version = @Version", Program.GetOpenCacheConnection()))
					{
						cmd.Parameters.AddWithValue("@Version", version);
						cmd.ExecuteNonQuery();
					}
				}
			}
		}

		private static void UpgradeSettingsDatabase()
		{
			int version;
			int initialVersion;

			// Get DatabaseSetting Version
			using (SqlCeCommand cmd = new SqlCeCommand("select Version from DatabaseSetting", Program.GetOpenSettingsConnection()))
			using (SqlCeDataAdapter da = new SqlCeDataAdapter(cmd))
			{
				DataSet ds = new DataSet();
				da.Fill(ds);

				if (ds.Tables[0].Rows.Count == 0)
				{
					initialVersion = version = 0;
				}
				else
				{
					initialVersion = version = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
				}
			}

			// Run Upgrades
			if (version == 0)
			{
				using (SqlCeCommand cmd = new SqlCeCommand("create table RecentFile (ID int primary key identity, Path nvarchar(1024) not null)", Program.GetOpenSettingsConnection()))
				{
					cmd.ExecuteNonQuery();
				}
				version++;
			}

			if (version == 1)
			{
				using (SqlCeCommand cmd = new SqlCeCommand("alter table General add CheckForUpdates bit not null default(1)", Program.GetOpenSettingsConnection()))
					cmd.ExecuteNonQuery();
				using (SqlCeCommand cmd = new SqlCeCommand("alter table General add LastUpdateCheck datetime not null default('2002-10-30')", Program.GetOpenSettingsConnection()))
					cmd.ExecuteNonQuery();
				using (SqlCeCommand cmd = new SqlCeCommand("alter table General add UpdateCheckFrequency int not null default(7)", Program.GetOpenSettingsConnection()))
					cmd.ExecuteNonQuery();
				version++;
			}

			if (version == 2)
			{
				using (SqlCeCommand cmd = new SqlCeCommand("update Creating set ExcludeFilesOfType = ExcludeFilesOfType + ';.sha1';", Program.GetOpenSettingsConnection()))
					cmd.ExecuteNonQuery();
				version++;
			}

			if (version == 3)
			{
				using (SqlCeCommand cmd = new SqlCeCommand("alter table Checking add AutoVerify bit not null default(1);", Program.GetOpenSettingsConnection()))
					cmd.ExecuteNonQuery();
				version++;
			}

			if (version == 4)
			{
				using (SqlCeCommand cmd = new SqlCeCommand("alter table Checking add PlaySoundOK bit not null default(1), PlaySoundOK_IfInactive bit not null default(1), PlaySoundError bit not null default(1);", Program.GetOpenSettingsConnection()))
					cmd.ExecuteNonQuery();
				version++;
			}

			if (version == 5)
			{
				using (SqlCeCommand cmd = new SqlCeCommand("alter table Creating add CreateForEachSubDir bit not null default(0);", Program.GetOpenSettingsConnection()))
					cmd.ExecuteNonQuery();
				version++;
			}

			if (version == 6)
			{
				using (SqlCeCommand cmd = new SqlCeCommand("create table Comments (ID int primary key identity, WriteComments bit not null, Header nvarchar(2048) not null, Content nvarchar(512) not null, Footer nvarchar(2048) not null);", Program.GetOpenSettingsConnection()))
					cmd.ExecuteNonQuery();
				using (SqlCeCommand cmd = new SqlCeCommand("insert into Comments (WriteComments, Header, Content, Footer) values(1, '', '', '');", Program.GetOpenSettingsConnection()))
					cmd.ExecuteNonQuery();
				CommentSettings comments = new CommentSettings();
				comments.Load();
				comments.Header = " Using ilSFV on {0:yyyy-MM-dd} at {0:HH:mm.ss}" + Environment.NewLine + " http://cdtag.com/ilsfv";
				comments.Content = "{0,13:#,0}  {1:HH:mm.ss} {1:yyyy-MM-dd} {2}";
				comments.Footer = "";
				comments.Save();
				version++;
			}

			if (version == 7)
			{
				using (SqlCeCommand cmd = new SqlCeCommand("alter table General add UseLowPriorityOnHide bit not null default(1)", Program.GetOpenSettingsConnection()))
					cmd.ExecuteNonQuery();
				version++;
			}

			// Update DatabaseSetting Version
			if (initialVersion != version)
			{
				if (initialVersion == 0)
				{
					using (SqlCeCommand cmd = new SqlCeCommand("insert into DatabaseSetting (Version) values(@Version);", Program.GetOpenSettingsConnection()))
					{
						cmd.Parameters.AddWithValue("@Version", version);
						cmd.ExecuteNonQuery();
					}
				}
				else
				{
					using (SqlCeCommand cmd = new SqlCeCommand("update DatabaseSetting set Version = @Version", Program.GetOpenSettingsConnection()))
					{
						cmd.Parameters.AddWithValue("@Version", version);
						cmd.ExecuteNonQuery();
					}
				}
			}
		}
	}
}
