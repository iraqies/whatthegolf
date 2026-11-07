using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C33")]
public class ScreenShakeOnCollision : MonoBehaviour
{
	[Token(Token = "0x2000C34")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x44020", Offset = "0x44020")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x400432E")]
		[FieldOffset(Offset = "0x10")]
		public ScreenShakeOnCollision _003C_003E4__this;

		[Token(Token = "0x400432F")]
		[FieldOffset(Offset = "0x18")]
		public float mag;

		[Token(Token = "0x6003A49")]
		[Address(RVA = "0x183EE44", Offset = "0x183EE44", VA = "0x183EE44")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6003A4A")]
		[Address(RVA = "0x183EE4C", Offset = "0x183EE4C", VA = "0x183EE4C")]
		internal void _003CCheckCollision_003Eb__0(AudioSource a)
		{
		}
	}

	[Token(Token = "0x4004325")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask CollisionMask;

	[Token(Token = "0x4004326")]
	[FieldOffset(Offset = "0x1C")]
	public bool OnlyOnce;

	[Token(Token = "0x4004327")]
	[FieldOffset(Offset = "0x20")]
	public float Duration;

	[Token(Token = "0x4004328")]
	[FieldOffset(Offset = "0x24")]
	public float Speed;

	[Token(Token = "0x4004329")]
	[FieldOffset(Offset = "0x28")]
	public float Magnitude;

	[Token(Token = "0x400432A")]
	[FieldOffset(Offset = "0x30")]
	public List<AudioClip> AudioClip;

	[Token(Token = "0x400432B")]
	[FieldOffset(Offset = "0x38")]
	public float clipVolumeMax;

	[Token(Token = "0x400432C")]
	[FieldOffset(Offset = "0x3C")]
	public bool UseCollisionForce;

	[Token(Token = "0x400432D")]
	[FieldOffset(Offset = "0x3D")]
	private bool hasShaken;

	[Token(Token = "0x6003A45")]
	[Address(RVA = "0x167D2F0", Offset = "0x167D2F0", VA = "0x167D2F0")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6003A46")]
	[Address(RVA = "0x167D510", Offset = "0x167D510", VA = "0x167D510")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003A47")]
	[Address(RVA = "0x167D344", Offset = "0x167D344", VA = "0x167D344")]
	private void CheckCollision(GameObject other, Vector3 impactForce)
	{
	}

	[Token(Token = "0x6003A48")]
	[Address(RVA = "0x167D554", Offset = "0x167D554", VA = "0x167D554")]
	public ScreenShakeOnCollision()
	{
	}
}
