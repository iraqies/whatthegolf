using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200027C")]
	public class UpdateUserPoolClientResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x0")]
		private static UpdateUserPoolClientResponseUnmarshaller _instance;

		[Token(Token = "0x170003FF")]
		public static UpdateUserPoolClientResponseUnmarshaller Instance
		{
			[Token(Token = "0x60012C0")]
			[Address(RVA = "0x116DBE4", Offset = "0x116DBE4", VA = "0x116DBE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60012BD")]
		[Address(RVA = "0x116C09C", Offset = "0x116C09C", VA = "0x116C09C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60012BE")]
		[Address(RVA = "0x116D214", Offset = "0x116D214", VA = "0x116D214", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60012BF")]
		[Address(RVA = "0x116DB80", Offset = "0x116DB80", VA = "0x116DB80")]
		internal static UpdateUserPoolClientResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60012C1")]
		[Address(RVA = "0x116DC48", Offset = "0x116DC48", VA = "0x116DC48")]
		public UpdateUserPoolClientResponseUnmarshaller()
		{
		}
	}
}
