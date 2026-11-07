using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Build2DWire : MonoBehaviour
{
	public GameObject LineSegment;

	public float MassPerLine;

	public float SegmentsLength;

	public Transform LineStart;

	public Transform LineEnd;

	public bool BuildLinesNow;

	private List<GameObject> lines;

	private Transform container;

	private void Update()
	{
	}

	private void BuildLines(Transform previousMast, Transform currentMast)
	{
	}
}
