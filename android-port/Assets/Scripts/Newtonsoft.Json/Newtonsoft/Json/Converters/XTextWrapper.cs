using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000103")]
	[Attribute(Name = "NullableAttribute", RVA = "0x184C38", Offset = "0x184C38")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184C38", Offset = "0x184C38")]
	internal class XTextWrapper : XObjectWrapper
	{
		[Token(Token = "0x17000179")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18F974", Offset = "0x18F974")]
		private XText Text
		{
			[Token(Token = "0x600082D")]
			[Address(RVA = "0x232BAF8", Offset = "0x232BAF8", VA = "0x232BAF8")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18AEF0", Offset = "0x18AEF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017A")]
		public override string Value
		{
			[Token(Token = "0x600082F")]
			[Address(RVA = "0x232BB8C", Offset = "0x232BB8C", VA = "0x232BB8C", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017B")]
		public override IXmlNode ParentNode
		{
			[Token(Token = "0x6000830")]
			[Address(RVA = "0x232BC28", Offset = "0x232BC28", VA = "0x232BC28", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x23295F0", Offset = "0x23295F0", VA = "0x23295F0")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18AF04", Offset = "0x18AF04")]
		public XTextWrapper(XText text)
		{
		}
	}
}
