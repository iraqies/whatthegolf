using System;
using System.Runtime.InteropServices;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000B00")]
public class ExplosionBarrel : MonoBehaviour, IAudioEvent
{
	[Token(Token = "0x4003D43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50738", Offset = "0x50738")]
	private Action<Collider, ExplosionBarrel> m_OnExplode;

	[Token(Token = "0x4003D44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEvent OnExplodeEvent;

	[Token(Token = "0x4003D45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public PlayClipOnAudioEvent ExplosionSFX;

	[Token(Token = "0x4003D46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float startCooldown;

	[Token(Token = "0x4003D47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool canExplode;

	[Token(Token = "0x4003D48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ParticleSystem ps;

	[Token(Token = "0x4003D49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float impactThreshold;

	[Token(Token = "0x4003D4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float radius;

	[Token(Token = "0x4003D4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float power;

	[Token(Token = "0x4003D4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Renderer normalRender;

	[Token(Token = "0x4003D4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Renderer burnedRender;

	[Token(Token = "0x4003D4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool screenShake;

	[Token(Token = "0x4003D4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float PlayerBlockDuration;

	[Token(Token = "0x4003D50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool DestroyOnExplosion;

	[Token(Token = "0x4003D51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool KeepOldVelocity;

	[Token(Token = "0x4003D52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float hitObjectExplosionForce;

	[Token(Token = "0x4003D53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Vector3 hitObjectExplosionForceModsMinRange;

	[Token(Token = "0x4003D54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Vector3 hitObjectExplosionForceModsMaxRange;

	[Token(Token = "0x4003D55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool applyNormalExplosionToHitObject;

	[Token(Token = "0x4003D56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public LayerMask ignoreLayers;

	[Token(Token = "0x4003D57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool ExplodeOnOutOfBounds;

	[Token(Token = "0x4003D58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	public bool AddRandomAngularVelocity;

	[Token(Token = "0x4003D59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float ignoreTime;

	[Token(Token = "0x4003D5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float startTime;

	[Token(Token = "0x4003D5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool didExplode;

	[Token(Token = "0x4003D5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float explosionTime;

	[Token(Token = "0x4003D5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private bool shouldExplode;

	[Token(Token = "0x4003D5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Rigidbody rigid;

	[Token(Token = "0x4003D5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Collider[] nearbyColliders;

	[Token(Token = "0x4003D60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Rigidbody[] nearbyRigids;

	[Token(Token = "0x4003D61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float allowedExplodeTime;

	[Token(Token = "0x4003D62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private bool initialized;

	[Token(Token = "0x4003D63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50748", Offset = "0x50748")]
	private Action<Vector3> OnAudioEvent__BackingField;

	[Token(Token = "0x4003D64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private GolfBallController ball;

	[Token(Token = "0x17000562")]
	public Action<Vector3> OnAudioEvent
	{
		[Token(Token = "0x600346E")]
		[Address(RVA = "0x1451110", Offset = "0x1451110", VA = "0x1451110", Slot = "4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A768", Offset = "0x6A768")]
		get
		{
			return null;
		}
		[Token(Token = "0x600346F")]
		[Address(RVA = "0x1451118", Offset = "0x1451118", VA = "0x1451118", Slot = "5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A778", Offset = "0x6A778")]
		set
		{
		}
	}

	[Token(Token = "0x1400006F")]
	public event Action<Collider, ExplosionBarrel> OnExplode
	{
		[Token(Token = "0x600346C")]
		[Address(RVA = "0x144E6D4", Offset = "0x144E6D4", VA = "0x144E6D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A748", Offset = "0x6A748")]
		add
		{
		}
		[Token(Token = "0x600346D")]
		[Address(RVA = "0x145106C", Offset = "0x145106C", VA = "0x145106C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A758", Offset = "0x6A758")]
		remove
		{
		}
	}

	[Token(Token = "0x6003470")]
	[Address(RVA = "0x1451120", Offset = "0x1451120", VA = "0x1451120")]
	private void Start()
	{
	}

	[Token(Token = "0x6003471")]
	[Address(RVA = "0x1451268", Offset = "0x1451268", VA = "0x1451268")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6003472")]
	[Address(RVA = "0x1451D6C", Offset = "0x1451D6C", VA = "0x1451D6C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003473")]
	[Address(RVA = "0x1451E54", Offset = "0x1451E54", VA = "0x1451E54")]
	private void Update()
	{
	}

	[Token(Token = "0x6003474")]
	[Address(RVA = "0x1451EEC", Offset = "0x1451EEC", VA = "0x1451EEC")]
	public void SetExplosionTimer(float delay)
	{
	}

	[Token(Token = "0x6003475")]
	[Address(RVA = "0x1451F2C", Offset = "0x1451F2C", VA = "0x1451F2C")]
	public void CanExplode()
	{
	}

	[Token(Token = "0x6003476")]
	[Address(RVA = "0x1451EBC", Offset = "0x1451EBC", VA = "0x1451EBC")]
	public void Explode([Optional] Collider col)
	{
	}

	[Token(Token = "0x6003477")]
	[Address(RVA = "0x14513B4", Offset = "0x14513B4", VA = "0x14513B4")]
	private void Explode(Vector3 normal, [Optional] Collider col)
	{
	}

	[Token(Token = "0x6003478")]
	[Address(RVA = "0x1451F38", Offset = "0x1451F38", VA = "0x1451F38")]
	public void Reset()
	{
	}

	[Token(Token = "0x6003479")]
	[Address(RVA = "0x1451F84", Offset = "0x1451F84", VA = "0x1451F84")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600347A")]
	[Address(RVA = "0x1451FC0", Offset = "0x1451FC0", VA = "0x1451FC0")]
	public ExplosionBarrel()
	{
	}
}
