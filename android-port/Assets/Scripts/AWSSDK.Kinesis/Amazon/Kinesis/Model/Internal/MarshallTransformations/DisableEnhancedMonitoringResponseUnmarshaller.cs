using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000071")]
	public class DisableEnhancedMonitoringResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x0")]
		private static DisableEnhancedMonitoringResponseUnmarshaller _instance;

		[Token(Token = "0x170000B7")]
		public static DisableEnhancedMonitoringResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x12ADEBC", Offset = "0x12ADEBC", VA = "0x12ADEBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x12AD4C4", Offset = "0x12AD4C4", VA = "0x12AD4C4", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x12AD820", Offset = "0x12AD820", VA = "0x12AD820", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x12ADE58", Offset = "0x12ADE58", VA = "0x12ADE58")]
		internal static DisableEnhancedMonitoringResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x12ADF20", Offset = "0x12ADF20", VA = "0x12ADF20")]
		public DisableEnhancedMonitoringResponseUnmarshaller()
		{
		}
	}
}
