using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000099")]
	public class RegisterStreamConsumerResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x0")]
		private static RegisterStreamConsumerResponseUnmarshaller _instance;

		[Token(Token = "0x170000DE")]
		public static RegisterStreamConsumerResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x12C4480", Offset = "0x12C4480", VA = "0x12C4480")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x12C3C5C", Offset = "0x12C3C5C", VA = "0x12C3C5C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x12C3DE4", Offset = "0x12C3DE4", VA = "0x12C3DE4", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x12C441C", Offset = "0x12C441C", VA = "0x12C441C")]
		internal static RegisterStreamConsumerResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x12C44E4", Offset = "0x12C44E4", VA = "0x12C44E4")]
		public RegisterStreamConsumerResponseUnmarshaller()
		{
		}
	}
}
