using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B1A")]
public class OverworldSpaceStation : MonoBehaviour
{
	[Token(Token = "0x4003E10")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> targets;

	[Token(Token = "0x4003E11")]
	[FieldOffset(Offset = "0x20")]
	public float targetInterval;

	[Token(Token = "0x4003E12")]
	[FieldOffset(Offset = "0x24")]
	public float force;

	[Token(Token = "0x4003E13")]
	[FieldOffset(Offset = "0x28")]
	public float backwardsForce;

	[Token(Token = "0x4003E14")]
	[FieldOffset(Offset = "0x2C")]
	private float nextTargetTime;

	[Token(Token = "0x4003E15")]
	[FieldOffset(Offset = "0x30")]
	private int currentTargetIndex;

	[Token(Token = "0x4003E16")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody2D rigid;

	[Token(Token = "0x60034FD")]
	[Address(RVA = "0x15CC190", Offset = "0x15CC190", VA = "0x15CC190")]
	private void Start()
	{
	}

	[Token(Token = "0x60034FE")]
	[Address(RVA = "0x15CC200", Offset = "0x15CC200", VA = "0x15CC200")]
	private void Update()
	{
	}

	[Token(Token = "0x60034FF")]
	[Address(RVA = "0x15CC2F0", Offset = "0x15CC2F0", VA = "0x15CC2F0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003500")]
	[Address(RVA = "0x15CC240", Offset = "0x15CC240", VA = "0x15CC240")]
	private void SetNextTarget()
	{
	}

	[Token(Token = "0x6003501")]
	[Address(RVA = "0x15CC42C", Offset = "0x15CC42C", VA = "0x15CC42C")]
	public OverworldSpaceStation()
	{
	}
}
