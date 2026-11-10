using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class GrapplingHookShooter2D : GolfBallShooterExperimental
{
	public GameObject GrapplingHookPrefab;

	public int NumberOfHooks;

	public float GrappleLength = 50f;

	public List<AudioClip> RopeReachedMaxLengthClips;

	public AudioSource CreakAudio;

	public new Rigidbody2D RigidbodyOverride;

	public Collider2D ColliderOverride;

	private List<GrapplingHook2D> hookQueue;

	private int nextHookIndex;

	private GrapplingHook2D lastHook;

	private bool firstShot;

	private bool setAffectTime;

	private Rigidbody2D rigid;

	private bool hooksInitialized;

	private void Start()
	{
		rigid = ((RigidbodyOverride != null) ? RigidbodyOverride : GetComponent<Rigidbody2D>());
		hookQueue = new List<GrapplingHook2D>();
		if (GolfBallController != null && GolfBallController.affectTime)
		{
			setAffectTime = true;
			GolfBallController.affectTime = false;
		}
	}

	public void SetNumberOfHooks(int hooks)
	{
		if (hookQueue != null && hookQueue.Count > 0)
		{
			foreach (GrapplingHook2D item in hookQueue)
			{
				if (item != null && item.gameObject != null)
					UnityEngine.Object.Destroy(item.gameObject);
			}
		}
		hookQueue = new List<GrapplingHook2D>();
		Collider2D collider = ((ColliderOverride != null) ? ColliderOverride : GetComponent<Collider2D>());
		for (int i = 0; i < hooks; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(GrapplingHookPrefab);
			if (base.gameObject.scene.IsValid() && gameObject.scene != base.gameObject.scene)
				UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(gameObject, base.gameObject.scene);
			if (gameObject.TryGetComponent<HookAudio>(out var component))
			{
				component.SetController(GolfBallController);
			}
			Collider2D componentInChildren = gameObject.GetComponentInChildren<Collider2D>();
			Physics2D.IgnoreCollision(collider, componentInChildren, ignore: true);
			GrapplingHook2D component2 = gameObject.GetComponent<GrapplingHook2D>();
			component2.Init();
			component2.OnCollided = (Action<Rigidbody2D>)Delegate.Combine(component2.OnCollided, new Action<Rigidbody2D>(OnCollided));
			hookQueue.Add(component2);
		}
		hooksInitialized = true;
	}

	private void OnCollided(Rigidbody2D rigid)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
		if (!hooksInitialized)
		{
			SetNumberOfHooks(NumberOfHooks);
		}
		lastHook = hookQueue[nextHookIndex];
		lastHook.SetOrigin(base.transform.position);
		lastHook.FireHook(base.transform.position, boost, rigid.velocity, GrappleLength);
		nextHookIndex = (nextHookIndex + 1) % hookQueue.Count;
		if (setAffectTime && GolfBallController != null)
		{
			GolfBallController.affectTime = true;
			setAffectTime = false;
		}
	}

	private void Update()
	{
		bool flag = false;
		foreach (GrapplingHook2D item in hookQueue)
		{
			if (item.gameObject.activeSelf && item.GetRopeLength() > GrappleLength)
			{
				item.gameObject.SetActive(value: false);
				AudioManager.Instance.AudioSources.Play(RopeReachedMaxLengthClips);
			}
			flag |= item.HasHitSomething;
		}
		CreakAudio.enabled = flag;
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Vector2 zero = Vector3.zero;
		foreach (GrapplingHook2D item in hookQueue)
		{
			if (item.gameObject.activeSelf)
			{
				item.MoveHook();
			}
			if (item.HasHitSomething)
			{
				GrapplingHook2D.RopeJoint pullPoint = item.GetPullPoint();
				zero += (pullPoint.Point + pullPoint.Normal - (Vector2)base.transform.position).normalized * item.PullStrength;
			}
		}
		if (zero != Vector2.zero)
		{
			rigid.AddForce(zero);
		}
	}

	public void LateUpdate()
	{
		foreach (GrapplingHook2D item in hookQueue)
		{
			item.SetOrigin(base.transform.position);
		}
	}

	public override void OnReset()
	{
		base.OnReset();
		rigid.velocity = Vector3.zero;
		rigid.angularVelocity = 0f;
		foreach (GrapplingHook2D item in hookQueue)
		{
			item.gameObject.SetActive(value: false);
		}
	}

	private void EnteredPortal(PortalPackage package)
	{
		foreach (GrapplingHook2D item in hookQueue)
		{
			if (item.gameObject.activeSelf)
			{
				item.OriginEnteredPortal(package);
			}
		}
	}

	private void OnDrawGizmosSelected()
	{
		foreach (GrapplingHook2D item in hookQueue)
		{
			if (item.gameObject.activeSelf)
			{
				item.MoveHook();
			}
			if (item.HasHitSomething)
			{
				GrapplingHook2D.RopeJoint pullPoint = item.GetPullPoint();
				Gizmos.DrawSphere(pullPoint.Point, 1f);
			}
		}
	}

	private void OnDestroy()
	{
		if (hookQueue == null)
			return;
		foreach (GrapplingHook2D item in hookQueue)
		{
			if (item != null && item.gameObject != null)
				UnityEngine.Object.Destroy(item.gameObject);
		}
	}
}
