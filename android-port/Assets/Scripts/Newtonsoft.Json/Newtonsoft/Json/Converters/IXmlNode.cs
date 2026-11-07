using System.Collections.Generic;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000FF")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184B64", Offset = "0x184B64")]
	internal interface IXmlNode
	{
		[Token(Token = "0x17000163")]
		XmlNodeType NodeType
		{
			[Token(Token = "0x6000806")]
			get;
		}

		[Token(Token = "0x17000164")]
		string LocalName
		{
			[Token(Token = "0x6000807")]
			get;
		}

		[Token(Token = "0x17000165")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18F924", Offset = "0x18F924")]
		List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x6000808")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18AE54", Offset = "0x18AE54")]
			get;
		}

		[Token(Token = "0x17000166")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18F938", Offset = "0x18F938")]
		List<IXmlNode> Attributes
		{
			[Token(Token = "0x6000809")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18AE68", Offset = "0x18AE68")]
			get;
		}

		[Token(Token = "0x17000167")]
		IXmlNode ParentNode
		{
			[Token(Token = "0x600080A")]
			get;
		}

		[Token(Token = "0x17000168")]
		string Value
		{
			[Token(Token = "0x600080B")]
			get;
		}

		[Token(Token = "0x17000169")]
		string NamespaceUri
		{
			[Token(Token = "0x600080D")]
			get;
		}

		[Token(Token = "0x1700016A")]
		object WrappedNode
		{
			[Token(Token = "0x600080E")]
			get;
		}

		[Token(Token = "0x600080C")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18AE7C", Offset = "0x18AE7C")]
		IXmlNode AppendChild(IXmlNode newChild);
	}
}
