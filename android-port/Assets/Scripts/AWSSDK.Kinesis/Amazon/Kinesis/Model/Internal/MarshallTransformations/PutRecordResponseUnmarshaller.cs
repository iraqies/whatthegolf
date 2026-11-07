using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class PutRecordResponseUnmarshaller : JsonResponseUnmarshaller
	{
		private static PutRecordResponseUnmarshaller _instance;

		public static PutRecordResponseUnmarshaller Instance => null;

		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		internal static PutRecordResponseUnmarshaller GetInstance()
		{
			return null;
		}
	}
}
