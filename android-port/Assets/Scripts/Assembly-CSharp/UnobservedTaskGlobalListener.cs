using System.Threading.Tasks;
using Il2CppDummyDll;

[Token(Token = "0x2000592")]
public static class UnobservedTaskGlobalListener
{
	[Token(Token = "0x6001964")]
	[Address(RVA = "0x173CE64", Offset = "0x173CE64", VA = "0x173CE64")]
	[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x63450", Offset = "0x63450")]
	public static void Init()
	{
	}

	[Token(Token = "0x6001965")]
	[Address(RVA = "0x173CE68", Offset = "0x173CE68", VA = "0x173CE68")]
	public static void RegisterGlobalUnobservedTaskExceptionHandler()
	{
	}

	[Token(Token = "0x6001966")]
	[Address(RVA = "0x173CFA4", Offset = "0x173CFA4", VA = "0x173CFA4")]
	private static void HandleTaskSchedulerOnUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs eventArgs)
	{
	}
}
