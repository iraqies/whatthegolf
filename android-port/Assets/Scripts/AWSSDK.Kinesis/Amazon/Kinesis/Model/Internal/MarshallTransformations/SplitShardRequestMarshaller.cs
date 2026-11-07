using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20000A0")]
	public class SplitShardRequestMarshaller : IMarshaller<IRequest, SplitShardRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x0")]
		private static SplitShardRequestMarshaller _instance;

		[Token(Token = "0x170000E5")]
		public static SplitShardRequestMarshaller Instance
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x12C7AA0", Offset = "0x12C7AA0", VA = "0x12C7AA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x12C702C", Offset = "0x12C702C", VA = "0x12C702C", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x12C70C0", Offset = "0x12C70C0", VA = "0x12C70C0", Slot = "4")]
		public IRequest Marshall(SplitShardRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x12C7A3C", Offset = "0x12C7A3C", VA = "0x12C7A3C")]
		internal static SplitShardRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x12C7B04", Offset = "0x12C7B04", VA = "0x12C7B04")]
		public SplitShardRequestMarshaller()
		{
		}
	}
}
