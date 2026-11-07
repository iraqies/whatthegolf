using Il2CppDummyDll;

namespace MonitorComponents
{
	[Token(Token = "0x2000265")]
	public class MonitorEvent
	{
		[Token(Token = "0x4000FAD")]
		[FieldOffset(Offset = "0x10")]
		public float time;

		[Token(Token = "0x4000FAE")]
		[FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0x13AE664", Offset = "0x13AE664", VA = "0x13AE664")]
		public MonitorEvent()
		{
		}
	}
}
