using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200004F")]
	public class SequenceNumberRange
	{
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x10")]
		private string _endingSequenceNumber;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x18")]
		private string _startingSequenceNumber;

		[Token(Token = "0x17000076")]
		public string EndingSequenceNumber
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x12C61A0", Offset = "0x12C61A0", VA = "0x12C61A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x12C61A8", Offset = "0x12C61A8", VA = "0x12C61A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2FE9C", Offset = "0x2FE9C")]
		public string StartingSequenceNumber
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x12C61C0", Offset = "0x12C61C0", VA = "0x12C61C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x12C61C8", Offset = "0x12C61C8", VA = "0x12C61C8")]
			set
			{
			}
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x12C61B0", Offset = "0x12C61B0", VA = "0x12C61B0")]
		internal bool IsSetEndingSequenceNumber()
		{
			return default;
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x12C61D0", Offset = "0x12C61D0", VA = "0x12C61D0")]
		internal bool IsSetStartingSequenceNumber()
		{
			return default;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x12C61E0", Offset = "0x12C61E0", VA = "0x12C61E0")]
		public SequenceNumberRange()
		{
		}
	}
}
