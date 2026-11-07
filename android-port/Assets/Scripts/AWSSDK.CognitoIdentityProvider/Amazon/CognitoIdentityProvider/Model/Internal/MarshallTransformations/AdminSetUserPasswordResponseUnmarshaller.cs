using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000187")]
	public class AdminSetUserPasswordResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400039F")]
		[FieldOffset(Offset = "0x0")]
		private static AdminSetUserPasswordResponseUnmarshaller _instance;

		[Token(Token = "0x17000327")]
		public static AdminSetUserPasswordResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000D9D")]
			[Address(RVA = "0x10BF0E8", Offset = "0x10BF0E8", VA = "0x10BF0E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0x10BE788", Offset = "0x10BE788", VA = "0x10BE788", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0x10BE7E0", Offset = "0x10BE7E0", VA = "0x10BE7E0", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0x10BF084", Offset = "0x10BF084", VA = "0x10BF084")]
		internal static AdminSetUserPasswordResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0x10BF14C", Offset = "0x10BF14C", VA = "0x10BF14C")]
		public AdminSetUserPasswordResponseUnmarshaller()
		{
		}
	}
}
