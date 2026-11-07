using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000047")]
	public class PutRecordsResultEntry
	{
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x10")]
		private string _errorCode;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x18")]
		private string _errorMessage;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x20")]
		private string _sequenceNumber;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x28")]
		private string _shardId;

		[Token(Token = "0x17000068")]
		public string ErrorCode
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x12C2424", Offset = "0x12C2424", VA = "0x12C2424")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x12C242C", Offset = "0x12C242C", VA = "0x12C242C")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public string ErrorMessage
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x12C2444", Offset = "0x12C2444", VA = "0x12C2444")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x12C244C", Offset = "0x12C244C", VA = "0x12C244C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public string SequenceNumber
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x12C2464", Offset = "0x12C2464", VA = "0x12C2464")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x12C246C", Offset = "0x12C246C", VA = "0x12C246C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2FC0C", Offset = "0x2FC0C")]
		public string ShardId
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x12C2484", Offset = "0x12C2484", VA = "0x12C2484")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x12C248C", Offset = "0x12C248C", VA = "0x12C248C")]
			set
			{
			}
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x12C2434", Offset = "0x12C2434", VA = "0x12C2434")]
		internal bool IsSetErrorCode()
		{
			return default;
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x12C2454", Offset = "0x12C2454", VA = "0x12C2454")]
		internal bool IsSetErrorMessage()
		{
			return default;
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x12C2474", Offset = "0x12C2474", VA = "0x12C2474")]
		internal bool IsSetSequenceNumber()
		{
			return default;
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x12C2494", Offset = "0x12C2494", VA = "0x12C2494")]
		internal bool IsSetShardId()
		{
			return default;
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x12C24A4", Offset = "0x12C24A4", VA = "0x12C24A4")]
		public PutRecordsResultEntry()
		{
		}
	}
}
