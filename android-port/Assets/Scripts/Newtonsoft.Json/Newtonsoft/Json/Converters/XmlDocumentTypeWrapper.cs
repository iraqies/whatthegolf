using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000F9")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184A94", Offset = "0x184A94")]
	[Attribute(Name = "NullableAttribute", RVA = "0x184A94", Offset = "0x184A94")]
	internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode
	{
		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x28")]
		private readonly XmlDocumentType _documentType;

		[Token(Token = "0x1700014C")]
		public string Name
		{
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x232BE3C", Offset = "0x232BE3C", VA = "0x232BE3C", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014D")]
		public string System
		{
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x232BE5C", Offset = "0x232BE5C", VA = "0x232BE5C", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014E")]
		public string Public
		{
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x232BE78", Offset = "0x232BE78", VA = "0x232BE78", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014F")]
		public string InternalSubset
		{
			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x232BE94", Offset = "0x232BE94", VA = "0x232BE94", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000150")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18F8D4", Offset = "0x18F8D4")]
		public override string LocalName
		{
			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x232BEB0", Offset = "0x232BEB0", VA = "0x232BEB0", Slot = "13")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18ADA0", Offset = "0x18ADA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x232BE0C", Offset = "0x232BE0C", VA = "0x232BE0C")]
		public XmlDocumentTypeWrapper(XmlDocumentType documentType)
		{
		}
	}
}
