using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	public class LookupDeveloperIdentityResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static LookupDeveloperIdentityResponseUnmarshaller _instance;

		public static LookupDeveloperIdentityResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static LookupDeveloperIdentityResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
