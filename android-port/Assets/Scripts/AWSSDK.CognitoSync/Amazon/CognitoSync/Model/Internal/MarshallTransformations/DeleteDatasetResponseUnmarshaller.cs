using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000049")]
	public class DeleteDatasetResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x0")]
		private static DeleteDatasetResponseUnmarshaller _instance;

		[Token(Token = "0x17000081")]
		public static DeleteDatasetResponseUnmarshaller Instance
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x1194F7C", Offset = "0x1194F7C", VA = "0x1194F7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1194408", Offset = "0x1194408", VA = "0x1194408", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1194590", Offset = "0x1194590", VA = "0x1194590", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1194F18", Offset = "0x1194F18", VA = "0x1194F18")]
		internal static DeleteDatasetResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1194FE0", Offset = "0x1194FE0", VA = "0x1194FE0")]
		public DeleteDatasetResponseUnmarshaller()
		{
		}
	}
}
