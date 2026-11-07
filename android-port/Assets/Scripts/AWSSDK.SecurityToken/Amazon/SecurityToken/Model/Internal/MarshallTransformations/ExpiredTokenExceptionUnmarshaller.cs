using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	public class ExpiredTokenExceptionUnmarshaller : IErrorResponseUnmarshaller<ExpiredTokenException, XmlUnmarshallerContext>, IUnmarshaller<ExpiredTokenException, XmlUnmarshallerContext>
	{
		private static ExpiredTokenExceptionUnmarshaller _instance;

		public static ExpiredTokenExceptionUnmarshaller Instance => null;

		public ExpiredTokenException Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		public ExpiredTokenException Unmarshall(XmlUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}
	}
}
