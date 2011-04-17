using System;
using System.IO;

namespace ilSFV.Model.Workset
{
	public class ChecksumFile
	{
		private string _originalChecksum;
		private string _currentChecksum;

		public string FileName { get; set; }
		public FileInfo FileInfo { get; set; }
		public ChecksumFileState State { get; set; }
		public bool IsDeleted { get; set; }

		public string OriginalChecksum
		{
			get { return _originalChecksum; }
			set { _originalChecksum = value == null ? null : value.ToLower(); }
		}

		public string CurrentChecksum
		{
			get { return _currentChecksum; }
			set { _currentChecksum = value == null ? null : value.ToLower(); }
		}

		public DateTime CacheLastWriteUtc { get; set; }
		public long CacheLength { get; set; }
		public string Guid { get; private set; }
		public ChecksumSet Set { get; private set; }

		public ChecksumFile(ChecksumSet set)
		{
			State = ChecksumFileState.NotProcessed;
			Guid = System.Guid.NewGuid().ToString();
			Set = set;
		}
	}
}
