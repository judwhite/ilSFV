namespace ilSFV.Localization
{
    public class RemoveDuplicatesForm
    {
        ///<summary>Find and Delete Duplicate Files</summary>
        public string Title { get; set; }

        ///<summary>Duplicates</summary>
        public string DuplicatesColumnHeader { get; set; }

        ///<summary>Count</summary>
        public string CountColumnHeader { get; set; }

        ///<summary>Select file to keep</summary>
        public string SelectFileToKeep { get; set; }

        ///<summary>File name</summary>
        public string FileNameColumnHeader { get; set; }

        ///<summary>Optional: Select directories to delete all duplicates from</summary>
        public string OptionalSelectDirsToDeleteAllDuplicatesFrom { get; set; }

        ///<summary>Directory</summary>
        public string DirectoryColumnHeader { get; set; }

        ///<summary>&Delete Duplicates</summary>
        public string DeleteDuplicatesButton { get; set; }

        ///<summary>'{0}' does not exist.</summary>
        public string SourceFileDoesNotExist_Message { get; set; }

        ///<summary>File not found</summary>
        public string SourceFileDoesNotExist_Title { get; set; }

        ///<summary>Are you sure you want to use '{0}' as the source file?</summary>
        public string ConfirmSourceFile_Message { get; set; }

        ///<summary>Remove duplicates</summary>
        public string ConfirmSourceFile_Title { get; set; }

        ///<summary>Are you sure want to delete all {0:#,0} duplicate(s) in '{1}'?</summary>
        public string ConfirmDelete_Message { get; set; }

        ///<summary>The following items will be deleted:</summary>
        public string ConfirmDelete_Message_FileListHeader { get; set; }

        ///<summary>Remove duplicates</summary>
        public string ConfirmDelete_Title { get; set; }

        ///<summary>Would you like to rewrite the checksum file without the {0:#,0} deleted files?\n\nNote: Comments will be removed.</summary>
        public string RewriteChecksum_Message { get; set; }

        ///<summary>Rewrite Checksum File</summary>
        public string RewriteChecksum_Title { get; set; }
    }
}
