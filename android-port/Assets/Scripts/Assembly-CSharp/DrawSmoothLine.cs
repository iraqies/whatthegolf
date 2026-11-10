using System.Collections.Generic;
using UnityEngine;

public class DrawSmoothLine : MonoBehaviour
{
	public bool UpdateAutomatically;

	public LineRenderer brush;

	public float StepDetail = 0.25f;

	public bool UseBezier = true;

	public bool UseEndPointAsStartPoint;

	public Vector3 Offset;

	private float t;

	private int[] controlIndex;

	private int[] endIndex;

	private float detail;

	private Transform start;

	private Transform end;

	private Transform control;

	private void Update()
	{
		if (UpdateAutomatically)
		{
			UpdateLine();
		}
	}

	private void UpdateLine()
	{
		if (brush == null)
		{
			return;
		}
		if (UseEndPointAsStartPoint)
		{
			var points = new List<Vector3>();
			for (int i = 0; i < transform.childCount - 1; i += 2)
			{
				Transform c0 = transform.GetChild(i);
				if (c0 == null || !c0.gameObject.activeSelf)
					continue;
				Vector3 p0 = c0.position;
				Vector3 p1 = transform.GetChild(i | 1).position;
				Vector3 p2 = (i + 2 < transform.childCount) ? transform.GetChild(i + 2).position : p1;
				points.Add(p0);
				for (int j = 0; j < 10; j++)
				{
					float u = j / 10f;
					float oneMinusU = 1f - u;
					Vector3 pt = oneMinusU * oneMinusU * p0 + 2f * oneMinusU * u * p1 + u * u * p2;
					points.Add(pt);
				}
				points.Add(p2);
			}
			brush.positionCount = points.Count;
			brush.SetPositions(points.ToArray());
			return;
		}

		if (transform.childCount < 1)
		{
			return;
		}
		if (UseBezier && (transform.childCount & 1) != 0)
		{
			return;
		}
		if (UseBezier)
		{
			UpdateIndexes();
		}
		start = transform.GetChild(0);
		var list = new List<Vector3>();
		if (UseBezier)
		{
			t = 0f;
			for (int i = 0; i < transform.childCount / 2; i++)
			{
				if (controlIndex == null || endIndex == null || i >= controlIndex.Length || i >= endIndex.Length)
					break;
				control = transform.GetChild(controlIndex[i]);
				end = transform.GetChild(endIndex[i]);
				float len = Mathf.Max(0.01f, DetermineLength());
				detail = Mathf.Max(0.01f, StepDetail / len);
				for (float u = 0f; u < 1f; u += detail)
				{
					float oneMinusU = 1f - u;
					Vector3 pt = oneMinusU * oneMinusU * start.position + 2f * oneMinusU * u * control.position + u * u * end.position;
					list.Add(pt);
				}
				start = end;
			}
			if (end != null)
			{
				list.Add(end.position);
			}
		}
		else
		{
			for (int i = 0; i < transform.childCount; i++)
			{
				Transform ch = transform.GetChild(i);
				if (ch != null && ch.gameObject.activeSelf)
				{
					list.Add(ch.position);
				}
			}
		}
		brush.positionCount = list.Count;
		brush.SetPositions(list.ToArray());
	}

	private float DetermineLength()
	{
		if (start == null || end == null)
		{
			return 1f;
		}
		if (UseBezier && control != null)
		{
			return Vector3.Distance(start.position, control.position) + Vector3.Distance(control.position, end.position);
		}
		return Vector3.Distance(start.position, end.position);
	}

	private void OnDrawGizmos()
	{
	}

	private void UpdateIndexes()
	{
		int pairs = transform.childCount / 2;
		controlIndex = new int[pairs];
		endIndex = new int[pairs];
		for (int i = 0; i < pairs; i++)
		{
			controlIndex[i] = i * 2 + 1;
			endIndex[i] = Mathf.Min(transform.childCount - 1, (i + 1) * 2);
		}
	}
}
