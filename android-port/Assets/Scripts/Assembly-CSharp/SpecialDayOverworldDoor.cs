using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Audio;
using UnityEngine;

public class SpecialDayOverworldDoor : MonoBehaviour
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

	private Vector3 leftStart;

	private Vector3 rightStart;

	private bool _startsInitialized;

	private void EnsureStarts()
	{
		if (!_startsInitialized)
		{
			_startsInitialized = true;
			if (LeftDoor != null) leftStart = LeftDoor.localPosition;
			if (RightDoor != null) rightStart = RightDoor.localPosition;
		}
	}

	public async void OpenDoor(Action onOpen, bool instant = false)
	{
		EnsureStarts();
		await OpenDoorAsync(onOpen, instant ? 0f : RoutineLength);
	}

	public async void CloseDoor(Action onClose, bool instant = false)
	{
		EnsureStarts();
		await CloseDoorAsync(onClose, instant ? 0f : RoutineLength);
	}

	private async Task OpenDoorAsync(Action onOpen, float duration)
	{
		await MoveDoorsAsync(shouldOpen: true, duration);
		if (Colliders != null)
		{
			foreach (var c in Colliders)
			{
				if (c != null) c.enabled = false;
			}
		}
		onOpen?.Invoke();
	}

	private async Task MoveDoorsAsync(bool shouldOpen, float duration)
	{
		EnsureStarts();
		float startTime = Time.time;
		float endTime = startTime + duration;
		Vector3 dir = transform.InverseTransformDirection(transform.right) * DoorExtend;
		Vector3 leftOpen = leftStart - dir;
		Vector3 rightOpen = rightStart + dir;
		do
		{
			float t = (duration <= 0f) ? 1f : ((animationCurve != null) ? animationCurve.Evaluate(Mathf.InverseLerp(startTime, endTime, Time.time)) : Mathf.InverseLerp(startTime, endTime, Time.time));
			t = Mathf.Clamp01(t);
			if (LeftDoor != null)
			{
				LeftDoor.localPosition = Vector3.Lerp(shouldOpen ? leftStart : leftOpen, shouldOpen ? leftOpen : leftStart, t);
			}
			if (RightDoor != null)
			{
				RightDoor.localPosition = Vector3.Lerp(shouldOpen ? rightStart : rightOpen, shouldOpen ? rightOpen : rightStart, t);
			}
			if (duration <= 0f) break;
			await Task.Delay(16);
		}
		while (Time.time <= endTime);
	}

	private async Task CloseDoorAsync(Action onClose, float duration, bool playEndSounds = true)
	{
		if (Colliders != null)
		{
			foreach (var c in Colliders)
			{
				if (c != null) c.enabled = true;
			}
		}
		await MoveDoorsAsync(shouldOpen: false, duration);
		onClose?.Invoke();
	}
}
