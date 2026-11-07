using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001FC")]
	public class GetUserPoolMfaConfigResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x0")]
		private static GetUserPoolMfaConfigResponseUnmarshaller _instance;

		[Token(Token = "0x17000392")]
		public static GetUserPoolMfaConfigResponseUnmarshaller Instance
		{
			[Token(Token = "0x6001026")]
			[Address(RVA = "0x112410C", Offset = "0x112410C", VA = "0x112410C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001023")]
		[Address(RVA = "0x1123650", Offset = "0x1123650", VA = "0x1123650", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001024")]
		[Address(RVA = "0x11239A4", Offset = "0x11239A4", VA = "0x11239A4", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6001025")]
		[Address(RVA = "0x11240A8", Offset = "0x11240A8", VA = "0x11240A8")]
		internal static GetUserPoolMfaConfigResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001027")]
		[Address(RVA = "0x1124170", Offset = "0x1124170", VA = "0x1124170")]
		public GetUserPoolMfaConfigResponseUnmarshaller()
		{
		}
	}
}
