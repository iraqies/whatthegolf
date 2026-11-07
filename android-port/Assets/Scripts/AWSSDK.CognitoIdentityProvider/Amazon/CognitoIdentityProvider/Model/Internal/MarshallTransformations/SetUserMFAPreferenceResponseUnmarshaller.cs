using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class SetUserMFAPreferenceResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static SetUserMFAPreferenceResponseUnmarshaller _instance;

		public static SetUserMFAPreferenceResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static SetUserMFAPreferenceResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
