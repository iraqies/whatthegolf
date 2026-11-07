using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200006B")]
	public class DescribeStreamConsumerResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x0")]
		private static DescribeStreamConsumerResponseUnmarshaller _instance;

		[Token(Token = "0x170000B1")]
		public static DescribeStreamConsumerResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x12A9EAC", Offset = "0x12A9EAC", VA = "0x12A9EAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x12A9754", Offset = "0x12A9754", VA = "0x12A9754", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x12A98DC", Offset = "0x12A98DC", VA = "0x12A98DC", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x12A9E48", Offset = "0x12A9E48", VA = "0x12A9E48")]
		internal static DescribeStreamConsumerResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x12A9F10", Offset = "0x12A9F10", VA = "0x12A9F10")]
		public DescribeStreamConsumerResponseUnmarshaller()
		{
		}
	}
}
