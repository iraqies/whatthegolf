using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005A2")]
public class LightningEffect : MonoBehaviour
{
	[Token(Token = "0x4001CC6")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 EmissionTime;

	[Token(Token = "0x4001CC7")]
	[FieldOffset(Offset = "0x20")]
	public List<AudioClip> Clips;

	[Token(Token = "0x4001CC8")]
	[FieldOffset(Offset = "0x28")]
	public ClipSettingsCollection LightingSFX;

	[Token(Token = "0x4001CC9")]
	[FieldOffset(Offset = "0x30")]
	public Gradient LightningGradient;

	[Token(Token = "0x4001CCA")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve LightningCurve;

	[Token(Token = "0x4001CCB")]
	[FieldOffset(Offset = "0x40")]
	public ParticleSystem Particles;

	[Token(Token = "0x4001CCC")]
	[FieldOffset(Offset = "0x48")]
	public Light DirectionalLight;

	[Token(Token = "0x4001CCD")]
	[FieldOffset(Offset = "0x50")]
	public float Duration;

	[Token(Token = "0x4001CCE")]
	[FieldOffset(Offset = "0x54")]
	public float ShakeDuration;

	[Token(Token = "0x4001CCF")]
	[FieldOffset(Offset = "0x58")]
	public Vector2 ShakeSpeedRange;

	[Token(Token = "0x4001CD0")]
	[FieldOffset(Offset = "0x60")]
	public float ShakeMagnitude;

	[Token(Token = "0x4001CD1")]
	[FieldOffset(Offset = "0x64")]
	private float timer;

	[Token(Token = "0x4001CD2")]
	[FieldOffset(Offset = "0x68")]
	private float nextLightning;

	[Token(Token = "0x4001CD3")]
	[FieldOffset(Offset = "0x70")]
	private Camera mainCamera;

	[Token(Token = "0x60019AA")]
	[Address(RVA = "0x1531B74", Offset = "0x1531B74", VA = "0x1531B74")]
	private void Start()
	{
	}

	[Token(Token = "0x60019AB")]
	[Address(RVA = "0x1531BB4", Offset = "0x1531BB4", VA = "0x1531BB4")]
	private void Update()
	{
	}

	[Token(Token = "0x60019AC")]
	[Address(RVA = "0x1531C14", Offset = "0x1531C14", VA = "0x1531C14")]
	private void LightningRoutine()
	{
	}

	[Token(Token = "0x60019AD")]
	[Address(RVA = "0x1531E40", Offset = "0x1531E40", VA = "0x1531E40")]
	public LightningEffect()
	{
	}

	[Token(Token = "0x60019AE")]
	[Address(RVA = "0x1531E6C", Offset = "0x1531E6C", VA = "0x1531E6C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x63574", Offset = "0x63574")]
	private void _003CLightningRoutine_003Eb__16_0(float t)
	{
	}

	[Token(Token = "0x60019AF")]
	[Address(RVA = "0x1531EC0", Offset = "0x1531EC0", VA = "0x1531EC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x63584", Offset = "0x63584")]
	private void _003CLightningRoutine_003Eb__16_1(float t)
	{
	}
}
