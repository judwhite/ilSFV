using System;
using System.IO;
using System.Text;
using ilSFV.Localization;
using ilSFV.Model.Workset;

namespace ilSFV
{
    class InvalidChecksumFileException : Exception
    {
        // TODO: Localize "Line"
        public InvalidChecksumFileException(string fileName, ChecksumType checksumType, string[] lines, int lineIndex, int codePage)
            : base(string.Format("Line {0}: \"{1}\"", lineIndex + 1, lines[lineIndex]) + Environment.NewLine + Environment.NewLine +
                   string.Format(Language.MainForm.FileContentsNotRecognized, fileName, checksumType, File.ReadAllText(fileName, Encoding.GetEncoding(codePage)))
            )
        {
        }
    }
}
