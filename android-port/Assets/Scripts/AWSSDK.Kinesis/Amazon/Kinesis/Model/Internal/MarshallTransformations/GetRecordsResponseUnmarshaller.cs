using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000078")]
	public class GetRecordsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x0")]
		private static GetRecordsResponseUnmarshaller _instance;

		[Token(Token = "0x170000BE")]
		public static GetRecordsResponseUnmarshaller Instance
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x12B2990", Offset = "0x12B2990", VA = "0x12B2990")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x12B13D4", Offset = "0x12B13D4", VA = "0x12B13D4", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x12B180C", Offset = "0x12B180C", VA = "0x12B180C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x12B292C", Offset = "0x12B292C", VA = "0x12B292C")]
		internal static GetRecordsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x12B29F4", Offset = "0x12B29F4", VA = "0x12B29F4")]
		public GetRecordsResponseUnmarshaller()
		{
		}
	}
}
