using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectAlongCurve : MonoBehaviour
{
	public List<Transform> CurvePoints;

	public float MoveSpeed;

	public float Delay;

	public bool UsePhysics;

	public Rigidbody Rigid;

	private float timer;

	private int curIndex;

	private bool running;

	[SerializeField]
	private bool loop;

	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private Vector3 GetPosition()
	{
		return default;
	}

	private void OnDrawGizmos()
	{
	}
}
