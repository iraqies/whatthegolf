using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x2000020")]
	public class FederatedUser
	{
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x10")]
		private string _arn;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x18")]
		private string _federatedUserId;

		[Token(Token = "0x1700003D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x3141C", Offset = "0x3141C")]
		public string Arn
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x12DE674", Offset = "0x12DE674", VA = "0x12DE674")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x12DE67C", Offset = "0x12DE67C", VA = "0x12DE67C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x3146C", Offset = "0x3146C")]
		public string FederatedUserId
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x12DE694", Offset = "0x12DE694", VA = "0x12DE694")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x12DE69C", Offset = "0x12DE69C", VA = "0x12DE69C")]
			set
			{
			}
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x12DE634", Offset = "0x12DE634", VA = "0x12DE634")]
		public FederatedUser()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x12DE63C", Offset = "0x12DE63C", VA = "0x12DE63C")]
		public FederatedUser(string federatedUserId, string arn)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x12DE684", Offset = "0x12DE684", VA = "0x12DE684")]
		internal bool IsSetArn()
		{
			return default;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x12DE6A4", Offset = "0x12DE6A4", VA = "0x12DE6A4")]
		internal bool IsSetFederatedUserId()
		{
			return default;
		}
	}
}
