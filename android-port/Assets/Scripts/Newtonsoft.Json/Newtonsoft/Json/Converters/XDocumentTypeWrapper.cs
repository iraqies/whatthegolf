using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000101")]
	[Attribute(Name = "NullableAttribute", RVA = "0x184BB8", Offset = "0x184BB8")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184BB8", Offset = "0x184BB8")]
	internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode
	{
		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x18")]
		private readonly XDocumentType _documentType;

		[Token(Token = "0x17000170")]
		public string Name
		{
			[Token(Token = "0x6000816")]
			[Address(RVA = "0x232982C", Offset = "0x232982C", VA = "0x232982C", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000171")]
		public string System
		{
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x2329848", Offset = "0x2329848", VA = "0x2329848", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000172")]
		public string Public
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x2329864", Offset = "0x2329864", VA = "0x2329864", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000173")]
		public string InternalSubset
		{
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x2329880", Offset = "0x2329880", VA = "0x2329880", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000174")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18F94C", Offset = "0x18F94C")]
		public override string LocalName
		{
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x232989C", Offset = "0x232989C", VA = "0x232989C", Slot = "14")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18AEA0", Offset = "0x18AEA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x232961C", Offset = "0x232961C", VA = "0x232961C")]
		public XDocumentTypeWrapper(XDocumentType documentType)
		{
		}
	}
}
