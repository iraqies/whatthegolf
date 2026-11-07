using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000092")]
	public class PutRecordResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x0")]
		private static PutRecordResponseUnmarshaller _instance;

		[Token(Token = "0x170000D8")]
		public static PutRecordResponseUnmarshaller Instance
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x12C0108", Offset = "0x12C0108", VA = "0x12C0108")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x12BF364", Offset = "0x12BF364", VA = "0x12BF364", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x12BF688", Offset = "0x12BF688", VA = "0x12BF688", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x12C00A4", Offset = "0x12C00A4", VA = "0x12C00A4")]
		internal static PutRecordResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x12C016C", Offset = "0x12C016C", VA = "0x12C016C")]
		public PutRecordResponseUnmarshaller()
		{
		}
	}
}
