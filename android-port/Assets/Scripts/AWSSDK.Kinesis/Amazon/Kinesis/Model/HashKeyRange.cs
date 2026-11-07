using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200002C")]
	public class HashKeyRange
	{
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x10")]
		private string _endingHashKey;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x18")]
		private string _startingHashKey;

		[Token(Token = "0x1700003B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F1E8", Offset = "0x2F1E8")]
		public string EndingHashKey
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x12B4190", Offset = "0x12B4190", VA = "0x12B4190")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x12B4198", Offset = "0x12B4198", VA = "0x12B4198")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F21C", Offset = "0x2F21C")]
		public string StartingHashKey
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x12B41B0", Offset = "0x12B41B0", VA = "0x12B41B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x12B41B8", Offset = "0x12B41B8", VA = "0x12B41B8")]
			set
			{
			}
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x12B41A0", Offset = "0x12B41A0", VA = "0x12B41A0")]
		internal bool IsSetEndingHashKey()
		{
			return default;
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x12B41C0", Offset = "0x12B41C0", VA = "0x12B41C0")]
		internal bool IsSetStartingHashKey()
		{
			return default;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x12B41D0", Offset = "0x12B41D0", VA = "0x12B41D0")]
		public HashKeyRange()
		{
		}
	}
}
