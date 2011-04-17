using System.Windows.Forms;

namespace ilSFV
{
	public partial class GetInputForm : Form
	{
		private GetInputForm()
		{
			InitializeComponent();
		}

		public static bool ShowForm(string windowText, string labelText, out string userInput)
		{
			Cursor.Current = Cursors.WaitCursor;
			using (GetInputForm form = new GetInputForm())
			{
				form.Text = windowText;
				form.label1.Text = labelText;
				Cursor.Current = Cursors.Default;
				if (form.ShowDialog() == DialogResult.OK)
				{
					userInput = form.textBox1.Text.Trim();
					return !string.IsNullOrEmpty(userInput);
				}
				else
				{
					userInput = null;
					return false;
				}
			}
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
