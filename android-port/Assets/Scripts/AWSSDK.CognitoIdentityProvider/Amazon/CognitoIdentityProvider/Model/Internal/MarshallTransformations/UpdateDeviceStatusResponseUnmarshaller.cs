using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000272")]
	public class UpdateDeviceStatusResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x0")]
		private static UpdateDeviceStatusResponseUnmarshaller _instance;

		[Token(Token = "0x170003F5")]
		public static UpdateDeviceStatusResponseUnmarshaller Instance
		{
			[Token(Token = "0x6001284")]
			[Address(RVA = "0x11624C8", Offset = "0x11624C8", VA = "0x11624C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001281")]
		[Address(RVA = "0x11618F8", Offset = "0x11618F8", VA = "0x11618F8", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001282")]
		[Address(RVA = "0x1161950", Offset = "0x1161950", VA = "0x1161950", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6001283")]
		[Address(RVA = "0x1162464", Offset = "0x1162464", VA = "0x1162464")]
		internal static UpdateDeviceStatusResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001285")]
		[Address(RVA = "0x116252C", Offset = "0x116252C", VA = "0x116252C")]
		public UpdateDeviceStatusResponseUnmarshaller()
		{
		}
	}
}
