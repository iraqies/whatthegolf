using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x2000205")]
	public class ProfileIniFile : IniFile
	{
		[Token(Token = "0x40007A1")]
		private const string ProfileMarker = "profile";

		[Token(Token = "0x40007A2")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27B48", Offset = "0x27B48")]
		private bool ProfileMarkerRequired__BackingField;

		[Token(Token = "0x170003FF")]
		public bool ProfileMarkerRequired
		{
			[Token(Token = "0x6000FE1")]
			[Address(RVA = "0x12509F4", Offset = "0x12509F4", VA = "0x12509F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BC40", Offset = "0x2BC40")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000FE2")]
			[Address(RVA = "0x12509FC", Offset = "0x12509FC", VA = "0x12509FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BC50", Offset = "0x2BC50")]
			set
			{
			}
		}

		[Token(Token = "0x6000FE3")]
		[Address(RVA = "0x1250A04", Offset = "0x1250A04", VA = "0x1250A04", Slot = "4")]
		public override HashSet<string> ListSectionNames()
		{
			return null;
		}

		[Token(Token = "0x6000FE4")]
		[Address(RVA = "0x1250C9C", Offset = "0x1250C9C", VA = "0x1250C9C")]
		public ProfileIniFile(string filePath, bool profileMarkerRequired)
		{
		}

		[Token(Token = "0x6000FE5")]
		[Address(RVA = "0x1250CC8", Offset = "0x1250CC8", VA = "0x1250CC8", Slot = "5")]
		public override bool TryGetSection(string sectionName, out Dictionary<string, string> properties)
		{
			return default;
		}
	}
}
