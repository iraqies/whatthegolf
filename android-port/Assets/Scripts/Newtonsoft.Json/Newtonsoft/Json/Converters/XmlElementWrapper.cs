using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000F7")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184A14", Offset = "0x184A14")]
	[Attribute(Name = "NullableAttribute", RVA = "0x184A14", Offset = "0x184A14")]
	internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode
	{
		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x28")]
		private readonly XmlElement _element;

		[Token(Token = "0x17000148")]
		public bool IsEmpty
		{
			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x232C88C", Offset = "0x232C88C", VA = "0x232C88C", Slot = "17")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x232C474", Offset = "0x232C474", VA = "0x232C474")]
		public XmlElementWrapper(XmlElement element)
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x232C748", Offset = "0x232C748", VA = "0x232C748", Slot = "15")]
		public void SetAttributeNode(IXmlNode attribute)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x232C868", Offset = "0x232C868", VA = "0x232C868", Slot = "16")]
		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return null;
		}
	}
}
