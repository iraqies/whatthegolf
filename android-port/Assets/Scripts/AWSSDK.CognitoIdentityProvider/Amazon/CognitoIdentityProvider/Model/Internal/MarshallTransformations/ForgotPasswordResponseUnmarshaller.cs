using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001EC")]
	public class ForgotPasswordResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x0")]
		private static ForgotPasswordResponseUnmarshaller _instance;

		[Token(Token = "0x17000382")]
		public static ForgotPasswordResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000FC6")]
			[Address(RVA = "0x1117968", Offset = "0x1117968", VA = "0x1117968")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000FC3")]
		[Address(RVA = "0x1116418", Offset = "0x1116418", VA = "0x1116418", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000FC4")]
		[Address(RVA = "0x11165A4", Offset = "0x11165A4", VA = "0x11165A4", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0x1117904", Offset = "0x1117904", VA = "0x1117904")]
		internal static ForgotPasswordResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000FC7")]
		[Address(RVA = "0x11179CC", Offset = "0x11179CC", VA = "0x11179CC")]
		public ForgotPasswordResponseUnmarshaller()
		{
		}
	}
}
