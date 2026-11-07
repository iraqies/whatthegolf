using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000095")]
	public class PutRecordsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x0")]
		private static PutRecordsResponseUnmarshaller _instance;

		[Token(Token = "0x170000DA")]
		public static PutRecordsResponseUnmarshaller Instance
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x12C2358", Offset = "0x12C2358", VA = "0x12C2358")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x12C145C", Offset = "0x12C145C", VA = "0x12C145C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x12C18D8", Offset = "0x12C18D8", VA = "0x12C18D8", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x12C22F4", Offset = "0x12C22F4", VA = "0x12C22F4")]
		internal static PutRecordsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x12C23BC", Offset = "0x12C23BC", VA = "0x12C23BC")]
		public PutRecordsResponseUnmarshaller()
		{
		}
	}
}
