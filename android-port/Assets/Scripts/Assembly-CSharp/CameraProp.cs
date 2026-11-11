using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraProp : MonoBehaviour
{
	public float ViewDistance = 10f;

	public float UpdateInterval = 0.2f;

	public float HoldTargetMinTime = 2f;

	public ConfigurableJoint Joint;

	public Transform CameraLens;

	public Transform AlwaysFollow;

	public bool lookForCustomKinematicTarget;

	public List<Rigidbody> IgnoreList;

	private Transform currentTarget;

	private Rigidbody rigid;

	private Rigidbody jointRigid;

	private Quaternion startRot;

	private IEnumerator Start()
	{
		startRot = base.transform.rotation;
		rigid = GetComponent<Rigidbody>();
		jointRigid = Joint.GetComponent<Rigidbody>();
		jointRigid.mass = 1f / (base.transform.localScale.x * 0.25f);
		Collider[] colliders = new Collider[100];
		while (base.enabled)
		{
			if (AlwaysFollow != null && AlwaysFollow.gameObject.activeInHierarchy)
			{
				yield return new WaitForSeconds(Random.Range(0.2f, 1f));
				currentTarget = AlwaysFollow;
				yield return new WaitForSeconds(UpdateInterval);
				continue;
			}
			int num = Physics.OverlapSphereNonAlloc(base.transform.position, ViewDistance, colliders);
			Transform transform = null;
			float num2 = 0f;
			for (int i = 0; i < num; i++)
			{
				if (IsValidTarget(colliders[i].attachedRigidbody))
				{
					float sqrMagnitude = colliders[i].attachedRigidbody.velocity.sqrMagnitude;
					if (sqrMagnitude > num2)
					{
						num2 = sqrMagnitude;
						transform = colliders[i].transform;
					}
				}
				else if (lookForCustomKinematicTarget && IsValidKinematicTarget(colliders[i].attachedRigidbody, out var kinematic))
				{
					float sqrMagnitude2 = kinematic.Velocity.sqrMagnitude;
					if (sqrMagnitude2 > num2)
					{
						num2 = sqrMagnitude2;
						transform = colliders[i].transform;
					}
				}
			}
			currentTarget = transform;
			if (transform != null)
			{
				yield return new WaitForSeconds(HoldTargetMinTime);
			}
			else
			{
				yield return new WaitForSeconds(UpdateInterval);
			}
		}
	}

	private bool IsValidTarget(Rigidbody otherRigid)
	{
		if (otherRigid != null && !otherRigid.isKinematic && otherRigid != rigid && otherRigid != jointRigid)
		{
			return !IgnoreList.Contains(otherRigid);
		}
		return false;
	}

	private bool IsValidKinematicTarget(Rigidbody otherRigid, out IMovingKinematicTarget kinematic)
	{
		kinematic = null;
		if (otherRigid != null)
		{
			return otherRigid.TryGetComponent<IMovingKinematicTarget>(out kinematic);
		}
		return false;
	}

	private void Update()
	{
		Vector3 forward = base.transform.forward;
		if (currentTarget != null)
		{
			forward = (currentTarget.position - CameraLens.position).normalized;
		}
		Joint.SetTargetRotationLocal(Quaternion.LookRotation(forward), startRot);
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.DrawWireSphere(base.transform.position, ViewDistance);
	}
}
