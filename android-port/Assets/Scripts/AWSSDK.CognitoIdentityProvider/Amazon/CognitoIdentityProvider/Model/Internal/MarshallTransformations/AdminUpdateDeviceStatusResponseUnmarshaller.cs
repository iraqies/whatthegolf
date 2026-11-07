using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200018D")]
	public class AdminUpdateDeviceStatusResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x0")]
		private static AdminUpdateDeviceStatusResponseUnmarshaller _instance;

		[Token(Token = "0x1700032D")]
		public static AdminUpdateDeviceStatusResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000DC1")]
			[Address(RVA = "0x10C36CC", Offset = "0x10C36CC", VA = "0x10C36CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000DBE")]
		[Address(RVA = "0x10C2D6C", Offset = "0x10C2D6C", VA = "0x10C2D6C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000DBF")]
		[Address(RVA = "0x10C2DC4", Offset = "0x10C2DC4", VA = "0x10C2DC4", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000DC0")]
		[Address(RVA = "0x10C3668", Offset = "0x10C3668", VA = "0x10C3668")]
		internal static AdminUpdateDeviceStatusResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000DC2")]
		[Address(RVA = "0x10C3730", Offset = "0x10C3730", VA = "0x10C3730")]
		public AdminUpdateDeviceStatusResponseUnmarshaller()
		{
		}
	}
}
