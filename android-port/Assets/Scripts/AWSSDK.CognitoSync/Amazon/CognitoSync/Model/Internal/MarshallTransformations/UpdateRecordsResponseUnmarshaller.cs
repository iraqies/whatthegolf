using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000078")]
	public class UpdateRecordsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x0")]
		private static UpdateRecordsResponseUnmarshaller _instance;

		[Token(Token = "0x170000AE")]
		public static UpdateRecordsResponseUnmarshaller Instance
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x11AEBA8", Offset = "0x11AEBA8", VA = "0x11AEBA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x11ADEE8", Offset = "0x11ADEE8", VA = "0x11ADEE8", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x11AE12C", Offset = "0x11AE12C", VA = "0x11AE12C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x11AEB44", Offset = "0x11AEB44", VA = "0x11AEB44")]
		internal static UpdateRecordsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x11AEC0C", Offset = "0x11AEC0C", VA = "0x11AEC0C")]
		public UpdateRecordsResponseUnmarshaller()
		{
		}
	}
}
