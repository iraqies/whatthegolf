using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001F0")]
	public class GetDeviceResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0x0")]
		private static GetDeviceResponseUnmarshaller _instance;

		[Token(Token = "0x17000386")]
		public static GetDeviceResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000FDE")]
			[Address(RVA = "0x111A850", Offset = "0x111A850", VA = "0x111A850")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000FDB")]
		[Address(RVA = "0x1119C30", Offset = "0x1119C30", VA = "0x1119C30", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000FDC")]
		[Address(RVA = "0x1119DBC", Offset = "0x1119DBC", VA = "0x1119DBC", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0x111A7EC", Offset = "0x111A7EC", VA = "0x111A7EC")]
		internal static GetDeviceResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000FDF")]
		[Address(RVA = "0x111A8B4", Offset = "0x111A8B4", VA = "0x111A8B4")]
		public GetDeviceResponseUnmarshaller()
		{
		}
	}
}
