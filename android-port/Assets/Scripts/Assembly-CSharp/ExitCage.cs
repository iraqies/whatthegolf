using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200073F")]
public class ExitCage : MonoBehaviour
{
	[Token(Token = "0x4002667")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform cageTop;

	[Token(Token = "0x4002668")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Rigidbody cage;

	[Token(Token = "0x4002669")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private CageShooter ball;

	[Token(Token = "0x400266A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ParticleSystem breakParticles;

	[Token(Token = "0x400266B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<ExplosionBarrel> leftEscapeBarrels;

	[Token(Token = "0x400266C")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<ExplosionBarrel> rightEscapeBarrels;

	[Token(Token = "0x400266D")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform leftBreakFreePosition;

	[Token(Token = "0x400266E")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform rightBreakFreePosition;

	[Token(Token = "0x400266F")]
	[FieldOffset(Offset = "0x58")]
	private LobbySpawnPoint.SpawnPointPositions side;

	[Token(Token = "0x4002670")]
	[FieldOffset(Offset = "0x5C")]
	private bool hasExited;

	[Token(Token = "0x600216D")]
	[Address(RVA = "0x144E2B8", Offset = "0x144E2B8", VA = "0x144E2B8")]
	private void Start()
	{
	}

	[Token(Token = "0x600216E")]
	[Address(RVA = "0x144E778", Offset = "0x144E778", VA = "0x144E778")]
	private void BarrelOnOnExplode(Collider arg1, ExplosionBarrel arg2)
	{
	}

	[Token(Token = "0x600216F")]
	[Address(RVA = "0x144E7C4", Offset = "0x144E7C4", VA = "0x144E7C4")]
	public void BreakFree(Vector3 position)
	{
	}

	[Token(Token = "0x6002170")]
	[Address(RVA = "0x144EE28", Offset = "0x144EE28", VA = "0x144EE28")]
	public ExitCage()
	{
	}
}
