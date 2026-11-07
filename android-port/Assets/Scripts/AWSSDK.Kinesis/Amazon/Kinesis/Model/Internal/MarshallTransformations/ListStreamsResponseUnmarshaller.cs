using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200008B")]
	public class ListStreamsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x0")]
		private static ListStreamsResponseUnmarshaller _instance;

		[Token(Token = "0x170000D1")]
		public static ListStreamsResponseUnmarshaller Instance
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x12BB134", Offset = "0x12BB134", VA = "0x12BB134")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x12BA970", Offset = "0x12BA970", VA = "0x12BA970", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x12BACF8", Offset = "0x12BACF8", VA = "0x12BACF8", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x12BB0D0", Offset = "0x12BB0D0", VA = "0x12BB0D0")]
		internal static ListStreamsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x12BB198", Offset = "0x12BB198", VA = "0x12BB198")]
		public ListStreamsResponseUnmarshaller()
		{
		}
	}
}
