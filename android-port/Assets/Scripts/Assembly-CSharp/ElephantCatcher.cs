using CameraStack;
using Core;
using UnityEngine;

public class ElephantCatcher : GolfBallShooterBase
{
	public Transform CatcherRoot;

	public Rigidbody CatcherRagdoolRoot;

	public float MoveForce;

	public float MoveDuration;

	public AnimationCurve DampenCurve;

	public Transform Elephant;

	public float RotateSpeed = 30f;

	public Rigidbody elephantRoot;

	public float minShotVelocity = 20f;

	public float shotVelocity = 900f;

	public float pitch = 20f;

	public float spin = 6000f;

	public Transform ElephantEntry;

	public Rigidbody ElephantMountain;

	public ParticleSystem Particles;

	public Transform Car;

	private Vector3 currentDirection;

	private float moveTimer;

	private bool aiming;

	private bool hasBrokenFree;

	private Vector3 catcherStartPos;

	private Vector3 elephantStartPos;

	private Coroutine elephantEntryRoutine;

	private void Start()
	{
		if (CatcherRoot == null)
		{
			return;
		}
		rigidbodyC = CatcherRoot.GetComponent<Rigidbody>();
		Rigidbody[] componentsInChildren = CatcherRoot.GetComponentsInChildren<Rigidbody>();
		if (componentsInChildren != null)
		{
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				Rigidbody rigidbody = componentsInChildren[i];
				if (rigidbody != null)
				{
					rigidbody.isKinematic = true;
					rigidbody.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
					Collider component = rigidbody.gameObject.GetComponent<Collider>();
					if (component != null)
					{
						component.enabled = false;
					}
				}
			}
		}
		if (rigidbodyC != null)
		{
			rigidbodyC.isKinematic = false;
			rigidbodyC.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
		}
		Collider component2 = CatcherRoot.GetComponent<Collider>();
		if (component2 != null)
		{
			component2.enabled = true;
		}
		if (Elephant != null)
		{
			elephantStartPos = Elephant.transform.position;
		}
		catcherStartPos = CatcherRoot.transform.position;
	}

	public override void OnShoot(Vector3 boost)
	{
		if (hasBrokenFree)
		{
			StandardShoot(boost, pitch, minShotVelocity, shotVelocity, spin);
			return;
		}
		base.OnShoot(boost);
		currentDirection = boost;
		moveTimer = MoveDuration * boost.magnitude;
		if (rigidbodyC != null && boost.sqrMagnitude > 0.0001f)
		{
			rigidbodyC.MoveRotation(Quaternion.LookRotation(boost, base.transform.up));
		}
		aiming = false;
	}

	public override void OnCancel()
	{
		base.OnCancel();
		aiming = false;
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		base.OnAimUpdate(boost, onlyAimArrow);
		if (!hasBrokenFree && rigidbodyC != null && boost.sqrMagnitude > 0.0001f)
		{
			rigidbodyC.MoveRotation(Quaternion.LookRotation(boost, Vector3.up));
		}
		aiming = true;
	}

	private void Update()
	{
		if (CatcherRoot != null && Car != null && Vector3.Distance(CatcherRoot.position, Car.position) < 20f && !hasBrokenFree)
		{
			Rigidbody[] componentsInChildren = CatcherRoot.GetComponentsInChildren<Rigidbody>();
			if (componentsInChildren != null)
			{
				for (int i = 0; i < componentsInChildren.Length; i++)
				{
					Rigidbody rigidbody = componentsInChildren[i];
					if (rigidbody != null)
					{
						Collider component = rigidbody.gameObject.GetComponent<Collider>();
						if (component != null)
						{
							component.enabled = true;
						}
						rigidbody.isKinematic = false;
						rigidbody.velocity = Vector3.zero;
						rigidbody.angularVelocity = Vector3.zero;
					}
				}
			}
			Animator component2 = CatcherRoot.GetComponent<Animator>();
			if (component2 != null)
			{
				component2.enabled = false;
			}
			Collider component3 = CatcherRoot.GetComponent<Collider>();
			if (component3 != null)
			{
				component3.enabled = false;
			}
			Object.Destroy(CatcherRoot.GetComponent<Rigidbody>());
			if (elephantRoot != null)
			{
				base.transform.position = elephantRoot.position;
				rigidbodyC = elephantRoot;
			}
			hasBrokenFree = true;
		}
		if (hasBrokenFree && elephantEntryRoutine == null && Elephant != null && ElephantEntry != null && Vector3.Distance(Elephant.position, ElephantEntry.position) < 50f)
		{
			if (Particles != null)
			{
				Particles.Play();
			}
			float startY = ((ElephantMountain != null) ? ElephantMountain.position.y : 0f);
			if (CameraManager.Instance != null)
			{
				CameraManager.Instance.Shake(3f, 10f, 2f);
			}
			elephantEntryRoutine = StartCoroutine(pTween.To(3f, delegate(float t)
			{
				if (ElephantMountain != null)
				{
					Vector3 position = ElephantMountain.position;
					float num = Mathf.Clamp01(t);
					ElephantMountain.MovePosition(new Vector3(position.x, Mathf.Lerp(startY, 0f, num), position.z));
				}
			}));
		}
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (rigidbodyC != null)
		{
			base.transform.position = rigidbodyC.position;
		}
		if (hasBrokenFree)
		{
			if (Elephant != null && Elephant.position.y < -20f)
			{
				if (GolfBallController != null)
				{
					GolfBallController.OutOfBounds("OUT OF BOUNDS", 0f);
				}
				Elephant.transform.position = elephantStartPos;
				if (CatcherRagdoolRoot != null)
				{
					CatcherRagdoolRoot.transform.position = catcherStartPos;
				}
			}
			return;
		}
		moveTimer -= Time.deltaTime;
		if (rigidbodyC != null && moveTimer > 0f)
		{
			Vector3 vector = rigidbodyC.position + currentDirection * MoveForce;
			Vector3 point = vector + Vector3.up * 2f;
			int layerMask = 1 << LayerMask.NameToLayer("Ground");
			if (!Physics.CheckCapsule(vector, point, 1f, layerMask))
			{
				rigidbodyC.MovePosition(vector);
				if (currentDirection.sqrMagnitude > 0.0001f)
				{
					rigidbodyC.MoveRotation(Quaternion.LookRotation(currentDirection, Vector3.up));
				}
				if (DampenCurve != null && MoveDuration > 0.0001f)
				{
					float d = DampenCurve.Evaluate(1f - moveTimer / MoveDuration);
					currentDirection *= d;
				}
			}
		}
		if (CatcherRoot != null && CatcherRoot.transform.position.y < -20f)
		{
			if (GolfBallController != null)
			{
				GolfBallController.OutOfBounds("OUT OF BOUNDS", 0f);
			}
			CatcherRoot.transform.position = catcherStartPos;
			if (Elephant != null)
			{
				Elephant.transform.position = elephantStartPos;
			}
		}
	}
}
