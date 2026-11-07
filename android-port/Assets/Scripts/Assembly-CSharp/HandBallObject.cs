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
	}

	public void AddJointTo(Rigidbody holder, Transform holdPos)
	{
	}

	public void Release()
	{
	}

	public void Throw(Vector3 force)
	{
	}

	public void PrepareForShot()
	{
	}
}
