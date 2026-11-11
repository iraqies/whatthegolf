using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class SetTorusSizeInShader : MonoBehaviour
{
	[Serializable]
	public class Shape
	{
		public float Size;

		public Transform TestPosition;
	}

	public Material Mat;

	public List<Shape> Sizes;

	public Transform GiraffeHand;

	public GolfBallController Controller;

	public float DistanceThreshold = 2f;

	public float RotateSpeed = 800f;

	public float SculptSpeed = 0.5f;

	public float WinFat = 0.2f;

	public ParticleSystem Particles;

	public Transform Bottom;

	public float TestPositionSpacing = 0.1f;

	public float TestSize = 1f;

	public AudioSource clayAudioSource;

	private bool hasShot;

	private float targetVolume;

	private void Awake()
	{
		if (Sizes != null)
		{
			for (int i = 0; i < Sizes.Count; i++)
			{
				GameObject go = new GameObject("TestPosition");
				go.transform.SetParent(Bottom);
				go.transform.localPosition = new Vector3(0f, TestPositionSpacing * i, 0f);
				if (Sizes[i] != null)
				{
					Sizes[i].TestPosition = go.transform;
					Sizes[i].Size = 1f;
				}
			}
			if (Mat != null && Sizes.Count >= 1)
			{
				Mat.SetFloatArray("_Sizes", Sizes.Select(s => s.Size).ToArray());
			}
		}
		if (Controller != null)
		{
			Controller.OnShoot += ControllerOnOnShoot;
		}
	}

	private void ControllerOnOnShoot(Vector3 obj)
	{
		hasShot = true;
	}

	private void Update()
	{
		if (!hasShot || Sizes == null || GiraffeHand == null)
		{
			return;
		}
		if (!Sizes.Any(s => s != null && s.TestPosition != null && Vector3.Distance(s.TestPosition.position, GiraffeHand.position) < DistanceThreshold))
		{
			return;
		}
		if (clayAudioSource != null && !clayAudioSource.isPlaying)
		{
			clayAudioSource.Play();
		}
		Shape closest = Sizes
			.Where(s => s != null && s.TestPosition != null)
			.OrderBy(s => Vector3.Distance(s.TestPosition.position, GiraffeHand.position))
			.FirstOrDefault();
		if (closest != null)
		{
			float nextSize = Mathf.Max(closest.Size - Time.deltaTime * SculptSpeed, WinFat);
			if (nextSize < closest.Size)
			{
				targetVolume = 1f;
				closest.Size = nextSize;
				if (Particles != null)
				{
					Particles.Emit(UnityEngine.Random.value > 0.5f ? 1 : 0);
				}
			}
			else
			{
				targetVolume = 0f;
			}
		}
		if (clayAudioSource != null)
		{
			clayAudioSource.volume = Mathf.MoveTowards(clayAudioSource.volume, targetVolume, Time.deltaTime * 4f);
		}
		bool allDone = true;
		for (int i = 0; i < Sizes.Count; i++)
		{
			if (Sizes[i] != null && Sizes[i].Size > WinFat)
			{
				allDone = false;
				break;
			}
		}
		if (allDone && LevelManager.Instance != null && LevelManager.Instance.IsPlayingLevel && Level.Instance != null)
		{
			Level.Instance.Complete();
		}
		if (Mat != null && Sizes.Count >= 1)
		{
			Mat.SetFloatArray("_Sizes", Sizes.Select(s => s.Size).ToArray());
		}
	}

	private void OnDrawGizmosSelected()
	{
		if (!Application.isPlaying && Mat != null)
		{
			float[] arr = new float[10];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = TestSize;
			}
			Mat.SetFloatArray("_Sizes", arr);
		}
	}
}
