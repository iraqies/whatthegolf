using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200008D")]
	public class ListTagsForStreamResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x0")]
		private static ListTagsForStreamResponseUnmarshaller _instance;

		[Token(Token = "0x170000D3")]
		public static ListTagsForStreamResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x12BC9F8", Offset = "0x12BC9F8", VA = "0x12BC9F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x12BC0A0", Offset = "0x12BC0A0", VA = "0x12BC0A0", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x12BC428", Offset = "0x12BC428", VA = "0x12BC428", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x12BC994", Offset = "0x12BC994", VA = "0x12BC994")]
		internal static ListTagsForStreamResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x12BCA5C", Offset = "0x12BCA5C", VA = "0x12BCA5C")]
		public ListTagsForStreamResponseUnmarshaller()
		{
		}
	}
}
