using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000FE")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184B50", Offset = "0x184B50")]
	internal interface IXmlElement : IXmlNode
	{
		[Token(Token = "0x17000162")]
		bool IsEmpty
		{
			[Token(Token = "0x6000805")]
			get;
		}

		[Token(Token = "0x6000803")]
		void SetAttributeNode(IXmlNode attribute);

		[Token(Token = "0x6000804")]
		string GetPrefixOfNamespace(string namespaceUri);
	}
}
