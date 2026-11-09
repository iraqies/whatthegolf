using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;
using VFX;

public class PortalGun : GolfBallShooterBase
{
	public Vector3 Up;

	public List<GameObject> portals;

	public LayerMask HitLayers;

	public LayerMask BlockLayers;

	public float HitOffsetFromWall;

	public AnimationCurve ShootCurve;

	public float LineLife;

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
	}

	private void Update()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, 15f, 5f, 22f, 5f);
	}

	private void HasShot(bool hasHit, Vector3 point, Vector3 normal)
	{
	}

	private bool IsValidShot(Vector3 dir)
	{
		return false;
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	protected override void FixedUpdate()
	{
	base.FixedUpdate();
	}
}
