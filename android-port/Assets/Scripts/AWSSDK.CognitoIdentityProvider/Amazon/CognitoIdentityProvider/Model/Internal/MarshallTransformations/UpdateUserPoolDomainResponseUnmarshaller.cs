using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200027E")]
	public class UpdateUserPoolDomainResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x0")]
		private static UpdateUserPoolDomainResponseUnmarshaller _instance;

		[Token(Token = "0x17000401")]
		public static UpdateUserPoolDomainResponseUnmarshaller Instance
		{
			[Token(Token = "0x60012CC")]
			[Address(RVA = "0x116F1E8", Offset = "0x116F1E8", VA = "0x116F1E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60012C9")]
		[Address(RVA = "0x116E8F0", Offset = "0x116E8F0", VA = "0x116E8F0", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60012CA")]
		[Address(RVA = "0x116EA7C", Offset = "0x116EA7C", VA = "0x116EA7C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60012CB")]
		[Address(RVA = "0x116F184", Offset = "0x116F184", VA = "0x116F184")]
		internal static UpdateUserPoolDomainResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60012CD")]
		[Address(RVA = "0x116F24C", Offset = "0x116F24C", VA = "0x116F24C")]
		public UpdateUserPoolDomainResponseUnmarshaller()
		{
		}
	}
}
