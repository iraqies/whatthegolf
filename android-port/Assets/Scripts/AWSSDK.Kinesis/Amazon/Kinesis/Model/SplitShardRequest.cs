using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000051")]
	public class SplitShardRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x30")]
		private string _newStartingHashKey;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x38")]
		private string _shardToSplit;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x40")]
		private string _streamName;

		[Token(Token = "0x1700007D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30018", Offset = "0x30018")]
		public string NewStartingHashKey
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x12C6FC4", Offset = "0x12C6FC4", VA = "0x12C6FC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x12C6FCC", Offset = "0x12C6FCC", VA = "0x12C6FCC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x3004C", Offset = "0x3004C")]
		public string ShardToSplit
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x12C6FE4", Offset = "0x12C6FE4", VA = "0x12C6FE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x12C6FEC", Offset = "0x12C6FEC", VA = "0x12C6FEC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x3009C", Offset = "0x3009C")]
		public string StreamName
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x12C7004", Offset = "0x12C7004", VA = "0x12C7004")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x12C700C", Offset = "0x12C700C", VA = "0x12C700C")]
			set
			{
			}
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x12C6FD4", Offset = "0x12C6FD4", VA = "0x12C6FD4")]
		internal bool IsSetNewStartingHashKey()
		{
			return default;
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x12C6FF4", Offset = "0x12C6FF4", VA = "0x12C6FF4")]
		internal bool IsSetShardToSplit()
		{
			return default;
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x12C7014", Offset = "0x12C7014", VA = "0x12C7014")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x12C7024", Offset = "0x12C7024", VA = "0x12C7024")]
		public SplitShardRequest()
		{
		}
	}
}
