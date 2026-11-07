using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	public class AssumeRoleResponseUnmarshaller : XmlResponseUnmarshaller
	{
		private static AssumeRoleResponseUnmarshaller _instance;

		public static AssumeRoleResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		private static void UnmarshallResult(XmlUnmarshallerContext context, AssumeRoleResponse response)
		{
		}

		public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static AssumeRoleResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
