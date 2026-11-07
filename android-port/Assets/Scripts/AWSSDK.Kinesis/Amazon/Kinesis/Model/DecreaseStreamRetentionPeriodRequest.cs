using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000013")]
	public class DecreaseStreamRetentionPeriodRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x2C")]
		private int? _retentionPeriodHours;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x38")]
		private string _streamName;

		[Token(Token = "0x17000012")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2E734", Offset = "0x2E734")]
		public int RetentionPeriodHours
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x12A4094", Offset = "0x12A4094", VA = "0x12A4094")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x129C6A4", Offset = "0x129C6A4", VA = "0x129C6A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2E784", Offset = "0x2E784")]
		public string StreamName
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x12A4114", Offset = "0x12A4114", VA = "0x12A4114")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x12A411C", Offset = "0x12A411C", VA = "0x12A411C")]
			set
			{
			}
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x12A40D4", Offset = "0x12A40D4", VA = "0x12A40D4")]
		internal bool IsSetRetentionPeriodHours()
		{
			return default;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x12A4124", Offset = "0x12A4124", VA = "0x12A4124")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x129C69C", Offset = "0x129C69C", VA = "0x129C69C")]
		public DecreaseStreamRetentionPeriodRequest()
		{
		}
	}
}
