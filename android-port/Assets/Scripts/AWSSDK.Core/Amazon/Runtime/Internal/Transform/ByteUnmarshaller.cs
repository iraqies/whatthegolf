using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x200022C")]
	public class ByteUnmarshaller : IUnmarshaller<byte, XmlUnmarshallerContext>, IUnmarshaller<byte, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40007D4")]
		[FieldOffset(Offset = "0x0")]
		private static ByteUnmarshaller _instance;

		[Token(Token = "0x17000420")]
		public static ByteUnmarshaller Instance
		{
			[Token(Token = "0x600108B")]
			[Address(RVA = "0x11D64A0", Offset = "0x11D64A0", VA = "0x11D64A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600108A")]
		[Address(RVA = "0x11D6498", Offset = "0x11D6498", VA = "0x11D6498")]
		private ByteUnmarshaller()
		{
		}

		[Token(Token = "0x600108C")]
		[Address(RVA = "0x11D6504", Offset = "0x11D6504", VA = "0x11D6504")]
		public static ByteUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600108D")]
		[Address(RVA = "0x11D65A0", Offset = "0x11D65A0", VA = "0x11D65A0", Slot = "4")]
		public byte Unmarshall(XmlUnmarshallerContext context)
		{
			return default;
		}

		[Token(Token = "0x600108E")]
		[Address(RVA = "0x11D65F4", Offset = "0x11D65F4", VA = "0x11D65F4", Slot = "5")]
		public byte Unmarshall(JsonUnmarshallerContext context)
		{
			return default;
		}
	}
}
