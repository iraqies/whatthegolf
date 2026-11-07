using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class UserNotFoundExceptionUnmarshaller : IErrorResponseUnmarshaller<UserNotFoundException, JsonUnmarshallerContext>, IUnmarshaller<UserNotFoundException, JsonUnmarshallerContext>
	{
		private static UserNotFoundExceptionUnmarshaller _instance;

		public static UserNotFoundExceptionUnmarshaller Instance => null;

		public UserNotFoundException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public UserNotFoundException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
