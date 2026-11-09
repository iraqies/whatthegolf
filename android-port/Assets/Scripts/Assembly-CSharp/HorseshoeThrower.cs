using System.Collections.Generic;
using Core;
using UnityEngine;
using Utility;

public class HorseshoeThrower : GolfBallShooterBase
{
	public GameObject ObjectToSpawn;

	public Transform SpawnPosition;

	public Rigidbody HorseHand;

	public Rigidbody HorseRotator;

	public float ThrowForce;

	public float MinThrowForce;

	public float Spin;

	public float Pitch;

	public float HandRetractRange;

	public Vector3 euler;

	public List<ConstantForce> FrontlegForces;

	private ObjectPool<GameObject> objectPool;

	private Rigidbody currentObject;

	private Vector3 handTargetPosition;

	private float throwTimer;

	private FixedJoint currentJoint;

	private void Start()
	{
	}

	protected override void FixedUpdate()
	{
	base.FixedUpdate();
	}

	public override void OnAimStart()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, Pitch, (MinThrowForce > 0f ? MinThrowForce : 5f), (ThrowForce > 0f ? ThrowForce : 22f), Spin);
	}
}
