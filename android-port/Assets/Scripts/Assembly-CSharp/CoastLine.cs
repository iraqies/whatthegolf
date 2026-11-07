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
	}

	private void Update()
	{
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
