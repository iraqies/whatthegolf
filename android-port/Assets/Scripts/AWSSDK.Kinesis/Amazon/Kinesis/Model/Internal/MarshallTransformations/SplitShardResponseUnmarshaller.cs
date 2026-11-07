using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20000A1")]
	public class SplitShardResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x0")]
		private static SplitShardResponseUnmarshaller _instance;

		[Token(Token = "0x170000E6")]
		public static SplitShardResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x12C8268", Offset = "0x12C8268", VA = "0x12C8268")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x12C7B74", Offset = "0x12C7B74", VA = "0x12C7B74", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x12C7BCC", Offset = "0x12C7BCC", VA = "0x12C7BCC", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x12C8204", Offset = "0x12C8204", VA = "0x12C8204")]
		internal static SplitShardResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x12C82CC", Offset = "0x12C82CC", VA = "0x12C82CC")]
		public SplitShardResponseUnmarshaller()
		{
		}
	}
}
