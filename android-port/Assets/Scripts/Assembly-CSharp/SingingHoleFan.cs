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
		audioSrc = GetComponent<AudioSource>();
		if (flag != null)
		{
			flagStartPosition = flag.transform.localPosition;
		}
	}

	private void Update()
	{
		time += Time.deltaTime * speedMod;
		timeFloor = Mathf.FloorToInt(time);
		if (beats != null && beatCount > 0 && beats.Contains(timeFloor % beatCount) && timeFloor != ptimeFloor)
		{
			StartCoroutine(ScaleUpCR());
		}
		ptimeFloor = timeFloor;
	}

	private IEnumerator ScaleUpCR()
	{
		if (flag != null)
		{
			StartCoroutine(pTween.To(0.2f, 0f, 1f, delegate(float t)
			{
				if (flag != null && animationCurveIn != null)
				{
					Vector3 b = flagStartPosition + new Vector3(0f, flagHeight, 0f);
					flag.transform.localPosition = Vector3.LerpUnclamped(flagStartPosition, b, animationCurveIn.Evaluate(t));
				}
			}));
		}
		StartCoroutine(pTween.To(0.2f, 0f, 1f, delegate(float t)
		{
			if (fan != null && animationCurveIn != null)
			{
				fan.transform.localScale = Vector3.LerpUnclamped(Vector3.zero, new Vector3(0.2f, 0.2f, 0.2f), animationCurveIn.Evaluate(t));
			}
		}));
		StartCoroutine(pTween.To(0.2f, 0f, 1f, delegate(float t)
		{
			if (windParticles != null && animationCurveIn != null)
			{
				windParticles.transform.localScale = Vector3.LerpUnclamped(Vector3.zero, Vector3.one, animationCurveIn.Evaluate(t));
			}
		}));
		if (_mouthAnimator != null)
		{
			_mouthAnimator.SetBool("isSinging", value: true);
		}
		yield return new WaitForSeconds(audiosourceDelay);
		if (audioSrc != null)
		{
			audioSrc.Stop();
		}
		if (nodeParticles != null)
		{
			nodeParticles.Play();
		}
		if (audioSrc != null)
		{
			audioSrc.Play();
		}
		yield return new WaitForSeconds(stayOpenDuration);
		yield return new WaitForSeconds(durationIn - audiosourceDelay);
		if (flag != null)
		{
			StartCoroutine(pTween.To(0.2f, 0f, 1f, delegate(float t)
			{
				if (flag != null && animationCurveIn != null)
				{
					Vector3 a = flagStartPosition + new Vector3(0f, flagHeight, 0f);
					flag.transform.localPosition = Vector3.LerpUnclamped(a, flagStartPosition, animationCurveIn.Evaluate(t));
				}
			}));
		}
		StartCoroutine(pTween.To(0.2f, 0f, 1f, delegate(float t)
		{
			if (fan != null && animationCurveOut != null)
			{
				fan.transform.localScale = Vector3.LerpUnclamped(new Vector3(0.2f, 0.2f, 0.2f), Vector3.zero, animationCurveOut.Evaluate(t));
			}
		}));
		StartCoroutine(pTween.To(0.2f, 0f, 1f, delegate(float t)
		{
			if (windParticles != null && animationCurveOut != null)
			{
				windParticles.transform.localScale = Vector3.LerpUnclamped(Vector3.one, Vector3.zero, animationCurveOut.Evaluate(t));
			}
		}));
		if (_mouthAnimator != null)
		{
			_mouthAnimator.SetBool("isSinging", value: false);
		}
		yield return new WaitForSeconds(durationOut);
	}

	public SingingHoleFan()
	{
		to = 1f;
		beatCount = 4;
		stayOpenDuration = 1f;
		ptimeFloor = -1;
	}
}
