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

	public void OpenDoor(Action onOpen, bool instant = false)
	{
	}

	public void CloseDoor(Action onClose, bool instant = false)
	{
	}

	private Task OpenDoorAsync(Action onOpen, float duration)
	{
		return null;
	}

	private Task MoveDoorsAsync(bool shouldOpen, float duration)
	{
		return null;
	}

	private Task CloseDoorAsync(Action onClose, float duration, bool playEndSounds = true)
	{
		return null;
	}
}
