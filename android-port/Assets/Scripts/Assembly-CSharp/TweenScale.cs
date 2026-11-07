using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200035A")]
public class TweenScale : MonoBehaviour
{
	[Token(Token = "0x400126E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject totween;

	[Token(Token = "0x400126F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector3 from;

	[Token(Token = "0x4001270")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private Vector3 to;

	[Token(Token = "0x4001271")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationCurve animationCurve;

	[Token(Token = "0x4001272")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float duration;

	[Token(Token = "0x4001273")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool StartOnAwake;

	[Token(Token = "0x6000F88")]
	[Address(RVA = "0x17344B8", Offset = "0x17344B8", VA = "0x17344B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000F89")]
	[Address(RVA = "0x17345A8", Offset = "0x17345A8", VA = "0x17345A8")]
	public void Scale()
	{
	}

	[Token(Token = "0x6000F8A")]
	[Address(RVA = "0x1734678", Offset = "0x1734678", VA = "0x1734678")]
	public TweenScale()
	{
	}

	[Token(Token = "0x6000F8B")]
	[Address(RVA = "0x17346AC", Offset = "0x17346AC", VA = "0x17346AC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x611FC", Offset = "0x611FC")]
	private void _003CScale_003Eb__7_0(float t)
	{
	}
}
