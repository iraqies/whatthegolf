using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;
using VFX;

public class PortalGun : GolfBallShooterBase
{
	public Vector3 Up = Vector3.up;

	public List<GameObject> portals;

	public LayerMask HitLayers;

	public LayerMask BlockLayers;

	public float HitOffsetFromWall = 0.5f;

	public AnimationCurve ShootCurve;

	public float LineLife = 0.5f;

	public bool Is2DLevel;

	public ClipSettingsCollection placePortalSFX;

	public ClipSettingsCollection failPortalSFX;

	public bool lookWithPhysics;

	private LineRenderer shootLine;

	private float lineShootTimer;

	private TrajectoryProjector trajectoryProjector;

	public Transform BarrelTransform;

	public SpriteRenderer AimRenderer;

	public bool flipPortal;

	private bool validShot;

	private Quaternion targetRotation;

	protected override void Awake()
	{
		base.Awake();
		shootLine = GetComponent<LineRenderer>();
		trajectoryProjector = GetComponentInChildren<TrajectoryProjector>();
	}

	private void Update()
	{
		if (AimRenderer != null)
		{
			AimRenderer.enabled = false;
		}
		if (lineShootTimer > 0f)
		{
			if (ShootCurve != null && shootLine != null && LineLife > 0.0001f)
			{
				float time = Mathf.Lerp(0f, 1f, 1f - lineShootTimer / LineLife);
				shootLine.widthMultiplier = ShootCurve.Evaluate(time);
			}
			lineShootTimer -= Time.deltaTime;
		}
		else if (shootLine != null)
		{
			shootLine.positionCount = 0;
		}
		if (GolfBallController != null && trajectoryProjector != null)
		{
			trajectoryProjector.enabled = GolfBallController.IsAiming && validShot;
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		if (flipPortal)
		{
			boost = -boost;
		}
		base.OnShoot(boost);
		if (Is2DLevel)
		{
			Vector2 vector = base.transform.position;
			if (AimRenderer != null)
			{
				Vector3 vector2 = AimRenderer.transform.position - base.transform.position;
				vector += new Vector2(vector2.x, vector2.y);
			}
			int layerMask = (int)HitLayers | (int)BlockLayers;
			RaycastHit2D raycastHit2D = Physics2D.Raycast(vector, new Vector2(boost.x, boost.y), 5000f, layerMask);
			if (raycastHit2D.transform != null)
			{
				int num = HitLayers;
				int layer = raycastHit2D.transform.gameObject.layer;
				bool hasHit = num == (num | (1 << layer));
				HasShot(hasHit, raycastHit2D.point, raycastHit2D.normal);
			}
			return;
		}
		Vector3 origin = base.transform.position;
		if (AimRenderer != null)
		{
			origin += AimRenderer.transform.position - base.transform.position;
		}
		int layerMask2 = (int)HitLayers | (int)BlockLayers;
		if (Physics.Raycast(origin, boost, out var hitInfo, 5000f, layerMask2))
		{
			int num2 = HitLayers;
			int layer2 = hitInfo.transform.gameObject.layer;
			bool hasHit2 = num2 == (num2 | (1 << layer2));
			HasShot(hasHit2, hitInfo.point, hitInfo.normal);
		}
	}

	private void HasShot(bool hasHit, Vector3 point, Vector3 normal)
	{
		if (!hasHit)
		{
			if (failPortalSFX != null)
			{
				failPortalSFX.Play(point);
			}
			return;
		}
		if (portals == null || portals.Count == 0)
		{
			return;
		}
		GameObject gameObject = portals[0];
		if (gameObject == null)
		{
			return;
		}
		bool activeSelf = gameObject.activeSelf;
		Vector3 position = gameObject.transform.position;
		Quaternion rotation = gameObject.transform.rotation;
		gameObject.transform.position = point + normal * HitOffsetFromWall;
		Vector3 upwards = (Is2DLevel ? Vector3.forward : Vector3.up);
		if (normal.sqrMagnitude > 0.0001f)
		{
			gameObject.transform.rotation = Quaternion.LookRotation(normal, upwards);
		}
		gameObject.SetActive(true);
		portals.RemoveAt(0);
		foreach (GameObject portal in portals)
		{
			if (portal == null)
			{
				continue;
			}
			bool flag = false;
			if (Is2DLevel)
			{
				Collider2D componentInChildren = portal.GetComponentInChildren<Collider2D>();
				Collider2D componentInChildren2 = gameObject.GetComponentInChildren<Collider2D>();
				if (componentInChildren != null && componentInChildren2 != null)
				{
					flag = componentInChildren.bounds.Intersects(componentInChildren2.bounds);
				}
			}
			else
			{
				Collider componentInChildren3 = portal.GetComponentInChildren<Collider>();
				Collider componentInChildren4 = gameObject.GetComponentInChildren<Collider>();
				if (componentInChildren3 != null && componentInChildren4 != null)
				{
					flag = componentInChildren3.bounds.Intersects(componentInChildren4.bounds);
				}
			}
			if (flag)
			{
				portal.transform.position = position;
				portal.transform.rotation = rotation;
				portal.SetActive(activeSelf);
			}
		}
		portals.Add(gameObject);
		if (placePortalSFX != null)
		{
			placePortalSFX.Play(point);
		}
		lineShootTimer = LineLife;
		if (shootLine != null && BarrelTransform != null)
		{
			shootLine.positionCount = 2;
			shootLine.SetPosition(0, BarrelTransform.position);
			shootLine.SetPosition(1, point);
		}
	}

	private bool IsValidShot(Vector3 dir)
	{
		if (Is2DLevel)
		{
			RaycastHit2D raycastHit2D = Physics2D.Raycast(base.transform.position, new Vector2(dir.x, dir.y), 5000f, BlockLayers);
			return raycastHit2D.transform == null;
		}
		return !Physics.Raycast(base.transform.position, dir, 5000f, BlockLayers);
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (flipPortal)
		{
			boost = -boost;
		}
		validShot = IsValidShot(boost.normalized);
		if (trajectoryProjector != null)
		{
			trajectoryProjector.enabled = validShot;
		}
		if (boost.sqrMagnitude > 0.0001f)
		{
			Quaternion quaternion = Quaternion.LookRotation(boost.normalized, Up);
			if (lookWithPhysics)
			{
				targetRotation = quaternion.normalized;
			}
			else
			{
				base.transform.rotation = quaternion;
			}
		}
		if (trajectoryProjector != null && GolfBallController != null)
		{
			GolfBallController.isSubAimBlockedByIsBlocking = !trajectoryProjector.enabled;
		}
		if (AimRenderer != null)
		{
			AimRenderer.enabled = validShot;
		}
	}

	protected override void FixedUpdate()
	{
		if (lookWithPhysics && GolfBallController != null && (GolfBallController.IsAiming || GolfBallController.isShooting) && rigidbodyC != null)
		{
			float num = Vector3.SignedAngle(targetRotation.eulerAngles, base.transform.forward, Vector3.up);
			rigidbodyC.angularVelocity = Vector3.up * num;
			rigidbodyC.MoveRotation(targetRotation.normalized);
			rigidbodyC.MovePosition(rigidbodyC.position);
		}
	}
}
