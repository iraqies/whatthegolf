using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AC6")]
[Attribute(Name = "RequireComponent", RVA = "0x4322C", Offset = "0x4322C")]
[Attribute(Name = "RequireComponent", RVA = "0x4322C", Offset = "0x4322C")]
public class OverworldWaterCooler : MonoBehaviour
{
	[Token(Token = "0x2000AC7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x432C8", Offset = "0x432C8")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x4003C0F")]
		[FieldOffset(Offset = "0x10")]
		public ParticleSystem.MainModule main;

		[Token(Token = "0x600338F")]
		[Address(RVA = "0x181FC04", Offset = "0x181FC04", VA = "0x181FC04")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6003390")]
		[Address(RVA = "0x181FC0C", Offset = "0x181FC0C", VA = "0x181FC0C")]
		internal void _003COnCollisionEnter2D_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x4003C09")]
	[FieldOffset(Offset = "0x18")]
	public RandomAudioClips hitSfx;

	[Token(Token = "0x4003C0A")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem particles;

	[Token(Token = "0x4003C0B")]
	[FieldOffset(Offset = "0x28")]
	private float nextHitSound;

	[Token(Token = "0x4003C0C")]
	[FieldOffset(Offset = "0x30")]
	private Collider2D col;

	[Token(Token = "0x4003C0D")]
	[FieldOffset(Offset = "0x38")]
	private Coroutine lastRoutine;

	[Token(Token = "0x4003C0E")]
	[FieldOffset(Offset = "0x40")]
	private Quaternion baseRotation;

	[Token(Token = "0x600338A")]
	[Address(RVA = "0x15D3C88", Offset = "0x15D3C88", VA = "0x15D3C88")]
	private void Awake()
	{
	}

	[Token(Token = "0x600338B")]
	[Address(RVA = "0x15D3D00", Offset = "0x15D3D00", VA = "0x15D3D00")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x600338C")]
	[Address(RVA = "0x15D3FD4", Offset = "0x15D3FD4", VA = "0x15D3FD4")]
	public OverworldWaterCooler()
	{
	}

	[Token(Token = "0x600338D")]
	[Address(RVA = "0x15D3FDC", Offset = "0x15D3FDC", VA = "0x15D3FDC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A458", Offset = "0x6A458")]
	private void _003COnCollisionEnter2D_003Eb__7_1(float t)
	{
	}

	[Token(Token = "0x600338E")]
	[Address(RVA = "0x15D4054", Offset = "0x15D4054", VA = "0x15D4054")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A468", Offset = "0x6A468")]
	private void _003COnCollisionEnter2D_003Eb__7_2()
	{
	}
}
