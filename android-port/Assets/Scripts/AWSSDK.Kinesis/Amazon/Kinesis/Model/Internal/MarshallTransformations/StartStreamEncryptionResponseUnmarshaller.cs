using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20000A3")]
	public class StartStreamEncryptionResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x0")]
		private static StartStreamEncryptionResponseUnmarshaller _instance;

		[Token(Token = "0x170000E8")]
		public static StartStreamEncryptionResponseUnmarshaller Instance
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x12C9BA4", Offset = "0x12C9BA4", VA = "0x12C9BA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x12C8FE8", Offset = "0x12C8FE8", VA = "0x12C8FE8", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x12C9040", Offset = "0x12C9040", VA = "0x12C9040", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x12C9B40", Offset = "0x12C9B40", VA = "0x12C9B40")]
		internal static StartStreamEncryptionResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x12C9C08", Offset = "0x12C9C08", VA = "0x12C9C08")]
		public StartStreamEncryptionResponseUnmarshaller()
		{
		}
	}
}
