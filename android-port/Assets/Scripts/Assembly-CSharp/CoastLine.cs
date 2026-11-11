using System;
using UnityEngine;

public class CoastLine : MonoBehaviour
{
	[Serializable]
	public class Point
	{
		public Vector3 position;

		public Vector3 normal;

		public float distance;
	}

	[SerializeField]
	private float lineWidth;

	[SerializeField]
	private float frequency;

	[SerializeField]
	private float amplitude;

	[SerializeField]
	private float timeShiftOverDistance;

	[SerializeField]
	private AnimationCurve waveCurve;

	[SerializeField]
	private float normalSize;

	public Point[] points;

	private LineRenderer lineRenderer;

	private Vector3[] positions;

	private void Awake()
	{
		lineRenderer = GetComponent<LineRenderer>();
		if (lineRenderer != null && points != null && points.Length > 0)
		{
			positions = new Vector3[points.Length];
			lineRenderer.positionCount = points.Length;
			lineRenderer.widthMultiplier = lineWidth;
		}
	}

	private void Update()
	{
		if (lineRenderer == null || points == null || positions == null || points.Length == 0 || waveCurve == null)
		{
			return;
		}
		for (int i = 0; i < points.Length; i++)
		{
			Point p = points[i];
			float t = (Time.time * frequency + p.distance * timeShiftOverDistance) % 1f;
			if (t < 0f) t += 1f;
			positions[i] = p.position + p.normal * (waveCurve.Evaluate(t) * amplitude);
		}
		lineRenderer.SetPositions(positions);
	}

	private void OnDrawGizmos()
	{
	}

	public void SavePoints()
	{
	}

	public void GenerateNormals()
	{
	}
}
