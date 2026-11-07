using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200007D")]
	public class IncreaseStreamRetentionPeriodResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x0")]
		private static IncreaseStreamRetentionPeriodResponseUnmarshaller _instance;

		[Token(Token = "0x170000C3")]
		public static IncreaseStreamRetentionPeriodResponseUnmarshaller Instance
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x12B57E4", Offset = "0x12B57E4", VA = "0x12B57E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x12B50F0", Offset = "0x12B50F0", VA = "0x12B50F0", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x12B5148", Offset = "0x12B5148", VA = "0x12B5148", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x12B5780", Offset = "0x12B5780", VA = "0x12B5780")]
		internal static IncreaseStreamRetentionPeriodResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x12B5848", Offset = "0x12B5848", VA = "0x12B5848")]
		public IncreaseStreamRetentionPeriodResponseUnmarshaller()
		{
		}
	}
}
