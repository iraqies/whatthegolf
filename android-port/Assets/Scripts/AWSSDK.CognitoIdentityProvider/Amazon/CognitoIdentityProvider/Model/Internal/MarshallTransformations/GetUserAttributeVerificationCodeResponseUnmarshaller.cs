using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001FA")]
	public class GetUserAttributeVerificationCodeResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x0")]
		private static GetUserAttributeVerificationCodeResponseUnmarshaller _instance;

		[Token(Token = "0x17000390")]
		public static GetUserAttributeVerificationCodeResponseUnmarshaller Instance
		{
			[Token(Token = "0x600101A")]
			[Address(RVA = "0x1122A20", Offset = "0x1122A20", VA = "0x1122A20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001017")]
		[Address(RVA = "0x1121878", Offset = "0x1121878", VA = "0x1121878", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001018")]
		[Address(RVA = "0x1121A04", Offset = "0x1121A04", VA = "0x1121A04", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6001019")]
		[Address(RVA = "0x11229BC", Offset = "0x11229BC", VA = "0x11229BC")]
		internal static GetUserAttributeVerificationCodeResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600101B")]
		[Address(RVA = "0x1122A84", Offset = "0x1122A84", VA = "0x1122A84")]
		public GetUserAttributeVerificationCodeResponseUnmarshaller()
		{
		}
	}
}
