using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200096D")]
public class ActiveFlagAnimation : MonoBehaviour
{
	[Token(Token = "0x40033BA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float minScale;

	[Token(Token = "0x40033BB")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float maxScale;

	[Token(Token = "0x40033BC")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float frequency;

	[Token(Token = "0x40033BD")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AnimationCurve scaleCurve;

	[Token(Token = "0x40033BE")]
	[FieldOffset(Offset = "0x30")]
	private float t;

	[Token(Token = "0x40033BF")]
	[FieldOffset(Offset = "0x38")]
	private Transform cachedTransform;

	[Token(Token = "0x40033C0")]
	[FieldOffset(Offset = "0x40")]
	private float startTime;

	[Token(Token = "0x40033C1")]
	[FieldOffset(Offset = "0x44")]
	private float delayedStartTime;

	[Token(Token = "0x6002BFF")]
	[Address(RVA = "0x14052EC", Offset = "0x14052EC", VA = "0x14052EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002C00")]
	[Address(RVA = "0x1405380", Offset = "0x1405380", VA = "0x1405380")]
	private void Update()
	{
	}

	[Token(Token = "0x6002C01")]
	[Address(RVA = "0x1405498", Offset = "0x1405498", VA = "0x1405498")]
	public ActiveFlagAnimation()
	{
	}
}
