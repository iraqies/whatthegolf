using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200002A")]
	public class AccountTakeoverActionType
	{
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x10")]
		private AccountTakeoverEventActionType _eventAction;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x18")]
		private bool? _notify;

		[Token(Token = "0x17000009")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1AC44", Offset = "0x1AC44")]
		public AccountTakeoverEventActionType EventAction
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x1097D6C", Offset = "0x1097D6C", VA = "0x1097D6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x1097D74", Offset = "0x1097D74", VA = "0x1097D74")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1AC78", Offset = "0x1AC78")]
		public bool Notify
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x1097DF8", Offset = "0x1097DF8", VA = "0x1097DF8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x1097E38", Offset = "0x1097E38", VA = "0x1097E38")]
			set
			{
			}
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1097D7C", Offset = "0x1097D7C", VA = "0x1097D7C")]
		internal bool IsSetEventAction()
		{
			return default;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1097EAC", Offset = "0x1097EAC", VA = "0x1097EAC")]
		internal bool IsSetNotify()
		{
			return default;
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1097EEC", Offset = "0x1097EEC", VA = "0x1097EEC")]
		public AccountTakeoverActionType()
		{
		}
	}
}
