using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200005C")]
	public class AddTagsToStreamRequestMarshaller : IMarshaller<IRequest, AddTagsToStreamRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x0")]
		private static AddTagsToStreamRequestMarshaller _instance;

		[Token(Token = "0x170000A2")]
		public static AddTagsToStreamRequestMarshaller Instance
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x129AC6C", Offset = "0x129AC6C", VA = "0x129AC6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x129A090", Offset = "0x129A090", VA = "0x129A090", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x129A124", Offset = "0x129A124", VA = "0x129A124", Slot = "4")]
		public IRequest Marshall(AddTagsToStreamRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x129AC08", Offset = "0x129AC08", VA = "0x129AC08")]
		internal static AddTagsToStreamRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x129ACD0", Offset = "0x129ACD0", VA = "0x129ACD0")]
		public AddTagsToStreamRequestMarshaller()
		{
		}
	}
}
