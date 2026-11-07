using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000029")]
	public class AccountTakeoverActionsType
	{
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x10")]
		private AccountTakeoverActionType _highAction;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x18")]
		private AccountTakeoverActionType _lowAction;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x20")]
		private AccountTakeoverActionType _mediumAction;

		[Token(Token = "0x17000006")]
		public AccountTakeoverActionType HighAction
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x10985D0", Offset = "0x10985D0", VA = "0x10985D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x10985D8", Offset = "0x10985D8", VA = "0x10985D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public AccountTakeoverActionType LowAction
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x10985F0", Offset = "0x10985F0", VA = "0x10985F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x10985F8", Offset = "0x10985F8", VA = "0x10985F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public AccountTakeoverActionType MediumAction
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x1098610", Offset = "0x1098610", VA = "0x1098610")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x1098618", Offset = "0x1098618", VA = "0x1098618")]
			set
			{
			}
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x10985E0", Offset = "0x10985E0", VA = "0x10985E0")]
		internal bool IsSetHighAction()
		{
			return default;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1098600", Offset = "0x1098600", VA = "0x1098600")]
		internal bool IsSetLowAction()
		{
			return default;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1098620", Offset = "0x1098620", VA = "0x1098620")]
		internal bool IsSetMediumAction()
		{
			return default;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1098630", Offset = "0x1098630", VA = "0x1098630")]
		public AccountTakeoverActionsType()
		{
		}
	}
}
