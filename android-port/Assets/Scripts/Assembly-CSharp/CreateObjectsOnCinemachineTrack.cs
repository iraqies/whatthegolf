using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

[ExecuteAlways]
public class CreateObjectsOnCinemachineTrack : MonoBehaviour
{
	public CinemachineSmoothPath Path;

	public List<GameObject> ObjectsToPlace;

	public Vector3 RotationOffsetEuler;

	public float OffsetAlongUpVector;

	public float Resolution;

	public bool Place;

	private void Update()
	{
	}

	private void PlaceObjects()
	{
	}
}
