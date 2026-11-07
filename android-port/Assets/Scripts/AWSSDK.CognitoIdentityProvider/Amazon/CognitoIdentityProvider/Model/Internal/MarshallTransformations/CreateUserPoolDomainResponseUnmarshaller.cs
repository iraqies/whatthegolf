using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001B9")]
	public class CreateUserPoolDomainResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x0")]
		private static CreateUserPoolDomainResponseUnmarshaller _instance;

		[Token(Token = "0x17000353")]
		public static CreateUserPoolDomainResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000EAB")]
			[Address(RVA = "0x10F6794", Offset = "0x10F6794", VA = "0x10F6794")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x10F5E98", Offset = "0x10F5E98", VA = "0x10F5E98", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0x10F6024", Offset = "0x10F6024", VA = "0x10F6024", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x10F6730", Offset = "0x10F6730", VA = "0x10F6730")]
		internal static CreateUserPoolDomainResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0x10F67F8", Offset = "0x10F67F8", VA = "0x10F67F8")]
		public CreateUserPoolDomainResponseUnmarshaller()
		{
		}
	}
}
