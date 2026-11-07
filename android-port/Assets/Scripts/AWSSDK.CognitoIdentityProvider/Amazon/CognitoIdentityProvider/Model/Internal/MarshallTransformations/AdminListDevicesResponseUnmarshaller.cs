using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000179")]
	public class AdminListDevicesResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000391")]
		[FieldOffset(Offset = "0x0")]
		private static AdminListDevicesResponseUnmarshaller _instance;

		[Token(Token = "0x17000319")]
		public static AdminListDevicesResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000D49")]
			[Address(RVA = "0x10B2A80", Offset = "0x10B2A80", VA = "0x10B2A80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D46")]
		[Address(RVA = "0x10B1F48", Offset = "0x10B1F48", VA = "0x10B1F48", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000D47")]
		[Address(RVA = "0x10B2244", Offset = "0x10B2244", VA = "0x10B2244", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000D48")]
		[Address(RVA = "0x10B2A1C", Offset = "0x10B2A1C", VA = "0x10B2A1C")]
		internal static AdminListDevicesResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0x10B2AE4", Offset = "0x10B2AE4", VA = "0x10B2AE4")]
		public AdminListDevicesResponseUnmarshaller()
		{
		}
	}
}
