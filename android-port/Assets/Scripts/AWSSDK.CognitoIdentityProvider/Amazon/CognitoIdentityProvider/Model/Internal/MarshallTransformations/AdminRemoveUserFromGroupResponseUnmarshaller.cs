using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200017F")]
	public class AdminRemoveUserFromGroupResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x0")]
		private static AdminRemoveUserFromGroupResponseUnmarshaller _instance;

		[Token(Token = "0x1700031F")]
		public static AdminRemoveUserFromGroupResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000D6D")]
			[Address(RVA = "0x10B7514", Offset = "0x10B7514", VA = "0x10B7514")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D6A")]
		[Address(RVA = "0x10B6C80", Offset = "0x10B6C80", VA = "0x10B6C80", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000D6B")]
		[Address(RVA = "0x10B6CD8", Offset = "0x10B6CD8", VA = "0x10B6CD8", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000D6C")]
		[Address(RVA = "0x10B74B0", Offset = "0x10B74B0", VA = "0x10B74B0")]
		internal static AdminRemoveUserFromGroupResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000D6E")]
		[Address(RVA = "0x10B7578", Offset = "0x10B7578", VA = "0x10B7578")]
		public AdminRemoveUserFromGroupResponseUnmarshaller()
		{
		}
	}
}
