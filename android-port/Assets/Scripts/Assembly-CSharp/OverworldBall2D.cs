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
	public float minSpeed = 1f;
	public float maxSpeedMultiplier = 2f;
	public float stopThreshold = 2f;
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
		rigidBody = GetComponent<Rigidbody2D>();
		trail = GetComponentInChildren<TrailRenderer>();
		Init();
	}

	public void Init()
	{
		if (didInit) return;
		didInit = true;
		t = transform;
		checkPoint = transform.position;
		timeline = GetComponent<Timeline>();
		if (rigidBody == null) rigidBody = GetComponent<Rigidbody2D>();
		rigidbodyC = rigidBody;
		if (rigidBody != null)
			startDrag = rigidBody.drag;
		controller = GetComponent<GolfBallController>();
		if (controller != null)
		{
			controller.shooter = this;
			controller.OnShoot -= OnShoot;
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
		if (!didInit) Init();
	}

	public void ClearTrail()
	{
		if (trail != null) trail.Clear();
	}

	private void OnDisable()
	{
		m_OnDisabled?.Invoke(this);
	}

	protected virtual void Controller_OnCancel() { }
	protected virtual void Controller_OnAimStart() { }

	protected virtual void Controller_OnAimUpdate(Vector3 dir, bool arg2)
	{
		if (lookInAimDirection && rigidbodyC != null && dir.sqrMagnitude > 1e-4f)
		{
			Vector2 n = new Vector2(dir.x, dir.y).normalized;
			float angle = Vector2.SignedAngle( n, transform.up);
			rigidbodyC.angularVelocity = angle * lookSpeed * Time.deltaTime;
		}
	}

	public void SetEnableFlagsAndDoors() => canEnableFlagsAndDoors = true;

	public bool CheckUseInteractiveThing()
	{
		bool res = canEnableFlagsAndDoors;
		if (res) canEnableFlagsAndDoors = false;
		return res;
	}

	public bool GetCanEnableFlagsAndDoors() => canEnableFlagsAndDoors;

	private void ResetZ()
	{
		if (t == null) t = transform;
		Vector3 p = t.position;
		p.z = 0f;
		t.position = p;
	}

	public override void OnShoot(Vector3 boost) => Shooter_OnShoot(boost);

	protected virtual void Shooter_OnShoot(Vector3 dir)
	{
		ResetZ();
		if (rigidBody == null) rigidBody = GetComponent<Rigidbody2D>();
		if (rigidBody == null) return;
		rigidBody.isKinematic = false;
		rigidBody.simulated = true;
		rigidBody.WakeUp();
		float mag = Mathf.Clamp01(dir.magnitude);
		if (mag <= 1e-4f) return;
		float targetSpeed = Mathf.Lerp(minSpeed > 0f ? minSpeed : 1f, speed > 0f ? speed : 15f, mag);
		Vector2 n = new Vector2(dir.x, dir.y);
		if (n.sqrMagnitude < 1e-4f)
			n = new Vector2(dir.x, dir.z);
		n.Normalize();
		rigidBody.velocity = n * targetSpeed;
		if (Mathf.Abs(randomAngularForce) > 0.001f)
			rigidBody.angularVelocity = UnityEngine.Random.Range(-randomAngularForce, randomAngularForce);
		canEnableFlagsAndDoors = true;
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (rigidBody == null) return;
		float mag = rigidBody.velocity.magnitude;
		if (mag < stopThreshold)
		{
			float dt = Time.fixedDeltaTime;
			rigidBody.velocity *= Mathf.Max(0f, 1f - 3f * dt);
		}
		if (rigidBody.velocity.magnitude < 0.1f)
		{
			rigidBody.velocity *= 0.1f;
		}
	}

	private void DoCheat() { }

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other != null && other.CompareTag("OutOfBounds"))
		{
			if (rigidBody != null)
			{
				rigidBody.velocity = Vector2.zero;
				rigidBody.angularVelocity = 0f;
			}
			ResetZ();
			transform.position = checkPoint;
		}
	}

	public void HitFlag()
	{
		ResetZ();
		if (rigidBody != null)
		{
			rigidBody.isKinematic = true;
			rigidBody.velocity = Vector2.zero;
			rigidBody.angularVelocity = 0f;
		}
		if (controller != null)
			controller.StopAiming();
	}

	public void StopBall(bool disable = true)
	{
		if (!gameObject.activeInHierarchy) return;
		ResetZ();
		if (rigidBody != null)
		{
			rigidBody.isKinematic = true;
			rigidBody.velocity = Vector2.zero;
			rigidBody.angularVelocity = 0f;
		}
		if (controller != null)
			controller.CancelShooting();
		if (disable)
			gameObject.SetActive(false);
	}

	public void HideAndStop(bool disable = true)
	{
		StopBall(disable);
		Hide();
	}

	public void Hide()
	{
		foreach (var r in GetComponentsInChildren<Renderer>(true))
		{
			if (r != null) r.enabled = false;
		}
		ClearTrail();
	}

	public void Show()
	{
		foreach (var r in GetComponentsInChildren<Renderer>(true))
		{
			if (r != null) r.enabled = true;
		}
		ClearTrail();
		ResetZ();
	}

	public void ShowAndEnable()
	{
		if (!didInit) Init();
		gameObject.SetActive(true);
		if (rigidBody != null)
		{
			rigidBody.isKinematic = false;
			rigidBody.simulated = true;
			rigidBody.velocity = Vector2.zero;
			rigidBody.angularVelocity = 0f;
			if (startDrag > 0f)
				rigidBody.drag = startDrag;
		}
		canEnableFlagsAndDoors = false;
		if (controller != null)
			controller.enabled = true;
		ResetZ();
		Show();
	}

	public bool ToggleColliders()
	{
		bool last = false;
		foreach (var c in GetComponentsInChildren<Collider2D>(true))
		{
			if (c != null)
			{
				c.enabled = !c.enabled;
				last = c.enabled;
			}
		}
		return last;
	}

	public void SetColliders(bool state)
	{
		foreach (var c in GetComponentsInChildren<Collider2D>(true))
		{
			if (c != null) c.enabled = state;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision) { }

	protected void Death()
	{
		m_OnDeath?.Invoke(this);
	}

	public virtual void OnHiddenByTransition() { }
}
