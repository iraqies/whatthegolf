using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class ResourceNotFoundExceptionUnmarshaller : IErrorResponseUnmarshaller<ResourceNotFoundException, JsonUnmarshallerContext>, IUnmarshaller<ResourceNotFoundException, JsonUnmarshallerContext>
	{
		private static ResourceNotFoundExceptionUnmarshaller _instance;

		public static ResourceNotFoundExceptionUnmarshaller Instance => null;

		public ResourceNotFoundException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public ResourceNotFoundException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
