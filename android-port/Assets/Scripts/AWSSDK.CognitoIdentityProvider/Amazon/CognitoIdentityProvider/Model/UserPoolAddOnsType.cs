using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000145")]
	public class UserPoolAddOnsType
	{
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x10")]
		private AdvancedSecurityModeType _advancedSecurityMode;

		[Token(Token = "0x170002A4")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x216C0", Offset = "0x216C0")]
		public AdvancedSecurityModeType AdvancedSecurityMode
		{
			[Token(Token = "0x6000B65")]
			[Address(RVA = "0x11736A4", Offset = "0x11736A4", VA = "0x11736A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B66")]
			[Address(RVA = "0x11736AC", Offset = "0x11736AC", VA = "0x11736AC")]
			set
			{
			}
		}

		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x11736B4", Offset = "0x11736B4", VA = "0x11736B4")]
		internal bool IsSetAdvancedSecurityMode()
		{
			return default;
		}

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x1173730", Offset = "0x1173730", VA = "0x1173730")]
		public UserPoolAddOnsType()
		{
		}
	}
}
