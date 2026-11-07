using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000F8")]
	[Attribute(Name = "NullableAttribute", RVA = "0x184A54", Offset = "0x184A54")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184A54", Offset = "0x184A54")]
	internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode
	{
		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x28")]
		private readonly XmlDeclaration _declaration;

		[Token(Token = "0x17000149")]
		public string Version
		{
			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x232BDB8", Offset = "0x232BDB8", VA = "0x232BDB8", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014A")]
		public string Encoding
		{
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x232BDD4", Offset = "0x232BDD4", VA = "0x232BDD4", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014B")]
		public string Standalone
		{
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x232BDF0", Offset = "0x232BDF0", VA = "0x232BDF0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x232BD5C", Offset = "0x232BD5C", VA = "0x232BD5C")]
		public XmlDeclarationWrapper(XmlDeclaration declaration)
		{
		}
	}
}
