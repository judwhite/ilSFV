using System.Collections.Generic;

namespace ilSFV.Model.Workset
{
	public class ChecksumSet
	{
		public string VerificationFileName { get; set; }
		public string Directory { get; set; }
		public List<ChecksumFile> Files { get; private set; }
		public long TotalSize { get; set; }
		public ChecksumType Type { get; set; }
		public string Comments { get; set; }
		public string QuickSfvAnalysis { get; set; }

		public ChecksumSet(string fileName, string directory, ChecksumType setType)
		{
			VerificationFileName = fileName;
			Directory = directory;
			Type = setType;
			Files = new List<ChecksumFile>();
		}
	}
}
