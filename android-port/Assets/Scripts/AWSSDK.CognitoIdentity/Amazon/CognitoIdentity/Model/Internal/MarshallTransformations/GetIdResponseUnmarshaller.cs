using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	public class GetIdResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static GetIdResponseUnmarshaller _instance;

		public static GetIdResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static GetIdResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
