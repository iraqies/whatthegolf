using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200054C")]
public class FollowRectTransform : MonoBehaviour
{
	[Token(Token = "0x4001B63")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform FollowTarget;

	[Token(Token = "0x4001B64")]
	[FieldOffset(Offset = "0x20")]
	public bool SizeDelta;

	[Token(Token = "0x4001B65")]
	[FieldOffset(Offset = "0x21")]
	public bool AnchoredPosition;

	[Token(Token = "0x4001B66")]
	[FieldOffset(Offset = "0x28")]
	private RectTransform rectTransform;

	[Token(Token = "0x600182D")]
	[Address(RVA = "0x146FE80", Offset = "0x146FE80", VA = "0x146FE80")]
	private void Awake()
	{
	}

	[Token(Token = "0x600182E")]
	[Address(RVA = "0x146FEDC", Offset = "0x146FEDC", VA = "0x146FEDC")]
	private void Update()
	{
	}

	[Token(Token = "0x600182F")]
	[Address(RVA = "0x146FFF8", Offset = "0x146FFF8", VA = "0x146FFF8")]
	public FollowRectTransform()
	{
	}
}
