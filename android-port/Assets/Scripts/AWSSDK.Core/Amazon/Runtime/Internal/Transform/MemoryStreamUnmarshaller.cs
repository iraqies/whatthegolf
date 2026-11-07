using System.IO;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000230")]
	public class MemoryStreamUnmarshaller : IUnmarshaller<MemoryStream, XmlUnmarshallerContext>, IUnmarshaller<MemoryStream, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40007D8")]
		[FieldOffset(Offset = "0x0")]
		private static MemoryStreamUnmarshaller _instance;

		[Token(Token = "0x17000424")]
		public static MemoryStreamUnmarshaller Instance
		{
			[Token(Token = "0x60010A3")]
			[Address(RVA = "0x123E09C", Offset = "0x123E09C", VA = "0x123E09C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60010A2")]
		[Address(RVA = "0x123E094", Offset = "0x123E094", VA = "0x123E094")]
		private MemoryStreamUnmarshaller()
		{
		}

		[Token(Token = "0x60010A4")]
		[Address(RVA = "0x123E100", Offset = "0x123E100", VA = "0x123E100")]
		public static MemoryStreamUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60010A5")]
		[Address(RVA = "0x123E19C", Offset = "0x123E19C", VA = "0x123E19C", Slot = "4")]
		public MemoryStream Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60010A6")]
		[Address(RVA = "0x123E260", Offset = "0x123E260", VA = "0x123E260", Slot = "5")]
		public MemoryStream Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}
	}
}
