using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001C1")]
	public class DeleteIdentityProviderResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003D9")]
		[FieldOffset(Offset = "0x0")]
		private static DeleteIdentityProviderResponseUnmarshaller _instance;

		[Token(Token = "0x1700035A")]
		public static DeleteIdentityProviderResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000ED7")]
			[Address(RVA = "0x10FCC80", Offset = "0x10FCC80", VA = "0x10FCC80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0x10FC3EC", Offset = "0x10FC3EC", VA = "0x10FC3EC", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0x10FC444", Offset = "0x10FC444", VA = "0x10FC444", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000ED6")]
		[Address(RVA = "0x10FCC1C", Offset = "0x10FCC1C", VA = "0x10FCC1C")]
		internal static DeleteIdentityProviderResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000ED8")]
		[Address(RVA = "0x10FCCE4", Offset = "0x10FCCE4", VA = "0x10FCCE4")]
		public DeleteIdentityProviderResponseUnmarshaller()
		{
		}
	}
}
