using System.Collections.Generic;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000102")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184BF8", Offset = "0x184BF8")]
	[Attribute(Name = "NullableAttribute", RVA = "0x184BF8", Offset = "0x184BF8")]
	internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode
	{
		[Token(Token = "0x17000175")]
		private XDocument Document
		{
			[Token(Token = "0x600081B")]
			[Address(RVA = "0x23298E0", Offset = "0x23298E0", VA = "0x23298E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000176")]
		public override List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x600081D")]
			[Address(RVA = "0x2329974", Offset = "0x2329974", VA = "0x2329974", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000177")]
		protected override bool HasChildNodes
		{
			[Token(Token = "0x600081E")]
			[Address(RVA = "0x2329BBC", Offset = "0x2329BBC", VA = "0x2329BBC", Slot = "21")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000178")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18F960", Offset = "0x18F960")]
		public IXmlElement DocumentElement
		{
			[Token(Token = "0x600082B")]
			[Address(RVA = "0x232A4B4", Offset = "0x232A4B4", VA = "0x232A4B4", Slot = "34")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18AEDC", Offset = "0x18AEDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x232956C", Offset = "0x232956C", VA = "0x232956C")]
		public XDocumentWrapper(XDocument document)
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x2329CEC", Offset = "0x2329CEC", VA = "0x2329CEC", Slot = "22")]
		public IXmlNode CreateComment([Attribute(Name = "NullableAttribute", RVA = "0x18E4B0", Offset = "0x18E4B0")] string text)
		{
			return null;
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x2329D80", Offset = "0x2329D80", VA = "0x2329D80", Slot = "23")]
		public IXmlNode CreateTextNode([Attribute(Name = "NullableAttribute", RVA = "0x18E4C4", Offset = "0x18E4C4")] string text)
		{
			return null;
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x2329E14", Offset = "0x2329E14", VA = "0x2329E14", Slot = "24")]
		public IXmlNode CreateCDataSection([Attribute(Name = "NullableAttribute", RVA = "0x18E4D8", Offset = "0x18E4D8")] string data)
		{
			return null;
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x2329EA8", Offset = "0x2329EA8", VA = "0x2329EA8", Slot = "25")]
		public IXmlNode CreateWhitespace([Attribute(Name = "NullableAttribute", RVA = "0x18E4EC", Offset = "0x18E4EC")] string text)
		{
			return null;
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x2329F3C", Offset = "0x2329F3C", VA = "0x2329F3C", Slot = "26")]
		public IXmlNode CreateSignificantWhitespace([Attribute(Name = "NullableAttribute", RVA = "0x18E500", Offset = "0x18E500")] string text)
		{
			return null;
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x2329FD0", Offset = "0x2329FD0", VA = "0x2329FD0", Slot = "27")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18AEB4", Offset = "0x18AEB4")]
		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			return null;
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x232A07C", Offset = "0x232A07C", VA = "0x232A07C", Slot = "28")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18AEC8", Offset = "0x18AEC8")]
		public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			return null;
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x232A138", Offset = "0x232A138", VA = "0x232A138", Slot = "29")]
		public IXmlNode CreateProcessingInstruction(string target, [Attribute(Name = "NullableAttribute", RVA = "0x18E514", Offset = "0x18E514")] string data)
		{
			return null;
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x232A1DC", Offset = "0x232A1DC", VA = "0x232A1DC", Slot = "30")]
		public IXmlElement CreateElement(string elementName)
		{
			return null;
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x232A280", Offset = "0x232A280", VA = "0x232A280", Slot = "31")]
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			return null;
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x232A33C", Offset = "0x232A33C", VA = "0x232A33C", Slot = "32")]
		public IXmlNode CreateAttribute(string name, [Attribute(Name = "NullableAttribute", RVA = "0x18E528", Offset = "0x18E528")] string value)
		{
			return null;
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x232A3F0", Offset = "0x232A3F0", VA = "0x232A3F0", Slot = "33")]
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, [Attribute(Name = "NullableAttribute", RVA = "0x18E53C", Offset = "0x18E53C")] string value)
		{
			return null;
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x232A620", Offset = "0x232A620", VA = "0x232A620", Slot = "19")]
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
}
