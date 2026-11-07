using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	public class AssumeRoleWithWebIdentityResponseUnmarshaller : XmlResponseUnmarshaller
	{
		private static AssumeRoleWithWebIdentityResponseUnmarshaller _instance;

		public static AssumeRoleWithWebIdentityResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		private static void UnmarshallResult(XmlUnmarshallerContext context, AssumeRoleWithWebIdentityResponse response)
		{
		}

		public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static AssumeRoleWithWebIdentityResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
