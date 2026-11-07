using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000017")]
	public class DeregisterStreamConsumerRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x30")]
		private string _consumerARN;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x38")]
		private string _consumerName;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x40")]
		private string _streamARN;

		[Token(Token = "0x17000016")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2E824", Offset = "0x2E824")]
		public string ConsumerARN
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x12A6750", Offset = "0x12A6750", VA = "0x12A6750")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x12A6758", Offset = "0x12A6758", VA = "0x12A6758")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2E86C", Offset = "0x2E86C")]
		public string ConsumerName
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x12A6770", Offset = "0x12A6770", VA = "0x12A6770")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x12A6778", Offset = "0x12A6778", VA = "0x12A6778")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2E8B4", Offset = "0x2E8B4")]
		public string StreamARN
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x12A6790", Offset = "0x12A6790", VA = "0x12A6790")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x12A6798", Offset = "0x12A6798", VA = "0x12A6798")]
			set
			{
			}
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x12A6760", Offset = "0x12A6760", VA = "0x12A6760")]
		internal bool IsSetConsumerARN()
		{
			return default;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x12A6780", Offset = "0x12A6780", VA = "0x12A6780")]
		internal bool IsSetConsumerName()
		{
			return default;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x12A67A0", Offset = "0x12A67A0", VA = "0x12A67A0")]
		internal bool IsSetStreamARN()
		{
			return default;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x12A67B0", Offset = "0x12A67B0", VA = "0x12A67B0")]
		public DeregisterStreamConsumerRequest()
		{
		}
	}
}
