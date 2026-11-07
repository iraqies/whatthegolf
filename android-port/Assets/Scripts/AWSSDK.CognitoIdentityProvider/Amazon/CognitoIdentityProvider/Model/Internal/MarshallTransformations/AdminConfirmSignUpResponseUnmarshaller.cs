using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200015F")]
	public class AdminConfirmSignUpResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x0")]
		private static AdminConfirmSignUpResponseUnmarshaller _instance;

		[Token(Token = "0x17000300")]
		public static AdminConfirmSignUpResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000CB1")]
			[Address(RVA = "0x109DCAC", Offset = "0x109DCAC", VA = "0x109DCAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x109D01C", Offset = "0x109D01C", VA = "0x109D01C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x109D074", Offset = "0x109D074", VA = "0x109D074", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x109DC48", Offset = "0x109DC48", VA = "0x109DC48")]
		internal static AdminConfirmSignUpResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x109DD10", Offset = "0x109DD10", VA = "0x109DD10")]
		public AdminConfirmSignUpResponseUnmarshaller()
		{
		}
	}
}
