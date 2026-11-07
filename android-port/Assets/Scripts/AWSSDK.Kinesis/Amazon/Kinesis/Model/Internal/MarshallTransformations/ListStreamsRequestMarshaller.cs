using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200008A")]
	public class ListStreamsRequestMarshaller : IMarshaller<IRequest, ListStreamsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x0")]
		private static ListStreamsRequestMarshaller _instance;

		[Token(Token = "0x170000D0")]
		public static ListStreamsRequestMarshaller Instance
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x12BA6C8", Offset = "0x12BA6C8", VA = "0x12BA6C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x12B9C78", Offset = "0x12B9C78", VA = "0x12B9C78", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x12B9D0C", Offset = "0x12B9D0C", VA = "0x12B9D0C", Slot = "4")]
		public IRequest Marshall(ListStreamsRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x12BA664", Offset = "0x12BA664", VA = "0x12BA664")]
		internal static ListStreamsRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x12BA72C", Offset = "0x12BA72C", VA = "0x12BA72C")]
		public ListStreamsRequestMarshaller()
		{
		}
	}
}
