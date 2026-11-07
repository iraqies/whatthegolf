using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200007A")]
	public class GetShardIteratorResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x0")]
		private static GetShardIteratorResponseUnmarshaller _instance;

		[Token(Token = "0x170000C0")]
		public static GetShardIteratorResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x12B40C4", Offset = "0x12B40C4", VA = "0x12B40C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x12B3968", Offset = "0x12B3968", VA = "0x12B3968", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x12B3AF4", Offset = "0x12B3AF4", VA = "0x12B3AF4", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x12B4060", Offset = "0x12B4060", VA = "0x12B4060")]
		internal static GetShardIteratorResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x12B4128", Offset = "0x12B4128", VA = "0x12B4128")]
		public GetShardIteratorResponseUnmarshaller()
		{
		}
	}
}
