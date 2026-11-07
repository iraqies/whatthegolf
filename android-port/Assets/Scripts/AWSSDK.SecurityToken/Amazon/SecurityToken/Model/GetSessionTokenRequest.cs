using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x2000027")]
	public class GetSessionTokenRequest : AmazonSecurityTokenServiceRequest
	{
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x2C")]
		private int? _durationSeconds;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x38")]
		private string _serialNumber;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x40")]
		private string _tokenCode;

		[Token(Token = "0x1700004C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x316A8", Offset = "0x316A8")]
		public int DurationSeconds
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x12E273C", Offset = "0x12E273C", VA = "0x12E273C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x12E277C", Offset = "0x12E277C", VA = "0x12E277C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x316F4", Offset = "0x316F4")]
		public string SerialNumber
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x12E2830", Offset = "0x12E2830", VA = "0x12E2830")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x12E2838", Offset = "0x12E2838", VA = "0x12E2838")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x3173C", Offset = "0x3173C")]
		public string TokenCode
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x12E2850", Offset = "0x12E2850", VA = "0x12E2850")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x12E2858", Offset = "0x12E2858", VA = "0x12E2858")]
			set
			{
			}
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x12D4358", Offset = "0x12D4358", VA = "0x12D4358")]
		public GetSessionTokenRequest()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x12E27F0", Offset = "0x12E27F0", VA = "0x12E27F0")]
		internal bool IsSetDurationSeconds()
		{
			return default;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x12E2840", Offset = "0x12E2840", VA = "0x12E2840")]
		internal bool IsSetSerialNumber()
		{
			return default;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x12E2860", Offset = "0x12E2860", VA = "0x12E2860")]
		internal bool IsSetTokenCode()
		{
			return default;
		}
	}
}
