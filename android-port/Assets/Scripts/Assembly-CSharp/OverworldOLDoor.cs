using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using CameraStack;
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

	private Vector3 doorStart;

	public float trophyPushForce;

	public float trophyPushTorque;

	public PlantParticles openParticles;

	[NonSerialized]
	public OverworldID overworldID;

	private bool isOpening;

	public void SetCamera(OverworldCamera overworldCamera)
	{
	}

	public void Init()
	{
	}

	public void OpenDoor(Action onOpen, Vector2 direction, bool instant = false)
	{
	}

	public IEnumerator OpenDoorRoutine(Action onOpen, Vector2 direction, float duration, bool playEndSounds = true)
	{
		return null;
	}

	private void OnDisable()
	{
	}

	public void RemoveButton()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
