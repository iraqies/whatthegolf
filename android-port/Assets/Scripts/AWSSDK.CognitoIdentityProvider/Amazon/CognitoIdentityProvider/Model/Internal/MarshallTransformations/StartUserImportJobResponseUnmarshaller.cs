using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class StartUserImportJobResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static StartUserImportJobResponseUnmarshaller _instance;

		public static StartUserImportJobResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static StartUserImportJobResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
