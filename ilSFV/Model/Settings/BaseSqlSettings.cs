using System.Data;
using System.Data.SqlServerCe;

namespace ilSFV.Model.Settings
{
	public abstract class BaseSqlSettings
	{
		public DataRow GetDataRow(string tableName)
		{
			using (SqlCeCommand cmd = new SqlCeCommand("select * from " + tableName, Program.GetOpenSettingsConnection()))
			using (SqlCeDataAdapter da = new SqlCeDataAdapter(cmd))
			{
				DataSet ds = new DataSet();
				da.Fill(ds);

				return ds.Tables[0].Rows[0];
			}
		}
	}
}
