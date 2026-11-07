using System;
using System.Collections.Generic;
using UnityEngine;

public class Arrow3D : MonoBehaviour
{
	public List<Collider> Colliders;

	public Rigidbody Rigidbody;

	public Action OnHitGoal;

	public Action OnMissGoal;

	public LayerMask HitLayers;

	public Action OnReset;

	public bool CanWin;

	public bool Initialized;

	public bool stuck;

	private RotateWithVelocity rotator;

	public bool shouldStick;

	[NonSerialized]
	public string golfGoalLayerTag;

	[SerializeField]
	private float minPenetration;

	[SerializeField]
	private float maxPenetration;

	[SerializeField]
	private float additionalHitForce;

	[SerializeField]
	private float penetrationFactor;

	public Action<Collision> OnCollisionEnterExtraActions;

	private float lastVelBeforeHit;

	private Quaternion lastRotationBeforeHit;

	private Vector3 lastPositionBeforeHit;

	private float collisionVel;

	private Collision collision;

	private void OnEnable()
	{
	}

	private void FixedUpdate()
	{
	}

	private void HitSomething(Collision collision)
	{
	}

	private void OnCollisionEnter(Collision col)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void EnteredPortal(PortalPackage package)
	{
	}
}
