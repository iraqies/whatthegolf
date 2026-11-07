namespace Amazon.Runtime.Internal.Transform
{
	public class JsonErrorResponseUnmarshaller : IUnmarshaller<ErrorResponse, JsonUnmarshallerContext>
	{
		private static JsonErrorResponseUnmarshaller instance;

		public ErrorResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		private static void GetValuesFromJsonIfPossible(JsonUnmarshallerContext context, out string type, out string message, out string code)
		{
			type = null;
			message = null;
			code = null;
		}

		private static bool TryReadContext(JsonUnmarshallerContext context)
		{
			return false;
		}

		public static JsonErrorResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
