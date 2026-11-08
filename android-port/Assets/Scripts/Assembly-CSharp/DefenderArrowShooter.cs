using System.Collections;
using Core;
using UnityEngine;

public class DefenderArrowShooter : GolfBallShooterBase
{
	public Transform ColliderObject;

	public float MaxColliderLength;

	public LayerMask GroundLayer;

	public float GroundCheckSize;

	public Vector2 ColliderResizeRange;

	public float SmoothedPhysicsSpeed;

	public float CapsuleColliderMod;

	private CapsuleCollider spawnedCollider;

	private bool initialized;

	protected override void Awake()
	{
	base.Awake();
	}

	private IEnumerator Start()
	{
		return null;
	}

	protected override void FixedUpdate()
	{
	base.FixedUpdate();
	}

	public override void OnAimStart()
	{
	}

	public override void OnAimUpdate(Vector3 dir, bool onlyAimArrow)
	{
	}
}
