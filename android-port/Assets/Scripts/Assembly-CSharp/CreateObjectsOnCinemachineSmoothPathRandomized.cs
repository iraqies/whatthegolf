using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

[ExecuteAlways]
public class CreateObjectsOnCinemachineSmoothPathRandomized : MonoBehaviour
{
	public CinemachineSmoothPath Path;

	public List<GameObject> ObjectsToPlace;

	public Vector3 RotationOffsetEuler;

	public float OffsetAlongUpVector;

	public float DistanceInterval;

	public int NumberOfRows;

	public float RowsOffset;

	public Vector2 PlacementRandomVector;

	public Vector2 RotationRandomVector;

	public bool Place;

	private void Update()
	{
	}

	private void PlaceObjects()
	{
	}
}
