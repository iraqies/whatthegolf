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

	public float ThrowForce = 10f;

	public float MinThrowForce = 2f;

	public float Spin = 1f;

	public float Pitch = 1f;

	public float HandRetractRange = 5f;

	public Vector3 euler;

	public List<ConstantForce> FrontlegForces;

	private ObjectPool<GameObject> objectPool;

	private Rigidbody currentObject;

	private Vector3 handTargetPosition;

	private float throwTimer;

	private FixedJoint currentJoint;

	private void Start()
	{
		Collider[] colliders = base.transform.root.GetComponentsInChildren<Collider>();
		objectPool = new ObjectPool<GameObject>(ObjectToSpawn, 20, delegate(GameObject g)
		{
			Collider[] componentsInChildren = g.GetComponentsInChildren<Collider>();
			foreach (Collider collider in componentsInChildren)
			{
				foreach (Collider collider2 in colliders)
				{
					Physics.IgnoreCollision(collider, collider2, true);
				}
			}
			WinnableGolfBall component = g.GetComponent<WinnableGolfBall>();
			if (component != null)
			{
				component.PlayerIndex = GolfBallController.PlayerID;
			}
		});
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (throwTimer > 0f)
		{
			HorseHand.MovePosition(Vector3.MoveTowards(HorseHand.position, handTargetPosition, Time.deltaTime * 50f));
			throwTimer -= Time.deltaTime;
		}
	}

	public override void OnAimStart()
	{
		if (!(currentObject == null))
		{
			return;
		}
		currentObject = objectPool.Retrieve(HorseHand.position, default(Quaternion)).GetComponent<Rigidbody>();
		currentJoint = currentObject.gameObject.AddComponent<FixedJoint>();
		currentJoint.connectedBody = HorseHand;
		currentObject.rotation = Quaternion.identity;
		currentObject.constraints = (RigidbodyConstraints)80;
		foreach (ConstantForce frontlegForce in FrontlegForces)
		{
			frontlegForce.enabled = true;
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		handTargetPosition = HorseHand.position - boost * HandRetractRange;
		throwTimer = 0.5f;
		HorseRotator.MoveRotation(Quaternion.LookRotation(boost.normalized) * Quaternion.Euler(euler));
	}

	public override void OnShoot(Vector3 boost)
	{
		AudioSource componentInChildren = currentObject.GetComponentInChildren<AudioSource>(true);
		if (componentInChildren != null)
		{
			componentInChildren.gameObject.SetActive(true);
		}
		handTargetPosition = HorseHand.position + boost * HandRetractRange;
		throwTimer = 0.5f;
		base.RigidbodyOverride = currentObject;
		Object.Destroy(currentJoint);
		currentObject = null;
		Vector3 axis = Vector3.Cross(boost, Vector3.up);
		StandardShoot(Quaternion.AngleAxis(Pitch, axis) * boost, Pitch, MinThrowForce, ThrowForce, 0f);
		rigid.angularVelocity = Vector3.up * Spin;
	}
}
