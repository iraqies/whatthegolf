using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000065")]
	public class DeleteStreamResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x0")]
		private static DeleteStreamResponseUnmarshaller _instance;

		[Token(Token = "0x170000AB")]
		public static DeleteStreamResponseUnmarshaller Instance
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x12A6684", Offset = "0x12A6684", VA = "0x12A6684")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x12A6058", Offset = "0x12A6058", VA = "0x12A6058", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x12A60B0", Offset = "0x12A60B0", VA = "0x12A60B0", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x12A6620", Offset = "0x12A6620", VA = "0x12A6620")]
		internal static DeleteStreamResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x12A66E8", Offset = "0x12A66E8", VA = "0x12A66E8")]
		public DeleteStreamResponseUnmarshaller()
		{
		}
	}
}
