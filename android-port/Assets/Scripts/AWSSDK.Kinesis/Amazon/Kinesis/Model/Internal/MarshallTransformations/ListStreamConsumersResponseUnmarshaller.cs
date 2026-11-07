using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000089")]
	public class ListStreamConsumersResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x0")]
		private static ListStreamConsumersResponseUnmarshaller _instance;

		[Token(Token = "0x170000CF")]
		public static ListStreamConsumersResponseUnmarshaller Instance
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x12B9A98", Offset = "0x12B9A98", VA = "0x12B9A98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x12B9038", Offset = "0x12B9038", VA = "0x12B9038", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x12B9334", Offset = "0x12B9334", VA = "0x12B9334", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x12B9A34", Offset = "0x12B9A34", VA = "0x12B9A34")]
		internal static ListStreamConsumersResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x12B9AFC", Offset = "0x12B9AFC", VA = "0x12B9AFC")]
		public ListStreamConsumersResponseUnmarshaller()
		{
		}
	}
}
