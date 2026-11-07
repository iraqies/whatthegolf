using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	public class NotAuthorizedExceptionUnmarshaller : IErrorResponseUnmarshaller<NotAuthorizedException, JsonUnmarshallerContext>, IUnmarshaller<NotAuthorizedException, JsonUnmarshallerContext>
	{
		private static NotAuthorizedExceptionUnmarshaller _instance;

		public static NotAuthorizedExceptionUnmarshaller Instance => null;

		public NotAuthorizedException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public NotAuthorizedException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
