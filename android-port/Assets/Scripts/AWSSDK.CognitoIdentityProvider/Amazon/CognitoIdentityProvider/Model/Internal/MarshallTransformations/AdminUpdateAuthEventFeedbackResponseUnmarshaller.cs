using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200018B")]
	public class AdminUpdateAuthEventFeedbackResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x0")]
		private static AdminUpdateAuthEventFeedbackResponseUnmarshaller _instance;

		[Token(Token = "0x1700032B")]
		public static AdminUpdateAuthEventFeedbackResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000DB5")]
			[Address(RVA = "0x10C1F60", Offset = "0x10C1F60", VA = "0x10C1F60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000DB2")]
		[Address(RVA = "0x10C1600", Offset = "0x10C1600", VA = "0x10C1600", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000DB3")]
		[Address(RVA = "0x10C1658", Offset = "0x10C1658", VA = "0x10C1658", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000DB4")]
		[Address(RVA = "0x10C1EFC", Offset = "0x10C1EFC", VA = "0x10C1EFC")]
		internal static AdminUpdateAuthEventFeedbackResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000DB6")]
		[Address(RVA = "0x10C1FC4", Offset = "0x10C1FC4", VA = "0x10C1FC4")]
		public AdminUpdateAuthEventFeedbackResponseUnmarshaller()
		{
		}
	}
}
