using System;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000898")]
public class BreakableBottle : MonoBehaviour, IHitscanTarget
{
	[Token(Token = "0x4002F33")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F51C", Offset = "0x4F51C")]
	private Action m_OnBreak;

	[Token(Token = "0x4002F34")]
	[FieldOffset(Offset = "0x20")]
	public float ShatterForce;

	[Token(Token = "0x4002F35")]
	[FieldOffset(Offset = "0x24")]
	public float breakThreshold;

	[Token(Token = "0x4002F36")]
	[FieldOffset(Offset = "0x28")]
	public RandomAudioClips ShatterClips;

	[Token(Token = "0x4002F37")]
	[FieldOffset(Offset = "0x30")]
	public LayerMask BlacklistLayers;

	[Token(Token = "0x4002F38")]
	[FieldOffset(Offset = "0x38")]
	public GameObject DestroyGameobject;

	[Token(Token = "0x4002F39")]
	[FieldOffset(Offset = "0x40")]
	public bool FailLevelOnBreak;

	[Token(Token = "0x4002F3A")]
	[FieldOffset(Offset = "0x44")]
	public float failDelay;

	[Token(Token = "0x4002F3B")]
	[FieldOffset(Offset = "0x48")]
	public MonoBehaviour[] disableComponentsOnBreak;

	[Token(Token = "0x4002F3C")]
	[FieldOffset(Offset = "0x50")]
	private ObjectShatter shatter;

	[Token(Token = "0x4002F3D")]
	[FieldOffset(Offset = "0x58")]
	private bool hasShattered;

	[Token(Token = "0x4002F3E")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F52C", Offset = "0x4F52C")]
	private Action<IHitscanTarget> OnHitscanHit__BackingField;

	[Token(Token = "0x17000432")]
	public Action<IHitscanTarget> OnHitscanHit
	{
		[Token(Token = "0x60027A7")]
		[Address(RVA = "0x170658C", Offset = "0x170658C", VA = "0x170658C", Slot = "5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66F74", Offset = "0x66F74")]
		get
		{
			return null;
		}
		[Token(Token = "0x60027A8")]
		[Address(RVA = "0x1706594", Offset = "0x1706594", VA = "0x1706594", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66F84", Offset = "0x66F84")]
		set
		{
		}
	}

	[Token(Token = "0x14000037")]
	public event Action OnBreak
	{
		[Token(Token = "0x60027A5")]
		[Address(RVA = "0x1706444", Offset = "0x1706444", VA = "0x1706444")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66F54", Offset = "0x66F54")]
		add
		{
		}
		[Token(Token = "0x60027A6")]
		[Address(RVA = "0x17064E8", Offset = "0x17064E8", VA = "0x17064E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66F64", Offset = "0x66F64")]
		remove
		{
		}
	}

	[Token(Token = "0x60027A9")]
	[Address(RVA = "0x170659C", Offset = "0x170659C", VA = "0x170659C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60027AA")]
	[Address(RVA = "0x1706674", Offset = "0x1706674", VA = "0x1706674")]
	public void ExternalBreak()
	{
	}

	[Token(Token = "0x60027AB")]
	[Address(RVA = "0x1706934", Offset = "0x1706934", VA = "0x1706934", Slot = "4")]
	public void OnHit(Vector3 hit)
	{
	}

	[Token(Token = "0x60027AC")]
	[Address(RVA = "0x17066D0", Offset = "0x17066D0", VA = "0x17066D0")]
	private void Shatter(Vector3 hit)
	{
	}

	[Token(Token = "0x60027AD")]
	[Address(RVA = "0x17069B8", Offset = "0x17069B8", VA = "0x17069B8")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60027AE")]
	[Address(RVA = "0x1706ABC", Offset = "0x1706ABC", VA = "0x1706ABC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60027AF")]
	[Address(RVA = "0x1706B5C", Offset = "0x1706B5C", VA = "0x1706B5C")]
	public BreakableBottle()
	{
	}
}
