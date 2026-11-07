using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000043")]
	public class BulkPublishResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x0")]
		private static BulkPublishResponseUnmarshaller _instance;

		[Token(Token = "0x1700007C")]
		public static BulkPublishResponseUnmarshaller Instance
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x1191D54", Offset = "0x1191D54", VA = "0x1191D54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1190F30", Offset = "0x1190F30", VA = "0x1190F30", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x11910BC", Offset = "0x11910BC", VA = "0x11910BC", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1191CF0", Offset = "0x1191CF0", VA = "0x1191CF0")]
		internal static BulkPublishResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1191DB8", Offset = "0x1191DB8", VA = "0x1191DB8")]
		public BulkPublishResponseUnmarshaller()
		{
		}
	}
}
