using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200006F")]
	public class DescribeStreamSummaryResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x0")]
		private static DescribeStreamSummaryResponseUnmarshaller _instance;

		[Token(Token = "0x170000B5")]
		public static DescribeStreamSummaryResponseUnmarshaller Instance
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x12AC510", Offset = "0x12AC510", VA = "0x12AC510")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x12ABE7C", Offset = "0x12ABE7C", VA = "0x12ABE7C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x12AC008", Offset = "0x12AC008", VA = "0x12AC008", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x12AC4AC", Offset = "0x12AC4AC", VA = "0x12AC4AC")]
		internal static DescribeStreamSummaryResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x12AC574", Offset = "0x12AC574", VA = "0x12AC574")]
		public DescribeStreamSummaryResponseUnmarshaller()
		{
		}
	}
}
