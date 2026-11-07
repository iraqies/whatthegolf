using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000CD")]
	public class HttpHeader
	{
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x10")]
		private string _headerName;

		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x18")]
		private string _headerValue;

		[Token(Token = "0x1700017C")]
		public string HeaderName
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x1127AB4", Offset = "0x1127AB4", VA = "0x1127AB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x1127ABC", Offset = "0x1127ABC", VA = "0x1127ABC")]
			set
			{
			}
		}

		[Token(Token = "0x1700017D")]
		public string HeaderValue
		{
			[Token(Token = "0x6000702")]
			[Address(RVA = "0x1127AD4", Offset = "0x1127AD4", VA = "0x1127AD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000703")]
			[Address(RVA = "0x1127ADC", Offset = "0x1127ADC", VA = "0x1127ADC")]
			set
			{
			}
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x1127AC4", Offset = "0x1127AC4", VA = "0x1127AC4")]
		internal bool IsSetHeaderName()
		{
			return default;
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x1127AE4", Offset = "0x1127AE4", VA = "0x1127AE4")]
		internal bool IsSetHeaderValue()
		{
			return default;
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x1127AF4", Offset = "0x1127AF4", VA = "0x1127AF4")]
		public HttpHeader()
		{
		}
	}
}
