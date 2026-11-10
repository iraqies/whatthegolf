using System.Collections.Generic;
using UnityEngine;

public class HandBallObject : MonoBehaviour
{
	public Transform LeftHold;

	public Transform RightHold;

	private List<Joint> joints;

	private Rigidbody rigid;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		joints = new List<Joint>();
	}

	public void AddJointTo(Rigidbody holder, Transform holdPos)
	{
		if (holder == null)
		{
			return;
		}
		if (joints == null)
		{
			joints = new List<Joint>();
		}
		if (holdPos != null)
		{
			transform.position = holdPos.position;
		}
		FixedJoint fj = gameObject.AddComponent<FixedJoint>();
		fj.connectedBody = holder;
		joints.Add(fj);
	}

	public void Release()
	{
		if (joints == null)
		{
			return;
		}
		for (int i = 0; i < joints.Count; i++)
		{
			if (joints[i] != null)
			{
				Object.Destroy(joints[i]);
			}
		}
		joints.Clear();
	}

	public void Throw(Vector3 force)
	{
		Release();
		if (rigid != null)
		{
			rigid.isKinematic = false;
			rigid.AddForce(force, ForceMode.VelocityChange);
		}
	}

	public void PrepareForShot()
	{
		Release();
		if (rigid != null)
		{
			rigid.isKinematic = false;
			rigid.velocity = Vector3.zero;
			rigid.angularVelocity = Vector3.zero;
		}
	}
}
