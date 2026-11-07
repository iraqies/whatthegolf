using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x2000201")]
	public class IniFile
	{
		[Token(Token = "0x4000795")]
		private const string sectionNamePrefix = "[";

		[Token(Token = "0x4000796")]
		private const string sectionNameSuffix = "]";

		[Token(Token = "0x4000797")]
		private const string keyValueSeparator = "=";

		[Token(Token = "0x4000798")]
		private const string semiColonComment = ";";

		[Token(Token = "0x4000799")]
		private const string hashComment = "#";

		[Token(Token = "0x400079A")]
		[FieldOffset(Offset = "0x10")]
		private OptimisticLockedTextFile textFile;

		[Token(Token = "0x400079B")]
		[FieldOffset(Offset = "0x18")]
		private Logger logger;

		[Token(Token = "0x170003F7")]
		public string FilePath
		{
			[Token(Token = "0x6000FAB")]
			[Address(RVA = "0x1215B88", Offset = "0x1215B88", VA = "0x1215B88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003F8")]
		private List<string> Lines
		{
			[Token(Token = "0x6000FAC")]
			[Address(RVA = "0x1215BA4", Offset = "0x1215BA4", VA = "0x1215BA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000FAA")]
		[Address(RVA = "0x1215990", Offset = "0x1215990", VA = "0x1215990")]
		public IniFile(string filePath)
		{
		}

		[Token(Token = "0x6000FAD")]
		[Address(RVA = "0x1215BC0", Offset = "0x1215BC0", VA = "0x1215BC0")]
		public void Persist()
		{
		}

		[Token(Token = "0x6000FAE")]
		[Address(RVA = "0x1215BF0", Offset = "0x1215BF0", VA = "0x1215BF0")]
		public void RenameSection(string oldSectionName, string newSectionName)
		{
		}

		[Token(Token = "0x6000FAF")]
		[Address(RVA = "0x1215BF8", Offset = "0x1215BF8", VA = "0x1215BF8")]
		public void RenameSection(string oldSectionName, string newSectionName, bool force)
		{
		}

		[Token(Token = "0x6000FB0")]
		[Address(RVA = "0x121623C", Offset = "0x121623C", VA = "0x121623C")]
		public void CopySection(string fromSectionName, string toSectionName, Dictionary<string, string> replaceProperties)
		{
		}

		[Token(Token = "0x6000FB1")]
		[Address(RVA = "0x1216244", Offset = "0x1216244", VA = "0x1216244")]
		public void CopySection(string fromSectionName, string toSectionName, Dictionary<string, string> replaceProperties, bool force)
		{
		}

		[Token(Token = "0x6000FB2")]
		[Address(RVA = "0x121693C", Offset = "0x121693C", VA = "0x121693C")]
		public void EditSection(string sectionName, SortedDictionary<string, string> properties)
		{
		}

		[Token(Token = "0x6000FB3")]
		[Address(RVA = "0x1216FC0", Offset = "0x1216FC0", VA = "0x1216FC0")]
		public void EnsureSectionExists(string sectionName)
		{
		}

		[Token(Token = "0x6000FB4")]
		[Address(RVA = "0x1215F1C", Offset = "0x1215F1C", VA = "0x1215F1C")]
		public void DeleteSection(string sectionName)
		{
		}

		[Token(Token = "0x6000FB5")]
		[Address(RVA = "0x12172B8", Offset = "0x12172B8", VA = "0x12172B8", Slot = "4")]
		public virtual HashSet<string> ListSectionNames()
		{
			return null;
		}

		[Token(Token = "0x6000FB6")]
		[Address(RVA = "0x1217470", Offset = "0x1217470", VA = "0x1217470")]
		public bool SectionExists(string sectionName)
		{
			return default;
		}

		[Token(Token = "0x6000FB7")]
		[Address(RVA = "0x12174F8", Offset = "0x12174F8", VA = "0x12174F8", Slot = "5")]
		public virtual bool TryGetSection(string sectionName, out Dictionary<string, string> properties)
		{
			return default;
		}

		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0x12178A8", Offset = "0x12178A8", VA = "0x12178A8")]
		public bool TryGetSection(Regex sectionNameRegex, out Dictionary<string, string> properties)
		{
			return default;
		}

		[Token(Token = "0x6000FB9")]
		[Address(RVA = "0x12178D0", Offset = "0x12178D0", VA = "0x12178D0")]
		public bool TryGetSection(Regex sectionNameRegex, out string sectionName, out Dictionary<string, string> properties)
		{
			return default;
		}

		[Token(Token = "0x6000FBA")]
		[Address(RVA = "0x1217B84", Offset = "0x1217B84", VA = "0x1217B84", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000FBB")]
		[Address(RVA = "0x1217724", Offset = "0x1217724", VA = "0x1217724")]
		private bool IsDuplicateProperty(Dictionary<string, string> properties, string propertyName, string sectionName, int lineNumber)
		{
			return default;
		}

		[Token(Token = "0x6000FBC")]
		[Address(RVA = "0x1215A5C", Offset = "0x1215A5C", VA = "0x1215A5C")]
		private void Validate()
		{
		}

		[Token(Token = "0x6000FBD")]
		[Address(RVA = "0x1217ACC", Offset = "0x1217ACC", VA = "0x1217ACC")]
		private bool TrySeekSection(Regex sectionNameRegex, ref int lineNumber, out string sectionName)
		{
			return default;
		}

		[Token(Token = "0x6000FBE")]
		[Address(RVA = "0x1215E94", Offset = "0x1215E94", VA = "0x1215E94")]
		private bool TrySeekSection(string sectionName, ref int lineNumber)
		{
			return default;
		}

		[Token(Token = "0x6000FBF")]
		[Address(RVA = "0x12173A8", Offset = "0x12173A8", VA = "0x12173A8")]
		private bool SeekSection(ref int lineNumber, out string sectionName)
		{
			return default;
		}

		[Token(Token = "0x6000FC0")]
		[Address(RVA = "0x12170E4", Offset = "0x12170E4", VA = "0x12170E4")]
		private bool SeekProperty(ref int lineNumber, out string propertyName, out string propertyValue)
		{
			return default;
		}

		[Token(Token = "0x6000FC1")]
		[Address(RVA = "0x1217C88", Offset = "0x1217C88", VA = "0x1217C88")]
		private string GetErrorMessage(int lineNumber)
		{
			return null;
		}

		[Token(Token = "0x6000FC2")]
		[Address(RVA = "0x1217BCC", Offset = "0x1217BCC", VA = "0x1217BCC")]
		private static bool IsCommentOrBlank(string line)
		{
			return default;
		}

		[Token(Token = "0x6000FC3")]
		[Address(RVA = "0x1217294", Offset = "0x1217294", VA = "0x1217294")]
		private static bool IsSection(string line)
		{
			return default;
		}

		[Token(Token = "0x6000FC4")]
		[Address(RVA = "0x12166E0", Offset = "0x12166E0", VA = "0x12166E0")]
		private static bool TryParseSection(string line, out string sectionName)
		{
			return default;
		}

		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0x1217BA4", Offset = "0x1217BA4", VA = "0x1217BA4")]
		private static bool IsProperty(string line)
		{
			return default;
		}

		[Token(Token = "0x6000FC6")]
		[Address(RVA = "0x12167CC", Offset = "0x12167CC", VA = "0x12167CC")]
		private static bool TryParseProperty(string line, out string propertyName, out string propertyValue)
		{
			return default;
		}

		[Token(Token = "0x6000FC7")]
		[Address(RVA = "0x12168D8", Offset = "0x12168D8", VA = "0x12168D8")]
		private static string GetPropertyLine(string propertyName, string propertyValue)
		{
			return null;
		}

		[Token(Token = "0x6000FC8")]
		[Address(RVA = "0x1216064", Offset = "0x1216064", VA = "0x1216064")]
		private string GetLineMessage(int lineNumber)
		{
			return null;
		}
	}
}
