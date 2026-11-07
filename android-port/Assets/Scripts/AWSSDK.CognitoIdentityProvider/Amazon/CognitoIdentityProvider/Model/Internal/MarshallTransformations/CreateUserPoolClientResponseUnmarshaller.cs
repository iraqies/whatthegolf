using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001B7")]
	public class CreateUserPoolClientResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x0")]
		private static CreateUserPoolClientResponseUnmarshaller _instance;

		[Token(Token = "0x17000351")]
		public static CreateUserPoolClientResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000E9F")]
			[Address(RVA = "0x10F50F8", Offset = "0x10F50F8", VA = "0x10F50F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E9C")]
		[Address(RVA = "0x10F4598", Offset = "0x10F4598", VA = "0x10F4598", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000E9D")]
		[Address(RVA = "0x10F4724", Offset = "0x10F4724", VA = "0x10F4724", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000E9E")]
		[Address(RVA = "0x10F5094", Offset = "0x10F5094", VA = "0x10F5094")]
		internal static CreateUserPoolClientResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000EA0")]
		[Address(RVA = "0x10F515C", Offset = "0x10F515C", VA = "0x10F515C")]
		public CreateUserPoolClientResponseUnmarshaller()
		{
		}
	}
}
