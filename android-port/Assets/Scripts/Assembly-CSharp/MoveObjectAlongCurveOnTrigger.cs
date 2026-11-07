using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectAlongCurveOnTrigger : MonoBehaviour
{
	public List<Transform> CurvePoints;

	public float MoveSpeed;

	public float Delay;

	public bool UsePhysics;

	public Rigidbody Rigid;

	private float timer;

	public int curIndex;

	private bool running;

	public AnimationCurve animationCurve;

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

	private void OnDrawGizmosSelected()
	{
	}

	public void ResetIndex()
	{
	}

	public void SetSpeed(float newSpeed)
	{
	}
}
