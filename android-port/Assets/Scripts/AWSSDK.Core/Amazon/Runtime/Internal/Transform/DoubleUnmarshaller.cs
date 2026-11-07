using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000228")]
	public class DoubleUnmarshaller : IUnmarshaller<double, XmlUnmarshallerContext>, IUnmarshaller<double, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40007D0")]
		[FieldOffset(Offset = "0x0")]
		private static DoubleUnmarshaller _instance;

		[Token(Token = "0x1700041C")]
		public static DoubleUnmarshaller Instance
		{
			[Token(Token = "0x6001073")]
			[Address(RVA = "0x11F23F0", Offset = "0x11F23F0", VA = "0x11F23F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001072")]
		[Address(RVA = "0x11F23E8", Offset = "0x11F23E8", VA = "0x11F23E8")]
		private DoubleUnmarshaller()
		{
		}

		[Token(Token = "0x6001074")]
		[Address(RVA = "0x11F2454", Offset = "0x11F2454", VA = "0x11F2454")]
		public static DoubleUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001075")]
		[Address(RVA = "0x11F24F0", Offset = "0x11F24F0", VA = "0x11F24F0", Slot = "4")]
		public double Unmarshall(XmlUnmarshallerContext context)
		{
			return default;
		}

		[Token(Token = "0x6001076")]
		[Address(RVA = "0x11F2544", Offset = "0x11F2544", VA = "0x11F2544", Slot = "5")]
		public double Unmarshall(JsonUnmarshallerContext context)
		{
			return default;
		}
	}
}
