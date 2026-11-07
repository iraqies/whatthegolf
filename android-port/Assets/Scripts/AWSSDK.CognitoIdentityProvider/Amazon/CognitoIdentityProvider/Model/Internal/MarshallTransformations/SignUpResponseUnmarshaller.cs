using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000255")]
	public class SignUpResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400046D")]
		[FieldOffset(Offset = "0x0")]
		private static SignUpResponseUnmarshaller _instance;

		[Token(Token = "0x170003DE")]
		public static SignUpResponseUnmarshaller Instance
		{
			[Token(Token = "0x60011F3")]
			[Address(RVA = "0x1156570", Offset = "0x1156570", VA = "0x1156570")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60011F0")]
		[Address(RVA = "0x115537C", Offset = "0x115537C", VA = "0x115537C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60011F1")]
		[Address(RVA = "0x11556D8", Offset = "0x11556D8", VA = "0x11556D8", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60011F2")]
		[Address(RVA = "0x115650C", Offset = "0x115650C", VA = "0x115650C")]
		internal static SignUpResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60011F4")]
		[Address(RVA = "0x11565D4", Offset = "0x11565D4", VA = "0x11565D4")]
		public SignUpResponseUnmarshaller()
		{
		}
	}
}
