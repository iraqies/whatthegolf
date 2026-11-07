using System;
using System.Runtime.CompilerServices;
using Chronos;
using Core;
using UnityEngine;

public class OverworldBall2D : GolfBall2DShooterBase
{
	[CompilerGenerated]
	private Action<OverworldBall2D> m_OnDisabled;

	[CompilerGenerated]
	private Action<OverworldBall2D> m_OnDeath;

	public float speed;

	public LayerMask layers;

	public float minSpeed;

	public float maxSpeedMultiplier;

	public float stopThreshold;

	public bool UseMinSpeed;

	public float randomAngularForce;

	public Rigidbody2D rigidBody;

	public RigidbodyTimeline2D rigidTimeline;

	public bool lookInAimDirection;

	public float lookSpeed;

	public TrailRenderer trail;

	private GolfBallController controller;

	private float startDrag;

	private Vector3 checkPoint;

	protected bool canEnableFlagsAndDoors;

	private Timeline timeline;

	private bool didInit;

	private Transform t;

	private OverworldButton2D debugLastHitDoor;

	public Vector3 Velocity
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public GolfBallController Controller => null;

	public event Action<OverworldBall2D> OnDisabled
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<OverworldBall2D> OnDeath
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected override void Awake()
	{
	}

	public void Init()
	{
	}

	private void Start()
	{
	}

	public void ClearTrail()
	{
	}

	private void OnDisable()
	{
	}

	protected virtual void Controller_OnCancel()
	{
	}

	protected virtual void Controller_OnAimStart()
	{
	}

	protected virtual void Controller_OnAimUpdate(Vector3 dir, bool arg2)
	{
	}

	public void SetEnableFlagsAndDoors()
	{
	}

	public bool CheckUseInteractiveThing()
	{
		return false;
	}

	public bool GetCanEnableFlagsAndDoors()
	{
		return false;
	}

	private void ResetZ()
	{
	}

	protected virtual void Shooter_OnShoot(Vector3 dir)
	{
	}

	protected override void FixedUpdate()
	{
	}

	private void DoCheat()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	public void HitFlag()
	{
	}

	public void StopBall(bool disable = true)
	{
	}

	public void HideAndStop(bool disable = true)
	{
	}

	public void Hide()
	{
	}

	public void Show()
	{
	}

	public void ShowAndEnable()
	{
	}

	public bool ToggleColliders()
	{
		return false;
	}

	public void SetColliders(bool state)
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	protected void Death()
	{
	}

	public virtual void OnHiddenByTransition()
	{
	}
}
