using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	public class ListDatasetsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static ListDatasetsResponseUnmarshaller _instance;

		public static ListDatasetsResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static ListDatasetsResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
