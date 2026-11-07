using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001C7")]
	public class DeleteUserPoolClientResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x0")]
		private static DeleteUserPoolClientResponseUnmarshaller _instance;

		[Token(Token = "0x17000360")]
		public static DeleteUserPoolClientResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000EFB")]
			[Address(RVA = "0x1100CA8", Offset = "0x1100CA8", VA = "0x1100CA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000EF8")]
		[Address(RVA = "0x11004E0", Offset = "0x11004E0", VA = "0x11004E0", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000EF9")]
		[Address(RVA = "0x1100538", Offset = "0x1100538", VA = "0x1100538", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000EFA")]
		[Address(RVA = "0x1100C44", Offset = "0x1100C44", VA = "0x1100C44")]
		internal static DeleteUserPoolClientResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000EFC")]
		[Address(RVA = "0x1100D0C", Offset = "0x1100D0C", VA = "0x1100D0C")]
		public DeleteUserPoolClientResponseUnmarshaller()
		{
		}
	}
}
