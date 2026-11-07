using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
	public Transform head;

	public Transform[] segments;

	private List<Vector3> breadcrumbs;

	public float segmentSpacing;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
