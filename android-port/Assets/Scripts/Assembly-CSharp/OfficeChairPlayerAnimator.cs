using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200010D")]
public class OfficeChairPlayerAnimator : MonoBehaviour
{
	[Token(Token = "0x400049C")]
	[FieldOffset(Offset = "0x18")]
	public Animator Animator;

	[Token(Token = "0x400049D")]
	[FieldOffset(Offset = "0x20")]
	public SuperGolfShooter Controller;

	[Token(Token = "0x400049E")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RangeAttribute", RVA = "0x49810", Offset = "0x49810")]
	public float HardThrowThreshold;

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x1594CC0", Offset = "0x1594CC0", VA = "0x1594CC0")]
	private void Start()
	{
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x1594ED4", Offset = "0x1594ED4", VA = "0x1594ED4")]
	private void OnWeaponPickUp(SuperGolfGun obj)
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x1594F30", Offset = "0x1594F30", VA = "0x1594F30")]
	public void OnDeath(SuperGolfShooter obj)
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x1594F88", Offset = "0x1594F88", VA = "0x1594F88")]
	private void OnPlayerShot(SuperGolfGun gun, Vector3 boost)
	{
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x15950AC", Offset = "0x15950AC", VA = "0x15950AC")]
	public OfficeChairPlayerAnimator()
	{
	}
}
