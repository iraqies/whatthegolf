using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000066")]
	public class DeregisterStreamConsumerRequestMarshaller : IMarshaller<IRequest, DeregisterStreamConsumerRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x0")]
		private static DeregisterStreamConsumerRequestMarshaller _instance;

		[Token(Token = "0x170000AC")]
		public static DeregisterStreamConsumerRequestMarshaller Instance
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x12A722C", Offset = "0x12A722C", VA = "0x12A722C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x12A67B8", Offset = "0x12A67B8", VA = "0x12A67B8", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x12A684C", Offset = "0x12A684C", VA = "0x12A684C", Slot = "4")]
		public IRequest Marshall(DeregisterStreamConsumerRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x12A71C8", Offset = "0x12A71C8", VA = "0x12A71C8")]
		internal static DeregisterStreamConsumerRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x12A7290", Offset = "0x12A7290", VA = "0x12A7290")]
		public DeregisterStreamConsumerRequestMarshaller()
		{
		}
	}
}
