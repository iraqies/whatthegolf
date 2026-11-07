using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingingHoleFan : MonoBehaviour
{
	public List<int> beats;

	public float durationIn;

	public float speedMod;

	public float durationOut;

	public float audiosourceDelay;

	public float to;

	public GameObject fan;

	public ParticleSystem nodeParticles;

	public ParticleSystem windParticles;

	private AudioSource audioSrc;

	public AnimationCurve animationCurveIn;

	public AnimationCurve animationCurveOut;

	public int beatCount;

	public float stayOpenDuration;

	private int timeFloor;

	private int ptimeFloor;

	private float time;

	public GameObject flag;

	public float flagHeight;

	private Vector3 flagStartPosition;

	[SerializeField]
	private Animator _mouthAnimator;

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
