using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class ResourceInUseExceptionUnmarshaller : IErrorResponseUnmarshaller<ResourceInUseException, JsonUnmarshallerContext>, IUnmarshaller<ResourceInUseException, JsonUnmarshallerContext>
	{
		private static ResourceInUseExceptionUnmarshaller _instance;

		public static ResourceInUseExceptionUnmarshaller Instance => null;

		public ResourceInUseException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public ResourceInUseException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
