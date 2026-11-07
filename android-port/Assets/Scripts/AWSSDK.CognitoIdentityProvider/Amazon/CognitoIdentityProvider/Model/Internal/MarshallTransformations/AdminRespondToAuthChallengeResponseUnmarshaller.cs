using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000183")]
	public class AdminRespondToAuthChallengeResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x0")]
		private static AdminRespondToAuthChallengeResponseUnmarshaller _instance;

		[Token(Token = "0x17000323")]
		public static AdminRespondToAuthChallengeResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000D85")]
			[Address(RVA = "0x10BC20C", Offset = "0x10BC20C", VA = "0x10BC20C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D82")]
		[Address(RVA = "0x10BA9AC", Offset = "0x10BA9AC", VA = "0x10BA9AC", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000D83")]
		[Address(RVA = "0x10BAEA4", Offset = "0x10BAEA4", VA = "0x10BAEA4", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000D84")]
		[Address(RVA = "0x10BC1A8", Offset = "0x10BC1A8", VA = "0x10BC1A8")]
		internal static AdminRespondToAuthChallengeResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000D86")]
		[Address(RVA = "0x10BC270", Offset = "0x10BC270", VA = "0x10BC270")]
		public AdminRespondToAuthChallengeResponseUnmarshaller()
		{
		}
	}
}
