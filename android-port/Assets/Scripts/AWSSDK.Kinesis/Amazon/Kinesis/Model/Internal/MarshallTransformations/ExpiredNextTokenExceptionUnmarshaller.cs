using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class ExpiredNextTokenExceptionUnmarshaller : IErrorResponseUnmarshaller<ExpiredNextTokenException, JsonUnmarshallerContext>, IUnmarshaller<ExpiredNextTokenException, JsonUnmarshallerContext>
	{
		private static ExpiredNextTokenExceptionUnmarshaller _instance;

		public static ExpiredNextTokenExceptionUnmarshaller Instance => null;

		public ExpiredNextTokenException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public ExpiredNextTokenException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
