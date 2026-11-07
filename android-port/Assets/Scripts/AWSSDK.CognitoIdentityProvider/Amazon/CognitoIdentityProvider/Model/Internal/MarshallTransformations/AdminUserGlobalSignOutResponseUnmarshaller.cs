using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000191")]
	public class AdminUserGlobalSignOutResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003A9")]
		[FieldOffset(Offset = "0x0")]
		private static AdminUserGlobalSignOutResponseUnmarshaller _instance;

		[Token(Token = "0x17000331")]
		public static AdminUserGlobalSignOutResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000DD9")]
			[Address(RVA = "0x10C6D88", Offset = "0x10C6D88", VA = "0x10C6D88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x10C64F4", Offset = "0x10C64F4", VA = "0x10C64F4", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x10C654C", Offset = "0x10C654C", VA = "0x10C654C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0x10C6D24", Offset = "0x10C6D24", VA = "0x10C6D24")]
		internal static AdminUserGlobalSignOutResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x10C6DEC", Offset = "0x10C6DEC", VA = "0x10C6DEC")]
		public AdminUserGlobalSignOutResponseUnmarshaller()
		{
		}
	}
}
