using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000070")]
	public class GetOpenIdTokenResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x0")]
		private static GetOpenIdTokenResponseUnmarshaller _instance;

		[Token(Token = "0x170000BF")]
		public static GetOpenIdTokenResponseUnmarshaller Instance
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x108C54C", Offset = "0x108C54C", VA = "0x108C54C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x108BA2C", Offset = "0x108BA2C", VA = "0x108BA2C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x108BC5C", Offset = "0x108BC5C", VA = "0x108BC5C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x108C4E8", Offset = "0x108C4E8", VA = "0x108C4E8")]
		internal static GetOpenIdTokenResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x108C5B0", Offset = "0x108C5B0", VA = "0x108C5B0")]
		public GetOpenIdTokenResponseUnmarshaller()
		{
		}
	}
}
