using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingingHole : MonoBehaviour
{
	public List<int> beats;

	public float durationIn;

	public float speedMod;

	public float durationOut;

	public float audiosourceDelay;

	public float to;

	public ParticleSystem particles;

	private AudioSource audioSrc;

	public AnimationCurve animationCurveIn;

	public AnimationCurve animationCurveOut;

	public int beatCount;

	public float stayOpenDuration;

	private int timeFloor;

	private int ptimeFloor;

	private float time;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private IEnumerator ScaleUpCR()
	{
		return null;
	}
}
