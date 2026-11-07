using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000063")]
	public class DecreaseStreamRetentionPeriodResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x0")]
		private static DecreaseStreamRetentionPeriodResponseUnmarshaller _instance;

		[Token(Token = "0x170000A9")]
		public static DecreaseStreamRetentionPeriodResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x12A534C", Offset = "0x12A534C", VA = "0x12A534C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x12A4C58", Offset = "0x12A4C58", VA = "0x12A4C58", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x12A4CB0", Offset = "0x12A4CB0", VA = "0x12A4CB0", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x12A52E8", Offset = "0x12A52E8", VA = "0x12A52E8")]
		internal static DecreaseStreamRetentionPeriodResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x12A53B0", Offset = "0x12A53B0", VA = "0x12A53B0")]
		public DecreaseStreamRetentionPeriodResponseUnmarshaller()
		{
		}
	}
}
