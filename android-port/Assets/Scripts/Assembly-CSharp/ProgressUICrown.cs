using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200016E")]
public class ProgressUICrown : MonoBehaviour
{
	[Token(Token = "0x4000681")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SVGImage Shrine;

	[Token(Token = "0x4000682")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SVGImage Coin;

	[Token(Token = "0x4000683")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float ClaimedCrownAlpha;

	[Token(Token = "0x4000684")]
	[FieldOffset(Offset = "0x30")]
	public Animator anim;

	[Token(Token = "0x6000650")]
	[Address(RVA = "0x1626FC0", Offset = "0x1626FC0", VA = "0x1626FC0")]
	public void Claim(Color color)
	{
	}

	[Token(Token = "0x6000651")]
	[Address(RVA = "0x16270B4", Offset = "0x16270B4", VA = "0x16270B4")]
	public void Reclaim()
	{
	}

	[Token(Token = "0x6000652")]
	[Address(RVA = "0x1625ED0", Offset = "0x1625ED0", VA = "0x1625ED0")]
	public void SetLastPoint(bool value)
	{
	}

	[Token(Token = "0x6000653")]
	[Address(RVA = "0x1627138", Offset = "0x1627138", VA = "0x1627138")]
	public void Unclaim()
	{
	}

	[Token(Token = "0x6000654")]
	[Address(RVA = "0x1627194", Offset = "0x1627194", VA = "0x1627194")]
	public void ResetCrown()
	{
	}

	[Token(Token = "0x6000655")]
	[Address(RVA = "0x1627244", Offset = "0x1627244", VA = "0x1627244")]
	public bool IsClaimed()
	{
		return default;
	}

	[Token(Token = "0x6000656")]
	[Address(RVA = "0x162729C", Offset = "0x162729C", VA = "0x162729C")]
	public ProgressUICrown()
	{
	}
}
