using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class MFAMethodNotFoundExceptionUnmarshaller : IErrorResponseUnmarshaller<MFAMethodNotFoundException, JsonUnmarshallerContext>, IUnmarshaller<MFAMethodNotFoundException, JsonUnmarshallerContext>
	{
		private static MFAMethodNotFoundExceptionUnmarshaller _instance;

		public static MFAMethodNotFoundExceptionUnmarshaller Instance => null;

		public MFAMethodNotFoundException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public MFAMethodNotFoundException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
