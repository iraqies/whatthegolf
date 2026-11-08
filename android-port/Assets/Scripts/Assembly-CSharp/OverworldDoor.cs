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
		float dur = instant ? 0f : RoutineLength;
		if (dur <= 0f || !gameObject.activeInHierarchy)
		{
			if (Button != null) Button.SetActive(false);
			Vector3 localRight = transform.InverseTransformDirection(transform.right);
			if (LeftDoor != null) LeftDoor.localPosition = leftStart - localRight * DoorExtend;
			if (RightDoor != null) RightDoor.localPosition = rightStart + localRight * DoorExtend;
			if (Colliders != null)
			{
				foreach (var c in Colliders)
					if (c != null) c.enabled = false;
			}
			onOpen?.Invoke();
		}
		else
		{
			StartCoroutine(OpenDoorRoutineInternal(onOpen, dur, true));
		}
	}

	private IEnumerator OpenDoorRoutineInternal(Action onOpen, float duration, bool playEndSounds)
	{
		if (Button != null) Button.SetActive(false);
		if (duration > 0f && canPlaySound && SFX != null)
		{
			SFX.Play(transform.position);
		}
		if (duration > 0f)
			yield return new WaitForSeconds(0.5f);

		Vector3 localRight = transform.InverseTransformDirection(transform.right);
		Vector3 leftEnd = leftStart - localRight * DoorExtend;
		Vector3 rightEnd = rightStart + localRight * DoorExtend;

		float elapsed = 0f;
		while (elapsed < duration && duration > 0f)
		{
			elapsed += Time.deltaTime;
			float t = Mathf.Clamp01(elapsed / duration);
			float eval = animationCurve != null && animationCurve.length > 0 ? animationCurve.Evaluate(t) : t;
			if (LeftDoor != null) LeftDoor.localPosition = Vector3.Lerp(leftStart, leftEnd, eval);
			if (RightDoor != null) RightDoor.localPosition = Vector3.Lerp(rightStart, rightEnd, eval);
			yield return null;
		}
		if (LeftDoor != null) LeftDoor.localPosition = leftEnd;
		if (RightDoor != null) RightDoor.localPosition = rightEnd;

		if (Colliders != null)
		{
			foreach (var c in Colliders)
				if (c != null) c.enabled = false;
		}
		onOpen?.Invoke();
	}

	public Task OpenDoorAsync(Action onOpen, float duration, bool playEndSounds = true)
	{
		OpenDoor(onOpen, duration <= 0f);
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
