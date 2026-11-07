using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000021")]
	public class DisableEnhancedMonitoringRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x30")]
		private List<string> _shardLevelMetrics;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x38")]
		private string _streamName;

		[Token(Token = "0x17000025")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2EC48", Offset = "0x2EC48")]
		public List<string> ShardLevelMetrics
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x12AC5DC", Offset = "0x12AC5DC", VA = "0x12AC5DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x12AC5E4", Offset = "0x12AC5E4", VA = "0x12AC5E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2EC98", Offset = "0x2EC98")]
		public string StreamName
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x12AC644", Offset = "0x12AC644", VA = "0x12AC644")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x12AC64C", Offset = "0x12AC64C", VA = "0x12AC64C")]
			set
			{
			}
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x12AC5EC", Offset = "0x12AC5EC", VA = "0x12AC5EC")]
		internal bool IsSetShardLevelMetrics()
		{
			return default;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x12AC654", Offset = "0x12AC654", VA = "0x12AC654")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x12AC664", Offset = "0x12AC664", VA = "0x12AC664")]
		public DisableEnhancedMonitoringRequest()
		{
		}
	}
}
