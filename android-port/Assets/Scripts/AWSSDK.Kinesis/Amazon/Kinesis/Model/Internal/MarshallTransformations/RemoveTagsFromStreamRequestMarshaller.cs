using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200009A")]
	public class RemoveTagsFromStreamRequestMarshaller : IMarshaller<IRequest, RemoveTagsFromStreamRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x0")]
		private static RemoveTagsFromStreamRequestMarshaller _instance;

		[Token(Token = "0x170000DF")]
		public static RemoveTagsFromStreamRequestMarshaller Instance
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x12C51E0", Offset = "0x12C51E0", VA = "0x12C51E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x12C4654", Offset = "0x12C4654", VA = "0x12C4654", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x12C46E8", Offset = "0x12C46E8", VA = "0x12C46E8", Slot = "4")]
		public IRequest Marshall(RemoveTagsFromStreamRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x12C517C", Offset = "0x12C517C", VA = "0x12C517C")]
		internal static RemoveTagsFromStreamRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x12C5244", Offset = "0x12C5244", VA = "0x12C5244")]
		public RemoveTagsFromStreamRequestMarshaller()
		{
		}
	}
}
