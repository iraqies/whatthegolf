using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200029A")]
	public class VerifyUserAttributeResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0x0")]
		private static VerifyUserAttributeResponseUnmarshaller _instance;

		[Token(Token = "0x17000418")]
		public static VerifyUserAttributeResponseUnmarshaller Instance
		{
			[Token(Token = "0x6001354")]
			[Address(RVA = "0x117E38C", Offset = "0x117E38C", VA = "0x117E38C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001351")]
		[Address(RVA = "0x117D6FC", Offset = "0x117D6FC", VA = "0x117D6FC", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001352")]
		[Address(RVA = "0x117D754", Offset = "0x117D754", VA = "0x117D754", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6001353")]
		[Address(RVA = "0x117E328", Offset = "0x117E328", VA = "0x117E328")]
		internal static VerifyUserAttributeResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001355")]
		[Address(RVA = "0x117E3F0", Offset = "0x117E3F0", VA = "0x117E3F0")]
		public VerifyUserAttributeResponseUnmarshaller()
		{
		}
	}
}
