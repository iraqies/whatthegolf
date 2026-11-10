using System.Collections;
using Core;
using UnityEngine;

public class DefenderArrowShooter : GolfBallShooterBase
{
	public Transform ColliderObject;

	public float MaxColliderLength = 10f;

	public LayerMask GroundLayer;

	public float GroundCheckSize = 5f;

	public Vector2 ColliderResizeRange = new Vector2(0.02f, 1.1f);

	public float SmoothedPhysicsSpeed = 1000f;

	public float CapsuleColliderMod = 2f;

	private CapsuleCollider spawnedCollider;

	private bool initialized;

	protected override void Awake()
	{
		base.Awake();
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
		arrow.SmoothedPhysicsSpeed = SmoothedPhysicsSpeed;

		Rigidbody arrowRb = arrow.gameObject.GetComponent<Rigidbody>() ?? arrow.gameObject.AddComponent<Rigidbody>();
		arrowRb.isKinematic = true;
		arrowRb.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
		arrowRb.interpolation = RigidbodyInterpolation.Interpolate;
		arrowRb.drag = 1f;
		arrowRb.mass = 10f;
		arrowRb.angularDrag = 0.5f;
		RigidbodyOverride = arrowRb;

		arrow.AutoHide = false;
		arrow.overrideBall = arrow.transform;
		arrow.transform.position = transform.position;
		arrow.tag = "Player";
		initialized = true;
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (!initialized || GolfBallController == null || !GolfBallController.IsAiming || GolfBallController.shootArrow == null)
			return;
		ShootArrow arrow = GolfBallController.shootArrow;
		if (spawnedCollider != null && arrow.arrowHeadJoint != null && arrow.arrowBaseJoint != null)
		{
			Vector3 delta = arrow.arrowHeadJoint.position - arrow.arrowBaseJoint.position;
			spawnedCollider.center = spawnedCollider.transform.InverseTransformPoint(arrow.arrowBaseJoint.position + delta * 0.5f);
			spawnedCollider.height = delta.magnitude * CapsuleColliderMod;
		}
	}

	public override void OnAimStart()
	{
		if (!initialized) return;
		if (RigidbodyOverride != null)
			RigidbodyOverride.isKinematic = true;
		if (GolfBallController != null && GolfBallController.shootArrow != null && GolfBallController.shootArrow.arrowOutline != null)
			GolfBallController.shootArrow.arrowOutline.enabled = true;
	}

	public override void OnAimUpdate(Vector3 dir, bool onlyAimArrow)
	{
		if (GolfBallController != null && GolfBallController.shootArrow != null)
		{
			Color c = GolfBallController.shootArrow.GetColor(dir);
			GolfBallController.shootArrow.SetArrowColor(c);
		}
	}
}
