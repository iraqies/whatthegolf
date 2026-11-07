using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000270")]
	public class UpdateAuthEventFeedbackResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x0")]
		private static UpdateAuthEventFeedbackResponseUnmarshaller _instance;

		[Token(Token = "0x170003F3")]
		public static UpdateAuthEventFeedbackResponseUnmarshaller Instance
		{
			[Token(Token = "0x6001278")]
			[Address(RVA = "0x1160B80", Offset = "0x1160B80", VA = "0x1160B80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001275")]
		[Address(RVA = "0x1160064", Offset = "0x1160064", VA = "0x1160064", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001276")]
		[Address(RVA = "0x11600BC", Offset = "0x11600BC", VA = "0x11600BC", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6001277")]
		[Address(RVA = "0x1160B1C", Offset = "0x1160B1C", VA = "0x1160B1C")]
		internal static UpdateAuthEventFeedbackResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001279")]
		[Address(RVA = "0x1160BE4", Offset = "0x1160BE4", VA = "0x1160BE4")]
		public UpdateAuthEventFeedbackResponseUnmarshaller()
		{
		}
	}
}
