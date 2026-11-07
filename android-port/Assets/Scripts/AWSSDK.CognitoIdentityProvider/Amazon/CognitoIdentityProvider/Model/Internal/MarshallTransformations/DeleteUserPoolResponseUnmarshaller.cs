using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001CB")]
	public class DeleteUserPoolResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x0")]
		private static DeleteUserPoolResponseUnmarshaller _instance;

		[Token(Token = "0x17000364")]
		public static DeleteUserPoolResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000F13")]
			[Address(RVA = "0x110338C", Offset = "0x110338C", VA = "0x110338C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F10")]
		[Address(RVA = "0x1102AF8", Offset = "0x1102AF8", VA = "0x1102AF8", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000F11")]
		[Address(RVA = "0x1102B50", Offset = "0x1102B50", VA = "0x1102B50", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000F12")]
		[Address(RVA = "0x1103328", Offset = "0x1103328", VA = "0x1103328")]
		internal static DeleteUserPoolResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000F14")]
		[Address(RVA = "0x11033F0", Offset = "0x11033F0", VA = "0x11033F0")]
		public DeleteUserPoolResponseUnmarshaller()
		{
		}
	}
}
