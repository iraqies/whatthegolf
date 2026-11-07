using System.Collections.Generic;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000106")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184CF8", Offset = "0x184CF8")]
	[Attribute(Name = "NullableAttribute", RVA = "0x184CF8", Offset = "0x184CF8")]
	internal class XContainerWrapper : XObjectWrapper
	{
		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "NullableAttribute", RVA = "0x188568", Offset = "0x188568")]
		private List<IXmlNode> _childNodes;

		[Token(Token = "0x17000182")]
		private XContainer Container
		{
			[Token(Token = "0x6000839")]
			[Address(RVA = "0x2328E78", Offset = "0x2328E78", VA = "0x2328E78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000183")]
		public override List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x600083B")]
			[Address(RVA = "0x2328F38", Offset = "0x2328F38", VA = "0x2328F38", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000184")]
		protected virtual bool HasChildNodes
		{
			[Token(Token = "0x600083C")]
			[Address(RVA = "0x232938C", Offset = "0x232938C", VA = "0x232938C", Slot = "21")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000185")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18F9B0", Offset = "0x18F9B0")]
		public override IXmlNode ParentNode
		{
			[Token(Token = "0x600083D")]
			[Address(RVA = "0x2329438", Offset = "0x2329438", VA = "0x2329438", Slot = "17")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18AF68", Offset = "0x18AF68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x2328F0C", Offset = "0x2328F0C", VA = "0x2328F0C")]
		public XContainerWrapper(XContainer container)
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x2328810", Offset = "0x2328810", VA = "0x2328810")]
		internal static IXmlNode WrapNode(XObject node)
		{
			return null;
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x2329648", Offset = "0x2329648", VA = "0x2329648", Slot = "19")]
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
}
