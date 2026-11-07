using System.Collections.Generic;
using CameraStack;
using UnityEngine;

public class MultiplePlayerCameraFollow : MonoBehaviour
{
	public List<Transform> objectsToFollow;

	public float HeightMod;

	public float HeightChangeSpeed;

	public float PositionChangeSpeed;

	public Vector2 ElevationRanges;

	public Vector2 HeightBounds;

	public bool LockYAxis;

	public Transform GoalTransform;

	public float MaxFollowNumber;

	private CBFollow followCam;

	private List<Transform> toBeRemoved;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
