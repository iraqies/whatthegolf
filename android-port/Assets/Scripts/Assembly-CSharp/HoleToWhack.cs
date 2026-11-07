using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200011A")]
public class HoleToWhack : MonoBehaviour
{
	[Token(Token = "0x40004E1")]
	[FieldOffset(Offset = "0x18")]
	public Transform ItemsContainer;

	[Token(Token = "0x40004E2")]
	[FieldOffset(Offset = "0x20")]
	public Animator HoleAnimator;

	[Token(Token = "0x40004E3")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 HiddenDurationRange;

	[Token(Token = "0x40004E4")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 StayUpDurationRange;

	[Token(Token = "0x40004E5")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 randomRotationRange;

	[Token(Token = "0x40004E6")]
	[FieldOffset(Offset = "0x40")]
	public ParticleSystem HitParticles;

	[Token(Token = "0x40004E7")]
	[FieldOffset(Offset = "0x48")]
	private float hiddenTimer;

	[Token(Token = "0x40004E8")]
	[FieldOffset(Offset = "0x4C")]
	private float stayUpTimer;

	[Token(Token = "0x40004E9")]
	[FieldOffset(Offset = "0x50")]
	private Animator[] childAnimators;

	[Token(Token = "0x40004EA")]
	[FieldOffset(Offset = "0x58")]
	private int currentIndex;

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x14D10F0", Offset = "0x14D10F0", VA = "0x14D10F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x14D12B0", Offset = "0x14D12B0", VA = "0x14D12B0")]
	private void Update()
	{
	}

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x14D147C", Offset = "0x14D147C", VA = "0x14D147C")]
	private void SetNewTimes()
	{
	}

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0x14D14B8", Offset = "0x14D14B8", VA = "0x14D14B8")]
	public void HasBeenWhacked()
	{
	}

	[Token(Token = "0x60004E2")]
	[Address(RVA = "0x14D15BC", Offset = "0x14D15BC", VA = "0x14D15BC")]
	public HoleToWhack()
	{
	}
}
