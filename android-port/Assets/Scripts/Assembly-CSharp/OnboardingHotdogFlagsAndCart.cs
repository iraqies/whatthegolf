using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200030C")]
public class OnboardingHotdogFlagsAndCart : MonoBehaviour
{
	[Token(Token = "0x40010D4")]
	[FieldOffset(Offset = "0x18")]
	public Animator cartAnimator;

	[Token(Token = "0x40010D5")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> flagList;

	[Token(Token = "0x40010D6")]
	[FieldOffset(Offset = "0x28")]
	private int currentFlagIndex;

	[Token(Token = "0x6000E08")]
	[Address(RVA = "0x159B7B0", Offset = "0x159B7B0", VA = "0x159B7B0")]
	public void SpawnNextFlag()
	{
	}

	[Token(Token = "0x6000E09")]
	[Address(RVA = "0x159B934", Offset = "0x159B934", VA = "0x159B934")]
	public void StealTheCart()
	{
	}

	[Token(Token = "0x6000E0A")]
	[Address(RVA = "0x159B98C", Offset = "0x159B98C", VA = "0x159B98C")]
	public OnboardingHotdogFlagsAndCart()
	{
	}
}
