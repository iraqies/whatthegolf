using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200023D")]
	public class ResendConfirmationCodeResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x0")]
		private static ResendConfirmationCodeResponseUnmarshaller _instance;

		[Token(Token = "0x170003C9")]
		public static ResendConfirmationCodeResponseUnmarshaller Instance
		{
			[Token(Token = "0x6001173")]
			[Address(RVA = "0x1144A5C", Offset = "0x1144A5C", VA = "0x1144A5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001170")]
		[Address(RVA = "0x1143A38", Offset = "0x1143A38", VA = "0x1143A38", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001171")]
		[Address(RVA = "0x1143BC4", Offset = "0x1143BC4", VA = "0x1143BC4", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6001172")]
		[Address(RVA = "0x11449F8", Offset = "0x11449F8", VA = "0x11449F8")]
		internal static ResendConfirmationCodeResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001174")]
		[Address(RVA = "0x1144AC0", Offset = "0x1144AC0", VA = "0x1144AC0")]
		public ResendConfirmationCodeResponseUnmarshaller()
		{
		}
	}
}
