using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000206")]
	public class InitiateAuthResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x0")]
		private static InitiateAuthResponseUnmarshaller _instance;

		[Token(Token = "0x1700039B")]
		public static InitiateAuthResponseUnmarshaller Instance
		{
			[Token(Token = "0x600105C")]
			[Address(RVA = "0x112B034", Offset = "0x112B034", VA = "0x112B034")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001059")]
		[Address(RVA = "0x1129CB4", Offset = "0x1129CB4", VA = "0x1129CB4", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600105A")]
		[Address(RVA = "0x112A1AC", Offset = "0x112A1AC", VA = "0x112A1AC", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600105B")]
		[Address(RVA = "0x112AFD0", Offset = "0x112AFD0", VA = "0x112AFD0")]
		internal static InitiateAuthResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600105D")]
		[Address(RVA = "0x112B098", Offset = "0x112B098", VA = "0x112B098")]
		public InitiateAuthResponseUnmarshaller()
		{
		}
	}
}
