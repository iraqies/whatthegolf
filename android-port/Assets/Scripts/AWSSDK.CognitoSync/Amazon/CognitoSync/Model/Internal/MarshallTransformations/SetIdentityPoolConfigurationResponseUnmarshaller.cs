using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000071")]
	public class SetIdentityPoolConfigurationResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x0")]
		private static SetIdentityPoolConfigurationResponseUnmarshaller _instance;

		[Token(Token = "0x170000A7")]
		public static SetIdentityPoolConfigurationResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x11AA10C", Offset = "0x11AA10C", VA = "0x11AA10C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x11A95F4", Offset = "0x11A95F4", VA = "0x11A95F4", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x11A98E8", Offset = "0x11A98E8", VA = "0x11A98E8", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x11AA0A8", Offset = "0x11AA0A8", VA = "0x11AA0A8")]
		internal static SetIdentityPoolConfigurationResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x11AA170", Offset = "0x11AA170", VA = "0x11AA170")]
		public SetIdentityPoolConfigurationResponseUnmarshaller()
		{
		}
	}
}
