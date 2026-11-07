using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000FC")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184B28", Offset = "0x184B28")]
	internal interface IXmlDeclaration : IXmlNode
	{
		[Token(Token = "0x1700015B")]
		string Version
		{
			[Token(Token = "0x60007FC")]
			get;
		}

		[Token(Token = "0x1700015C")]
		string Encoding
		{
			[Token(Token = "0x60007FD")]
			get;
		}

		[Token(Token = "0x1700015D")]
		string Standalone
		{
			[Token(Token = "0x60007FE")]
			get;
		}
	}
}
