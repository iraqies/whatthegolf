using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000189")]
	public class AdminSetUserSettingsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003A1")]
		[FieldOffset(Offset = "0x0")]
		private static AdminSetUserSettingsResponseUnmarshaller _instance;

		[Token(Token = "0x17000329")]
		public static AdminSetUserSettingsResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000DA9")]
			[Address(RVA = "0x10C07F4", Offset = "0x10C07F4", VA = "0x10C07F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000DA6")]
		[Address(RVA = "0x10C002C", Offset = "0x10C002C", VA = "0x10C002C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0x10C0084", Offset = "0x10C0084", VA = "0x10C0084", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0x10C0790", Offset = "0x10C0790", VA = "0x10C0790")]
		internal static AdminSetUserSettingsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0x10C0858", Offset = "0x10C0858", VA = "0x10C0858")]
		public AdminSetUserSettingsResponseUnmarshaller()
		{
		}
	}
}
