using System;
using System.Data;
using System.Data.SqlServerCe;

namespace ilSFV.Model.Settings
{
	public class CommentSettings : BaseSqlSettings
	{
		public bool WriteComments { get; set; }
		public string Header { get; set; }
		public string Content { get; set; }
		public string Footer { get; set; }

		public void Save()
		{
			const string updateSql = @"update Comments set
WriteComments = @WriteComments,
Header = @Header,
Content = @Content,
Footer = @Footer
";

			using (SqlCeCommand cmd = new SqlCeCommand(updateSql, Program.GetOpenSettingsConnection()))
			{
				cmd.Parameters.AddWithValue("@WriteComments", WriteComments);
				cmd.Parameters.AddWithValue("@Header", Header);
				cmd.Parameters.AddWithValue("@Content", Content);
				cmd.Parameters.AddWithValue("@Footer", Footer);

				cmd.ExecuteNonQuery();
			}
		}

		public void Load()
		{
			DataRow dr = GetDataRow("Comments");

			WriteComments = Convert.ToBoolean(dr["WriteComments"]);
			Header = Convert.ToString(dr["Header"]);
			Content = Convert.ToString(dr["Content"]);
			Footer = Convert.ToString(dr["Footer"]);
		}
	}
}
