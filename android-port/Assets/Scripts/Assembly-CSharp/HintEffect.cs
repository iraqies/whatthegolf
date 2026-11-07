using System;
using CameraStack;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200059E")]
public class HintEffect : MonoBehaviour
{
	[Token(Token = "0x200059F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x407B0", Offset = "0x407B0")]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x4001CBF")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 centerPosition;

		[Token(Token = "0x4001CC0")]
		[FieldOffset(Offset = "0x20")]
		public HintEffect _003C_003E4__this;

		[Token(Token = "0x60019A2")]
		[Address(RVA = "0x17BBE4C", Offset = "0x17BBE4C", VA = "0x17BBE4C")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60019A3")]
		[Address(RVA = "0x17BBE54", Offset = "0x17BBE54", VA = "0x17BBE54")]
		internal void _003CPlay_003Eb__0(AudioSource s)
		{
		}
	}

	[Token(Token = "0x20005A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x407C0", Offset = "0x407C0")]
	private sealed class _003C_003Ec__DisplayClass4_1
	{
		[Token(Token = "0x4001CC1")]
		[FieldOffset(Offset = "0x10")]
		public TrailRenderer trail;

		[Token(Token = "0x4001CC2")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 outerPosition;

		[Token(Token = "0x4001CC3")]
		[FieldOffset(Offset = "0x28")]
		public _003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x60019A4")]
		[Address(RVA = "0x17BBEB0", Offset = "0x17BBEB0", VA = "0x17BBEB0")]
		public _003C_003Ec__DisplayClass4_1()
		{
		}

		[Token(Token = "0x60019A5")]
		[Address(RVA = "0x17BBEB8", Offset = "0x17BBEB8", VA = "0x17BBEB8")]
		internal void _003CPlay_003Eb__1(float t)
		{
		}

		[Token(Token = "0x60019A6")]
		[Address(RVA = "0x17BBF64", Offset = "0x17BBF64", VA = "0x17BBF64")]
		internal void _003CPlay_003Eb__3()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20005A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x407D0", Offset = "0x407D0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001CC4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001CC5")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__4_2;

		[Token(Token = "0x60019A8")]
		[Address(RVA = "0x17BBE40", Offset = "0x17BBE40", VA = "0x17BBE40")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60019A9")]
		[Address(RVA = "0x17BBE48", Offset = "0x17BBE48", VA = "0x17BBE48")]
		internal void _003CPlay_003Eb__4_2(float t)
		{
		}
	}

	[Token(Token = "0x4001CBA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TrailRenderer trailTemplate;

	[Token(Token = "0x4001CBB")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip sound;

	[Token(Token = "0x4001CBC")]
	[FieldOffset(Offset = "0x28")]
	private TrailRenderer[] trails;

	[Token(Token = "0x4001CBD")]
	[FieldOffset(Offset = "0x30")]
	private OverworldCamera camera;

	[Token(Token = "0x4001CBE")]
	[FieldOffset(Offset = "0x0")]
	private static HintEffect instance;

	[Token(Token = "0x170002CD")]
	public static HintEffect Instance
	{
		[Token(Token = "0x600199F")]
		[Address(RVA = "0x14CCE54", Offset = "0x14CCE54", VA = "0x14CCE54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600199D")]
	[Address(RVA = "0x14CC7B8", Offset = "0x14CC7B8", VA = "0x14CC7B8")]
	public void Play(Vector3 centerPosition, Vector3[] outerPositions)
	{
	}

	[Token(Token = "0x600199E")]
	[Address(RVA = "0x14CCC68", Offset = "0x14CCC68", VA = "0x14CCC68")]
	private void Expand(int size)
	{
	}

	[Token(Token = "0x60019A0")]
	[Address(RVA = "0x14CCF48", Offset = "0x14CCF48", VA = "0x14CCF48")]
	public static void Initialize(OverworldCamera camera)
	{
	}

	[Token(Token = "0x60019A1")]
	[Address(RVA = "0x14CD084", Offset = "0x14CD084", VA = "0x14CD084")]
	public HintEffect()
	{
	}
}
