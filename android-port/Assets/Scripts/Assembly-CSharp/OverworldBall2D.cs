using System;
using System.Runtime.CompilerServices;
using Chronos;
using Core;
using UnityEngine;

public class OverworldBall2D : GolfBall2DShooterBase
{
	private Action<OverworldBall2D> m_OnDisabled;
	private Action<OverworldBall2D> m_OnDeath;

	public float speed = 15f;
	public LayerMask layers;
	public float minSpeed = 2f;
	public float maxSpeedMultiplier = 1f;
	public float stopThreshold = 0.1f;
	public bool UseMinSpeed;
	public float randomAngularForce;
	public Rigidbody2D rigidBody;
	public RigidbodyTimeline2D rigidTimeline;
	public bool lookInAimDirection;
	public float lookSpeed = 10f;
	public TrailRenderer trail;

	private GolfBallController controller;
	private float startDrag;
	private Vector3 checkPoint;
	protected bool canEnableFlagsAndDoors = true;
	private Timeline timeline;
	private bool didInit;
	private Transform t;
	private OverworldButton2D debugLastHitDoor;

	public Vector3 Velocity
	{
		get => rigidBody != null ? (Vector3)rigidBody.velocity : Vector3.zero;
		set
		{
			if (rigidBody != null) rigidBody.velocity = value;
		}
	}

	public GolfBallController Controller => controller != null ? controller : (controller = GetComponent<GolfBallController>());

	public event Action<OverworldBall2D> OnDisabled
	{
		add => m_OnDisabled = (Action<OverworldBall2D>)Delegate.Combine(m_OnDisabled, value);
		remove => m_OnDisabled = (Action<OverworldBall2D>)Delegate.Remove(m_OnDisabled, value);
	}

	public event Action<OverworldBall2D> OnDeath
	{
		add => m_OnDeath = (Action<OverworldBall2D>)Delegate.Combine(m_OnDeath, value);
		remove => m_OnDeath = (Action<OverworldBall2D>)Delegate.Remove(m_OnDeath, value);
	}

	protected override void Awake()
	{
		base.Awake();
		Init();
	}

	public void Init()
	{
		if (didInit) return;
		didInit = true;
		t = transform;
		checkPoint = transform.position;
		if (rigidBody == null) rigidBody = GetComponent<Rigidbody2D>();
		rigidbodyC = rigidBody;
		controller = GetComponent<GolfBallController>();
		if (controller != null)
		{
			controller.shooter = this;
			controller.OnShoot -= Shooter_OnShoot;
			controller.OnShoot += Shooter_OnShoot;
			controller.OnAimStart -= Controller_OnAimStart;
			controller.OnAimStart += Controller_OnAimStart;
			controller.OnAimUpdate -= Controller_OnAimUpdate;
			controller.OnAimUpdate += Controller_OnAimUpdate;
			controller.OnCancel -= Controller_OnCancel;
			controller.OnCancel += Controller_OnCancel;
		}
	}

	private void Start()
	{
		Init();
	}

	public void ClearTrail()
	{
		if (trail != null) trail.Clear();
	}

	private void OnDisable()
	{
		m_OnDisabled?.Invoke(this);
	}

	protected virtual void Controller_OnCancel() => OnCancel();
	protected virtual void Controller_OnAimStart() => OnAimStart();
	protected virtual void Controller_OnAimUpdate(Vector3 dir, bool arg2) => OnAimUpdate(dir, arg2);

	public void SetEnableFlagsAndDoors() => canEnableFlagsAndDoors = true;
	public bool CheckUseInteractiveThing() => canEnableFlagsAndDoors;
	public bool GetCanEnableFlagsAndDoors() => canEnableFlagsAndDoors;

	private void ResetZ()
	{
		Vector3 p = transform.position;
		p.z = 0f;
		transform.position = p;
	}

	public override void OnShoot(Vector3 boost) => Shooter_OnShoot(boost);

	protected virtual void Shooter_OnShoot(Vector3 dir)
	{
		if (rigidBody == null) rigidBody = GetComponent<Rigidbody2D>();
		if (rigidBody == null) return;
		rigidBody.isKinematic = false;
		rigidBody.WakeUp();
		float s = speed > 0f ? speed : 15f;
		StandardShoot(dir, 0f, UseMinSpeed ? minSpeed : 1f, s * Mathf.Max(0.5f, maxSpeedMultiplier), randomAngularForce);
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
	}

	private void DoCheat() { }
	private void OnTriggerEnter2D(Collider2D other) { }
	public void HitFlag() => StopBall(false);

	public void StopBall(bool disable = true)
	{
		if (rigidBody != null)
		{
			rigidBody.velocity = Vector2.zero;
			rigidBody.angularVelocity = 0f;
		}
		if (disable && controller != null)
			controller.StopAiming();
	}

	public void HideAndStop(bool disable = true)
	{
		StopBall(disable);
		Hide();
	}

	public void Hide() => gameObject.SetActive(false);

	public void Show() => gameObject.SetActive(true);

	public void ShowAndEnable()
	{
		gameObject.SetActive(true);
		if (controller != null) controller.enabled = true;
	}

	public bool ToggleColliders() => true;

	public void SetColliders(bool state)
	{
		foreach (var c in GetComponentsInChildren<Collider2D>(true))
			c.enabled = state;
	}

	private void OnCollisionEnter2D(Collision2D collision) { }

	protected void Death()
	{
		m_OnDeath?.Invoke(this);
	}

	public virtual void OnHiddenByTransition() { }
}
