using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000243")]
	public class RespondToAuthChallengeResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x0")]
		private static RespondToAuthChallengeResponseUnmarshaller _instance;

		[Token(Token = "0x170003CE")]
		public static RespondToAuthChallengeResponseUnmarshaller Instance
		{
			[Token(Token = "0x6001191")]
			[Address(RVA = "0x11487A0", Offset = "0x11487A0", VA = "0x11487A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600118E")]
		[Address(RVA = "0x1146E70", Offset = "0x1146E70", VA = "0x1146E70", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600118F")]
		[Address(RVA = "0x1147368", Offset = "0x1147368", VA = "0x1147368", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6001190")]
		[Address(RVA = "0x114873C", Offset = "0x114873C", VA = "0x114873C")]
		internal static RespondToAuthChallengeResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001192")]
		[Address(RVA = "0x1148804", Offset = "0x1148804", VA = "0x1148804")]
		public RespondToAuthChallengeResponseUnmarshaller()
		{
		}
	}
}
