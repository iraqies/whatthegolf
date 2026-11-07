using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

[ExecuteAlways]
public class CreateObjectsOnCinemachineSmoothPath : MonoBehaviour
{
	public CinemachineSmoothPath Path;

	public List<GameObject> ObjectsToPlace;

	public Vector3 RotationOffsetEuler;

	public float OffsetAlongUpVector;

	public float DistanceInterval;

	public Vector3 ObjectScale;

	public bool ObjectHasPhysics;

	public bool Place;

	private void Update()
	{
	}

	private void PlaceObjects()
	{
	}
}
