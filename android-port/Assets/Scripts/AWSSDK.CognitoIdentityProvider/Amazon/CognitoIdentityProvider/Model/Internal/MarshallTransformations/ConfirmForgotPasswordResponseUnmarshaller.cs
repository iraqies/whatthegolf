using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001AA")]
	public class ConfirmForgotPasswordResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x0")]
		private static ConfirmForgotPasswordResponseUnmarshaller _instance;

		[Token(Token = "0x17000345")]
		public static ConfirmForgotPasswordResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000E54")]
			[Address(RVA = "0x10E8B20", Offset = "0x10E8B20", VA = "0x10E8B20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E51")]
		[Address(RVA = "0x10E7B60", Offset = "0x10E7B60", VA = "0x10E7B60", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000E52")]
		[Address(RVA = "0x10E7BB8", Offset = "0x10E7BB8", VA = "0x10E7BB8", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000E53")]
		[Address(RVA = "0x10E8ABC", Offset = "0x10E8ABC", VA = "0x10E8ABC")]
		internal static ConfirmForgotPasswordResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000E55")]
		[Address(RVA = "0x10E8B84", Offset = "0x10E8B84", VA = "0x10E8B84")]
		public ConfirmForgotPasswordResponseUnmarshaller()
		{
		}
	}
}
