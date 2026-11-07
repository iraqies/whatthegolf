using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200006B")]
	public class RegisterDeviceResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x0")]
		private static RegisterDeviceResponseUnmarshaller _instance;

		[Token(Token = "0x170000A1")]
		public static RegisterDeviceResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x11A6FB4", Offset = "0x11A6FB4", VA = "0x11A6FB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x11A6604", Offset = "0x11A6604", VA = "0x11A6604", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x11A6790", Offset = "0x11A6790", VA = "0x11A6790", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x11A6F50", Offset = "0x11A6F50", VA = "0x11A6F50")]
		internal static RegisterDeviceResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x11A7018", Offset = "0x11A7018", VA = "0x11A7018")]
		public RegisterDeviceResponseUnmarshaller()
		{
		}
	}
}
