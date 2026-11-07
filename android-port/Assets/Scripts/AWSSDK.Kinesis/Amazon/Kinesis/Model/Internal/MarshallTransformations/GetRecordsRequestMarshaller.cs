using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000077")]
	public class GetRecordsRequestMarshaller : IMarshaller<IRequest, GetRecordsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x0")]
		private static GetRecordsRequestMarshaller _instance;

		[Token(Token = "0x170000BD")]
		public static GetRecordsRequestMarshaller Instance
		{
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x12B110C", Offset = "0x12B110C", VA = "0x12B110C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x12B06BC", Offset = "0x12B06BC", VA = "0x12B06BC", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x12B0750", Offset = "0x12B0750", VA = "0x12B0750", Slot = "4")]
		public IRequest Marshall(GetRecordsRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x12B10A8", Offset = "0x12B10A8", VA = "0x12B10A8")]
		internal static GetRecordsRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x12B1170", Offset = "0x12B1170", VA = "0x12B1170")]
		public GetRecordsRequestMarshaller()
		{
		}
	}
}
