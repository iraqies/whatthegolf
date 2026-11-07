using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001CD")]
	public class DeleteUserResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x0")]
		private static DeleteUserResponseUnmarshaller _instance;

		[Token(Token = "0x17000366")]
		public static DeleteUserResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000F1F")]
			[Address(RVA = "0x1104974", Offset = "0x1104974", VA = "0x1104974")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F1C")]
		[Address(RVA = "0x1103F48", Offset = "0x1103F48", VA = "0x1103F48", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000F1D")]
		[Address(RVA = "0x1103FA0", Offset = "0x1103FA0", VA = "0x1103FA0", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000F1E")]
		[Address(RVA = "0x1104910", Offset = "0x1104910", VA = "0x1104910")]
		internal static DeleteUserResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000F20")]
		[Address(RVA = "0x11049D8", Offset = "0x11049D8", VA = "0x11049D8")]
		public DeleteUserResponseUnmarshaller()
		{
		}
	}
}
