using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000067")]
	public class DeregisterStreamConsumerResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x0")]
		private static DeregisterStreamConsumerResponseUnmarshaller _instance;

		[Token(Token = "0x170000AD")]
		public static DeregisterStreamConsumerResponseUnmarshaller Instance
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x12A7928", Offset = "0x12A7928", VA = "0x12A7928")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x12A7300", Offset = "0x12A7300", VA = "0x12A7300", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x12A7358", Offset = "0x12A7358", VA = "0x12A7358", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x12A78C4", Offset = "0x12A78C4", VA = "0x12A78C4")]
		internal static DeregisterStreamConsumerResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x12A798C", Offset = "0x12A798C", VA = "0x12A798C")]
		public DeregisterStreamConsumerResponseUnmarshaller()
		{
		}
	}
}
