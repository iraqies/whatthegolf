using System;
using System.Collections.Generic;
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

	public float DistanceThreshold;

	public float RotateSpeed;

	public float SculptSpeed;

	public float WinFat;

	public ParticleSystem Particles;

	public Transform Bottom;

	public float TestPositionSpacing;

	public float TestSize;

	public AudioSource clayAudioSource;

	private bool hasShot;

	private float targetVolume;

	private void Awake()
	{
	}

	private void ControllerOnOnShoot(Vector3 obj)
	{
	}

	private void Update()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
