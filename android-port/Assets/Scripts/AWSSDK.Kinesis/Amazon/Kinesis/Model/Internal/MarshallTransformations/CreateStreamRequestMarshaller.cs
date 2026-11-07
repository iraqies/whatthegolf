using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000060")]
	public class CreateStreamRequestMarshaller : IMarshaller<IRequest, CreateStreamRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x0")]
		private static CreateStreamRequestMarshaller _instance;

		[Token(Token = "0x170000A6")]
		public static CreateStreamRequestMarshaller Instance
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x12A38CC", Offset = "0x12A38CC", VA = "0x12A38CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x12A2E7C", Offset = "0x12A2E7C", VA = "0x12A2E7C", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x12A2F10", Offset = "0x12A2F10", VA = "0x12A2F10", Slot = "4")]
		public IRequest Marshall(CreateStreamRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x12A3868", Offset = "0x12A3868", VA = "0x12A3868")]
		internal static CreateStreamRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x12A3930", Offset = "0x12A3930", VA = "0x12A3930")]
		public CreateStreamRequestMarshaller()
		{
		}
	}
}
