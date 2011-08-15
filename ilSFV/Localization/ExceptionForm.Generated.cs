namespace ilSFV.Localization
{
    public class ExceptionForm
    {
        ///<summary>Exception Handler</summary>
        public string Title { get; set; }

        ///<summary>&Ignore</summary>
        public string IgnoreButton { get; set; }

        ///<summary>&Report bug</summary>
        public string ReportBugButton { get; set; }

        ///<summary>Error Message</summary>
        public string ErrorMessageTab { get; set; }

        ///<summary>Stack Trace</summary>
        public string StackTraceTab { get; set; }

        ///<summary>This error occurred during startup.</summary>
        public string ErrorOccurredDuringStartup { get; set; }

        ///<summary>Would you like a response when the bug is fixed?</summary>
        public string WouldYouLikeAResponse_Message { get; set; }

        ///<summary>Submit bug</summary>
        public string WouldYouLikeAResponse_Title { get; set; }

        ///<summary>How can we contact you? (email, website, etc)</summary>
        public string HowCanWeContactYou_Message { get; set; }

        ///<summary>Submit bug</summary>
        public string HowCanWeContactYou_Title { get; set; }

        ///<summary>Thank you. This bug has been successfully submitted.</summary>
        public string SubmitBugSuccessful_Message { get; set; }

        ///<summary>Error submitting bug</summary>
        public string SubmitBugError_Title { get; set; }
    }
}
