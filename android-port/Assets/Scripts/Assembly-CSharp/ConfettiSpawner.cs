using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using CameraStack;
using Core;
using UnityEngine;

public class ConfettiSpawner : MonoBehaviour, IAudioEvent
{
	[SerializeField]
	private Confetti confettiPrefab;

	[SerializeField]
	private int amount = 10;

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

	private int innerAmount = 5;

	private Coroutine confettiSpawnRoutine;

	private GolfGoal goal;

	public Action<Vector3> OnAudioEvent { get; set; }

	private void Awake()
	{
		maxConfettiCount = innerAmount * amount;
		spawnedConfetti = new Queue<Confetti>();
	}

	private void OnEnable()
	{
		goal = GetComponentInParent<GolfGoal>();
		if (spawnedConfetti == null)
		{
			maxConfettiCount = innerAmount * amount;
			spawnedConfetti = new Queue<Confetti>();
		}
		if (spawnedConfetti.Count < maxConfettiCount && confettiSpawnRoutine == null && confettiPrefab != null)
		{
			confettiSpawnRoutine = StartCoroutine(PopulatePool());
		}
	}

	private void OnDisable()
	{
		confettiSpawnRoutine = null;
	}

	private void Instance_OnComplete(Level.CompletedState obj)
	{
		RemoteSpawn(transform.position, false);
	}

	private IEnumerator PopulatePool()
	{
		if (confettiPrefab == null)
		{
			yield break;
		}
		Transform trans = transform;
		while (spawnedConfetti.Count < maxConfettiCount)
		{
			for (int i = 0; i < 5 && spawnedConfetti.Count < maxConfettiCount; i++)
			{
				Confetti confetti = UnityEngine.Object.Instantiate(confettiPrefab, trans.position - Vector3.forward * 0.01f, Quaternion.identity, trans);
				if (confetti != null)
				{
					spawnedConfetti.Enqueue(confetti);
					confetti.gameObject.SetActive(false);
				}
			}
			yield return null;
		}
		confettiSpawnRoutine = null;
	}

	public void RemoteSpawn(Vector3 position, bool isCrown)
	{
		if (overworldCam != null)
		{
			overworldCam.Shake(0.15f, 200f, 0.4f);
		}
		StartCoroutine(ConfettiRoutine(position, isCrown));
	}

	private IEnumerator ConfettiRoutine(Vector3 pos, bool isCrown)
	{
		PlayConfettiSound(isCrown);
		int spawnWaves = Mathf.Min(amount, 20);
		for (int wave = 0; wave < spawnWaves; wave++)
		{
			for (int i = 0; i < innerAmount; i++)
			{
				SpawnConfetti(pos);
			}
			yield return null;
		}
	}

	public void PlayConfettiSound(bool isCrown)
	{
		if (AudioManager.Instance == null || AudioManager.Instance.sfx == null)
		{
			return;
		}
		AudioSources sfx = AudioManager.Instance.sfx;
		if (!isCrown || alwaysPlay)
		{
			if (confettiLayerOne != null)
			{
				confettiLayerOne.Play(sfx, transform.position, 0f);
			}
			if (confettiLayerTwo != null)
			{
				confettiLayerTwo.Play(sfx, transform.position, 0f);
			}
		}
		else if (crownLayerOne != null)
		{
			crownLayerOne.Play(sfx, transform.position, 0f);
		}
		OnAudioEvent?.Invoke(Vector3.zero);
	}

	public void SpawnConfetti(Vector3 position)
	{
		if (confettiPrefab == null || spawnedConfetti == null)
		{
			return;
		}
		if (spawnedConfetti.Count == 0)
		{
			Confetti extra = UnityEngine.Object.Instantiate(confettiPrefab, position - Vector3.forward * 0.01f, Quaternion.identity, transform);
			if (extra != null)
			{
				extra.gameObject.SetActive(true);
				extra.Initiate();
				spawnedConfetti.Enqueue(extra);
			}
			return;
		}
		Confetti confetti = spawnedConfetti.Dequeue();
		if (confetti != null)
		{
			confetti.transform.position = position - Vector3.forward * 0.01f;
			confetti.gameObject.SetActive(true);
			confetti.Initiate();
			spawnedConfetti.Enqueue(confetti);
		}
	}
}
