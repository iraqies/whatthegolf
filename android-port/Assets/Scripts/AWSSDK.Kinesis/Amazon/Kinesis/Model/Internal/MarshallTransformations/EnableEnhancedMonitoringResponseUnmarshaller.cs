using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000073")]
	public class EnableEnhancedMonitoringResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x0")]
		private static EnableEnhancedMonitoringResponseUnmarshaller _instance;

		[Token(Token = "0x170000B9")]
		public static EnableEnhancedMonitoringResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x12AF868", Offset = "0x12AF868", VA = "0x12AF868")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x12AEE70", Offset = "0x12AEE70", VA = "0x12AEE70", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x12AF1CC", Offset = "0x12AF1CC", VA = "0x12AF1CC", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x12AF804", Offset = "0x12AF804", VA = "0x12AF804")]
		internal static EnableEnhancedMonitoringResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x12AF8CC", Offset = "0x12AF8CC", VA = "0x12AF8CC")]
		public EnableEnhancedMonitoringResponseUnmarshaller()
		{
		}
	}
}
