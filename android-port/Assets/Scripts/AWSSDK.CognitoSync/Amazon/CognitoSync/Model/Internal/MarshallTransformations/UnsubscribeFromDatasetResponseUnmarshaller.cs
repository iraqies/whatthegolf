using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	public class UnsubscribeFromDatasetResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static UnsubscribeFromDatasetResponseUnmarshaller _instance;

		public static UnsubscribeFromDatasetResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static UnsubscribeFromDatasetResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
