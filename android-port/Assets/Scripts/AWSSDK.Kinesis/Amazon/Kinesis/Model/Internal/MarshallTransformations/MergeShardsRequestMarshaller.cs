using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200008E")]
	public class MergeShardsRequestMarshaller : IMarshaller<IRequest, MergeShardsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x0")]
		private static MergeShardsRequestMarshaller _instance;

		[Token(Token = "0x170000D4")]
		public static MergeShardsRequestMarshaller Instance
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x12BD5A0", Offset = "0x12BD5A0", VA = "0x12BD5A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x12BCB2C", Offset = "0x12BCB2C", VA = "0x12BCB2C", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x12BCBC0", Offset = "0x12BCBC0", VA = "0x12BCBC0", Slot = "4")]
		public IRequest Marshall(MergeShardsRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x12BD53C", Offset = "0x12BD53C", VA = "0x12BD53C")]
		internal static MergeShardsRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x12BD604", Offset = "0x12BD604", VA = "0x12BD604")]
		public MergeShardsRequestMarshaller()
		{
		}
	}
}
