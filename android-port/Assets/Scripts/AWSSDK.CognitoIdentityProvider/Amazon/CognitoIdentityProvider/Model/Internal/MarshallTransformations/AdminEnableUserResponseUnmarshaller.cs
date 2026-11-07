using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200016D")]
	public class AdminEnableUserResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000385")]
		[FieldOffset(Offset = "0x0")]
		private static AdminEnableUserResponseUnmarshaller _instance;

		[Token(Token = "0x1700030D")]
		public static AdminEnableUserResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000D01")]
			[Address(RVA = "0x10A7DA4", Offset = "0x10A7DA4", VA = "0x10A7DA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CFE")]
		[Address(RVA = "0x10A7510", Offset = "0x10A7510", VA = "0x10A7510", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000CFF")]
		[Address(RVA = "0x10A7568", Offset = "0x10A7568", VA = "0x10A7568", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000D00")]
		[Address(RVA = "0x10A7D40", Offset = "0x10A7D40", VA = "0x10A7D40")]
		internal static AdminEnableUserResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000D02")]
		[Address(RVA = "0x10A7E08", Offset = "0x10A7E08", VA = "0x10A7E08")]
		public AdminEnableUserResponseUnmarshaller()
		{
		}
	}
}
