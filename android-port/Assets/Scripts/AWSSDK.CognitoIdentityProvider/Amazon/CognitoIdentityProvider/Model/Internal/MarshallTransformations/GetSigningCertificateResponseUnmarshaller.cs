using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001F6")]
	public class GetSigningCertificateResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x0")]
		private static GetSigningCertificateResponseUnmarshaller _instance;

		[Token(Token = "0x1700038C")]
		public static GetSigningCertificateResponseUnmarshaller Instance
		{
			[Token(Token = "0x6001002")]
			[Address(RVA = "0x111F3E8", Offset = "0x111F3E8", VA = "0x111F3E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000FFF")]
		[Address(RVA = "0x111EC8C", Offset = "0x111EC8C", VA = "0x111EC8C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001000")]
		[Address(RVA = "0x111EE18", Offset = "0x111EE18", VA = "0x111EE18", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6001001")]
		[Address(RVA = "0x111F384", Offset = "0x111F384", VA = "0x111F384")]
		internal static GetSigningCertificateResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001003")]
		[Address(RVA = "0x111F44C", Offset = "0x111F44C", VA = "0x111F44C")]
		public GetSigningCertificateResponseUnmarshaller()
		{
		}
	}
}
