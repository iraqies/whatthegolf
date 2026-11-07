using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using CameraStack;
using UnityEngine;

public class ConfettiSpawner : MonoBehaviour, IAudioEvent
{
	[SerializeField]
	private Confetti confettiPrefab;

	[SerializeField]
	private int amount;

	[SerializeField]
	private List<AudioClip> confettiShootSounds;

	[SerializeField]
	private OverworldCamera overworldCam;

	[SerializeField]
	private bool alwaysPlay;

	[SerializeField]
	private ClipSettingsCollection confettiLayerOne;

	[SerializeField]
	private ClipSettingsCollection confettiLayerTwo;

	[SerializeField]
	private ClipSettingsCollection crownLayerOne;

	private Queue<Confetti> spawnedConfetti;

	private int maxConfettiCount;

	private int innerAmount;

	private Coroutine confettiSpawnRoutine;

	public Action<Vector3> OnAudioEvent { get; set; }

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private IEnumerator PopulatePool()
	{
		return null;
	}

	public void RemoteSpawn(Vector3 position, bool isCrown)
	{
	}

	private IEnumerator ConfettiRoutine(Vector3 pos, bool isCrown)
	{
		return null;
	}

	public void PlayConfettiSound(bool isCrown)
	{
	}

	public void SpawnConfetti(Vector3 position)
	{
	}
}
