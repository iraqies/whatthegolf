using System.Xml;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000214")]
	public class XmlMarshallerContext : MarshallerContext
	{
		[Token(Token = "0x40007B8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27B98", Offset = "0x27B98")]
		private XmlWriter Writer__BackingField;

		[Token(Token = "0x17000404")]
		public XmlWriter Writer
		{
			[Token(Token = "0x600100F")]
			[Address(RVA = "0x1283340", Offset = "0x1283340", VA = "0x1283340")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BD10", Offset = "0x2BD10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001010")]
			[Address(RVA = "0x1283348", Offset = "0x1283348", VA = "0x1283348")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BD20", Offset = "0x2BD20")]
			private set
			{
			}
		}

		[Token(Token = "0x6001011")]
		[Address(RVA = "0x1283350", Offset = "0x1283350", VA = "0x1283350")]
		public XmlMarshallerContext(IRequest request, XmlWriter writer)
		{
		}
	}
}
