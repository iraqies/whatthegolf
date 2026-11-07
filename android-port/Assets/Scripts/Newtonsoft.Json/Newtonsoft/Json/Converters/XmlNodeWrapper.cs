using System.Collections.Generic;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000FA")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184AD4", Offset = "0x184AD4")]
	[Attribute(Name = "NullableAttribute", RVA = "0x184AD4", Offset = "0x184AD4")]
	internal class XmlNodeWrapper : IXmlNode
	{
		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "NullableAttribute", RVA = "0x188464", Offset = "0x188464")]
		private readonly XmlNode _node;

		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "NullableAttribute", RVA = "0x188478", Offset = "0x188478")]
		private List<IXmlNode> _childNodes;

		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "NullableAttribute", RVA = "0x1884E8", Offset = "0x1884E8")]
		private List<IXmlNode> _attributes;

		[Token(Token = "0x17000151")]
		public object WrappedNode
		{
			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x23358E8", Offset = "0x23358E8", VA = "0x23358E8", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000152")]
		public XmlNodeType NodeType
		{
			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x23358F0", Offset = "0x23358F0", VA = "0x23358F0", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000153")]
		public virtual string LocalName
		{
			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x2335910", Offset = "0x2335910", VA = "0x2335910", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000154")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18F8E8", Offset = "0x18F8E8")]
		public List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x2335934", Offset = "0x2335934", VA = "0x2335934", Slot = "6")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18ADC8", Offset = "0x18ADC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000155")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18F8FC", Offset = "0x18F8FC")]
		public List<IXmlNode> Attributes
		{
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x2335D2C", Offset = "0x2335D2C", VA = "0x2335D2C", Slot = "7")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18ADF0", Offset = "0x18ADF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000156")]
		private bool HasAttributes
		{
			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x2336114", Offset = "0x2336114", VA = "0x2336114")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000157")]
		public IXmlNode ParentNode
		{
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x23361E4", Offset = "0x23361E4", VA = "0x23361E4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000158")]
		public string Value
		{
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x23362B4", Offset = "0x23362B4", VA = "0x23362B4", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x232C5E0", Offset = "0x232C5E0", VA = "0x232C5E0", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public string NamespaceUri
		{
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x233639C", Offset = "0x233639C", VA = "0x233639C", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x232BD8C", Offset = "0x232BD8C", VA = "0x232BD8C")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18ADB4", Offset = "0x18ADB4")]
		public XmlNodeWrapper(XmlNode node)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x232EB8C", Offset = "0x232EB8C", VA = "0x232EB8C")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18ADDC", Offset = "0x18ADDC")]
		internal static IXmlNode WrapNode(XmlNode node)
		{
			return null;
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x23362D4", Offset = "0x23362D4", VA = "0x23362D4", Slot = "10")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18AE04", Offset = "0x18AE04")]
		public IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
}
