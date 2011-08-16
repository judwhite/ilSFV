using System;
using System.Windows.Forms;
using ilSFV.Localization;

namespace ilSFV
{
	public partial class ReleaseNotesForm : Form
	{
		public ReleaseNotesForm()
		{
			InitializeComponent();

            Text = Language.ReleaseNotesForm.Title;
            btnOK.Text = Language.General.OKButton;
		}
	}
}
