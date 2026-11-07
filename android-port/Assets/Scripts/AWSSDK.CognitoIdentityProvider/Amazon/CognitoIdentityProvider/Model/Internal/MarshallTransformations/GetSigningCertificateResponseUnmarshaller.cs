using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	public class GetSigningCertificateResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static GetSigningCertificateResponseUnmarshaller _instance;

		public static GetSigningCertificateResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static GetSigningCertificateResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
