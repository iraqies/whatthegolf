using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x200022B")]
	public class StringUnmarshaller : IUnmarshaller<string, XmlUnmarshallerContext>, IUnmarshaller<string, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40007D3")]
		[FieldOffset(Offset = "0x0")]
		private static StringUnmarshaller _instance;

		[Token(Token = "0x1700041F")]
		public static StringUnmarshaller Instance
		{
			[Token(Token = "0x6001085")]
			[Address(RVA = "0x127C4CC", Offset = "0x127C4CC", VA = "0x127C4CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001084")]
		[Address(RVA = "0x127C4C4", Offset = "0x127C4C4", VA = "0x127C4C4")]
		private StringUnmarshaller()
		{
		}

		[Token(Token = "0x6001086")]
		[Address(RVA = "0x125FEA8", Offset = "0x125FEA8", VA = "0x125FEA8")]
		public static StringUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001087")]
		[Address(RVA = "0x125FF44", Offset = "0x125FF44", VA = "0x125FF44", Slot = "4")]
		public string Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001088")]
		[Address(RVA = "0x1260168", Offset = "0x1260168", VA = "0x1260168", Slot = "5")]
		public string Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}
	}
}
