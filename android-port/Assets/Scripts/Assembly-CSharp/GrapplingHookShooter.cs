using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class GrapplingHookShooter : GolfBallShooterExperimental
{
	public GameObject GrapplingHookPrefab;

	public int NumberOfHooks;

	public float GrappleLength = 50f;

	public float ObjectThrowSpeed = 10f;

	public Vector3 forceShot;

	[SerializeField]
	private float pullMinDistance = 3f;

	public List<AudioClip> RopeReachedMaxLengthClips;

	public AudioSource CreakAudio;

	private List<GrapplingHook> hookQueue;

	private int nextHookIndex;

	private GrapplingHook lastHook;

	private bool firstShot;

	private bool setAffectTime;

	private void Start()
	{
		hookQueue = new List<GrapplingHook>(NumberOfHooks);
		Collider component = GetComponent<Collider>();
		for (int i = 0; i < NumberOfHooks; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(GrapplingHookPrefab);
			Physics.IgnoreCollision(component, gameObject.GetComponent<Collider>(), ignore: true);
			GrapplingHook component2 = gameObject.GetComponent<GrapplingHook>();
			component2.Init();
			component2.OnCollided = (Action<Rigidbody>)Delegate.Combine(component2.OnCollided, new Action<Rigidbody>(OnCollided));
			hookQueue.Add(component2);
		}
		if (GolfBallController != null && GolfBallController.affectTime)
		{
			setAffectTime = true;
			GolfBallController.affectTime = false;
		}
	}

	private void OnCollided(Rigidbody rigid)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
		if (lastHook != null && lastHook.DraggingObject != null)
		{
			lastHook.DraggingObject.velocity = boost * ObjectThrowSpeed;
			lastHook.gameObject.SetActive(value: false);
		}
		else
		{
			lastHook = hookQueue[nextHookIndex];
			lastHook.SetOrigin(base.transform.position);
			lastHook.FireHook(base.transform.position, boost, Rigid.velocity, GrappleLength);
			nextHookIndex = (nextHookIndex + 1) % hookQueue.Count;
		}
		if (setAffectTime && GolfBallController != null)
		{
			GolfBallController.affectTime = true;
			setAffectTime = false;
		}
	}

	private void Update()
	{
		bool flag = false;
		foreach (GrapplingHook item in hookQueue)
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
		Vector3 zero = Vector3.zero;
		Vector3 zero2 = Vector3.zero;
		float num = 0f;
		foreach (GrapplingHook item in hookQueue)
		{
			if (item.gameObject.activeSelf)
			{
				item.MoveHook();
			}
			if (item.HasHitSomething)
			{
				if (item.DraggingObject == null)
				{
					GrapplingHook.RopeJoint pullPoint = item.GetPullPoint();
					zero += (pullPoint.Point + pullPoint.Normal - base.transform.position).normalized * item.PullStrength;
				}
				num = item.GetRopeLength();
			}
		}
		if (zero != Vector3.zero)
		{
			float d = Mathf.Clamp01(num / pullMinDistance);
			Rigid.AddForce(zero * d);
		}
	}

	public void LateUpdate()
	{
		foreach (GrapplingHook item in hookQueue)
		{
			item.SetOrigin(base.transform.position);
		}
	}

	public override void OnReset()
	{
		base.OnReset();
		Rigid.velocity = Vector3.zero;
		Rigid.angularVelocity = Vector3.zero;
		foreach (GrapplingHook item in hookQueue)
		{
			item.gameObject.SetActive(value: false);
		}
	}

	private void EnteredPortal(PortalPackage package)
	{
		foreach (GrapplingHook item in hookQueue)
		{
			if (item.gameObject.activeSelf)
			{
				item.OriginEnteredPortal(package);
			}
		}
	}
}
