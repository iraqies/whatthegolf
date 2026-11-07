using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy
{
	[Token(Token = "0x200025A")]
	public class Condition
	{
		[Token(Token = "0x400087C")]
		[FieldOffset(Offset = "0x10")]
		private string type;

		[Token(Token = "0x400087D")]
		[FieldOffset(Offset = "0x18")]
		private string conditionKey;

		[Token(Token = "0x400087E")]
		[FieldOffset(Offset = "0x20")]
		private string[] values;

		[Token(Token = "0x17000463")]
		public string Type
		{
			[Token(Token = "0x60011BE")]
			[Address(RVA = "0x11E3930", Offset = "0x11E3930", VA = "0x11E3930")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011BF")]
			[Address(RVA = "0x11E3938", Offset = "0x11E3938", VA = "0x11E3938")]
			set
			{
			}
		}

		[Token(Token = "0x17000464")]
		public string ConditionKey
		{
			[Token(Token = "0x60011C0")]
			[Address(RVA = "0x11E3940", Offset = "0x11E3940", VA = "0x11E3940")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011C1")]
			[Address(RVA = "0x11E3948", Offset = "0x11E3948", VA = "0x11E3948")]
			set
			{
			}
		}

		[Token(Token = "0x17000465")]
		public string[] Values
		{
			[Token(Token = "0x60011C2")]
			[Address(RVA = "0x11E3950", Offset = "0x11E3950", VA = "0x11E3950")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011C3")]
			[Address(RVA = "0x11E3958", Offset = "0x11E3958", VA = "0x11E3958")]
			set
			{
			}
		}

		[Token(Token = "0x60011BC")]
		[Address(RVA = "0x11E38E8", Offset = "0x11E38E8", VA = "0x11E38E8")]
		public Condition()
		{
		}

		[Token(Token = "0x60011BD")]
		[Address(RVA = "0x11E38F0", Offset = "0x11E38F0", VA = "0x11E38F0")]
		public Condition(string type, string conditionKey, params string[] values)
		{
		}
	}
}
