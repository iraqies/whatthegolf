using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000171")]
	public class AdminGetDeviceResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000389")]
		[FieldOffset(Offset = "0x0")]
		private static AdminGetDeviceResponseUnmarshaller _instance;

		[Token(Token = "0x17000311")]
		public static AdminGetDeviceResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000D19")]
			[Address(RVA = "0x10AA9E4", Offset = "0x10AA9E4", VA = "0x10AA9E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D16")]
		[Address(RVA = "0x10AA01C", Offset = "0x10AA01C", VA = "0x10AA01C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000D17")]
		[Address(RVA = "0x10AA1A8", Offset = "0x10AA1A8", VA = "0x10AA1A8", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000D18")]
		[Address(RVA = "0x10AA980", Offset = "0x10AA980", VA = "0x10AA980")]
		internal static AdminGetDeviceResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000D1A")]
		[Address(RVA = "0x10AAA48", Offset = "0x10AAA48", VA = "0x10AAA48")]
		public AdminGetDeviceResponseUnmarshaller()
		{
		}
	}
}
