using System.Collections;
using System.Collections.Generic;
using Audio;
using CameraStack;
using Core;
using UnityEngine;

public class ShootArrowInstead : GolfBallShooterBase
{
	public Transform ColliderObject;

	public float MaxColliderLength = 10f;

	public float MaxVelocity = 50f;

	public float MinVelocity = 10f;

	public float Spin = 10f;

	public float Pitch;

	public GolfBallController OtherController;

	public LayerMask GroundLayer;

	public float GroundCheckSize = 5f;

	public Vector2 ColliderResizeRange = new Vector2(0.02f, 1.1f);

	public List<OnCollisionAudioRemote> collisionAudioToApply;

	public AudioMaterial materialToApply;

	public float startDrag = 1f;

	private bool hasShot;

	private CBFollow followCamera;

	private bool firstShot = true;

	private Vector3 aimDirection;

	private Rigidbody oldRigid;

	private int shotCount;

	private float lastInputTarget;

	private CapsuleCollider spawnedCollider;

	private bool initialized;

	protected override void Awake()
	{
		base.Awake();
		if (followCamera == null && CameraManager.Instance != null)
			followCamera = CameraManager.Instance.GetComponent<CBFollow>();
		oldRigid = rigidbodyC;
	}

	private IEnumerator Start()
	{
		yield return null;
		if (GolfBallController == null || GolfBallController.shootArrow == null)
			yield break;

		ShootArrow arrow = GolfBallController.shootArrow;
		if (ColliderObject != null)
		{
			if (arrow.basePivot != null)
			{
				ColliderObject.SetParent(arrow.basePivot, false);
				ColliderObject.localPosition = Vector3.zero;
			}
			if (arrow.arrowHeadJoint != null)
			{
				Transform spawned = Instantiate(ColliderObject, arrow.arrowHeadJoint);
				if (spawned != null)
				{
					spawnedCollider = spawned.GetComponent<CapsuleCollider>();
					if (spawnedCollider != null)
					{
						spawnedCollider.transform.localScale /= 125.977f;
						spawnedCollider.transform.localPosition = Vector3.zero;
					}
				}
			}
		}

		arrow.MoveMethod = ShootArrow.MoveMethodEnum.None;
		arrow.RotateMethod = ShootArrow.MoveMethodEnum.SmoothedPhysics;
		arrow.SmoothedPhysicsSpeed = 1000f;

		Rigidbody arrowRb = arrow.gameObject.GetComponent<Rigidbody>() ?? arrow.gameObject.AddComponent<Rigidbody>();
		arrowRb.isKinematic = true;
		arrowRb.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
		arrowRb.interpolation = RigidbodyInterpolation.Interpolate;
		arrowRb.drag = startDrag;
		arrowRb.mass = 10f;
		arrowRb.angularDrag = 0.5f;
		RigidbodyOverride = arrowRb;

		var matSettings = arrowRb.gameObject.GetComponent<AudioMaterialSettings>() ?? arrowRb.gameObject.AddComponent<AudioMaterialSettings>();
		if (matSettings != null)
			matSettings.material = materialToApply;

		if (collisionAudioToApply != null)
		{
			for (int i = 0; i < collisionAudioToApply.Count; i++)
			{
				if (collisionAudioToApply[i] != null)
				{
					collisionAudioToApply[i].SetRoot(arrowRb.gameObject);
				}
			}
		}

		arrow.AutoHide = false;
		arrow.overrideBall = arrow.transform;
		arrow.transform.position = transform.position;
		arrow.tag = "Player";
		initialized = true;
	}

	private void Update()
	{
		if (hasShot && GolfBallController != null && GolfBallController.shootArrow != null)
		{
			GolfBallController.shootArrow.gameObject.SetActive(true);
			if (followCamera != null)
				followCamera.FollowTarget = GolfBallController.shootArrow.transform;
			GolfBallController.inputTarget = lastInputTarget;
		}
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (firstShot || GolfBallController == null || GolfBallController.shootArrow == null)
			return;

		if (oldRigid != null)
			oldRigid.MovePosition(GolfBallController.shootArrow.transform.position);

		bool grounded = Physics.CheckSphere(transform.position, GroundCheckSize, GroundLayer.value);
		GolfBallController.enabled = grounded;

		ShootArrow arrow = GolfBallController.shootArrow;
		Color col = grounded ? arrow.GetColor(aimDirection) : arrow.blockedColor;
		arrow.SetArrowColor(col);

		if (GolfBallController.IsAiming && spawnedCollider != null && arrow.arrowHeadJoint != null && arrow.arrowBaseJoint != null)
		{
			Vector3 delta = arrow.arrowHeadJoint.position - arrow.arrowBaseJoint.position;
			spawnedCollider.center = spawnedCollider.transform.InverseTransformPoint(arrow.arrowBaseJoint.position + delta * 0.5f);
			spawnedCollider.height = delta.magnitude * 2f;
		}
	}

	public override void OnAimStart()
	{
		hasShot = false;
		if (firstShot && initialized && RigidbodyOverride != null)
		{
			RigidbodyOverride.isKinematic = true;
		}
		if (GolfBallController != null && GolfBallController.shootArrow != null && GolfBallController.shootArrow.arrowOutline != null)
		{
			GolfBallController.shootArrow.arrowOutline.enabled = true;
		}
	}

	public override void OnAimUpdate(Vector3 dir, bool onlyAimArrow)
	{
		aimDirection = dir;
	}

	public override void OnCancel()
	{
		hasShot = true;
	}

	public override void OnShoot(Vector3 dir)
	{
		if (!initialized) return;
		hasShot = true;
		if (RigidbodyOverride != null)
		{
			RigidbodyOverride.isKinematic = false;
			RigidbodyOverride.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
		}
		if (GolfBallController != null && GolfBallController.shootArrow != null && GolfBallController.shootArrow.arrowOutline != null)
		{
			GolfBallController.shootArrow.arrowOutline.enabled = false;
		}

		Vector3 axis = Vector3.Cross(dir, Vector3.up);
		Vector3 pitched = Quaternion.AngleAxis(Pitch, axis) * dir;
		StandardShoot(pitched, Pitch, MinVelocity, MaxVelocity, Spin);

		if (RigidbodyOverride != null)
		{
			Vector3 randTorque = Random.onUnitSphere * 1000f;
			if (shotCount == 0)
			{
				Vector3 t = randTorque + RigidbodyOverride.transform.forward * 6592f - RigidbodyOverride.transform.right * 7000f;
				RigidbodyOverride.AddTorque(t, ForceMode.VelocityChange);
			}
			else
			{
				Vector3 t = randTorque + RigidbodyOverride.transform.forward * 6592f - RigidbodyOverride.transform.right * 10000f + RigidbodyOverride.transform.up * 16500f;
				RigidbodyOverride.AddTorque(t, ForceMode.VelocityChange);
			}
		}

		shotCount++;
		firstShot = false;
		if (OtherController != null)
			OtherController.enabled = false;
		if (GolfBallController != null)
			GolfBallController.CountStrokesWhileBlocked = true;
		lastInputTarget = pitched.magnitude;
	}
}
