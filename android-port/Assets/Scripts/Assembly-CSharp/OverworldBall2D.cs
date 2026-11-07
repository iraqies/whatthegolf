using System;
using Chronos;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009DF")]
public class OverworldBall2D : GolfBall2DShooterBase
{
	[Token(Token = "0x4003633")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5002C", Offset = "0x5002C")]
	private Action<OverworldBall2D> m_OnDisabled;

	[Token(Token = "0x4003634")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5003C", Offset = "0x5003C")]
	private Action<OverworldBall2D> m_OnDeath;

	[Token(Token = "0x4003635")]
	[FieldOffset(Offset = "0x58")]
	public float speed;

	[Token(Token = "0x4003636")]
	[FieldOffset(Offset = "0x5C")]
	public LayerMask layers;

	[Token(Token = "0x4003637")]
	[FieldOffset(Offset = "0x60")]
	public float minSpeed;

	[Token(Token = "0x4003638")]
	[FieldOffset(Offset = "0x64")]
	public float maxSpeedMultiplier;

	[Token(Token = "0x4003639")]
	[FieldOffset(Offset = "0x68")]
	public float stopThreshold;

	[Token(Token = "0x400363A")]
	[FieldOffset(Offset = "0x6C")]
	public bool UseMinSpeed;

	[Token(Token = "0x400363B")]
	[FieldOffset(Offset = "0x70")]
	public float randomAngularForce;

	[Token(Token = "0x400363C")]
	[FieldOffset(Offset = "0x78")]
	public Rigidbody2D rigidBody;

	[Token(Token = "0x400363D")]
	[FieldOffset(Offset = "0x80")]
	public RigidbodyTimeline2D rigidTimeline;

	[Token(Token = "0x400363E")]
	[FieldOffset(Offset = "0x88")]
	public bool lookInAimDirection;

	[Token(Token = "0x400363F")]
	[FieldOffset(Offset = "0x8C")]
	public float lookSpeed;

	[Token(Token = "0x4003640")]
	[FieldOffset(Offset = "0x90")]
	public TrailRenderer trail;

	[Token(Token = "0x4003641")]
	[FieldOffset(Offset = "0x98")]
	private GolfBallController controller;

	[Token(Token = "0x4003642")]
	[FieldOffset(Offset = "0xA0")]
	private float startDrag;

	[Token(Token = "0x4003643")]
	[FieldOffset(Offset = "0xA4")]
	private Vector3 checkPoint;

	[Token(Token = "0x4003644")]
	[FieldOffset(Offset = "0xB0")]
	protected bool canEnableFlagsAndDoors;

	[Token(Token = "0x4003645")]
	[FieldOffset(Offset = "0xB8")]
	private Timeline timeline;

	[Token(Token = "0x4003646")]
	[FieldOffset(Offset = "0xC0")]
	private bool didInit;

	[Token(Token = "0x4003647")]
	[FieldOffset(Offset = "0xC8")]
	private Transform t;

	[Token(Token = "0x4003648")]
	[FieldOffset(Offset = "0xD0")]
	private OverworldButton2D debugLastHitDoor;

	[Token(Token = "0x170004C9")]
	public Vector3 Velocity
	{
		[Token(Token = "0x6002E9A")]
		[Address(RVA = "0x15A33AC", Offset = "0x15A33AC", VA = "0x15A33AC")]
		get
		{
			return default;
		}
		[Token(Token = "0x6002E99")]
		[Address(RVA = "0x15A3390", Offset = "0x15A3390", VA = "0x15A3390")]
		set
		{
		}
	}

	[Token(Token = "0x170004CA")]
	public GolfBallController Controller
	{
		[Token(Token = "0x6002E9B")]
		[Address(RVA = "0x15A33D4", Offset = "0x15A33D4", VA = "0x15A33D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000053")]
	public event Action<OverworldBall2D> OnDisabled
	{
		[Token(Token = "0x6002E7C")]
		[Address(RVA = "0x15A1FCC", Offset = "0x15A1FCC", VA = "0x15A1FCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68A58", Offset = "0x68A58")]
		add
		{
		}
		[Token(Token = "0x6002E7D")]
		[Address(RVA = "0x15A2070", Offset = "0x15A2070", VA = "0x15A2070")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68A68", Offset = "0x68A68")]
		remove
		{
		}
	}

	[Token(Token = "0x14000054")]
	public event Action<OverworldBall2D> OnDeath
	{
		[Token(Token = "0x6002E7E")]
		[Address(RVA = "0x15A2114", Offset = "0x15A2114", VA = "0x15A2114")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68A78", Offset = "0x68A78")]
		add
		{
		}
		[Token(Token = "0x6002E7F")]
		[Address(RVA = "0x15A21B8", Offset = "0x15A21B8", VA = "0x15A21B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68A88", Offset = "0x68A88")]
		remove
		{
		}
	}

	[Token(Token = "0x6002E80")]
	[Address(RVA = "0x15A225C", Offset = "0x15A225C", VA = "0x15A225C", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002E81")]
	[Address(RVA = "0x15A22E8", Offset = "0x15A22E8", VA = "0x15A22E8")]
	public void Init()
	{
	}

	[Token(Token = "0x6002E82")]
	[Address(RVA = "0x15A25EC", Offset = "0x15A25EC", VA = "0x15A25EC")]
	private void Start()
	{
	}

	[Token(Token = "0x6002E83")]
	[Address(RVA = "0x15A25FC", Offset = "0x15A25FC", VA = "0x15A25FC")]
	public void ClearTrail()
	{
	}

	[Token(Token = "0x6002E84")]
	[Address(RVA = "0x15A26A0", Offset = "0x15A26A0", VA = "0x15A26A0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6002E85")]
	[Address(RVA = "0x15A2700", Offset = "0x15A2700", VA = "0x15A2700", Slot = "14")]
	protected virtual void Controller_OnCancel()
	{
	}

	[Token(Token = "0x6002E86")]
	[Address(RVA = "0x15A2704", Offset = "0x15A2704", VA = "0x15A2704", Slot = "15")]
	protected virtual void Controller_OnAimStart()
	{
	}

	[Token(Token = "0x6002E87")]
	[Address(RVA = "0x15A2708", Offset = "0x15A2708", VA = "0x15A2708", Slot = "16")]
	protected virtual void Controller_OnAimUpdate(Vector3 dir, bool arg2)
	{
	}

	[Token(Token = "0x6002E88")]
	[Address(RVA = "0x15A27BC", Offset = "0x15A27BC", VA = "0x15A27BC")]
	public void SetEnableFlagsAndDoors()
	{
	}

	[Token(Token = "0x6002E89")]
	[Address(RVA = "0x15A27C8", Offset = "0x15A27C8", VA = "0x15A27C8")]
	public bool CheckUseInteractiveThing()
	{
		return default;
	}

	[Token(Token = "0x6002E8A")]
	[Address(RVA = "0x15A27E0", Offset = "0x15A27E0", VA = "0x15A27E0")]
	public bool GetCanEnableFlagsAndDoors()
	{
		return default;
	}

	[Token(Token = "0x6002E8B")]
	[Address(RVA = "0x15A27E8", Offset = "0x15A27E8", VA = "0x15A27E8")]
	private void ResetZ()
	{
	}

	[Token(Token = "0x6002E8C")]
	[Address(RVA = "0x15A2828", Offset = "0x15A2828", VA = "0x15A2828", Slot = "17")]
	protected virtual void Shooter_OnShoot(Vector3 dir)
	{
	}

	[Token(Token = "0x6002E8D")]
	[Address(RVA = "0x15A2968", Offset = "0x15A2968", VA = "0x15A2968", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6002E8E")]
	[Address(RVA = "0x15A2B74", Offset = "0x15A2B74", VA = "0x15A2B74")]
	private void DoCheat()
	{
	}

	[Token(Token = "0x6002E8F")]
	[Address(RVA = "0x15A2BDC", Offset = "0x15A2BDC", VA = "0x15A2BDC")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6002E90")]
	[Address(RVA = "0x15A2CC8", Offset = "0x15A2CC8", VA = "0x15A2CC8")]
	public void HitFlag()
	{
	}

	[Token(Token = "0x6002E91")]
	[Address(RVA = "0x15A2D6C", Offset = "0x15A2D6C", VA = "0x15A2D6C")]
	public void StopBall(bool disable = true)
	{
	}

	[Token(Token = "0x6002E92")]
	[Address(RVA = "0x15A2E54", Offset = "0x15A2E54", VA = "0x15A2E54")]
	public void HideAndStop(bool disable = true)
	{
	}

	[Token(Token = "0x6002E93")]
	[Address(RVA = "0x15A2E78", Offset = "0x15A2E78", VA = "0x15A2E78")]
	public void Hide()
	{
	}

	[Token(Token = "0x6002E94")]
	[Address(RVA = "0x15A2F2C", Offset = "0x15A2F2C", VA = "0x15A2F2C")]
	public void Show()
	{
	}

	[Token(Token = "0x6002E95")]
	[Address(RVA = "0x15A3004", Offset = "0x15A3004", VA = "0x15A3004")]
	public void ShowAndEnable()
	{
	}

	[Token(Token = "0x6002E96")]
	[Address(RVA = "0x15A3110", Offset = "0x15A3110", VA = "0x15A3110")]
	public bool ToggleColliders()
	{
		return default;
	}

	[Token(Token = "0x6002E97")]
	[Address(RVA = "0x15A31E8", Offset = "0x15A31E8", VA = "0x15A31E8")]
	public void SetColliders(bool state)
	{
	}

	[Token(Token = "0x6002E98")]
	[Address(RVA = "0x15A32A0", Offset = "0x15A32A0", VA = "0x15A32A0")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6002E9C")]
	[Address(RVA = "0x15A33DC", Offset = "0x15A33DC", VA = "0x15A33DC")]
	protected void Death()
	{
	}

	[Token(Token = "0x6002E9D")]
	[Address(RVA = "0x15A343C", Offset = "0x15A343C", VA = "0x15A343C", Slot = "18")]
	public virtual void OnHiddenByTransition()
	{
	}

	[Token(Token = "0x6002E9E")]
	[Address(RVA = "0x15A3440", Offset = "0x15A3440", VA = "0x15A3440")]
	public OverworldBall2D()
	{
	}
}
