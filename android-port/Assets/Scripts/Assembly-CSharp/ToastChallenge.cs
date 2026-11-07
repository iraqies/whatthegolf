using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000427")]
public class ToastChallenge : Challenge
{
	[Token(Token = "0x40016B9")]
	[FieldOffset(Offset = "0xA8")]
	private Toaster[] _toasters;

	[Token(Token = "0x40016BA")]
	[FieldOffset(Offset = "0xB0")]
	private List<Toaster> _toastedToasters;

	[Token(Token = "0x6001381")]
	[Address(RVA = "0x17187A4", Offset = "0x17187A4", VA = "0x17187A4", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x6001382")]
	[Address(RVA = "0x1718964", Offset = "0x1718964", VA = "0x1718964")]
	private void OnToast(Toaster obj)
	{
	}

	[Token(Token = "0x6001383")]
	[Address(RVA = "0x1718A8C", Offset = "0x1718A8C", VA = "0x1718A8C")]
	public ToastChallenge()
	{
	}
}
