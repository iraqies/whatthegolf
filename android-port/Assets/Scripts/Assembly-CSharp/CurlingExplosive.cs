using System;
using System.Runtime.InteropServices;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20001ED")]
public class CurlingExplosive : MonoBehaviour, IAudioEvent
{
	[Token(Token = "0x400092C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A514", Offset = "0x4A514")]
	private Action<Collider, CurlingExplosive> m_OnExplode;

	[Token(Token = "0x400092D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEvent OnExplodeEvent;

	[Token(Token = "0x400092E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public PlayClipOnAudioEvent ExplosionSFX;

	[Token(Token = "0x400092F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool failOnExplode;

	[Token(Token = "0x4000930")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float startCooldown;

	[Token(Token = "0x4000931")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool canExplode;

	[Token(Token = "0x4000932")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ParticleSystem ps;

	[Token(Token = "0x4000933")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float impactThreshold;

	[Token(Token = "0x4000934")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float radius;

	[Token(Token = "0x4000935")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float power;

	[Token(Token = "0x4000936")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Renderer normalRender;

	[Token(Token = "0x4000937")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Renderer burnedRender;

	[Token(Token = "0x4000938")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool screenShake;

	[Token(Token = "0x4000939")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float PlayerBlockDuration;

	[Token(Token = "0x400093A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool DestroyOnExplosion;

	[Token(Token = "0x400093B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	public bool KeepOldVelocity;

	[Token(Token = "0x400093C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float hitObjectExplosionForce;

	[Token(Token = "0x400093D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector3 hitObjectExplosionForceModsMinRange;

	[Token(Token = "0x400093E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public Vector3 hitObjectExplosionForceModsMaxRange;

	[Token(Token = "0x400093F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool applyNormalExplosionToHitObject;

	[Token(Token = "0x4000940")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public LayerMask ignoreLayers;

	[Token(Token = "0x4000941")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool ExplodeOnOutOfBounds;

	[Token(Token = "0x4000942")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	public bool AddRandomAngularVelocity;

	[Token(Token = "0x4000943")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float ignoreTime;

	[Token(Token = "0x4000944")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float startTime;

	[Token(Token = "0x4000945")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public bool didExplode;

	[Token(Token = "0x4000946")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float explosionTime;

	[Token(Token = "0x4000947")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private bool shouldExplode;

	[Token(Token = "0x4000948")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Rigidbody rigid;

	[Token(Token = "0x4000949")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Collider[] nearbyColliders;

	[Token(Token = "0x400094A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Rigidbody[] nearbyRigids;

	[Token(Token = "0x400094B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float allowedExplodeTime;

	[Token(Token = "0x400094C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private bool initialized;

	[Token(Token = "0x400094D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A524", Offset = "0x4A524")]
	private Action<Vector3> OnAudioEvent__BackingField;

	[Token(Token = "0x400094E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private GolfBallController ball;

	[Token(Token = "0x17000119")]
	public Action<Vector3> OnAudioEvent
	{
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x18C4618", Offset = "0x18C4618", VA = "0x18C4618", Slot = "4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F5BC", Offset = "0x5F5BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x18C4620", Offset = "0x18C4620", VA = "0x18C4620", Slot = "5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F5CC", Offset = "0x5F5CC")]
		set
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event Action<Collider, CurlingExplosive> OnExplode
	{
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x18C44D0", Offset = "0x18C44D0", VA = "0x18C44D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F59C", Offset = "0x5F59C")]
		add
		{
		}
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x18C4574", Offset = "0x18C4574", VA = "0x18C4574")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F5AC", Offset = "0x5F5AC")]
		remove
		{
		}
	}

	[Token(Token = "0x60008A5")]
	[Address(RVA = "0x18C4628", Offset = "0x18C4628", VA = "0x18C4628")]
	private void Start()
	{
	}

	[Token(Token = "0x60008A6")]
	[Address(RVA = "0x18C4770", Offset = "0x18C4770", VA = "0x18C4770")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60008A7")]
	[Address(RVA = "0x18C52C0", Offset = "0x18C52C0", VA = "0x18C52C0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60008A8")]
	[Address(RVA = "0x18C53A8", Offset = "0x18C53A8", VA = "0x18C53A8")]
	private void Update()
	{
	}

	[Token(Token = "0x60008A9")]
	[Address(RVA = "0x18C5440", Offset = "0x18C5440", VA = "0x18C5440")]
	public void SetExplosionTimer(float delay)
	{
	}

	[Token(Token = "0x60008AA")]
	[Address(RVA = "0x18C5410", Offset = "0x18C5410", VA = "0x18C5410")]
	public void Explode([Optional] Collider col)
	{
	}

	[Token(Token = "0x60008AB")]
	[Address(RVA = "0x18C48BC", Offset = "0x18C48BC", VA = "0x18C48BC")]
	private void Explode(Vector3 normal, [Optional] Collider col)
	{
	}

	[Token(Token = "0x60008AC")]
	[Address(RVA = "0x18C5480", Offset = "0x18C5480", VA = "0x18C5480")]
	public void Reset()
	{
	}

	[Token(Token = "0x60008AD")]
	[Address(RVA = "0x18C54CC", Offset = "0x18C54CC", VA = "0x18C54CC")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60008AE")]
	[Address(RVA = "0x18C5508", Offset = "0x18C5508", VA = "0x18C5508")]
	public CurlingExplosive()
	{
	}
}
