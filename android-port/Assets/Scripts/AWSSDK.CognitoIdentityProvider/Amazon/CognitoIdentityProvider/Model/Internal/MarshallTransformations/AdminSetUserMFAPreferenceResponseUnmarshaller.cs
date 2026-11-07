using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000185")]
	public class AdminSetUserMFAPreferenceResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x0")]
		private static AdminSetUserMFAPreferenceResponseUnmarshaller _instance;

		[Token(Token = "0x17000325")]
		public static AdminSetUserMFAPreferenceResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000D91")]
			[Address(RVA = "0x10BD95C", Offset = "0x10BD95C", VA = "0x10BD95C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D8E")]
		[Address(RVA = "0x10BCFF4", Offset = "0x10BCFF4", VA = "0x10BCFF4", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000D8F")]
		[Address(RVA = "0x10BD04C", Offset = "0x10BD04C", VA = "0x10BD04C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000D90")]
		[Address(RVA = "0x10BD8F8", Offset = "0x10BD8F8", VA = "0x10BD8F8")]
		internal static AdminSetUserMFAPreferenceResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000D92")]
		[Address(RVA = "0x10BD9C0", Offset = "0x10BD9C0", VA = "0x10BD9C0")]
		public AdminSetUserMFAPreferenceResponseUnmarshaller()
		{
		}
	}
}
