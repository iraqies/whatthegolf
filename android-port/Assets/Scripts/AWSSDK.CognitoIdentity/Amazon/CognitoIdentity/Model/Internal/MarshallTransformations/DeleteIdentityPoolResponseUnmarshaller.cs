using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000060")]
	public class DeleteIdentityPoolResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x0")]
		private static DeleteIdentityPoolResponseUnmarshaller _instance;

		[Token(Token = "0x170000AF")]
		public static DeleteIdentityPoolResponseUnmarshaller Instance
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x107FA48", Offset = "0x107FA48", VA = "0x107FA48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x107F1AC", Offset = "0x107F1AC", VA = "0x107F1AC", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x107F204", Offset = "0x107F204", VA = "0x107F204", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x107F9E4", Offset = "0x107F9E4", VA = "0x107F9E4")]
		internal static DeleteIdentityPoolResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x107FAAC", Offset = "0x107FAAC", VA = "0x107FAAC")]
		public DeleteIdentityPoolResponseUnmarshaller()
		{
		}
	}
}
