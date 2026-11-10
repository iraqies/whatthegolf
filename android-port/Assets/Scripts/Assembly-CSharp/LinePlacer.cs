using System.Collections.Generic;
using UnityEngine;

public class LinePlacer : MonoBehaviour
{
	private struct PointDistance
	{
		public Vector3 point;

		public float distance;

		public Vector3 lookDir;

		public PointDistance(Vector3 point, float distance, Vector3 lookDir)
		{
			this.point = point;
			this.distance = distance;
			this.lookDir = lookDir;
		}
	}

	public Transform[] drawingPoints;

	public GameObject brush;

	public int segmentMeasuringSamples = 10;

	public float brushSize = 1f;

	public float orientationSampleDistance = 0.1f;

	private List<PointDistance> table;

	private void Start()
	{
		if (drawingPoints == null || drawingPoints.Length == 0)
		{
			return;
		}
		if (table == null)
		{
			table = new List<PointDistance>();
		}
		if (drawingPoints.Length % 2 != 1)
		{
			Debug.Log("LinePlacer: drawingPoints length must be odd");
			return;
		}
		for (int i = 0; i < drawingPoints.Length - 1; i += 2)
		{
			Vector3 start = drawingPoints[i].position;
			Vector3 end = drawingPoints[i + 2].position;
			Vector3 control = drawingPoints[i | 1].position;
			ComputeReparametrizationTable(start, end, control, segmentMeasuringSamples, table);
			if (table.Count == 0 || brushSize <= 0f)
			{
				continue;
			}
			float totalDist = table[table.Count - 1].distance;
			int count = (float.IsInfinity(totalDist / brushSize) ? 0 : ((int)(totalDist / brushSize)));
			for (int j = 0; j < count; j++)
			{
				SampleTable(table, brushSize * (float)j, out var pt);
				if (brush != null)
				{
					GameObject inst = Object.Instantiate(brush);
					inst.transform.position = pt.point;
					if (pt.lookDir != Vector3.zero)
					{
						inst.transform.rotation = Quaternion.LookRotation(pt.lookDir, Vector3.up);
					}
					inst.transform.SetParent(base.transform, true);
				}
			}
		}
	}

	private void ComputeReparametrizationTable(Vector3 start, Vector3 end, Vector3 control, int samples, List<PointDistance> table)
	{
		table.Clear();
		if (samples < 1)
		{
			return;
		}
		float accDist = 0f;
		float fSamples = samples;
		for (int i = 0; i < samples; i++)
		{
			float t0 = (float)i / fSamples;
			float t1 = (float)(i + 1) / fSamples;
			Vector3 p0 = TweenFunctions.Bezier(start, control, end, t0);
			Vector3 p1 = TweenFunctions.Bezier(start, control, end, t1);
			Vector3 pAhead = TweenFunctions.Bezier(start, control, end, Mathf.Clamp(t0 + orientationSampleDistance, 0f, 1f));
			Vector3 pBehind = TweenFunctions.Bezier(start, control, end, Mathf.Clamp(t0 - orientationSampleDistance, 0f, 1f));
			table.Add(new PointDistance(p0, accDist, pAhead - pBehind));
			accDist += Vector3.Distance(p0, p1);
			if (i == samples - 1)
			{
				Vector3 pEndAhead = TweenFunctions.Bezier(start, control, end, Mathf.Clamp(t1 + orientationSampleDistance, 0f, 1f));
				Vector3 pEndBehind = TweenFunctions.Bezier(start, control, end, Mathf.Clamp(t1 - orientationSampleDistance, 0f, 1f));
				table.Add(new PointDistance(p1, accDist, pEndAhead - pEndBehind));
			}
		}
	}

	private void SampleTable(List<PointDistance> table, float distance, out PointDistance point)
	{
		if (table == null || table.Count == 0)
		{
			point = default(PointDistance);
			return;
		}
		for (int i = 0; i < table.Count; i++)
		{
			if (table[i].distance > distance)
			{
				if (i == 0)
				{
					point = table[0];
					return;
				}
				PointDistance prev = table[i - 1];
				PointDistance curr = table[i];
				float denom = curr.distance - prev.distance;
				float t = ((denom > 1e-05f) ? Mathf.Clamp01((distance - prev.distance) / denom) : 0f);
				point = new PointDistance(Vector3.Lerp(prev.point, curr.point, t), distance, Vector3.Lerp(prev.lookDir, curr.lookDir, t));
				return;
			}
		}
		point = table[table.Count - 1];
	}

	private void OnDrawGizmos()
	{
	}
}
