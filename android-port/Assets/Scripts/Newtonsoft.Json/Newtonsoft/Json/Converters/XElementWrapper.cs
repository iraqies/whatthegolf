using System.Collections.Generic;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000109")]
	[Attribute(Name = "NullableAttribute", RVA = "0x184DB8", Offset = "0x184DB8")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184DB8", Offset = "0x184DB8")]
	internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode
	{
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "NullableAttribute", RVA = "0x1885D8", Offset = "0x1885D8")]
		private List<IXmlNode> _attributes;

		[Token(Token = "0x17000193")]
		private XElement Element
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0x232A754", Offset = "0x232A754", VA = "0x232A754")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000194")]
		public override List<IXmlNode> Attributes
		{
			[Token(Token = "0x6000853")]
			[Address(RVA = "0x232A914", Offset = "0x232A914", VA = "0x232A914", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000195")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18FA00", Offset = "0x18FA00")]
		public override string Value
		{
			[Token(Token = "0x6000856")]
			[Address(RVA = "0x232B55C", Offset = "0x232B55C", VA = "0x232B55C", Slot = "18")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18AFE0", Offset = "0x18AFE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000196")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18FA14", Offset = "0x18FA14")]
		public override string LocalName
		{
			[Token(Token = "0x6000857")]
			[Address(RVA = "0x232B5FC", Offset = "0x232B5FC", VA = "0x232B5FC", Slot = "14")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18AFF4", Offset = "0x18AFF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000197")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18FA28", Offset = "0x18FA28")]
		public override string NamespaceUri
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0x232B6A0", Offset = "0x232B6A0", VA = "0x232B6A0", Slot = "20")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18B008", Offset = "0x18B008")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000198")]
		public bool IsEmpty
		{
			[Token(Token = "0x600085A")]
			[Address(RVA = "0x232B744", Offset = "0x232B744", VA = "0x232B744", Slot = "24")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x2329598", Offset = "0x2329598", VA = "0x2329598")]
		public XElementWrapper(XElement element)
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x232A7E8", Offset = "0x232A7E8", VA = "0x232A7E8", Slot = "22")]
		public void SetAttributeNode(IXmlNode attribute)
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x232AEF0", Offset = "0x232AEF0", VA = "0x232AEF0")]
		private bool HasImplicitNamespaceAttribute(string namespaceUri)
		{
			return default;
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x232B530", Offset = "0x232B530", VA = "0x232B530", Slot = "19")]
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x232B474", Offset = "0x232B474", VA = "0x232B474", Slot = "23")]
		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return null;
		}
	}
}
