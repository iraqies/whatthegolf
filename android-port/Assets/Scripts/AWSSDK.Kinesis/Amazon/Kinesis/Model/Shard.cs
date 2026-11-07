using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000050")]
	public class Shard
	{
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x10")]
		private string _adjacentParentShardId;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x18")]
		private HashKeyRange _hashKeyRange;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x20")]
		private string _parentShardId;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x28")]
		private SequenceNumberRange _sequenceNumberRange;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x30")]
		private string _shardId;

		[Token(Token = "0x17000078")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2FED0", Offset = "0x2FED0")]
		public string AdjacentParentShardId
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x12C653C", Offset = "0x12C653C", VA = "0x12C653C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x12C6544", Offset = "0x12C6544", VA = "0x12C6544")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2FF18", Offset = "0x2FF18")]
		public HashKeyRange HashKeyRange
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x12C655C", Offset = "0x12C655C", VA = "0x12C655C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x12C6564", Offset = "0x12C6564", VA = "0x12C6564")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2FF4C", Offset = "0x2FF4C")]
		public string ParentShardId
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x12C657C", Offset = "0x12C657C", VA = "0x12C657C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x12C6584", Offset = "0x12C6584", VA = "0x12C6584")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2FF94", Offset = "0x2FF94")]
		public SequenceNumberRange SequenceNumberRange
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x12C659C", Offset = "0x12C659C", VA = "0x12C659C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x12C65A4", Offset = "0x12C65A4", VA = "0x12C65A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2FFC8", Offset = "0x2FFC8")]
		public string ShardId
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x12C65BC", Offset = "0x12C65BC", VA = "0x12C65BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x12C65C4", Offset = "0x12C65C4", VA = "0x12C65C4")]
			set
			{
			}
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x12C654C", Offset = "0x12C654C", VA = "0x12C654C")]
		internal bool IsSetAdjacentParentShardId()
		{
			return default;
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x12C656C", Offset = "0x12C656C", VA = "0x12C656C")]
		internal bool IsSetHashKeyRange()
		{
			return default;
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x12C658C", Offset = "0x12C658C", VA = "0x12C658C")]
		internal bool IsSetParentShardId()
		{
			return default;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x12C65AC", Offset = "0x12C65AC", VA = "0x12C65AC")]
		internal bool IsSetSequenceNumberRange()
		{
			return default;
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x12C65CC", Offset = "0x12C65CC", VA = "0x12C65CC")]
		internal bool IsSetShardId()
		{
			return default;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x12C65DC", Offset = "0x12C65DC", VA = "0x12C65DC")]
		public Shard()
		{
		}
	}
}
