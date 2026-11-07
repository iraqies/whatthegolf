using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000175")]
	public class AdminInitiateAuthResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400038D")]
		[FieldOffset(Offset = "0x0")]
		private static AdminInitiateAuthResponseUnmarshaller _instance;

		[Token(Token = "0x17000315")]
		public static AdminInitiateAuthResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000D31")]
			[Address(RVA = "0x10AF8B0", Offset = "0x10AF8B0", VA = "0x10AF8B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D2E")]
		[Address(RVA = "0x10AE44C", Offset = "0x10AE44C", VA = "0x10AE44C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000D2F")]
		[Address(RVA = "0x10AE944", Offset = "0x10AE944", VA = "0x10AE944", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000D30")]
		[Address(RVA = "0x10AF84C", Offset = "0x10AF84C", VA = "0x10AF84C")]
		internal static AdminInitiateAuthResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x10AF914", Offset = "0x10AF914", VA = "0x10AF914")]
		public AdminInitiateAuthResponseUnmarshaller()
		{
		}
	}
}
