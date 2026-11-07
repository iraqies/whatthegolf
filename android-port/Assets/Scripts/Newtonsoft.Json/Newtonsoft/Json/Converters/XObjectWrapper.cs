using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000107")]
	[Attribute(Name = "NullableAttribute", RVA = "0x184D38", Offset = "0x184D38")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184D38", Offset = "0x184D38")]
	internal class XObjectWrapper : IXmlNode
	{
		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x10")]
		private readonly XObject _xmlObject;

		[Token(Token = "0x17000186")]
		public object WrappedNode
		{
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x232B7E4", Offset = "0x232B7E4", VA = "0x232B7E4", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000187")]
		public virtual XmlNodeType NodeType
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x232B7EC", Offset = "0x232B7EC", VA = "0x232B7EC", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000188")]
		public virtual string LocalName
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x232B804", Offset = "0x232B804", VA = "0x232B804", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000189")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18F9C4", Offset = "0x18F9C4")]
		public virtual List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x232B80C", Offset = "0x232B80C", VA = "0x232B80C", Slot = "15")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18AF7C", Offset = "0x18AF7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018A")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18F9D8", Offset = "0x18F9D8")]
		public virtual List<IXmlNode> Attributes
		{
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x232B870", Offset = "0x232B870", VA = "0x232B870", Slot = "16")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18AF90", Offset = "0x18AF90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018B")]
		public virtual IXmlNode ParentNode
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x232B8D4", Offset = "0x232B8D4", VA = "0x232B8D4", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018C")]
		public virtual string Value
		{
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x232B8DC", Offset = "0x232B8DC", VA = "0x232B8DC", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018D")]
		public virtual string NamespaceUri
		{
			[Token(Token = "0x6000849")]
			[Address(RVA = "0x232B924", Offset = "0x232B924", VA = "0x232B924", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x23284CC", Offset = "0x23284CC", VA = "0x23284CC")]
		public XObjectWrapper(XObject xmlObject)
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x232B8E4", Offset = "0x232B8E4", VA = "0x232B8E4", Slot = "19")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18AFA4", Offset = "0x18AFA4")]
		public virtual IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
}
