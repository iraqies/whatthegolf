using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200002D")]
	public class IncreaseStreamRetentionPeriodRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x2C")]
		private int? _retentionPeriodHours;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x38")]
		private string _streamName;

		[Token(Token = "0x1700003D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F250", Offset = "0x2F250")]
		public int RetentionPeriodHours
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x12B452C", Offset = "0x12B452C", VA = "0x12B452C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x129EB70", Offset = "0x129EB70", VA = "0x129EB70")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F2A0", Offset = "0x2F2A0")]
		public string StreamName
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x12B45AC", Offset = "0x12B45AC", VA = "0x12B45AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x12B45B4", Offset = "0x12B45B4", VA = "0x12B45B4")]
			set
			{
			}
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x12B456C", Offset = "0x12B456C", VA = "0x12B456C")]
		internal bool IsSetRetentionPeriodHours()
		{
			return default;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x12B45BC", Offset = "0x12B45BC", VA = "0x12B45BC")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x129EB68", Offset = "0x129EB68", VA = "0x129EB68")]
		public IncreaseStreamRetentionPeriodRequest()
		{
		}
	}
}
