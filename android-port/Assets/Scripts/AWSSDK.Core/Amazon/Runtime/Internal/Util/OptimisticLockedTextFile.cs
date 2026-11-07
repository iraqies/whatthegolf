using System.Collections.Generic;

namespace Amazon.Runtime.Internal.Util
{
	public class OptimisticLockedTextFile
	{
		private string OriginalContents { get; set; }

		public string FilePath { get; private set; }

		public List<string> Lines { get; private set; }

		public OptimisticLockedTextFile(string filePath)
		{
		}

		public void Persist()
		{
		}

		public override string ToString()
		{
			return null;
		}

		private void Read()
		{
		}

		private static bool HasEnding(string line)
		{
			return false;
		}

		private static List<string> ReadLinesWithEndings(string str)
		{
			return null;
		}
	}
}
