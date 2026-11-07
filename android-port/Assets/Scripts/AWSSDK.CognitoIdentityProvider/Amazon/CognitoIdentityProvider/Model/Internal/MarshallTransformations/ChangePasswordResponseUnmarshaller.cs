using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200019E")]
	public class ChangePasswordResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003B6")]
		[FieldOffset(Offset = "0x0")]
		private static ChangePasswordResponseUnmarshaller _instance;

		[Token(Token = "0x1700033B")]
		public static ChangePasswordResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000E18")]
			[Address(RVA = "0x10E2E10", Offset = "0x10E2E10", VA = "0x10E2E10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E15")]
		[Address(RVA = "0x10E224C", Offset = "0x10E224C", VA = "0x10E224C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000E16")]
		[Address(RVA = "0x10E22A4", Offset = "0x10E22A4", VA = "0x10E22A4", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000E17")]
		[Address(RVA = "0x10E2DAC", Offset = "0x10E2DAC", VA = "0x10E2DAC")]
		internal static ChangePasswordResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000E19")]
		[Address(RVA = "0x10E2E74", Offset = "0x10E2E74", VA = "0x10E2E74")]
		public ChangePasswordResponseUnmarshaller()
		{
		}
	}
}
