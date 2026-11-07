using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200093D")]
public class CatHeadSlammer : MonoBehaviour
{
	[Token(Token = "0x4003275")]
	[FieldOffset(Offset = "0x18")]
	public Animator Animator;

	[Token(Token = "0x4003276")]
	[FieldOffset(Offset = "0x20")]
	public float SlamInterval;

	[Token(Token = "0x4003277")]
	[FieldOffset(Offset = "0x24")]
	public float StartDelay;

	[Token(Token = "0x4003278")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip SmashRecoveryClip;

	[Token(Token = "0x4003279")]
	[FieldOffset(Offset = "0x30")]
	public AudioClip AnticipationClip;

	[Token(Token = "0x400327A")]
	[FieldOffset(Offset = "0x38")]
	public AudioClip SmashClip;

	[Token(Token = "0x400327B")]
	[FieldOffset(Offset = "0x40")]
	public float Duration;

	[Token(Token = "0x400327C")]
	[FieldOffset(Offset = "0x44")]
	public float Speed;

	[Token(Token = "0x400327D")]
	[FieldOffset(Offset = "0x48")]
	public float Magnitude;

	[Token(Token = "0x400327E")]
	[FieldOffset(Offset = "0x4C")]
	private float timer;

	[Token(Token = "0x400327F")]
	[FieldOffset(Offset = "0x50")]
	private float startTimer;

	[Token(Token = "0x6002AE4")]
	[Address(RVA = "0x18903CC", Offset = "0x18903CC", VA = "0x18903CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002AE5")]
	[Address(RVA = "0x1890464", Offset = "0x1890464", VA = "0x1890464")]
	private void Update()
	{
	}

	[Token(Token = "0x6002AE6")]
	[Address(RVA = "0x1890524", Offset = "0x1890524", VA = "0x1890524")]
	public void PlayAnticipationClip()
	{
	}

	[Token(Token = "0x6002AE7")]
	[Address(RVA = "0x18905F0", Offset = "0x18905F0", VA = "0x18905F0")]
	public void DoScreenShake()
	{
	}

	[Token(Token = "0x6002AE8")]
	[Address(RVA = "0x1890628", Offset = "0x1890628", VA = "0x1890628")]
	public void TakeDamage()
	{
	}

	[Token(Token = "0x6002AE9")]
	[Address(RVA = "0x18906F4", Offset = "0x18906F4", VA = "0x18906F4")]
	public void PlaySmashRecoverClip()
	{
	}

	[Token(Token = "0x6002AEA")]
	[Address(RVA = "0x18907C0", Offset = "0x18907C0", VA = "0x18907C0")]
	public CatHeadSlammer()
	{
	}

	[Token(Token = "0x6002AEB")]
	[Address(RVA = "0x18907DC", Offset = "0x18907DC", VA = "0x18907DC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x67940", Offset = "0x67940")]
	private void _003CPlayAnticipationClip_003Eb__13_0(AudioSource m)
	{
	}

	[Token(Token = "0x6002AEC")]
	[Address(RVA = "0x1890834", Offset = "0x1890834", VA = "0x1890834")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x67950", Offset = "0x67950")]
	private void _003CTakeDamage_003Eb__15_0(AudioSource m)
	{
	}

	[Token(Token = "0x6002AED")]
	[Address(RVA = "0x189088C", Offset = "0x189088C", VA = "0x189088C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x67960", Offset = "0x67960")]
	private void _003CPlaySmashRecoverClip_003Eb__16_0(AudioSource m)
	{
	}
}
