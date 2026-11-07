using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Audio;
using CameraStack;
using UnityEngine;

public class OverworldDoor : MonoBehaviour
{
	public Transform LeftDoor;

	public Transform RightDoor;

	public GameObject Button;

	public AnimationCurve animationCurve;

	public float RoutineLength;

	public float DoorExtend;

	public GameObject DoorSides;

	public List<Collider2D> Colliders;

	public bool DebugThisDoor;

	public Vector3[] corners;

	public float BallDistanceThreshold;

	public float Speed;

	public float Magnitude;

	public bool canPlaySound;

	public PlayClipOnAudioEvent SFX;

	private OverworldCamera cam;

	private Vector3 leftStart;

	private Vector3 rightStart;

	public void SetCamera(OverworldCamera overworldCamera)
	{
	}

	public void Init()
	{
	}

	public void OpenDoor(Action onOpen, bool instant = false)
	{
	}

	public Task OpenDoorAsync(Action onOpen, float duration, bool playEndSounds = true)
	{
		return null;
	}

	private Task MoveDoorsOpen(float duration)
	{
		return null;
	}

	public void RemoveButton()
	{
	}

	public IEnumerator CloseDoorRoutine(Action onClose, float duration, bool playEndSounds = true)
	{
		return null;
	}

	public Vector3 GetCornerInThatDirection(Vector3 worldDir)
	{
		return default;
	}

	private void OnDrawGizmos()
	{
	}
}
