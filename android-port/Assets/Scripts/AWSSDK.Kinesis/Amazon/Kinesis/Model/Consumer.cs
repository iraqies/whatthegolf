using System;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200000F")]
	public class Consumer
	{
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x10")]
		private string _consumerARN;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x18")]
		private DateTime? _consumerCreationTimestamp;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x28")]
		private string _consumerName;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x30")]
		private ConsumerStatus _consumerStatus;

		[Token(Token = "0x17000007")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2E430", Offset = "0x2E430")]
		public string ConsumerARN
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x12A1B2C", Offset = "0x12A1B2C", VA = "0x12A1B2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x12A1B34", Offset = "0x12A1B34", VA = "0x12A1B34")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2E480", Offset = "0x2E480")]
		public DateTime ConsumerCreationTimestamp
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x12A1B4C", Offset = "0x12A1B4C", VA = "0x12A1B4C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x12A1B8C", Offset = "0x12A1B8C", VA = "0x12A1B8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2E4B4", Offset = "0x2E4B4")]
		public string ConsumerName
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x12A1C40", Offset = "0x12A1C40", VA = "0x12A1C40")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x12A1C48", Offset = "0x12A1C48", VA = "0x12A1C48")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2E504", Offset = "0x2E504")]
		public ConsumerStatus ConsumerStatus
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x12A1C60", Offset = "0x12A1C60", VA = "0x12A1C60")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x12A1C68", Offset = "0x12A1C68", VA = "0x12A1C68")]
			set
			{
			}
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x12A1B3C", Offset = "0x12A1B3C", VA = "0x12A1B3C")]
		internal bool IsSetConsumerARN()
		{
			return default;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x12A1C00", Offset = "0x12A1C00", VA = "0x12A1C00")]
		internal bool IsSetConsumerCreationTimestamp()
		{
			return default;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x12A1C50", Offset = "0x12A1C50", VA = "0x12A1C50")]
		internal bool IsSetConsumerName()
		{
			return default;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x12A1C70", Offset = "0x12A1C70", VA = "0x12A1C70")]
		internal bool IsSetConsumerStatus()
		{
			return default;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x12A1CEC", Offset = "0x12A1CEC", VA = "0x12A1CEC")]
		public Consumer()
		{
		}
	}
}
