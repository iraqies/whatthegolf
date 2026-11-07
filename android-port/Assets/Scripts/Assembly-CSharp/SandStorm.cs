using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20006E3")]
public class SandStorm : MonoBehaviour
{
	[Token(Token = "0x400240E")]
	[FieldOffset(Offset = "0x18")]
	public float WarmupDuration;

	[Token(Token = "0x400240F")]
	[FieldOffset(Offset = "0x1C")]
	public float SandstormTimeToFullEffect;

	[Token(Token = "0x4002410")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem SandParticles;

	[Token(Token = "0x4002411")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent OnSandstormStarted;

	[Token(Token = "0x4002412")]
	[FieldOffset(Offset = "0x30")]
	private bool countdownStarted;

	[Token(Token = "0x4002413")]
	[FieldOffset(Offset = "0x31")]
	private bool sandstormStarted;

	[Token(Token = "0x4002414")]
	[FieldOffset(Offset = "0x34")]
	private float sandstormTimer;

	[Token(Token = "0x4002415")]
	[FieldOffset(Offset = "0x38")]
	private bool hasBeenInvoked;

	[Token(Token = "0x6001FC8")]
	[Address(RVA = "0x166A0A0", Offset = "0x166A0A0", VA = "0x166A0A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6001FC9")]
	[Address(RVA = "0x166A164", Offset = "0x166A164", VA = "0x166A164")]
	private void BallOnOnShoot(Vector3 vector3)
	{
	}

	[Token(Token = "0x6001FCA")]
	[Address(RVA = "0x166A170", Offset = "0x166A170", VA = "0x166A170")]
	private void Update()
	{
	}

	[Token(Token = "0x6001FCB")]
	[Address(RVA = "0x166A270", Offset = "0x166A270", VA = "0x166A270")]
	public SandStorm()
	{
	}
}
