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
	public float RoutineLength = 0.5f;
	public float DoorExtend = 2f;
	public GameObject DoorSides;
	public List<Collider2D> Colliders = new List<Collider2D>();
	public bool DebugThisDoor;
	public Vector3[] corners;
	public float BallDistanceThreshold = 3f;
	public float Speed = 5f;
	public float Magnitude = 1f;
	public bool canPlaySound = true;
	public PlayClipOnAudioEvent SFX;

	private OverworldCamera cam;
	private Vector3 leftStart;
	private Vector3 rightStart;
	private bool _inited;

	public void SetCamera(OverworldCamera overworldCamera) => cam = overworldCamera;

	public void Init()
	{
		if (_inited) return;
		_inited = true;
		if (LeftDoor != null) leftStart = LeftDoor.localPosition;
		if (RightDoor != null) rightStart = RightDoor.localPosition;
	}

	public void OpenDoor(Action onOpen, bool instant = false)
	{
		Init();
		if (LeftDoor != null) LeftDoor.localPosition = leftStart + Vector3.left * DoorExtend;
		if (RightDoor != null) RightDoor.localPosition = rightStart + Vector3.right * DoorExtend;
		if (Colliders != null)
		{
			foreach (var c in Colliders)
				if (c != null) c.enabled = false;
		}
		onOpen?.Invoke();
	}

	public Task OpenDoorAsync(Action onOpen, float duration, bool playEndSounds = true)
	{
		OpenDoor(onOpen, false);
		return Task.CompletedTask;
	}

	private Task MoveDoorsOpen(float duration) => Task.CompletedTask;

	public void RemoveButton()
	{
		if (Button != null) Button.SetActive(false);
	}

	public IEnumerator CloseDoorRoutine(Action onClose, float duration, bool playEndSounds = true)
	{
		Init();
		if (LeftDoor != null) LeftDoor.localPosition = leftStart;
		if (RightDoor != null) RightDoor.localPosition = rightStart;
		if (Colliders != null)
		{
			foreach (var c in Colliders)
				if (c != null) c.enabled = true;
		}
		onClose?.Invoke();
		yield break;
	}

	public Vector3 GetCornerInThatDirection(Vector3 worldDir) => transform.position;
	private void OnDrawGizmos() { }
}
