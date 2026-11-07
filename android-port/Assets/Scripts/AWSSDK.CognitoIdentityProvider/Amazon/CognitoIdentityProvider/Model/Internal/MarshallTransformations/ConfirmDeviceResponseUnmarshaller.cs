using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001A8")]
	public class ConfirmDeviceResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x0")]
		private static ConfirmDeviceResponseUnmarshaller _instance;

		[Token(Token = "0x17000343")]
		public static ConfirmDeviceResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000E48")]
			[Address(RVA = "0x10E685C", Offset = "0x10E685C", VA = "0x10E685C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E45")]
		[Address(RVA = "0x10E5964", Offset = "0x10E5964", VA = "0x10E5964", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000E46")]
		[Address(RVA = "0x10E5B3C", Offset = "0x10E5B3C", VA = "0x10E5B3C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000E47")]
		[Address(RVA = "0x10E67F8", Offset = "0x10E67F8", VA = "0x10E67F8")]
		internal static ConfirmDeviceResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000E49")]
		[Address(RVA = "0x10E68C0", Offset = "0x10E68C0", VA = "0x10E68C0")]
		public ConfirmDeviceResponseUnmarshaller()
		{
		}
	}
}
