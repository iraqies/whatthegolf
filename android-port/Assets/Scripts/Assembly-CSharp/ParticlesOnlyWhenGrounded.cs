using Chronos;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C17")]
public class ParticlesOnlyWhenGrounded : MonoBehaviour
{
	[Token(Token = "0x40042C0")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask layer;

	[Token(Token = "0x40042C1")]
	[FieldOffset(Offset = "0x1C")]
	public float distanceToGroundThreshold;

	[Token(Token = "0x40042C2")]
	[FieldOffset(Offset = "0x20")]
	public bool StopInsteadOfPause;

	[Token(Token = "0x40042C3")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem ps;

	[Token(Token = "0x40042C4")]
	[FieldOffset(Offset = "0x30")]
	private ParticleSystem.EmissionModule emission;

	[Token(Token = "0x40042C5")]
	[FieldOffset(Offset = "0x38")]
	private TimelineChild timeline;

	[Token(Token = "0x60039EA")]
	[Address(RVA = "0x15DC894", Offset = "0x15DC894", VA = "0x15DC894")]
	private void Start()
	{
	}

	[Token(Token = "0x60039EB")]
	[Address(RVA = "0x15DC928", Offset = "0x15DC928", VA = "0x15DC928")]
	private void Update()
	{
	}

	[Token(Token = "0x60039EC")]
	[Address(RVA = "0x15DCAA0", Offset = "0x15DCAA0", VA = "0x15DCAA0")]
	public ParticlesOnlyWhenGrounded()
	{
	}
}
