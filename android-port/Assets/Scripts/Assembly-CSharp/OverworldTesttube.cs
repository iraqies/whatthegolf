using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AC4")]
[Attribute(Name = "RequireComponent", RVA = "0x43180", Offset = "0x43180")]
[Attribute(Name = "RequireComponent", RVA = "0x43180", Offset = "0x43180")]
public class OverworldTesttube : MonoBehaviour
{
	[Token(Token = "0x2000AC5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4321C", Offset = "0x4321C")]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[Token(Token = "0x4003C08")]
		[FieldOffset(Offset = "0x10")]
		public ParticleSystem.MainModule main;

		[Token(Token = "0x6003388")]
		[Address(RVA = "0x181E268", Offset = "0x181E268", VA = "0x181E268")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x6003389")]
		[Address(RVA = "0x181E270", Offset = "0x181E270", VA = "0x181E270")]
		internal void _003COnCollisionEnter2D_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x4003BFC")]
	[FieldOffset(Offset = "0x18")]
	public Transform floatyObject;

	[Token(Token = "0x4003BFD")]
	[FieldOffset(Offset = "0x20")]
	public float floatyDistance;

	[Token(Token = "0x4003BFE")]
	[FieldOffset(Offset = "0x24")]
	public float floatyRotation;

	[Token(Token = "0x4003BFF")]
	[FieldOffset(Offset = "0x28")]
	public bool isRotatingSineWave;

	[Token(Token = "0x4003C00")]
	[FieldOffset(Offset = "0x30")]
	public RandomAudioClips hitSfx;

	[Token(Token = "0x4003C01")]
	[FieldOffset(Offset = "0x38")]
	public ParticleSystem particles;

	[Token(Token = "0x4003C02")]
	[FieldOffset(Offset = "0x40")]
	private float nextHitSound;

	[Token(Token = "0x4003C03")]
	[FieldOffset(Offset = "0x48")]
	private Collider2D col;

	[Token(Token = "0x4003C04")]
	[FieldOffset(Offset = "0x50")]
	private Coroutine lastRoutine;

	[Token(Token = "0x4003C05")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 baseFloatyPosition;

	[Token(Token = "0x4003C06")]
	[FieldOffset(Offset = "0x64")]
	private Quaternion baseFloatyRotation;

	[Token(Token = "0x4003C07")]
	[FieldOffset(Offset = "0x74")]
	private float floatTime;

	[Token(Token = "0x6003381")]
	[Address(RVA = "0x15CD98C", Offset = "0x15CD98C", VA = "0x15CD98C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003382")]
	[Address(RVA = "0x15CDA14", Offset = "0x15CDA14", VA = "0x15CDA14")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6003383")]
	[Address(RVA = "0x15CDB44", Offset = "0x15CDB44", VA = "0x15CDB44")]
	private void Update()
	{
	}

	[Token(Token = "0x6003384")]
	[Address(RVA = "0x15CDD1C", Offset = "0x15CDD1C", VA = "0x15CDD1C")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6003385")]
	[Address(RVA = "0x15CE0A4", Offset = "0x15CE0A4", VA = "0x15CE0A4")]
	public OverworldTesttube()
	{
	}

	[Token(Token = "0x6003386")]
	[Address(RVA = "0x15CE0AC", Offset = "0x15CE0AC", VA = "0x15CE0AC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A438", Offset = "0x6A438")]
	private void _003COnCollisionEnter2D_003Eb__15_1(float t)
	{
	}

	[Token(Token = "0x6003387")]
	[Address(RVA = "0x15CE110", Offset = "0x15CE110", VA = "0x15CE110")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A448", Offset = "0x6A448")]
	private void _003COnCollisionEnter2D_003Eb__15_2()
	{
	}
}
