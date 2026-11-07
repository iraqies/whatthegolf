using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200006D")]
	public class DescribeStreamResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x0")]
		private static DescribeStreamResponseUnmarshaller _instance;

		[Token(Token = "0x170000B3")]
		public static DescribeStreamResponseUnmarshaller Instance
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x12AB2F8", Offset = "0x12AB2F8", VA = "0x12AB2F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x12AAC64", Offset = "0x12AAC64", VA = "0x12AAC64", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x12AADF0", Offset = "0x12AADF0", VA = "0x12AADF0", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x12AB294", Offset = "0x12AB294", VA = "0x12AB294")]
		internal static DescribeStreamResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x12AB35C", Offset = "0x12AB35C", VA = "0x12AB35C")]
		public DescribeStreamResponseUnmarshaller()
		{
		}
	}
}
