using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20000A4")]
	public class StopStreamEncryptionRequestMarshaller : IMarshaller<IRequest, StopStreamEncryptionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x0")]
		private static StopStreamEncryptionRequestMarshaller _instance;

		[Token(Token = "0x170000E9")]
		public static StopStreamEncryptionRequestMarshaller Instance
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x12CA850", Offset = "0x12CA850", VA = "0x12CA850")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x12C9D44", Offset = "0x12C9D44", VA = "0x12C9D44", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x12C9DD8", Offset = "0x12C9DD8", VA = "0x12C9DD8", Slot = "4")]
		public IRequest Marshall(StopStreamEncryptionRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x12CA7EC", Offset = "0x12CA7EC", VA = "0x12CA7EC")]
		internal static StopStreamEncryptionRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x12CA8B4", Offset = "0x12CA8B4", VA = "0x12CA8B4")]
		public StopStreamEncryptionRequestMarshaller()
		{
		}
	}
}
