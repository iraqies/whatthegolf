using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005C9")]
public class GifTriggerOnBreakable : MonoBehaviour
{
	[Token(Token = "0x4001D92")]
	[FieldOffset(Offset = "0x18")]
	public BreakableBottle bottle;

	[Token(Token = "0x4001D93")]
	[FieldOffset(Offset = "0x20")]
	private GifMomentTrigger trigger;

	[Token(Token = "0x6001A54")]
	[Address(RVA = "0x1488D24", Offset = "0x1488D24", VA = "0x1488D24")]
	private void Start()
	{
	}

	[Token(Token = "0x6001A55")]
	[Address(RVA = "0x1488DE0", Offset = "0x1488DE0", VA = "0x1488DE0")]
	private void Bottle_OnBreak()
	{
	}

	[Token(Token = "0x6001A56")]
	[Address(RVA = "0x1488E80", Offset = "0x1488E80", VA = "0x1488E80")]
	public GifTriggerOnBreakable()
	{
	}
}
