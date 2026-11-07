using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200005A")]
	public class UpdateShardCountRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x30")]
		private ScalingType _scalingType;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x38")]
		private string _streamName;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x40")]
		private int? _targetShardCount;

		[Token(Token = "0x1700009C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x307E0", Offset = "0x307E0")]
		public ScalingType ScalingType
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x12CDA94", Offset = "0x12CDA94", VA = "0x12CDA94")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x12CDA9C", Offset = "0x12CDA9C", VA = "0x12CDA9C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30814", Offset = "0x30814")]
		public string StreamName
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x12CDB20", Offset = "0x12CDB20", VA = "0x12CDB20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x12CDB28", Offset = "0x12CDB28", VA = "0x12CDB28")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30864", Offset = "0x30864")]
		public int TargetShardCount
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x12CDB40", Offset = "0x12CDB40", VA = "0x12CDB40")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x12CDB80", Offset = "0x12CDB80", VA = "0x12CDB80")]
			set
			{
			}
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x12CDAA4", Offset = "0x12CDAA4", VA = "0x12CDAA4")]
		internal bool IsSetScalingType()
		{
			return default;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x12CDB30", Offset = "0x12CDB30", VA = "0x12CDB30")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x12CDBF4", Offset = "0x12CDBF4", VA = "0x12CDBF4")]
		internal bool IsSetTargetShardCount()
		{
			return default;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x12CDC34", Offset = "0x12CDC34", VA = "0x12CDC34")]
		public UpdateShardCountRequest()
		{
		}
	}
}
