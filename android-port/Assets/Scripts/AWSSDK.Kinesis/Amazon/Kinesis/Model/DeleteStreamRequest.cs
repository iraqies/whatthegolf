using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000015")]
	public class DeleteStreamRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x29")]
		private bool? _enforceConsumerDeletion;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x30")]
		private string _streamName;

		[Token(Token = "0x17000014")]
		public bool EnforceConsumerDeletion
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x12A5418", Offset = "0x12A5418", VA = "0x12A5418")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x12A5458", Offset = "0x12A5458", VA = "0x12A5458")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2E7D4", Offset = "0x2E7D4")]
		public string StreamName
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x12A550C", Offset = "0x12A550C", VA = "0x12A550C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x12A5514", Offset = "0x12A5514", VA = "0x12A5514")]
			set
			{
			}
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x12A54CC", Offset = "0x12A54CC", VA = "0x12A54CC")]
		internal bool IsSetEnforceConsumerDeletion()
		{
			return default;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x12A551C", Offset = "0x12A551C", VA = "0x12A551C")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x12A552C", Offset = "0x12A552C", VA = "0x12A552C")]
		public DeleteStreamRequest()
		{
		}
	}
}
