using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200005D")]
	public class AddTagsToStreamResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x0")]
		private static AddTagsToStreamResponseUnmarshaller _instance;

		[Token(Token = "0x170000A3")]
		public static AddTagsToStreamResponseUnmarshaller Instance
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x129B604", Offset = "0x129B604", VA = "0x129B604")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x129AD40", Offset = "0x129AD40", VA = "0x129AD40", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x129AD98", Offset = "0x129AD98", VA = "0x129AD98", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x129B5A0", Offset = "0x129B5A0", VA = "0x129B5A0")]
		internal static AddTagsToStreamResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x129B668", Offset = "0x129B668", VA = "0x129B668")]
		public AddTagsToStreamResponseUnmarshaller()
		{
		}
	}
}
