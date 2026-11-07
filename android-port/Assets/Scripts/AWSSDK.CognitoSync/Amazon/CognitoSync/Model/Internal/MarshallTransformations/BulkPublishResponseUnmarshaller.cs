using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	public class BulkPublishResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static BulkPublishResponseUnmarshaller _instance;

		public static BulkPublishResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static BulkPublishResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
