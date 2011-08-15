using System;
using System.Windows.Forms;

namespace ilSFV
{
	public partial class ReleaseNotesForm : Form
	{
		public ReleaseNotesForm()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
