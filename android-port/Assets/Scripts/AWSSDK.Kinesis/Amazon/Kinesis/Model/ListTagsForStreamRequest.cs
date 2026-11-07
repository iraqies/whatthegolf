using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200003D")]
	public class ListTagsForStreamRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x30")]
		private string _exclusiveStartTagKey;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x38")]
		private int? _limit;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x40")]
		private string _streamName;

		[Token(Token = "0x17000050")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F678", Offset = "0x2F678")]
		public string ExclusiveStartTagKey
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x12BB200", Offset = "0x12BB200", VA = "0x12BB200")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x12BB208", Offset = "0x12BB208", VA = "0x12BB208")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F6C0", Offset = "0x2F6C0")]
		public int Limit
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x12BB220", Offset = "0x12BB220", VA = "0x12BB220")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x12BB260", Offset = "0x12BB260", VA = "0x12BB260")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F708", Offset = "0x2F708")]
		public string StreamName
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x12BB314", Offset = "0x12BB314", VA = "0x12BB314")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x12BB31C", Offset = "0x12BB31C", VA = "0x12BB31C")]
			set
			{
			}
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x12BB210", Offset = "0x12BB210", VA = "0x12BB210")]
		internal bool IsSetExclusiveStartTagKey()
		{
			return default;
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x12BB2D4", Offset = "0x12BB2D4", VA = "0x12BB2D4")]
		internal bool IsSetLimit()
		{
			return default;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x12BB324", Offset = "0x12BB324", VA = "0x12BB324")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x12BB334", Offset = "0x12BB334", VA = "0x12BB334")]
		public ListTagsForStreamRequest()
		{
		}
	}
}
