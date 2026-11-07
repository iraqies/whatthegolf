using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ElmastGenerator : MonoBehaviour
{
	public GameObject MastTemplate;

	public GameObject LineSegment;

	public List<Transform> MastPositions;

	public float SegmentsLength;

	public float MassPerLine;

	public bool DoUpdate;

	private List<GameObject> SpawnedMasts;

	private Dictionary<GameObject, List<GameObject>> lines;

	private void Update()
	{
	}

	private void BuildLines(Transform previousMast, Transform currentMast)
	{
	}
}
