using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001B5")]
	public class CreateUserImportJobResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x0")]
		private static CreateUserImportJobResponseUnmarshaller _instance;

		[Token(Token = "0x1700034F")]
		public static CreateUserImportJobResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000E93")]
			[Address(RVA = "0x10F1F14", Offset = "0x10F1F14", VA = "0x10F1F14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x10F1480", Offset = "0x10F1480", VA = "0x10F1480", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000E91")]
		[Address(RVA = "0x10F160C", Offset = "0x10F160C", VA = "0x10F160C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000E92")]
		[Address(RVA = "0x10F1EB0", Offset = "0x10F1EB0", VA = "0x10F1EB0")]
		internal static CreateUserImportJobResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000E94")]
		[Address(RVA = "0x10F1F78", Offset = "0x10F1F78", VA = "0x10F1F78")]
		public CreateUserImportJobResponseUnmarshaller()
		{
		}
	}
}
