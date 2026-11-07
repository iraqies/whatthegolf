using System;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200002A")]
	public class GetShardIteratorRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x30")]
		private string _shardId;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x38")]
		private ShardIteratorType _shardIteratorType;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x40")]
		private string _startingSequenceNumber;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x48")]
		private string _streamName;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x50")]
		private DateTime? _timestamp;

		[Token(Token = "0x17000035")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2F0CC", Offset = "0x2F0CC")]
		public string ShardId
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x12B2A5C", Offset = "0x12B2A5C", VA = "0x12B2A5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x12B2A64", Offset = "0x12B2A64", VA = "0x12B2A64")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2F11C", Offset = "0x2F11C")]
		public ShardIteratorType ShardIteratorType
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x12B2A7C", Offset = "0x12B2A7C", VA = "0x12B2A7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x12B2A84", Offset = "0x12B2A84", VA = "0x12B2A84")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public string StartingSequenceNumber
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x12B2B08", Offset = "0x12B2B08", VA = "0x12B2B08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x12B2B10", Offset = "0x12B2B10", VA = "0x12B2B10")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2F150", Offset = "0x2F150")]
		public string StreamName
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x12B2B28", Offset = "0x12B2B28", VA = "0x12B2B28")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x12B2B30", Offset = "0x12B2B30", VA = "0x12B2B30")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public DateTime Timestamp
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x12B2B48", Offset = "0x12B2B48", VA = "0x12B2B48")]
			get
			{
				return default;
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x12B2B88", Offset = "0x12B2B88", VA = "0x12B2B88")]
			set
			{
			}
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x12B2A6C", Offset = "0x12B2A6C", VA = "0x12B2A6C")]
		internal bool IsSetShardId()
		{
			return default;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x12B2A8C", Offset = "0x12B2A8C", VA = "0x12B2A8C")]
		internal bool IsSetShardIteratorType()
		{
			return default;
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x12B2B18", Offset = "0x12B2B18", VA = "0x12B2B18")]
		internal bool IsSetStartingSequenceNumber()
		{
			return default;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x12B2B38", Offset = "0x12B2B38", VA = "0x12B2B38")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x12B2BFC", Offset = "0x12B2BFC", VA = "0x12B2BFC")]
		internal bool IsSetTimestamp()
		{
			return default;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x12B2C3C", Offset = "0x12B2C3C", VA = "0x12B2C3C")]
		public GetShardIteratorRequest()
		{
		}
	}
}
