using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000229")]
	public class DecimalUnmarshaller : IUnmarshaller<decimal, XmlUnmarshallerContext>, IUnmarshaller<decimal, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40007D1")]
		[FieldOffset(Offset = "0x0")]
		private static DecimalUnmarshaller _instance;

		[Token(Token = "0x1700041D")]
		public static DecimalUnmarshaller Instance
		{
			[Token(Token = "0x6001079")]
			[Address(RVA = "0x11ECFC8", Offset = "0x11ECFC8", VA = "0x11ECFC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001078")]
		[Address(RVA = "0x11ECFC0", Offset = "0x11ECFC0", VA = "0x11ECFC0")]
		private DecimalUnmarshaller()
		{
		}

		[Token(Token = "0x600107A")]
		[Address(RVA = "0x11ED02C", Offset = "0x11ED02C", VA = "0x11ED02C")]
		public static DecimalUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600107B")]
		[Address(RVA = "0x11ED0C8", Offset = "0x11ED0C8", VA = "0x11ED0C8", Slot = "4")]
		public decimal Unmarshall(XmlUnmarshallerContext context)
		{
			return 0m;
		}

		[Token(Token = "0x600107C")]
		[Address(RVA = "0x11ED11C", Offset = "0x11ED11C", VA = "0x11ED11C", Slot = "5")]
		public decimal Unmarshall(JsonUnmarshallerContext context)
		{
			return 0m;
		}
	}
}
