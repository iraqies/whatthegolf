using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class StartStreamEncryptionResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static StartStreamEncryptionResponseUnmarshaller _instance;

		public static StartStreamEncryptionResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static StartStreamEncryptionResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
