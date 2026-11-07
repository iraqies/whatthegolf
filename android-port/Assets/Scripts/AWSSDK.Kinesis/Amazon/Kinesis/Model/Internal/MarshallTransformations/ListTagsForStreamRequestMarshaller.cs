using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200008C")]
	public class ListTagsForStreamRequestMarshaller : IMarshaller<IRequest, ListTagsForStreamRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x0")]
		private static ListTagsForStreamRequestMarshaller _instance;

		[Token(Token = "0x170000D2")]
		public static ListTagsForStreamRequestMarshaller Instance
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x12BBDF8", Offset = "0x12BBDF8", VA = "0x12BBDF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x12BB33C", Offset = "0x12BB33C", VA = "0x12BB33C", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x12BB3D0", Offset = "0x12BB3D0", VA = "0x12BB3D0", Slot = "4")]
		public IRequest Marshall(ListTagsForStreamRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x12BBD94", Offset = "0x12BBD94", VA = "0x12BBD94")]
		internal static ListTagsForStreamRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x12BBE5C", Offset = "0x12BBE5C", VA = "0x12BBE5C")]
		public ListTagsForStreamRequestMarshaller()
		{
		}
	}
}
