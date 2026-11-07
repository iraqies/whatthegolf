using System;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000010")]
	public class ConsumerDescription
	{
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x10")]
		private string _consumerARN;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x18")]
		private DateTime? _consumerCreationTimestamp;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x28")]
		private string _consumerName;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x30")]
		private ConsumerStatus _consumerStatus;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x38")]
		private string _streamARN;

		[Token(Token = "0x1700000B")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2E538", Offset = "0x2E538")]
		public string ConsumerARN
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x12A1CF4", Offset = "0x12A1CF4", VA = "0x12A1CF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x12A1CFC", Offset = "0x12A1CFC", VA = "0x12A1CFC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2E588", Offset = "0x2E588")]
		public DateTime ConsumerCreationTimestamp
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x12A1D14", Offset = "0x12A1D14", VA = "0x12A1D14")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x12A1D54", Offset = "0x12A1D54", VA = "0x12A1D54")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2E5BC", Offset = "0x2E5BC")]
		public string ConsumerName
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x12A1E08", Offset = "0x12A1E08", VA = "0x12A1E08")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x12A1E10", Offset = "0x12A1E10", VA = "0x12A1E10")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2E60C", Offset = "0x2E60C")]
		public ConsumerStatus ConsumerStatus
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x12A1E28", Offset = "0x12A1E28", VA = "0x12A1E28")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x12A1E30", Offset = "0x12A1E30", VA = "0x12A1E30")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2E640", Offset = "0x2E640")]
		public string StreamARN
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x12A1EB4", Offset = "0x12A1EB4", VA = "0x12A1EB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x12A1EBC", Offset = "0x12A1EBC", VA = "0x12A1EBC")]
			set
			{
			}
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x12A1D04", Offset = "0x12A1D04", VA = "0x12A1D04")]
		internal bool IsSetConsumerARN()
		{
			return default;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x12A1DC8", Offset = "0x12A1DC8", VA = "0x12A1DC8")]
		internal bool IsSetConsumerCreationTimestamp()
		{
			return default;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x12A1E18", Offset = "0x12A1E18", VA = "0x12A1E18")]
		internal bool IsSetConsumerName()
		{
			return default;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x12A1E38", Offset = "0x12A1E38", VA = "0x12A1E38")]
		internal bool IsSetConsumerStatus()
		{
			return default;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x12A1EC4", Offset = "0x12A1EC4", VA = "0x12A1EC4")]
		internal bool IsSetStreamARN()
		{
			return default;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x12A1ED4", Offset = "0x12A1ED4", VA = "0x12A1ED4")]
		public ConsumerDescription()
		{
		}
	}
}
