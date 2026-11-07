using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Amazon.Runtime.Internal.Util
{
	public class IniFile
	{
		private const string sectionNamePrefix = "[";

		private const string sectionNameSuffix = "]";

		private const string keyValueSeparator = "=";

		private const string semiColonComment = ";";

		private const string hashComment = "#";

		private OptimisticLockedTextFile textFile;

		private Logger logger;

		public string FilePath => null;

		private List<string> Lines => null;

		public IniFile(string filePath)
		{
		}

		public void Persist()
		{
		}

		public void RenameSection(string oldSectionName, string newSectionName)
		{
		}

		public void RenameSection(string oldSectionName, string newSectionName, bool force)
		{
		}

		public void CopySection(string fromSectionName, string toSectionName, Dictionary<string, string> replaceProperties)
		{
		}

		public void CopySection(string fromSectionName, string toSectionName, Dictionary<string, string> replaceProperties, bool force)
		{
		}

		public void EditSection(string sectionName, SortedDictionary<string, string> properties)
		{
		}

		public void EnsureSectionExists(string sectionName)
		{
		}

		public void DeleteSection(string sectionName)
		{
		}

		public virtual HashSet<string> ListSectionNames()
		{
			return null;
		}

		public bool SectionExists(string sectionName)
		{
			return false;
		}

		public virtual bool TryGetSection(string sectionName, out Dictionary<string, string> properties)
		{
			properties = null;
			return false;
		}

		public bool TryGetSection(Regex sectionNameRegex, out Dictionary<string, string> properties)
		{
			properties = null;
			return false;
		}

		public bool TryGetSection(Regex sectionNameRegex, out string sectionName, out Dictionary<string, string> properties)
		{
			sectionName = null;
			properties = null;
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		private bool IsDuplicateProperty(Dictionary<string, string> properties, string propertyName, string sectionName, int lineNumber)
		{
			return false;
		}

		private void Validate()
		{
		}

		private bool TrySeekSection(Regex sectionNameRegex, ref int lineNumber, out string sectionName)
		{
			sectionName = null;
			return false;
		}

		private bool TrySeekSection(string sectionName, ref int lineNumber)
		{
			return false;
		}

		private bool SeekSection(ref int lineNumber, out string sectionName)
		{
			sectionName = null;
			return false;
		}

		private bool SeekProperty(ref int lineNumber, out string propertyName, out string propertyValue)
		{
			propertyName = null;
			propertyValue = null;
			return false;
		}

		private string GetErrorMessage(int lineNumber)
		{
			return null;
		}

		private static bool IsCommentOrBlank(string line)
		{
			return false;
		}

		private static bool IsSection(string line)
		{
			return false;
		}

		private static bool TryParseSection(string line, out string sectionName)
		{
			sectionName = null;
			return false;
		}

		private static bool IsProperty(string line)
		{
			return false;
		}

		private static bool TryParseProperty(string line, out string propertyName, out string propertyValue)
		{
			propertyName = null;
			propertyValue = null;
			return false;
		}

		private static string GetPropertyLine(string propertyName, string propertyValue)
		{
			return null;
		}

		private string GetLineMessage(int lineNumber)
		{
			return null;
		}
	}
}
