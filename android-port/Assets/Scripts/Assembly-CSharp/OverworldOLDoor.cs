using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using Audio.Rumble;
using CameraStack;
using Core;
using UnityEngine;

public class OverworldOLDoor : MonoBehaviour
{
	public Transform door;

	public Rigidbody2D trophy;

	public SpriteRenderer trophyRender;

	public Collider2D trophyCollider;

	public GameObject Button;

	public SpriteRenderer doorSide;

	public SpriteRenderer doorTop;

	public AnimationCurve animationCurve;

	public float RoutineLength = 0.6f;

	public float DoorExtend = 1.5f;

	public GameObject DoorSides;

	public List<Collider2D> Colliders;

	public bool DebugThisDoor;

	public Vector3[] corners;

	public float BallDistanceThreshold = 15f;

	public float Speed = 20f;

	public float Magnitude = 0.1f;

	public bool canPlaySound = true;

	public PlayClipOnAudioEvent SFX;

	private OverworldCamera cam;

	private Vector3 doorStart;

	public float trophyPushForce = 25f;

	public float trophyPushTorque = 25f;

	public PlantParticles openParticles;

	[NonSerialized]
	public OverworldID overworldID;

	private bool isOpening;

	public void SetCamera(OverworldCamera overworldCamera)
	{
		cam = overworldCamera;
	}

	public void Init()
	{
		if (trophy != null)
		{
			trophyRender = trophy.GetComponentInChildren<SpriteRenderer>();
		}
		if (door != null)
		{
			doorStart = door.localPosition;
		}
		overworldID = GetComponent<OverworldID>();
	}

	public void OpenDoor(Action onOpen, Vector2 direction, bool instant = false)
	{
		float duration = (instant ? 0f : RoutineLength);
		Vector2 dir = (instant ? Vector2.zero : direction);
		StartCoroutine(OpenDoorRoutine(onOpen, dir, duration));
	}

	public IEnumerator OpenDoorRoutine(Action onOpen, Vector2 direction, float duration, bool playEndSounds = true)
	{
		isOpening = true;
		if (Button != null)
		{
			Button.SetActive(false);
		}
		bool notInstant = duration > 0f;
		if (notInstant)
		{
			if (canPlaySound && SFX != null)
			{
				SFX.Play(base.transform.position);
			}
			yield return new WaitForSecondsRealtime(0.5f);
		}
		if (PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null && PlatformSettings.Instance.GetCurrent().useRumble && notInstant && TryGetComponent<OverworldDoorRumble>(out var component) && component != null)
		{
			component.OpenDoorRumble(duration);
		}
		if (PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null && PlatformSettings.Instance.GetCurrent().useSaveThrobber)
		{
			SaveThrobber.ShowThrobber(0.5f);
		}
		yield return StartCoroutine(pTween.To(duration, delegate(float t)
		{
			if (animationCurve != null && door != null && doorSide != null)
			{
				float num = Mathf.Clamp01(animationCurve.Evaluate(t));
				Vector3 vector = base.transform.InverseTransformDirection(base.transform.up);
				float y = doorSide.bounds.size.y;
				Vector3 b = doorStart - vector * y;
				door.localPosition = Vector3.Lerp(doorStart, b, num);
			}
		}).Then(delegate
		{
			if (trophyCollider != null)
			{
				trophyCollider.enabled = true;
			}
			if (notInstant)
			{
				if (trophy != null)
				{
					trophy.AddForce(direction * trophyPushForce, ForceMode2D.Impulse);
					int num2 = UnityEngine.Random.Range(0, 1);
					trophy.AddTorque((num2 > 0) ? (0f - trophyPushTorque) : trophyPushTorque, ForceMode2D.Impulse);
				}
				if (openParticles != null)
				{
					openParticles.Emit(40);
				}
			}
			if (doorSide != null)
			{
				doorSide.gameObject.SetActive(false);
			}
			if (doorTop != null)
			{
				doorTop.gameObject.SetActive(false);
			}
			if (trophyRender != null)
			{
				trophyRender.sortingOrder -= 3;
			}
		}));
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.ball != null)
		{
			if (Vector3.Distance(OverworldBallManager.Instance.ball.transform.position, base.transform.position) < BallDistanceThreshold && cam != null)
			{
				cam.Shake(0.2f, Speed, Magnitude);
			}
		}
		if (Colliders != null)
		{
			foreach (Collider2D collider in Colliders)
			{
				if (collider != null)
				{
					collider.enabled = false;
				}
			}
		}
		onOpen?.Invoke();
		isOpening = false;
	}

	private void OnDisable()
	{
		if (!isOpening)
		{
			return;
		}
		if (trophyCollider != null)
		{
			trophyCollider.enabled = true;
		}
		if (doorSide != null)
		{
			doorSide.gameObject.SetActive(false);
		}
		if (doorTop != null)
		{
			doorTop.gameObject.SetActive(false);
		}
		if (trophyRender != null)
		{
			trophyRender.sortingOrder -= 3;
		}
		if (Colliders != null)
		{
			foreach (Collider2D collider in Colliders)
			{
				if (collider != null)
				{
					collider.enabled = false;
				}
			}
		}
		isOpening = false;
	}

	public void RemoveButton()
	{
		if (Button != null)
		{
			Button.SetActive(false);
		}
	}

	private void OnDrawGizmos()
	{
		if (corners != null)
		{
			for (int i = 0; i < corners.Length; i++)
			{
				Gizmos.color = Color.yellow;
				Gizmos.DrawSphere(base.transform.TransformPoint(corners[i]), 0.1f);
			}
		}
		if (doorSide != null)
		{
			Gizmos.color = Color.green;
			Vector3 from = doorSide.bounds.center + base.transform.up * doorSide.bounds.extents.y;
			Vector3 to = doorSide.bounds.center - base.transform.up * doorSide.bounds.extents.y;
			Gizmos.DrawLine(from, to);
		}
	}
}
