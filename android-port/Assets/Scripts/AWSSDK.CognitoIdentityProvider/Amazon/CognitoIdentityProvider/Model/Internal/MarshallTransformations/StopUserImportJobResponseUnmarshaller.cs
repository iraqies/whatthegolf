using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class StopUserImportJobResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static StopUserImportJobResponseUnmarshaller _instance;

		public static StopUserImportJobResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static StopUserImportJobResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
