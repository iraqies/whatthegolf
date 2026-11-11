using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectAlongCurve : MonoBehaviour
{
	public List<Transform> CurvePoints;

	public float MoveSpeed = 1f;

	public float Delay;

	public bool UsePhysics;

	public Rigidbody Rigid;

	private float timer;

	private int curIndex;

	private bool running;

	[SerializeField]
	private bool loop = true;

	private IEnumerator Start()
	{
		if (CurvePoints == null || CurvePoints.Count < 3)
		{
			yield break;
		}
		if (CurvePoints[0] != null)
		{
			transform.position = CurvePoints[0].position;
		}
		if (Delay > 0f)
		{
			yield return new WaitForSecondsRealtime(Delay);
		}
		running = true;
	}

	private void Update()
	{
		if (!running || CurvePoints == null || CurvePoints.Count < 3)
		{
			return;
		}
		if (!UsePhysics)
		{
			transform.position = GetPosition();
		}
		timer += Time.deltaTime * MoveSpeed;
		if (timer >= 1f)
		{
			timer = 0f;
			curIndex += 2;
			if (curIndex + 2 >= CurvePoints.Count)
			{
				curIndex = 0;
				if (!loop)
				{
					enabled = false;
				}
			}
		}
	}

	private void FixedUpdate()
	{
		if (running && UsePhysics && Rigid != null && CurvePoints != null && CurvePoints.Count >= 3)
		{
			Rigid.MovePosition(GetPosition());
		}
	}

	private Vector3 GetPosition()
	{
		if (CurvePoints == null || curIndex + 2 >= CurvePoints.Count)
		{
			return transform.position;
		}
		Transform p0 = CurvePoints[curIndex];
		Transform p1 = CurvePoints[curIndex + 1];
		Transform p2 = CurvePoints[curIndex + 2];
		if (p0 == null || p1 == null || p2 == null)
		{
			return transform.position;
		}
		return TweenFunctions.Bezier(p0.position, p1.position, p2.position, timer);
	}

	private void OnDrawGizmos()
	{
	}
}
