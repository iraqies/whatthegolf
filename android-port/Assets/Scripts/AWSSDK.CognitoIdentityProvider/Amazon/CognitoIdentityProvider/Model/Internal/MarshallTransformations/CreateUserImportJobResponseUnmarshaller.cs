using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class CreateUserImportJobResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static CreateUserImportJobResponseUnmarshaller _instance;

		public static CreateUserImportJobResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static CreateUserImportJobResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
