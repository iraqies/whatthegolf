using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001B1")]
	public class CreateIdentityProviderResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x0")]
		private static CreateIdentityProviderResponseUnmarshaller _instance;

		[Token(Token = "0x1700034B")]
		public static CreateIdentityProviderResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000E7B")]
			[Address(RVA = "0x10EEE2C", Offset = "0x10EEE2C", VA = "0x10EEE2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E78")]
		[Address(RVA = "0x10EE2B8", Offset = "0x10EE2B8", VA = "0x10EE2B8", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000E79")]
		[Address(RVA = "0x10EE444", Offset = "0x10EE444", VA = "0x10EE444", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000E7A")]
		[Address(RVA = "0x10EEDC8", Offset = "0x10EEDC8", VA = "0x10EEDC8")]
		internal static CreateIdentityProviderResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000E7C")]
		[Address(RVA = "0x10EEE90", Offset = "0x10EEE90", VA = "0x10EEE90")]
		public CreateIdentityProviderResponseUnmarshaller()
		{
		}
	}
}
