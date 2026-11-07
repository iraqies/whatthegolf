using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000226")]
	public class LongUnmarshaller : IUnmarshaller<long, XmlUnmarshallerContext>, IUnmarshaller<long, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40007CE")]
		[FieldOffset(Offset = "0x0")]
		private static LongUnmarshaller _instance;

		[Token(Token = "0x1700041A")]
		public static LongUnmarshaller Instance
		{
			[Token(Token = "0x6001067")]
			[Address(RVA = "0x123B6F0", Offset = "0x123B6F0", VA = "0x123B6F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001066")]
		[Address(RVA = "0x123B6E8", Offset = "0x123B6E8", VA = "0x123B6E8")]
		private LongUnmarshaller()
		{
		}

		[Token(Token = "0x6001068")]
		[Address(RVA = "0x123B754", Offset = "0x123B754", VA = "0x123B754")]
		public static LongUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001069")]
		[Address(RVA = "0x123B7F0", Offset = "0x123B7F0", VA = "0x123B7F0", Slot = "4")]
		public long Unmarshall(XmlUnmarshallerContext context)
		{
			return default;
		}

		[Token(Token = "0x600106A")]
		[Address(RVA = "0x123B844", Offset = "0x123B844", VA = "0x123B844", Slot = "5")]
		public long Unmarshall(JsonUnmarshallerContext context)
		{
			return default;
		}
	}
}
