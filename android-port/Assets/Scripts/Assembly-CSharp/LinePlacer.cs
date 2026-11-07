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
			this.point = default;
			this.distance = 0f;
			this.lookDir = default;
		}
	}

	public Transform[] drawingPoints;

	public GameObject brush;

	public int segmentMeasuringSamples;

	public float brushSize;

	public float orientationSampleDistance;

	private List<PointDistance> table;

	private void Start()
	{
	}

	private void ComputeReparametrizationTable(Vector3 start, Vector3 end, Vector3 control, int samples, List<PointDistance> table)
	{
	}

	private void SampleTable(List<PointDistance> table, float distance, out PointDistance point)
	{
		point = default;
	}

	private void OnDrawGizmos()
	{
	}
}
