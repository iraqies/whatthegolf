using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200071F")]
public class Kick2DBall : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000720")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41290", Offset = "0x41290")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002595")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002596")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__8_0;

		[Token(Token = "0x60020E9")]
		[Address(RVA = "0x17CCECC", Offset = "0x17CCECC", VA = "0x17CCECC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60020EA")]
		[Address(RVA = "0x17CCED4", Offset = "0x17CCED4", VA = "0x17CCED4")]
		internal void _003CPlaySfx_003Eb__8_0(AudioSource s)
		{
		}
	}

	[Token(Token = "0x400258F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private VolleyGame VolleyGame;

	[Token(Token = "0x4002590")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<AudioClip> clips;

	[Token(Token = "0x4002591")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float force;

	[Token(Token = "0x4002592")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float helperForce;

	[Token(Token = "0x4002593")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody2D rigid;

	[Token(Token = "0x4002594")]
	[FieldOffset(Offset = "0x38")]
	private float nextPush;

	[Token(Token = "0x60020E4")]
	[Address(RVA = "0x14FE5E4", Offset = "0x14FE5E4", VA = "0x14FE5E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60020E5")]
	[Address(RVA = "0x14FE640", Offset = "0x14FE640", VA = "0x14FE640")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x60020E6")]
	[Address(RVA = "0x14FE8CC", Offset = "0x14FE8CC", VA = "0x14FE8CC")]
	private void PlaySfx()
	{
	}

	[Token(Token = "0x60020E7")]
	[Address(RVA = "0x14FEA1C", Offset = "0x14FEA1C", VA = "0x14FEA1C")]
	public Kick2DBall()
	{
	}
}
