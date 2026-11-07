using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000FB")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184B14", Offset = "0x184B14")]
	internal interface IXmlDocument : IXmlNode
	{
		[Token(Token = "0x1700015A")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18F910", Offset = "0x18F910")]
		IXmlElement DocumentElement
		{
			[Token(Token = "0x60007FB")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18AE40", Offset = "0x18AE40")]
			get;
		}

		[Token(Token = "0x60007EF")]
		IXmlNode CreateComment([Attribute(Name = "NullableAttribute", RVA = "0x18E410", Offset = "0x18E410")] string text);

		[Token(Token = "0x60007F0")]
		IXmlNode CreateTextNode([Attribute(Name = "NullableAttribute", RVA = "0x18E424", Offset = "0x18E424")] string text);

		[Token(Token = "0x60007F1")]
		IXmlNode CreateCDataSection([Attribute(Name = "NullableAttribute", RVA = "0x18E438", Offset = "0x18E438")] string data);

		[Token(Token = "0x60007F2")]
		IXmlNode CreateWhitespace([Attribute(Name = "NullableAttribute", RVA = "0x18E44C", Offset = "0x18E44C")] string text);

		[Token(Token = "0x60007F3")]
		IXmlNode CreateSignificantWhitespace([Attribute(Name = "NullableAttribute", RVA = "0x18E460", Offset = "0x18E460")] string text);

		[Token(Token = "0x60007F4")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18AE18", Offset = "0x18AE18")]
		IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);

		[Token(Token = "0x60007F5")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18AE2C", Offset = "0x18AE2C")]
		IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);

		[Token(Token = "0x60007F6")]
		IXmlNode CreateProcessingInstruction(string target, [Attribute(Name = "NullableAttribute", RVA = "0x18E474", Offset = "0x18E474")] string data);

		[Token(Token = "0x60007F7")]
		IXmlElement CreateElement(string elementName);

		[Token(Token = "0x60007F8")]
		IXmlElement CreateElement(string qualifiedName, string namespaceUri);

		[Token(Token = "0x60007F9")]
		IXmlNode CreateAttribute(string name, [Attribute(Name = "NullableAttribute", RVA = "0x18E488", Offset = "0x18E488")] string value);

		[Token(Token = "0x60007FA")]
		IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, [Attribute(Name = "NullableAttribute", RVA = "0x18E49C", Offset = "0x18E49C")] string value);
	}
}
