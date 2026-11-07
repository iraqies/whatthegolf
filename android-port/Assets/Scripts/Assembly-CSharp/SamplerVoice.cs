using UnityEngine;

public class SamplerVoice : MonoBehaviour
{
	private readonly ASREnvelope _envelope;

	private AudioSource _audioSource;

	private uint _samplesUntilEnvelopeTrigger;

	private void Awake()
	{
	}

	public void Play(AudioClip audioClip, float pitch, double startTime, double attackTime, double sustainTime, double releaseTime)
	{
	}

	private void OnAudioFilterRead(float[] buffer, int numChannels)
	{
	}
}
