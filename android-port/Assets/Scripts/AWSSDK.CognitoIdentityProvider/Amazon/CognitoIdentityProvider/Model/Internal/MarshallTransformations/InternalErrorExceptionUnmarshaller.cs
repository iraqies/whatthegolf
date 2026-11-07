using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class InternalErrorExceptionUnmarshaller : IErrorResponseUnmarshaller<InternalErrorException, JsonUnmarshallerContext>, IUnmarshaller<InternalErrorException, JsonUnmarshallerContext>
	{
		private static InternalErrorExceptionUnmarshaller _instance;

		public static InternalErrorExceptionUnmarshaller Instance => null;

		public InternalErrorException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public InternalErrorException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
