using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AFE")]
public class EnvironmentCollision : MonoBehaviour
{
	[Token(Token = "0x2000AFF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x43440", Offset = "0x43440")]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		[Token(Token = "0x4003D41")]
		[FieldOffset(Offset = "0x10")]
		public EnvironmentCollision _003C_003E4__this;

		[Token(Token = "0x4003D42")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 shake;

		[Token(Token = "0x600346A")]
		[Address(RVA = "0x179F00C", Offset = "0x179F00C", VA = "0x179F00C")]
		public _003C_003Ec__DisplayClass17_0()
		{
		}

		[Token(Token = "0x600346B")]
		[Address(RVA = "0x179F014", Offset = "0x179F014", VA = "0x179F014")]
		internal void _003CShake_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x4003D33")]
	[FieldOffset(Offset = "0x18")]
	public bool CanBreak;

	[Token(Token = "0x4003D34")]
	[FieldOffset(Offset = "0x1C")]
	public float ForceRequiredToBreak;

	[Token(Token = "0x4003D35")]
	[FieldOffset(Offset = "0x20")]
	public float BreakForce;

	[Token(Token = "0x4003D36")]
	[FieldOffset(Offset = "0x28")]
	public List<Collider> ThingsToUnparent;

	[Token(Token = "0x4003D37")]
	[FieldOffset(Offset = "0x30")]
	public bool CanShake;

	[Token(Token = "0x4003D38")]
	[FieldOffset(Offset = "0x34")]
	public float ShakeDuration;

	[Token(Token = "0x4003D39")]
	[FieldOffset(Offset = "0x38")]
	public float ShakeForce;

	[Token(Token = "0x4003D3A")]
	[FieldOffset(Offset = "0x3C")]
	public float Shakes;

	[Token(Token = "0x4003D3B")]
	[FieldOffset(Offset = "0x40")]
	public List<ParticleSystem> ShakeParticles;

	[Token(Token = "0x4003D3C")]
	[FieldOffset(Offset = "0x48")]
	public bool Reset;

	[Token(Token = "0x4003D3D")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody rigidbody;

	[Token(Token = "0x4003D3E")]
	[FieldOffset(Offset = "0x58")]
	private Collider col;

	[Token(Token = "0x4003D3F")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 startPos;

	[Token(Token = "0x4003D40")]
	[FieldOffset(Offset = "0x6C")]
	private Quaternion startRot;

	[Token(Token = "0x6003463")]
	[Address(RVA = "0x1444C6C", Offset = "0x1444C6C", VA = "0x1444C6C")]
	private void Start()
	{
	}

	[Token(Token = "0x6003464")]
	[Address(RVA = "0x1444E3C", Offset = "0x1444E3C", VA = "0x1444E3C")]
	private void Update()
	{
	}

	[Token(Token = "0x6003465")]
	[Address(RVA = "0x1444EBC", Offset = "0x1444EBC", VA = "0x1444EBC")]
	private void OnCollisionEnter(Collision c)
	{
	}

	[Token(Token = "0x6003466")]
	[Address(RVA = "0x14452A0", Offset = "0x14452A0", VA = "0x14452A0")]
	private void Shake(Collision c)
	{
	}

	[Token(Token = "0x6003467")]
	[Address(RVA = "0x14450E0", Offset = "0x14450E0", VA = "0x14450E0")]
	private void Break(Collision c)
	{
	}

	[Token(Token = "0x6003468")]
	[Address(RVA = "0x1444F8C", Offset = "0x1444F8C", VA = "0x1444F8C")]
	private void PlayParticles()
	{
	}

	[Token(Token = "0x6003469")]
	[Address(RVA = "0x1445438", Offset = "0x1445438", VA = "0x1445438")]
	public EnvironmentCollision()
	{
	}
}
