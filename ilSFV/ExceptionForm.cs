using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Reflection;
using ilSFV.Localization;

namespace ilSFV
{
	/// <summary>
	/// Exception form.
	/// </summary>
	public partial class ExceptionForm : Form
	{
		/// <summary>
		/// Exception form constructor.
		/// </summary>
		/// <param name="message">The error message.</param>
		/// <param name="stackTrace">The stack trace.</param>
		/// <param name="isTopMost">if <c>true</c>, set TopMost = true.</param>
		/// <param name="occuredDuringStartup">set to <c>true</c> if the error occured during application startup.</param>
		public ExceptionForm(string message, string stackTrace, bool isTopMost, bool occuredDuringStartup)
		{
			InitializeComponent();

			if (isTopMost)
			{
				StartPosition = FormStartPosition.CenterScreen;
				TopMost = true;
			}

            var lang = Language.ExceptionForm;
            Text = lang.Title;
            tabPage1.Text = lang.ErrorMessageTab;
            tabPage2.Text = lang.StackTraceTab;
            btnReportBug.Text = lang.ReportBugButton;
            btnIgnore.Text = lang.IgnoreButton;
            lblMainLabel.Text = lang.AnErrorHasOccurred;

			if (occuredDuringStartup)
			{
				txtErrorMessage.Text = string.Format("{0}\r\n\r\n{1}", lang.ErrorOccurredDuringStartup, message);
			}
			else
			{
				txtErrorMessage.Text = message;
			}

			txtStackTrace.Text = stackTrace;

			Thread t = new Thread(SubmitErrorNoThrow);
			t.Start();
		}

		private void SubmitErrorNoThrow()
		{
			try
			{
				SubmitError("AUTO");
			}
			catch
			{
			}
		}

		private void btnReportBug_Click(object sender, EventArgs e)
		{
            var lang = Language.ExceptionForm;

			string email = null;
			DialogResult res = MessageBox.Show(lang.WouldYouLikeAResponse_Message, lang.WouldYouLikeAResponse_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (res == DialogResult.Yes)
			{
				GetInputForm.ShowForm(lang.HowCanWeContactYou_Title, lang.HowCanWeContactYou_Message, out email);
			}

			try
			{
				Cursor.Current = Cursors.WaitCursor;

				SubmitError(email);

				Cursor.Current = Cursors.Default;

				MessageBox.Show(lang.SubmitBugSuccessful_Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

				Close();
			}
			catch (Exception ex)
			{
				Cursor.Current = Cursors.Default;
				MessageBox.Show(ex.Message, lang.SubmitBugError_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		/// <summary>
		/// Submits the error.
		/// </summary>
		private void SubmitError(string email)
		{
			List<PostData> postData = new List<PostData>();
			postData.Add(new PostData("dummy", ""));
			postData.Add(new PostData("msg", txtErrorMessage.Text));
			postData.Add(new PostData("stacktrace", txtStackTrace.Text));
			postData.Add(new PostData("os", Environment.OSVersion.ToString()));
			postData.Add(new PostData("ver", Assembly.GetExecutingAssembly().FullName));
			postData.Add(new PostData("email", email ?? string.Empty));
			postData.Add(new PostData("comments", ""));

			IWebProxy proxy = WebRequest.DefaultWebProxy;
			proxy.Credentials = new NetworkCredential();

			Http.PostAsync("http://www.cdtag.com/ilsfvbug.php", postData, proxy);
		}

		private void ExceptionForm_Activated(object sender, EventArgs e)
		{
			txtErrorMessage.Focus();
		}

		private void btnIgnore_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
