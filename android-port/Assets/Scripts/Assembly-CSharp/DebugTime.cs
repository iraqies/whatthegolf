using Il2CppDummyDll;

[Token(Token = "0x2000560")]
public class DebugTime : WTGSingleton<DebugTime>
{
	[Token(Token = "0x4001BB0")]
	[FieldOffset(Offset = "0x18")]
	public int addDebugDays;

	[Token(Token = "0x4001BB1")]
	[FieldOffset(Offset = "0x1C")]
	public int setDebugWeek;

	[Token(Token = "0x170002AF")]
	public static int SetDebugWeek
	{
		[Token(Token = "0x600188D")]
		[Address(RVA = "0x18D5598", Offset = "0x18D5598", VA = "0x18D5598")]
		get
		{
			return default;
		}
		[Token(Token = "0x600188E")]
		[Address(RVA = "0x18D55EC", Offset = "0x18D55EC", VA = "0x18D55EC")]
		set
		{
		}
	}

	[Token(Token = "0x170002B0")]
	public static int AddDebugDays
	{
		[Token(Token = "0x600188F")]
		[Address(RVA = "0x18D5360", Offset = "0x18D5360", VA = "0x18D5360")]
		get
		{
			return default;
		}
		[Token(Token = "0x6001890")]
		[Address(RVA = "0x18D53B4", Offset = "0x18D53B4", VA = "0x18D53B4")]
		set
		{
		}
	}

	[Token(Token = "0x6001891")]
	[Address(RVA = "0x18D7304", Offset = "0x18D7304", VA = "0x18D7304")]
	public DebugTime()
	{
	}
}
