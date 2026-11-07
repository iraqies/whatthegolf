using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000227")]
	public class FloatUnmarshaller : IUnmarshaller<float, XmlUnmarshallerContext>, IUnmarshaller<float, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40007CF")]
		[FieldOffset(Offset = "0x0")]
		private static FloatUnmarshaller _instance;

		[Token(Token = "0x1700041B")]
		public static FloatUnmarshaller Instance
		{
			[Token(Token = "0x600106D")]
			[Address(RVA = "0x120CB64", Offset = "0x120CB64", VA = "0x120CB64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600106C")]
		[Address(RVA = "0x120CB5C", Offset = "0x120CB5C", VA = "0x120CB5C")]
		private FloatUnmarshaller()
		{
		}

		[Token(Token = "0x600106E")]
		[Address(RVA = "0x120CBC8", Offset = "0x120CBC8", VA = "0x120CBC8")]
		public static FloatUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600106F")]
		[Address(RVA = "0x120CC64", Offset = "0x120CC64", VA = "0x120CC64", Slot = "4")]
		public float Unmarshall(XmlUnmarshallerContext context)
		{
			return default;
		}

		[Token(Token = "0x6001070")]
		[Address(RVA = "0x120CCB8", Offset = "0x120CCB8", VA = "0x120CCB8", Slot = "5")]
		public float Unmarshall(JsonUnmarshallerContext context)
		{
			return default;
		}
	}
}
