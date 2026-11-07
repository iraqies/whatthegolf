using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000104")]
	[Attribute(Name = "NullableAttribute", RVA = "0x184C78", Offset = "0x184C78")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184C78", Offset = "0x184C78")]
	internal class XCommentWrapper : XObjectWrapper
	{
		[Token(Token = "0x1700017C")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18F988", Offset = "0x18F988")]
		private XComment Text
		{
			[Token(Token = "0x6000831")]
			[Address(RVA = "0x2328BE8", Offset = "0x2328BE8", VA = "0x2328BE8")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18AF18", Offset = "0x18AF18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017D")]
		public override string Value
		{
			[Token(Token = "0x6000833")]
			[Address(RVA = "0x2328CA8", Offset = "0x2328CA8", VA = "0x2328CA8", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017E")]
		public override IXmlNode ParentNode
		{
			[Token(Token = "0x6000834")]
			[Address(RVA = "0x2328D44", Offset = "0x2328D44", VA = "0x2328D44", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x2328C7C", Offset = "0x2328C7C", VA = "0x2328C7C")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18AF2C", Offset = "0x18AF2C")]
		public XCommentWrapper(XComment text)
		{
		}
	}
}
