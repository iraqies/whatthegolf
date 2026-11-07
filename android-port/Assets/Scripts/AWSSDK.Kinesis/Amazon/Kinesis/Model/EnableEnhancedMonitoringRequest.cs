using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000023")]
	public class EnableEnhancedMonitoringRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x30")]
		private List<string> _shardLevelMetrics;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x38")]
		private string _streamName;

		[Token(Token = "0x1700002A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2EDC0", Offset = "0x2EDC0")]
		public List<string> ShardLevelMetrics
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x12ADF88", Offset = "0x12ADF88", VA = "0x12ADF88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x12ADF90", Offset = "0x12ADF90", VA = "0x12ADF90")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2EE10", Offset = "0x2EE10")]
		public string StreamName
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x12ADFF0", Offset = "0x12ADFF0", VA = "0x12ADFF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x12ADFF8", Offset = "0x12ADFF8", VA = "0x12ADFF8")]
			set
			{
			}
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x12ADF98", Offset = "0x12ADF98", VA = "0x12ADF98")]
		internal bool IsSetShardLevelMetrics()
		{
			return default;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x12AE000", Offset = "0x12AE000", VA = "0x12AE000")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x12AE010", Offset = "0x12AE010", VA = "0x12AE010")]
		public EnableEnhancedMonitoringRequest()
		{
		}
	}
}
