using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000062")]
	public class DecreaseStreamRetentionPeriodRequestMarshaller : IMarshaller<IRequest, DecreaseStreamRetentionPeriodRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x0")]
		private static DecreaseStreamRetentionPeriodRequestMarshaller _instance;

		[Token(Token = "0x170000A8")]
		public static DecreaseStreamRetentionPeriodRequestMarshaller Instance
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x12A4B84", Offset = "0x12A4B84", VA = "0x12A4B84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x12A4134", Offset = "0x12A4134", VA = "0x12A4134", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x12A41C8", Offset = "0x12A41C8", VA = "0x12A41C8", Slot = "4")]
		public IRequest Marshall(DecreaseStreamRetentionPeriodRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x12A4B20", Offset = "0x12A4B20", VA = "0x12A4B20")]
		internal static DecreaseStreamRetentionPeriodRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x12A4BE8", Offset = "0x12A4BE8", VA = "0x12A4BE8")]
		public DecreaseStreamRetentionPeriodRequestMarshaller()
		{
		}
	}
}
