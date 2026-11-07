using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraProp : MonoBehaviour
{
	public float ViewDistance;

	public float UpdateInterval;

	public float HoldTargetMinTime;

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
		return null;
	}

	private bool IsValidTarget(Rigidbody otherRigid)
	{
		return false;
	}

	private bool IsValidKinematicTarget(Rigidbody otherRigid, out IMovingKinematicTarget kinematic)
	{
		kinematic = null;
		return false;
	}

	private void Update()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
