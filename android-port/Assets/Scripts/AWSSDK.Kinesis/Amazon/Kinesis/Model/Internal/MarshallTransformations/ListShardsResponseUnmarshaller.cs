using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000087")]
	public class ListShardsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x0")]
		private static ListShardsResponseUnmarshaller _instance;

		[Token(Token = "0x170000CD")]
		public static ListShardsResponseUnmarshaller Instance
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x12B7FF4", Offset = "0x12B7FF4", VA = "0x12B7FF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x12B7594", Offset = "0x12B7594", VA = "0x12B7594", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x12B7890", Offset = "0x12B7890", VA = "0x12B7890", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x12B7F90", Offset = "0x12B7F90", VA = "0x12B7F90")]
		internal static ListShardsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x12B8058", Offset = "0x12B8058", VA = "0x12B8058")]
		public ListShardsResponseUnmarshaller()
		{
		}
	}
}
