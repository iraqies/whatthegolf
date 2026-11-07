using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	public class SetCognitoEventsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static SetCognitoEventsResponseUnmarshaller _instance;

		public static SetCognitoEventsResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static SetCognitoEventsResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
