using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000061")]
	public class CreateStreamResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x0")]
		private static CreateStreamResponseUnmarshaller _instance;

		[Token(Token = "0x170000A7")]
		public static CreateStreamResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x12A3FC8", Offset = "0x12A3FC8", VA = "0x12A3FC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x12A39A0", Offset = "0x12A39A0", VA = "0x12A39A0", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x12A39F8", Offset = "0x12A39F8", VA = "0x12A39F8", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x12A3F64", Offset = "0x12A3F64", VA = "0x12A3F64")]
		internal static CreateStreamResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x12A402C", Offset = "0x12A402C", VA = "0x12A402C")]
		public CreateStreamResponseUnmarshaller()
		{
		}
	}
}
