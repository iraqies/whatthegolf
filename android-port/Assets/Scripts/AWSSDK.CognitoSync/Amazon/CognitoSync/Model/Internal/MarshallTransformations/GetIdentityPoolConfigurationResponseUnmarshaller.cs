using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000056")]
	public class GetIdentityPoolConfigurationResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x0")]
		private static GetIdentityPoolConfigurationResponseUnmarshaller _instance;

		[Token(Token = "0x1700008E")]
		public static GetIdentityPoolConfigurationResponseUnmarshaller Instance
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x119CBD8", Offset = "0x119CBD8", VA = "0x119CBD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x119BE84", Offset = "0x119BE84", VA = "0x119BE84", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x119C47C", Offset = "0x119C47C", VA = "0x119C47C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x119CB74", Offset = "0x119CB74", VA = "0x119CB74")]
		internal static GetIdentityPoolConfigurationResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x119CC3C", Offset = "0x119CC3C", VA = "0x119CC3C")]
		public GetIdentityPoolConfigurationResponseUnmarshaller()
		{
		}
	}
}
