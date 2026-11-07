using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200008F")]
	public class MergeShardsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x0")]
		private static MergeShardsResponseUnmarshaller _instance;

		[Token(Token = "0x170000D5")]
		public static MergeShardsResponseUnmarshaller Instance
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x12BDD68", Offset = "0x12BDD68", VA = "0x12BDD68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x12BD674", Offset = "0x12BD674", VA = "0x12BD674", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x12BD6CC", Offset = "0x12BD6CC", VA = "0x12BD6CC", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x12BDD04", Offset = "0x12BDD04", VA = "0x12BDD04")]
		internal static MergeShardsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x12BDDCC", Offset = "0x12BDDCC", VA = "0x12BDDCC")]
		public MergeShardsResponseUnmarshaller()
		{
		}
	}
}
