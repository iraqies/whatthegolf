using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x200021A")]
	public class JsonErrorResponseUnmarshaller : IUnmarshaller<ErrorResponse, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40007BA")]
		[FieldOffset(Offset = "0x0")]
		private static JsonErrorResponseUnmarshaller instance;

		[Token(Token = "0x6001021")]
		[Address(RVA = "0x12252B8", Offset = "0x12252B8", VA = "0x12252B8", Slot = "4")]
		public ErrorResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001022")]
		[Address(RVA = "0x1225BEC", Offset = "0x1225BEC", VA = "0x1225BEC")]
		private static void GetValuesFromJsonIfPossible(JsonUnmarshallerContext context, out string type, out string message, out string code)
		{
		}

		[Token(Token = "0x6001023")]
		[Address(RVA = "0x1225D98", Offset = "0x1225D98", VA = "0x1225D98")]
		private static bool TryReadContext(JsonUnmarshallerContext context)
		{
			return default;
		}

		[Token(Token = "0x6001024")]
		[Address(RVA = "0x1225E44", Offset = "0x1225E44", VA = "0x1225E44")]
		public static JsonErrorResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001025")]
		[Address(RVA = "0x1225EBC", Offset = "0x1225EBC", VA = "0x1225EBC")]
		public JsonErrorResponseUnmarshaller()
		{
		}
	}
}
