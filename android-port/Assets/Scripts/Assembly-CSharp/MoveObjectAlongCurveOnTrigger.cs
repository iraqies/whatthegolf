using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
		if (CurvePoints != null && CurvePoints.Count > 0 && CurvePoints[0] != null)
		{
			base.transform.position = CurvePoints[0].position;
		}
		yield return new WaitForSecondsRealtime(Delay);
		running = true;
	}

	private void Update()
	{
		if (!running)
		{
			return;
		}
		if (!UsePhysics)
		{
			base.transform.position = GetPosition();
		}
		timer += MoveSpeed * Time.deltaTime;
		if (timer >= 1f)
		{
			timer = 0f;
			curIndex += 2;
			if (CurvePoints != null && curIndex >= CurvePoints.Count - 1)
			{
				curIndex = 0;
			}
		}
	}

	private void FixedUpdate()
	{
		if (running && UsePhysics && Rigid != null)
		{
			Rigid.MovePosition(GetPosition());
		}
	}

	private Vector3 GetPosition()
	{
		return TweenFunctions.Bezier(CurvePoints[curIndex].position, CurvePoints[curIndex + 1].position, CurvePoints[curIndex + 2].position, animationCurve.Evaluate(timer));
	}

	private void OnDrawGizmosSelected()
	{
		if (CurvePoints == null || CurvePoints.Count == 0 || CurvePoints.Any((Transform c) => c == null))
		{
			return;
		}
		for (int i = 0; i < CurvePoints.Count - 1; i += 2)
		{
			Vector3 from = CurvePoints[0].position;
			for (int j = 0; j < 20; j++)
			{
				Vector3 vector = TweenFunctions.Bezier(CurvePoints[i].position, CurvePoints[i + 1].position, CurvePoints[i + 2].position, 1f / (float)j);
				Gizmos.DrawLine(from, vector);
				from = vector;
			}
		}
	}

	public void ResetIndex()
	{
		curIndex = 0;
	}

	public void SetSpeed(float newSpeed)
	{
		MoveSpeed = newSpeed;
	}
}
