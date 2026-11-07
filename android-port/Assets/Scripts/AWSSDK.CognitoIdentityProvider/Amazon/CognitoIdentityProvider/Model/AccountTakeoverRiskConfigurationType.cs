using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200002B")]
	public class AccountTakeoverRiskConfigurationType
	{
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x10")]
		private AccountTakeoverActionsType _actions;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x18")]
		private NotifyConfigurationType _notifyConfiguration;

		[Token(Token = "0x1700000B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1ACAC", Offset = "0x1ACAC")]
		public AccountTakeoverActionsType Actions
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x1098FCC", Offset = "0x1098FCC", VA = "0x1098FCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x1098FD4", Offset = "0x1098FD4", VA = "0x1098FD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public NotifyConfigurationType NotifyConfiguration
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x1098FEC", Offset = "0x1098FEC", VA = "0x1098FEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x1098FF4", Offset = "0x1098FF4", VA = "0x1098FF4")]
			set
			{
			}
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1098FDC", Offset = "0x1098FDC", VA = "0x1098FDC")]
		internal bool IsSetActions()
		{
			return default;
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1098FFC", Offset = "0x1098FFC", VA = "0x1098FFC")]
		internal bool IsSetNotifyConfiguration()
		{
			return default;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x109900C", Offset = "0x109900C", VA = "0x109900C")]
		public AccountTakeoverRiskConfigurationType()
		{
		}
	}
}
