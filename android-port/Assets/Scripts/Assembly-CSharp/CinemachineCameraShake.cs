using System.Collections;
using Cinemachine;
using UnityEngine;

public class CinemachineCameraShake : MonoBehaviour
{
	private CinemachineBasicMultiChannelPerlin noise;

	private void Start()
	{
		noise = GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
	}

	public void Shake(float amplitudeGain, float frequencyGain, float duration)
	{
		StartCoroutine(ShakeRoutine(amplitudeGain, frequencyGain, duration));
	}

	private IEnumerator ShakeRoutine(float amplitudeGain, float frequencyGain, float duration)
	{
		noise.m_AmplitudeGain = amplitudeGain;
		noise.m_FrequencyGain = frequencyGain;
		yield return StartCoroutine(pTween.ToRealTime(duration, delegate(float t)
		{
			noise.m_AmplitudeGain = Mathf.Lerp(amplitudeGain, 0f, t);
			noise.m_FrequencyGain = Mathf.Lerp(frequencyGain, 0f, t);
		}));
		noise.m_AmplitudeGain = 0f;
		noise.m_FrequencyGain = 0f;
	}
}
