using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	public class DeleteIdentitiesResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static DeleteIdentitiesResponseUnmarshaller _instance;

		public static DeleteIdentitiesResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static DeleteIdentitiesResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
