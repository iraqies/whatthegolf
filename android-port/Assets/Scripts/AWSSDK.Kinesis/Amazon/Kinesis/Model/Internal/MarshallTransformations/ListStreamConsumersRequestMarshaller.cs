using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000088")]
	public class ListStreamConsumersRequestMarshaller : IMarshaller<IRequest, ListStreamConsumersRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x0")]
		private static ListStreamConsumersRequestMarshaller _instance;

		[Token(Token = "0x170000CE")]
		public static ListStreamConsumersRequestMarshaller Instance
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x12B8E64", Offset = "0x12B8E64", VA = "0x12B8E64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x12B82F0", Offset = "0x12B82F0", VA = "0x12B82F0", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x12B8384", Offset = "0x12B8384", VA = "0x12B8384", Slot = "4")]
		public IRequest Marshall(ListStreamConsumersRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x12B8E00", Offset = "0x12B8E00", VA = "0x12B8E00")]
		internal static ListStreamConsumersRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x12B8EC8", Offset = "0x12B8EC8", VA = "0x12B8EC8")]
		public ListStreamConsumersRequestMarshaller()
		{
		}
	}
}
