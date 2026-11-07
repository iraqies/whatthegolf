using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x200022A")]
	public class BoolUnmarshaller : IUnmarshaller<bool, XmlUnmarshallerContext>, IUnmarshaller<bool, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40007D2")]
		[FieldOffset(Offset = "0x0")]
		private static BoolUnmarshaller _instance;

		[Token(Token = "0x1700041E")]
		public static BoolUnmarshaller Instance
		{
			[Token(Token = "0x600107F")]
			[Address(RVA = "0x11D6290", Offset = "0x11D6290", VA = "0x11D6290")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600107E")]
		[Address(RVA = "0x11D6288", Offset = "0x11D6288", VA = "0x11D6288")]
		private BoolUnmarshaller()
		{
		}

		[Token(Token = "0x6001080")]
		[Address(RVA = "0x11D62F4", Offset = "0x11D62F4", VA = "0x11D62F4")]
		public static BoolUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001081")]
		[Address(RVA = "0x11D6390", Offset = "0x11D6390", VA = "0x11D6390", Slot = "4")]
		public bool Unmarshall(XmlUnmarshallerContext context)
		{
			return default;
		}

		[Token(Token = "0x6001082")]
		[Address(RVA = "0x11D63E4", Offset = "0x11D63E4", VA = "0x11D63E4", Slot = "5")]
		public bool Unmarshall(JsonUnmarshallerContext context)
		{
			return default;
		}
	}
}
