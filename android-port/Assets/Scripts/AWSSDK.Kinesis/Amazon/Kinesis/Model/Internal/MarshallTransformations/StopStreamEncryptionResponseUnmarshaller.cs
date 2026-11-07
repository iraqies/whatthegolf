using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20000A5")]
	public class StopStreamEncryptionResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x0")]
		private static StopStreamEncryptionResponseUnmarshaller _instance;

		[Token(Token = "0x170000EA")]
		public static StopStreamEncryptionResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x12CB018", Offset = "0x12CB018", VA = "0x12CB018")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x12CA924", Offset = "0x12CA924", VA = "0x12CA924", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x12CA97C", Offset = "0x12CA97C", VA = "0x12CA97C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x12CAFB4", Offset = "0x12CAFB4", VA = "0x12CAFB4")]
		internal static StopStreamEncryptionResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x12CB07C", Offset = "0x12CB07C", VA = "0x12CB07C")]
		public StopStreamEncryptionResponseUnmarshaller()
		{
		}
	}
}
