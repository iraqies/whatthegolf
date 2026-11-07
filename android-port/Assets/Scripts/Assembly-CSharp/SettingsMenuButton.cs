using Il2CppDummyDll;
using UnityEngine.Events;

[Token(Token = "0x200091F")]
public class SettingsMenuButton : SettingsMenuCommon
{
	[Token(Token = "0x40031D6")]
	[FieldOffset(Offset = "0x40")]
	public ScrollableButton button;

	[Token(Token = "0x6002A44")]
	[Address(RVA = "0x16975BC", Offset = "0x16975BC", VA = "0x16975BC")]
	public void Init(UnityAction onChange, bool active, SettingsMenu settings)
	{
	}

	[Token(Token = "0x6002A45")]
	[Address(RVA = "0x169B5CC", Offset = "0x169B5CC", VA = "0x169B5CC", Slot = "6")]
	public override void HandleController()
	{
	}

	[Token(Token = "0x6002A46")]
	[Address(RVA = "0x169B6B8", Offset = "0x169B6B8", VA = "0x169B6B8")]
	public SettingsMenuButton()
	{
	}
}
