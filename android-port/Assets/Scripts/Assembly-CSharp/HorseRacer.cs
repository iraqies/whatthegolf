using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008A5")]
public class HorseRacer : MonoBehaviour
{
	[Token(Token = "0x4002F7A")]
	[FieldOffset(Offset = "0x18")]
	private Rigidbody rigidbody;

	[Token(Token = "0x4002F7B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Animator horseAnimator;

	[Token(Token = "0x4002F7C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float maxInputVelocity;

	[Token(Token = "0x4002F7D")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float maxAnimationSpeed;

	[Token(Token = "0x4002F7E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float jumpDuration;

	[Token(Token = "0x4002F7F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationCurve jumpLayerWeight;

	[Token(Token = "0x4002F80")]
	[FieldOffset(Offset = "0x40")]
	private int jumpLayerIndex;

	[Token(Token = "0x60027F2")]
	[Address(RVA = "0x14D8374", Offset = "0x14D8374", VA = "0x14D8374")]
	private void Awake()
	{
	}

	[Token(Token = "0x60027F3")]
	[Address(RVA = "0x14D8400", Offset = "0x14D8400", VA = "0x14D8400")]
	private void Update()
	{
	}

	[Token(Token = "0x60027F4")]
	[Address(RVA = "0x14D84C4", Offset = "0x14D84C4", VA = "0x14D84C4")]
	public void Jump()
	{
	}

	[Token(Token = "0x60027F5")]
	[Address(RVA = "0x14D8588", Offset = "0x14D8588", VA = "0x14D8588")]
	public HorseRacer()
	{
	}

	[Token(Token = "0x60027F6")]
	[Address(RVA = "0x14D85E0", Offset = "0x14D85E0", VA = "0x14D85E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x67054", Offset = "0x67054")]
	private void _003CJump_003Eb__9_0(float t)
	{
	}
}
