using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001C3")]
	public class DeleteResourceServerResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0x0")]
		private static DeleteResourceServerResponseUnmarshaller _instance;

		[Token(Token = "0x1700035C")]
		public static DeleteResourceServerResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000EE3")]
			[Address(RVA = "0x10FE038", Offset = "0x10FE038", VA = "0x10FE038")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000EE0")]
		[Address(RVA = "0x10FD870", Offset = "0x10FD870", VA = "0x10FD870", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000EE1")]
		[Address(RVA = "0x10FD8C8", Offset = "0x10FD8C8", VA = "0x10FD8C8", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000EE2")]
		[Address(RVA = "0x10FDFD4", Offset = "0x10FDFD4", VA = "0x10FDFD4")]
		internal static DeleteResourceServerResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000EE4")]
		[Address(RVA = "0x10FE09C", Offset = "0x10FE09C", VA = "0x10FE09C")]
		public DeleteResourceServerResponseUnmarshaller()
		{
		}
	}
}
