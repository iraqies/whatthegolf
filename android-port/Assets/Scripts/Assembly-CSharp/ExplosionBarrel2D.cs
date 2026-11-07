using System;
using System.Runtime.InteropServices;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B01")]
public class ExplosionBarrel2D : MonoBehaviour, IAudioEvent
{
	[Token(Token = "0x4003D65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool canExplode;

	[Token(Token = "0x4003D66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleSystem ps;

	[Token(Token = "0x4003D67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float impactThreshold;

	[Token(Token = "0x4003D68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float radius;

	[Token(Token = "0x4003D69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float power;

	[Token(Token = "0x4003D6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float extraUpPower;

	[Token(Token = "0x4003D6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Renderer normalRender;

	[Token(Token = "0x4003D6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Renderer burnedRender;

	[Token(Token = "0x4003D6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool screenShake;

	[Token(Token = "0x4003D6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float PlayerBlockDuration;

	[Token(Token = "0x4003D6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool DestroyOnExplosion;

	[Token(Token = "0x4003D70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public LayerMask ExplosionTriggerLayers;

	[Token(Token = "0x4003D71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50758", Offset = "0x50758")]
	private Action<Collider2D> m_OnExplode;

	[Token(Token = "0x4003D72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool SetVelocityInsteadOfAddForce;

	[Token(Token = "0x4003D73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool UseTrigger;

	[Token(Token = "0x4003D74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float ignoreTime;

	[Token(Token = "0x4003D75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float startTime;

	[Token(Token = "0x4003D76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool didExplode;

	[Token(Token = "0x4003D77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float explosionTime;

	[Token(Token = "0x4003D78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private bool shouldExplode;

	[Token(Token = "0x4003D79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Rigidbody2D rigid;

	[Token(Token = "0x4003D7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Collider2D[] nearbyColliders;

	[Token(Token = "0x4003D7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Rigidbody2D[] nearbyRigids;

	[Token(Token = "0x4003D7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool initialized;

	[Token(Token = "0x4003D7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50768", Offset = "0x50768")]
	private Action<Vector3> OnAudioEvent__BackingField;

	[Token(Token = "0x4003D7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Explosion2D m_Explosion2D;

	[Token(Token = "0x4003D7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float ExplosionMagnitude;

	[Token(Token = "0x4003D80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public bool OnlyActivatedByBall;

	[Token(Token = "0x17000563")]
	public Action<Vector3> OnAudioEvent
	{
		[Token(Token = "0x600347D")]
		[Address(RVA = "0x14520C8", Offset = "0x14520C8", VA = "0x14520C8", Slot = "4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A7A8", Offset = "0x6A7A8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600347E")]
		[Address(RVA = "0x14520D0", Offset = "0x14520D0", VA = "0x14520D0", Slot = "5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A7B8", Offset = "0x6A7B8")]
		set
		{
		}
	}

	[Token(Token = "0x14000070")]
	public event Action<Collider2D> OnExplode
	{
		[Token(Token = "0x600347B")]
		[Address(RVA = "0x144F658", Offset = "0x144F658", VA = "0x144F658")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A788", Offset = "0x6A788")]
		add
		{
		}
		[Token(Token = "0x600347C")]
		[Address(RVA = "0x1452024", Offset = "0x1452024", VA = "0x1452024")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A798", Offset = "0x6A798")]
		remove
		{
		}
	}

	[Token(Token = "0x600347F")]
	[Address(RVA = "0x14520D8", Offset = "0x14520D8", VA = "0x14520D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003480")]
	[Address(RVA = "0x1452148", Offset = "0x1452148", VA = "0x1452148")]
	private void Start()
	{
	}

	[Token(Token = "0x6003481")]
	[Address(RVA = "0x145226C", Offset = "0x145226C", VA = "0x145226C")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6003482")]
	[Address(RVA = "0x1452BAC", Offset = "0x1452BAC", VA = "0x1452BAC")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6003483")]
	[Address(RVA = "0x1452D94", Offset = "0x1452D94", VA = "0x1452D94")]
	private void Update()
	{
	}

	[Token(Token = "0x6003484")]
	[Address(RVA = "0x1452E30", Offset = "0x1452E30", VA = "0x1452E30")]
	private void SetExplosionTimer(float delay)
	{
	}

	[Token(Token = "0x6003485")]
	[Address(RVA = "0x1450334", Offset = "0x1450334", VA = "0x1450334")]
	public void Explode([Optional] Collider2D col)
	{
	}

	[Token(Token = "0x6003486")]
	[Address(RVA = "0x1452378", Offset = "0x1452378", VA = "0x1452378")]
	private void Explode(Vector2 contact, Vector2 normal, [Optional] Collider2D col)
	{
	}

	[Token(Token = "0x6003487")]
	[Address(RVA = "0x1452F24", Offset = "0x1452F24", VA = "0x1452F24")]
	public void DestroyAfterExplosion()
	{
	}

	[Token(Token = "0x6003488")]
	[Address(RVA = "0x1452E70", Offset = "0x1452E70", VA = "0x1452E70")]
	public void SetBurnedRenders()
	{
	}

	[Token(Token = "0x6003489")]
	[Address(RVA = "0x1453080", Offset = "0x1453080", VA = "0x1453080")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600348A")]
	[Address(RVA = "0x14530BC", Offset = "0x14530BC", VA = "0x14530BC")]
	public void SendOnExplodeEvent()
	{
	}

	[Token(Token = "0x600348B")]
	[Address(RVA = "0x145311C", Offset = "0x145311C", VA = "0x145311C")]
	public ExplosionBarrel2D()
	{
	}
}
