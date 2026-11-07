using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A09")]
public class OverworldGoalWithMenuPopup : OverworldGoal
{
	[Token(Token = "0x400376C")]
	[FieldOffset(Offset = "0x100")]
	public GameObject ObjectToActivateOnHit;

	[Token(Token = "0x6002FA3")]
	[Address(RVA = "0x15B9028", Offset = "0x15B9028", VA = "0x15B9028", Slot = "4")]
	public override void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6002FA4")]
	[Address(RVA = "0x15B90CC", Offset = "0x15B90CC", VA = "0x15B90CC")]
	public OverworldGoalWithMenuPopup()
	{
	}
}
