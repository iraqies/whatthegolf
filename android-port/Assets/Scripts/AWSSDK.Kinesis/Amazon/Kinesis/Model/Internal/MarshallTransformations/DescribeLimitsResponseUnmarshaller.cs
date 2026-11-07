using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000069")]
	public class DescribeLimitsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x0")]
		private static DescribeLimitsResponseUnmarshaller _instance;

		[Token(Token = "0x170000AF")]
		public static DescribeLimitsResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x12A8AB8", Offset = "0x12A8AB8", VA = "0x12A8AB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x12A83C8", Offset = "0x12A83C8", VA = "0x12A83C8", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x12A867C", Offset = "0x12A867C", VA = "0x12A867C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x12A8A54", Offset = "0x12A8A54", VA = "0x12A8A54")]
		internal static DescribeLimitsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x12A8B1C", Offset = "0x12A8B1C", VA = "0x12A8B1C")]
		public DescribeLimitsResponseUnmarshaller()
		{
		}
	}
}
