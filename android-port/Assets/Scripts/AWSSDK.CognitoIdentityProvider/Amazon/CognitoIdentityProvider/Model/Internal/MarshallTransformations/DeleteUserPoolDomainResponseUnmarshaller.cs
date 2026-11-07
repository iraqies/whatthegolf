using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001C9")]
	public class DeleteUserPoolDomainResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x0")]
		private static DeleteUserPoolDomainResponseUnmarshaller _instance;

		[Token(Token = "0x17000362")]
		public static DeleteUserPoolDomainResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000F07")]
			[Address(RVA = "0x1101F94", Offset = "0x1101F94", VA = "0x1101F94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F04")]
		[Address(RVA = "0x1101898", Offset = "0x1101898", VA = "0x1101898", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000F05")]
		[Address(RVA = "0x11018F0", Offset = "0x11018F0", VA = "0x11018F0", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000F06")]
		[Address(RVA = "0x1101F30", Offset = "0x1101F30", VA = "0x1101F30")]
		internal static DeleteUserPoolDomainResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000F08")]
		[Address(RVA = "0x1101FF8", Offset = "0x1101FF8", VA = "0x1101FF8")]
		public DeleteUserPoolDomainResponseUnmarshaller()
		{
		}
	}
}
