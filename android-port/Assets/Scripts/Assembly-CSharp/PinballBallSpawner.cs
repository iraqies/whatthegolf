using System;
using System.Collections.Generic;
using GolfGames.Pinball;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007F9")]
public class PinballBallSpawner : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20007FA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41710", Offset = "0x41710")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002AC2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002AC3")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__3_0;

		[Token(Token = "0x600249E")]
		[Address(RVA = "0x1826258", Offset = "0x1826258", VA = "0x1826258")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600249F")]
		[Address(RVA = "0x1826260", Offset = "0x1826260", VA = "0x1826260")]
		internal void _003COnCollisionEnter2D_003Eb__3_0(AudioSource s)
		{
		}
	}

	[Token(Token = "0x4002ABF")]
	[FieldOffset(Offset = "0x18")]
	public Pinball BallToSpawn;

	[Token(Token = "0x4002AC0")]
	[FieldOffset(Offset = "0x20")]
	public List<AudioClip> SpawnClip;

	[Token(Token = "0x4002AC1")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4F03C", Offset = "0x4F03C")]
	public float Probability;

	[Token(Token = "0x600249B")]
	[Address(RVA = "0x15E2610", Offset = "0x15E2610", VA = "0x15E2610")]
	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	[Token(Token = "0x600249C")]
	[Address(RVA = "0x15E28B4", Offset = "0x15E28B4", VA = "0x15E28B4")]
	public PinballBallSpawner()
	{
	}
}
