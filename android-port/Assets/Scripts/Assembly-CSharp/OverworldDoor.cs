using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Audio;
using Audio.Rumble;
using CameraStack;
using Core;
using UnityEngine;

public class OverworldDoor : MonoBehaviour
{
	public Transform LeftDoor;
	public Transform RightDoor;
	public GameObject Button;
	public AnimationCurve animationCurve;
	public float RoutineLength = 0.6f;
	public float DoorExtend = 1.5f;
	public GameObject DoorSides;
	public List<Collider2D> Colliders = new List<Collider2D>();
	public bool DebugThisDoor;
	public Vector3[] corners;
	public float BallDistanceThreshold = 15f;
	public float Speed = 20f;
	public float Magnitude = 0.1f;
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

	public async void OpenDoor(Action onOpen, bool instant = false)
	{
		Init();
		float dur = instant ? 0f : RoutineLength;
		await OpenDoorAsync(onOpen, dur, !instant);
	}

	public async Task OpenDoorAsync(Action onOpen, float duration, bool playEndSounds = true)
	{
		Init();
		if (Button != null)
			Button.SetActive(false);

		bool hasDuration = duration > 0f;
		if (hasDuration)
		{
			if (canPlaySound && SFX != null)
				SFX.Play(transform.position);
			await Task.Delay(500);
		}

		var curCfg = PlatformSettings.Instance != null ? PlatformSettings.Instance.GetCurrent() : null;
		if (curCfg != null && curCfg.useRumble && hasDuration)
		{
			if (TryGetComponent<OverworldDoorRumble>(out var doorRumble) && doorRumble != null)
				doorRumble.OpenDoorRumble(duration);
		}
		if (curCfg != null && curCfg.useSaveThrobber)
		{
			SaveThrobber.ShowThrobber(0.5f);
		}

		await MoveDoorsOpen(duration);

		if (hasDuration && playEndSounds)
		{
			var ballMgr = OverworldBallManager.Instance;
			if (ballMgr != null && ballMgr.Ball != null)
			{
				float dist = Vector3.Distance(ballMgr.Ball.transform.position, transform.position);
				if (dist < BallDistanceThreshold)
				{
					var targetCam = cam != null ? cam : OverworldCamera.Instance;
					if (targetCam != null)
						targetCam.Shake(0.2f, Speed, Magnitude);
				}
			}
		}

		if (Colliders != null)
		{
			foreach (var c in Colliders)
			{
				if (c != null)
					c.enabled = false;
			}
		}

		onOpen?.Invoke();
	}

	private async Task MoveDoorsOpen(float duration)
	{
		float startTime = Time.time;
		float endTime = startTime + duration;
		float curTime = startTime;

		do
		{
			curTime = Time.time;
			float eval = 1f;
			if (duration != 0f)
			{
				float t = Mathf.InverseLerp(startTime, endTime, curTime);
				eval = animationCurve != null && animationCurve.length > 0 ? animationCurve.Evaluate(t) : t;
			}
			float ct = Mathf.Clamp01(eval);
			Vector3 localRight = transform.InverseTransformDirection(transform.right);
			if (LeftDoor != null)
				LeftDoor.localPosition = Vector3.Lerp(leftStart, leftStart - localRight * DoorExtend, ct);
			if (RightDoor != null)
				RightDoor.localPosition = Vector3.Lerp(rightStart, rightStart + localRight * DoorExtend, ct);

			if (duration <= 0f)
				break;
			await Task.Delay(16);
		}
		while (curTime <= endTime);
	}

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

	public Vector3 GetCornerInThatDirection(Vector3 worldDir)
	{
		if (corners == null || corners.Length == 0)
			return transform.position;
		Vector3 best = transform.position;
		float bestDot = float.NegativeInfinity;
		Vector3 dirNorm = worldDir.normalized;
		for (int i = 0; i < corners.Length; i++)
		{
			Vector3 wp = transform.TransformPoint(corners[i]);
			Vector3 toCorner = (wp - transform.position).normalized;
			float d = Vector3.Dot(toCorner, dirNorm);
			if (d > bestDot)
			{
				bestDot = d;
				best = wp;
			}
		}
		return best;
	}

	private void OnDrawGizmos() { }
}
