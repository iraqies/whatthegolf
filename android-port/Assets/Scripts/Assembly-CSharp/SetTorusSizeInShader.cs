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
		for (int i = 0; i < Sizes.Count; i++)
		{
			GameObject gameObject = new GameObject("TestPosition");
			gameObject.transform.SetParent(Bottom);
			gameObject.transform.localPosition = new Vector3(0f, TestPositionSpacing * (float)i, 0f);
			Sizes[i].TestPosition = gameObject.transform;
			Sizes[i].Size = 1f;
		}
		if (Mat != null && Sizes.Count >= 1)
		{
			Mat.SetFloatArray("_Sizes", Sizes.Select((Shape s) => s.Size).ToArray());
		}
		Controller.OnShoot += ControllerOnOnShoot;
	}

	private void ControllerOnOnShoot(Vector3 obj)
	{
		hasShot = true;
	}

	private void Update()
	{
		if (!hasShot || !Sizes.Any((Shape s) => Vector3.Distance(s.TestPosition.position, GiraffeHand.position) < DistanceThreshold))
		{
			return;
		}
		if (!clayAudioSource.isPlaying)
		{
			clayAudioSource.Play();
		}
		Shape shape = Sizes.OrderBy((Shape s) => Vector3.Distance(s.TestPosition.position, GiraffeHand.position)).FirstOrDefault();
		if (shape != null)
		{
			float num = Mathf.Max(shape.Size - Time.deltaTime * SculptSpeed, WinFat);
			if (num < shape.Size)
			{
				targetVolume = 1f;
				shape.Size = num;
				Particles.Emit((UnityEngine.Random.value > 0.5f) ? 1 : 0);
			}
			else
			{
				targetVolume = 0f;
			}
		}
		clayAudioSource.volume = Mathf.MoveTowards(clayAudioSource.volume, targetVolume, Time.deltaTime * 4f);
		bool flag = true;
		for (int i = 0; i < Sizes.Count; i++)
		{
			if (Sizes[i].Size > WinFat)
			{
				flag = false;
				break;
			}
		}
		if (flag && LevelManager.Instance.getIsReallyInLevel)
		{
			Level.Instance.Complete();
		}
		if (Mat != null && Sizes.Count >= 1)
		{
			Mat.SetFloatArray("_Sizes", Sizes.Select((Shape s) => s.Size).ToArray());
		}
	}

	private void OnDrawGizmosSelected()
	{
		if (!Application.isPlaying && Mat != null)
		{
			float[] array = new float[10];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = TestSize;
			}
			Mat.SetFloatArray("_Sizes", array);
		}
	}
}
