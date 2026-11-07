using System;
using Audio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000D65")]
public class BreakableVase : MonoBehaviour
{
	[Token(Token = "0x40048E9")]
	[FieldOffset(Offset = "0x18")]
	public string Notes;

	[Token(Token = "0x40048EA")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x51B64", Offset = "0x51B64")]
	private Action m_OnBreak;

	[Token(Token = "0x40048EB")]
	[FieldOffset(Offset = "0x28")]
	public float ShatterForce;

	[Token(Token = "0x40048EC")]
	[FieldOffset(Offset = "0x2C")]
	public float breakThreshold;

	[Token(Token = "0x40048ED")]
	[FieldOffset(Offset = "0x30")]
	public RandomAudioClips ShatterClips;

	[Token(Token = "0x40048EE")]
	[FieldOffset(Offset = "0x38")]
	public LayerMask BlacklistLayers;

	[Token(Token = "0x40048EF")]
	[FieldOffset(Offset = "0x40")]
	public GameObject DestroyGameobject;

	[Token(Token = "0x40048F0")]
	[FieldOffset(Offset = "0x48")]
	public bool FailLevelOnBreak;

	[Token(Token = "0x40048F1")]
	[FieldOffset(Offset = "0x4C")]
	public float failDelay;

	[Token(Token = "0x40048F2")]
	[FieldOffset(Offset = "0x50")]
	public MonoBehaviour[] disableComponentsOnBreak;

	[Token(Token = "0x40048F3")]
	[FieldOffset(Offset = "0x58")]
	private ObjectShatter shatter;

	[Token(Token = "0x40048F4")]
	[FieldOffset(Offset = "0x60")]
	private bool hasShattered;

	[Token(Token = "0x40048F5")]
	[FieldOffset(Offset = "0x68")]
	public UnityEvent OnShattered;

	[Token(Token = "0x40048F6")]
	[FieldOffset(Offset = "0x70")]
	private Collision collisionWithOther;

	[Token(Token = "0x40048F7")]
	[FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x51B74", Offset = "0x51B74")]
	private Action<IHitscanTarget> OnHitscanHit__BackingField;

	[Token(Token = "0x1700066B")]
	public Action<IHitscanTarget> OnHitscanHit
	{
		[Token(Token = "0x6003F0B")]
		[Address(RVA = "0x17071CC", Offset = "0x17071CC", VA = "0x17071CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C6DC", Offset = "0x6C6DC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003F0C")]
		[Address(RVA = "0x17071D4", Offset = "0x17071D4", VA = "0x17071D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C6EC", Offset = "0x6C6EC")]
		set
		{
		}
	}

	[Token(Token = "0x1400007A")]
	public event Action OnBreak
	{
		[Token(Token = "0x6003F09")]
		[Address(RVA = "0x1707084", Offset = "0x1707084", VA = "0x1707084")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C6BC", Offset = "0x6C6BC")]
		add
		{
		}
		[Token(Token = "0x6003F0A")]
		[Address(RVA = "0x1707128", Offset = "0x1707128", VA = "0x1707128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C6CC", Offset = "0x6C6CC")]
		remove
		{
		}
	}

	[Token(Token = "0x6003F0D")]
	[Address(RVA = "0x17071DC", Offset = "0x17071DC", VA = "0x17071DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003F0E")]
	[Address(RVA = "0x17072B4", Offset = "0x17072B4", VA = "0x17072B4")]
	public void ExternalBreak()
	{
	}

	[Token(Token = "0x6003F0F")]
	[Address(RVA = "0x1707310", Offset = "0x1707310", VA = "0x1707310")]
	private void Shatter(Vector3 hit)
	{
	}

	[Token(Token = "0x6003F10")]
	[Address(RVA = "0x17075C4", Offset = "0x17075C4", VA = "0x17075C4")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6003F11")]
	[Address(RVA = "0x17076CC", Offset = "0x17076CC", VA = "0x17076CC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003F12")]
	[Address(RVA = "0x170776C", Offset = "0x170776C", VA = "0x170776C")]
	public BreakableVase()
	{
	}
}
