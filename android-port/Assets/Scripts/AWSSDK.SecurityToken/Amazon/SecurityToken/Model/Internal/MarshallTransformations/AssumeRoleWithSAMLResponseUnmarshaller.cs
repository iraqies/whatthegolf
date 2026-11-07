using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	public class AssumeRoleWithSAMLResponseUnmarshaller : XmlResponseUnmarshaller
	{
		private static AssumeRoleWithSAMLResponseUnmarshaller _instance;

		public static AssumeRoleWithSAMLResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		private static void UnmarshallResult(XmlUnmarshallerContext context, AssumeRoleWithSAMLResponse response)
		{
		}

		public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static AssumeRoleWithSAMLResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
