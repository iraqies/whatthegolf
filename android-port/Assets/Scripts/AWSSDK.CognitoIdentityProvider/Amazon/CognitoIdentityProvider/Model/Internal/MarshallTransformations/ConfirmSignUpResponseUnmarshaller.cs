using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001AC")]
	public class ConfirmSignUpResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x0")]
		private static ConfirmSignUpResponseUnmarshaller _instance;

		[Token(Token = "0x17000347")]
		public static ConfirmSignUpResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000E60")]
			[Address(RVA = "0x10EAE30", Offset = "0x10EAE30", VA = "0x10EAE30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0x10E9F40", Offset = "0x10E9F40", VA = "0x10E9F40", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0x10E9F98", Offset = "0x10E9F98", VA = "0x10E9F98", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x10EADCC", Offset = "0x10EADCC", VA = "0x10EADCC")]
		internal static ConfirmSignUpResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000E61")]
		[Address(RVA = "0x10EAE94", Offset = "0x10EAE94", VA = "0x10EAE94")]
		public ConfirmSignUpResponseUnmarshaller()
		{
		}
	}
}
