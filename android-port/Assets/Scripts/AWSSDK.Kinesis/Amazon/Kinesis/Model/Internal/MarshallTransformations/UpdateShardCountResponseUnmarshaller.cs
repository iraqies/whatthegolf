using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20000AA")]
	public class UpdateShardCountResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x0")]
		private static UpdateShardCountResponseUnmarshaller _instance;

		[Token(Token = "0x170000EF")]
		public static UpdateShardCountResponseUnmarshaller Instance
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x12CF474", Offset = "0x12CF474", VA = "0x12CF474")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x12CEA6C", Offset = "0x12CEA6C", VA = "0x12CEA6C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x12CEDD8", Offset = "0x12CEDD8", VA = "0x12CEDD8", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x12CF410", Offset = "0x12CF410", VA = "0x12CF410")]
		internal static UpdateShardCountResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x12CF4D8", Offset = "0x12CF4D8", VA = "0x12CF4D8")]
		public UpdateShardCountResponseUnmarshaller()
		{
		}
	}
}
