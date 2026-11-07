using System;
using System.Runtime.InteropServices;
using Chronos;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200082B")]
public class ObjectShatter : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200082C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41898", Offset = "0x41898")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002C12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002C13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Timeline, RigidbodyTimeline3D> _003C_003E9__5_0;

		[Token(Token = "0x600259E")]
		[Address(RVA = "0x180A1BC", Offset = "0x180A1BC", VA = "0x180A1BC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600259F")]
		[Address(RVA = "0x180A1C4", Offset = "0x180A1C4", VA = "0x180A1C4")]
		internal RigidbodyTimeline3D _003CStart_003Eb__5_0(Timeline t)
		{
			return null;
		}
	}

	[Token(Token = "0x200082D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x418A8", Offset = "0x418A8")]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x4002C14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 impactPoint;

		[Token(Token = "0x4002C15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float force;

		[Token(Token = "0x4002C16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ForceMode forceMode;

		[Token(Token = "0x4002C17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ObjectShatter _003C_003E4__this;

		[Token(Token = "0x60025A0")]
		[Address(RVA = "0x180A1DC", Offset = "0x180A1DC", VA = "0x180A1DC")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60025A1")]
		[Address(RVA = "0x180A1E4", Offset = "0x180A1E4", VA = "0x180A1E4")]
		internal void _003CShatter_003Eb__0(RigidbodyTimeline3D r)
		{
		}

		[Token(Token = "0x60025A2")]
		[Address(RVA = "0x180A2B0", Offset = "0x180A2B0", VA = "0x180A2B0")]
		internal void _003CShatter_003Eb__1(Rigidbody r)
		{
		}
	}

	[Token(Token = "0x4002C0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool UseTimelines;

	[Token(Token = "0x4002C0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool UnparentAllRigidbodies;

	[Token(Token = "0x4002C0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RigidbodyTimeline3D[] rigidbodiesTimeline;

	[Token(Token = "0x4002C10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Rigidbody[] rigidbodies;

	[Token(Token = "0x4002C11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool hasShattered;

	[Token(Token = "0x6002598")]
	[Address(RVA = "0x159261C", Offset = "0x159261C", VA = "0x159261C")]
	private void Start()
	{
	}

	[Token(Token = "0x6002599")]
	[Address(RVA = "0x159281C", Offset = "0x159281C", VA = "0x159281C")]
	private void Toggle(bool isEnabled, [Optional] Action<RigidbodyTimeline3D> doToRigid)
	{
	}

	[Token(Token = "0x600259A")]
	[Address(RVA = "0x1592930", Offset = "0x1592930", VA = "0x1592930")]
	private void ToggleRagdolls(bool isEnabled, [Optional] Action<Rigidbody> doToRigid)
	{
	}

	[Token(Token = "0x600259B")]
	[Address(RVA = "0x1592A4C", Offset = "0x1592A4C", VA = "0x1592A4C")]
	public void Shatter(Vector3 impactPoint, float force, float explosionRadius, float upwardsModifier, ForceMode forceMode)
	{
	}

	[Token(Token = "0x600259C")]
	[Address(RVA = "0x1592C18", Offset = "0x1592C18", VA = "0x1592C18")]
	public ObjectShatter()
	{
	}
}
