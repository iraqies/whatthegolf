using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEater : MonoBehaviour
{
	public float EatInterval;

	public float EatDistance;

	public float EatDuration;

	public AnimationCurve EatCurve;

	public List<AudioClip> MoveClips;

	public List<AudioClip> EatClips;

	public ParticleSystem Particles;

	public float Duration;

	public float Magnitude;

	public float Speed;

	private float timer;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private IEnumerator EatLevel(float dist)
	{
		return null;
	}
}
