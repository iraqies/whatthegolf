using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200009B")]
	public class RemoveTagsFromStreamResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x0")]
		private static RemoveTagsFromStreamResponseUnmarshaller _instance;

		[Token(Token = "0x170000E0")]
		public static RemoveTagsFromStreamResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x12C5B70", Offset = "0x12C5B70", VA = "0x12C5B70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x12C52B4", Offset = "0x12C52B4", VA = "0x12C52B4", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x12C530C", Offset = "0x12C530C", VA = "0x12C530C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x12C5B0C", Offset = "0x12C5B0C", VA = "0x12C5B0C")]
		internal static RemoveTagsFromStreamResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x12C5BD4", Offset = "0x12C5BD4", VA = "0x12C5BD4")]
		public RemoveTagsFromStreamResponseUnmarshaller()
		{
		}
	}
}
