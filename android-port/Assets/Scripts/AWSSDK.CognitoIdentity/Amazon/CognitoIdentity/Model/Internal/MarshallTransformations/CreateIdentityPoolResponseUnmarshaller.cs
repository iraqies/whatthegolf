using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200005B")]
	public class CreateIdentityPoolResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x0")]
		private static CreateIdentityPoolResponseUnmarshaller _instance;

		[Token(Token = "0x170000AA")]
		public static CreateIdentityPoolResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x107C8F8", Offset = "0x107C8F8", VA = "0x107C8F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x107B108", Offset = "0x107B108", VA = "0x107B108", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x107BC5C", Offset = "0x107BC5C", VA = "0x107BC5C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x107C894", Offset = "0x107C894", VA = "0x107C894")]
		internal static CreateIdentityPoolResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x107C95C", Offset = "0x107C95C", VA = "0x107C95C")]
		public CreateIdentityPoolResponseUnmarshaller()
		{
		}
	}
}
