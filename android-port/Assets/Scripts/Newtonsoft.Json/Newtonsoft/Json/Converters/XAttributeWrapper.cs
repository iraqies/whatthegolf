using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000108")]
	[Attribute(Name = "NullableAttribute", RVA = "0x184D78", Offset = "0x184D78")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184D78", Offset = "0x184D78")]
	internal class XAttributeWrapper : XObjectWrapper
	{
		[Token(Token = "0x1700018E")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18F9EC", Offset = "0x18F9EC")]
		private XAttribute Attribute
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x232840C", Offset = "0x232840C", VA = "0x232840C")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18AFB8", Offset = "0x18AFB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018F")]
		public override string Value
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x23284F8", Offset = "0x23284F8", VA = "0x23284F8", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000190")]
		public override string LocalName
		{
			[Token(Token = "0x600084D")]
			[Address(RVA = "0x2328594", Offset = "0x2328594", VA = "0x2328594", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000191")]
		public override string NamespaceUri
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x2328638", Offset = "0x2328638", VA = "0x2328638", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000192")]
		public override IXmlNode ParentNode
		{
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x23286DC", Offset = "0x23286DC", VA = "0x23286DC", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x23284A0", Offset = "0x23284A0", VA = "0x23284A0")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18AFCC", Offset = "0x18AFCC")]
		public XAttributeWrapper(XAttribute attribute)
		{
		}
	}
}
