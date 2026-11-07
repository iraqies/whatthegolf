using System.Xml;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000100")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184B78", Offset = "0x184B78")]
	[Attribute(Name = "NullableAttribute", RVA = "0x184B78", Offset = "0x184B78")]
	internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode
	{
		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x188558", Offset = "0x188558")]
		private readonly XDeclaration Declaration__BackingField;

		[Token(Token = "0x1700016B")]
		internal XDeclaration Declaration
		{
			[Token(Token = "0x600080F")]
			[Address(RVA = "0x232979C", Offset = "0x232979C", VA = "0x232979C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18AE90", Offset = "0x18AE90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016C")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000811")]
			[Address(RVA = "0x23297D0", Offset = "0x23297D0", VA = "0x23297D0", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700016D")]
		public string Version
		{
			[Token(Token = "0x6000812")]
			[Address(RVA = "0x23297D8", Offset = "0x23297D8", VA = "0x23297D8", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016E")]
		public string Encoding
		{
			[Token(Token = "0x6000813")]
			[Address(RVA = "0x23297F4", Offset = "0x23297F4", VA = "0x23297F4", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016F")]
		public string Standalone
		{
			[Token(Token = "0x6000814")]
			[Address(RVA = "0x2329810", Offset = "0x2329810", VA = "0x2329810", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x23297A4", Offset = "0x23297A4", VA = "0x23297A4")]
		public XDeclarationWrapper(XDeclaration declaration)
		{
		}
	}
}
