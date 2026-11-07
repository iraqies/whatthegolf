using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C1B")]
public class PushObjectOnCollision : MonoBehaviour
{
	[Token(Token = "0x2000C1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43FA0", Offset = "0x43FA0")]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x40042D6")]
		[FieldOffset(Offset = "0x10")]
		public PushObjectOnCollision _003C_003E4__this;

		[Token(Token = "0x40042D7")]
		[FieldOffset(Offset = "0x18")]
		public Collision other;

		[Token(Token = "0x60039F6")]
		[Address(RVA = "0x182F10C", Offset = "0x182F10C", VA = "0x182F10C")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60039F7")]
		[Address(RVA = "0x182F114", Offset = "0x182F114", VA = "0x182F114")]
		internal void _003COnCollisionEnter_003Eb__1()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000C1D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43FB0", Offset = "0x43FB0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40042D8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40042D9")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__8_0;

		[Token(Token = "0x60039F9")]
		[Address(RVA = "0x182F100", Offset = "0x182F100", VA = "0x182F100")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60039FA")]
		[Address(RVA = "0x182F108", Offset = "0x182F108", VA = "0x182F108")]
		internal void _003COnCollisionEnter_003Eb__8_0(float t)
		{
		}
	}

	[Token(Token = "0x40042CF")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 PushDirection;

	[Token(Token = "0x40042D0")]
	[FieldOffset(Offset = "0x24")]
	public float RandomSpread;

	[Token(Token = "0x40042D1")]
	[FieldOffset(Offset = "0x28")]
	public float PushStrength;

	[Token(Token = "0x40042D2")]
	[FieldOffset(Offset = "0x2C")]
	public float AngularForce;

	[Token(Token = "0x40042D3")]
	[FieldOffset(Offset = "0x30")]
	public LayerMask AffectedLayers;

	[Token(Token = "0x40042D4")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rigidbody;

	[Token(Token = "0x40042D5")]
	[FieldOffset(Offset = "0x40")]
	private Collider[] cols;

	[Token(Token = "0x60039F2")]
	[Address(RVA = "0x162D644", Offset = "0x162D644", VA = "0x162D644")]
	private void Start()
	{
	}

	[Token(Token = "0x60039F3")]
	[Address(RVA = "0x162D6C4", Offset = "0x162D6C4", VA = "0x162D6C4")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60039F4")]
	[Address(RVA = "0x162DA00", Offset = "0x162DA00", VA = "0x162DA00")]
	private void ToggleIgnoreCollision(Collider c, bool ignore)
	{
	}

	[Token(Token = "0x60039F5")]
	[Address(RVA = "0x162DA8C", Offset = "0x162DA8C", VA = "0x162DA8C")]
	public PushObjectOnCollision()
	{
	}
}
