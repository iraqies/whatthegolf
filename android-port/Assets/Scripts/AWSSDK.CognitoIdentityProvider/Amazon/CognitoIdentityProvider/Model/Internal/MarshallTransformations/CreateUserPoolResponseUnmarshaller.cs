using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001BB")]
	public class CreateUserPoolResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x0")]
		private static CreateUserPoolResponseUnmarshaller _instance;

		[Token(Token = "0x17000355")]
		public static CreateUserPoolResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000EB7")]
			[Address(RVA = "0x10F9DE8", Offset = "0x10F9DE8", VA = "0x10F9DE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000EB4")]
		[Address(RVA = "0x10F91BC", Offset = "0x10F91BC", VA = "0x10F91BC", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000EB5")]
		[Address(RVA = "0x10F9348", Offset = "0x10F9348", VA = "0x10F9348", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000EB6")]
		[Address(RVA = "0x10F9D84", Offset = "0x10F9D84", VA = "0x10F9D84")]
		internal static CreateUserPoolResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000EB8")]
		[Address(RVA = "0x10F9E4C", Offset = "0x10F9E4C", VA = "0x10F9E4C")]
		public CreateUserPoolResponseUnmarshaller()
		{
		}
	}
}
