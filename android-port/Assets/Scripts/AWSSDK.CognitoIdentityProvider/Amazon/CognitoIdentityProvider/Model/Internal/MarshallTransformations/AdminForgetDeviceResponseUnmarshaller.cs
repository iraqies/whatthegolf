using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200016F")]
	public class AdminForgetDeviceResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x0")]
		private static AdminForgetDeviceResponseUnmarshaller _instance;

		[Token(Token = "0x1700030F")]
		public static AdminForgetDeviceResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000D0D")]
			[Address(RVA = "0x10A9380", Offset = "0x10A9380", VA = "0x10A9380")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D0A")]
		[Address(RVA = "0x10A8A20", Offset = "0x10A8A20", VA = "0x10A8A20", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000D0B")]
		[Address(RVA = "0x10A8A78", Offset = "0x10A8A78", VA = "0x10A8A78", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000D0C")]
		[Address(RVA = "0x10A931C", Offset = "0x10A931C", VA = "0x10A931C")]
		internal static AdminForgetDeviceResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000D0E")]
		[Address(RVA = "0x10A93E4", Offset = "0x10A93E4", VA = "0x10A93E4")]
		public AdminForgetDeviceResponseUnmarshaller()
		{
		}
	}
}
