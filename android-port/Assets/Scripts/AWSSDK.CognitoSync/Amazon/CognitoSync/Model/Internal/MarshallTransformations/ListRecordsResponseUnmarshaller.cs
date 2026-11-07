using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000064")]
	public class ListRecordsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x0")]
		private static ListRecordsResponseUnmarshaller _instance;

		[Token(Token = "0x1700009C")]
		public static ListRecordsResponseUnmarshaller Instance
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x11A3A60", Offset = "0x11A3A60", VA = "0x11A3A60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x11A2AA4", Offset = "0x11A2AA4", VA = "0x11A2AA4", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x11A33CC", Offset = "0x11A33CC", VA = "0x11A33CC", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x11A39FC", Offset = "0x11A39FC", VA = "0x11A39FC")]
		internal static ListRecordsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x11A3AC4", Offset = "0x11A3AC4", VA = "0x11A3AC4")]
		public ListRecordsResponseUnmarshaller()
		{
		}
	}
}
