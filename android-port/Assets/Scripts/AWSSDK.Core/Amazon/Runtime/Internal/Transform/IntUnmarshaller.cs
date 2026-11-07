using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000224")]
	public class IntUnmarshaller : IUnmarshaller<int, XmlUnmarshallerContext>, IUnmarshaller<int, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40007CC")]
		[FieldOffset(Offset = "0x0")]
		private static IntUnmarshaller _instance;

		[Token(Token = "0x17000418")]
		public static IntUnmarshaller Instance
		{
			[Token(Token = "0x600105C")]
			[Address(RVA = "0x12197E0", Offset = "0x12197E0", VA = "0x12197E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600105B")]
		[Address(RVA = "0x12197D8", Offset = "0x12197D8", VA = "0x12197D8")]
		private IntUnmarshaller()
		{
		}

		[Token(Token = "0x600105D")]
		[Address(RVA = "0x1219844", Offset = "0x1219844", VA = "0x1219844")]
		public static IntUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600105E")]
		[Address(RVA = "0x12198E0", Offset = "0x12198E0", VA = "0x12198E0", Slot = "4")]
		public int Unmarshall(XmlUnmarshallerContext context)
		{
			return default;
		}

		[Token(Token = "0x600105F")]
		[Address(RVA = "0x1219934", Offset = "0x1219934", VA = "0x1219934", Slot = "5")]
		public int Unmarshall(JsonUnmarshallerContext context)
		{
			return default;
		}
	}
}
