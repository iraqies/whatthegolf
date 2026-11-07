using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000173")]
	public class AdminGetUserResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400038B")]
		[FieldOffset(Offset = "0x0")]
		private static AdminGetUserResponseUnmarshaller _instance;

		[Token(Token = "0x17000313")]
		public static AdminGetUserResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000D25")]
			[Address(RVA = "0x10ACD98", Offset = "0x10ACD98", VA = "0x10ACD98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D22")]
		[Address(RVA = "0x10ABBBC", Offset = "0x10ABBBC", VA = "0x10ABBBC", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x10AC55C", Offset = "0x10AC55C", VA = "0x10AC55C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x10ACD34", Offset = "0x10ACD34", VA = "0x10ACD34")]
		internal static AdminGetUserResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x10ACDFC", Offset = "0x10ACDFC", VA = "0x10ACDFC")]
		public AdminGetUserResponseUnmarshaller()
		{
		}
	}
}
