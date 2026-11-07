using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000F6")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x1849D4", Offset = "0x1849D4")]
	[Attribute(Name = "NullableAttribute", RVA = "0x1849D4", Offset = "0x1849D4")]
	internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode
	{
		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x28")]
		private readonly XmlDocument _document;

		[Token(Token = "0x17000147")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18F8C0", Offset = "0x18F8C0")]
		public IXmlElement DocumentElement
		{
			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x232C6B8", Offset = "0x232C6B8", VA = "0x232C6B8", Slot = "27")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18AD8C", Offset = "0x18AD8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x232BEF4", Offset = "0x232BEF4", VA = "0x232BEF4")]
		public XmlDocumentWrapper(XmlDocument document)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x232BF24", Offset = "0x232BF24", VA = "0x232BF24", Slot = "15")]
		public IXmlNode CreateComment([Attribute(Name = "NullableAttribute", RVA = "0x18E370", Offset = "0x18E370")] string data)
		{
			return null;
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x232BFB4", Offset = "0x232BFB4", VA = "0x232BFB4", Slot = "16")]
		public IXmlNode CreateTextNode([Attribute(Name = "NullableAttribute", RVA = "0x18E384", Offset = "0x18E384")] string text)
		{
			return null;
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x232C044", Offset = "0x232C044", VA = "0x232C044", Slot = "17")]
		public IXmlNode CreateCDataSection([Attribute(Name = "NullableAttribute", RVA = "0x18E398", Offset = "0x18E398")] string data)
		{
			return null;
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x232C0D4", Offset = "0x232C0D4", VA = "0x232C0D4", Slot = "18")]
		public IXmlNode CreateWhitespace([Attribute(Name = "NullableAttribute", RVA = "0x18E3AC", Offset = "0x18E3AC")] string text)
		{
			return null;
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x232C164", Offset = "0x232C164", VA = "0x232C164", Slot = "19")]
		public IXmlNode CreateSignificantWhitespace([Attribute(Name = "NullableAttribute", RVA = "0x18E3C0", Offset = "0x18E3C0")] string text)
		{
			return null;
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x232C1F4", Offset = "0x232C1F4", VA = "0x232C1F4", Slot = "20")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18AD64", Offset = "0x18AD64")]
		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			return null;
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x232C2A0", Offset = "0x232C2A0", VA = "0x232C2A0", Slot = "21")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18AD78", Offset = "0x18AD78")]
		public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			return null;
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x232C350", Offset = "0x232C350", VA = "0x232C350", Slot = "22")]
		public IXmlNode CreateProcessingInstruction(string target, [Attribute(Name = "NullableAttribute", RVA = "0x18E3D4", Offset = "0x18E3D4")] string data)
		{
			return null;
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x232C3E8", Offset = "0x232C3E8", VA = "0x232C3E8", Slot = "23")]
		public IXmlElement CreateElement(string elementName)
		{
			return null;
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x232C4A4", Offset = "0x232C4A4", VA = "0x232C4A4", Slot = "24")]
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			return null;
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x232C538", Offset = "0x232C538", VA = "0x232C538", Slot = "25")]
		public IXmlNode CreateAttribute(string name, [Attribute(Name = "NullableAttribute", RVA = "0x18E3E8", Offset = "0x18E3E8")] string value)
		{
			return null;
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x232C600", Offset = "0x232C600", VA = "0x232C600", Slot = "26")]
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, [Attribute(Name = "NullableAttribute", RVA = "0x18E3FC", Offset = "0x18E3FC")] string value)
		{
			return null;
		}
	}
}
