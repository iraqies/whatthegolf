using UnityEngine;

public class SamplerVoice : MonoBehaviour
{
	private readonly ASREnvelope _envelope = new ASREnvelope();

	private AudioSource _audioSource;

	private uint _samplesUntilEnvelopeTrigger;

	private void Awake()
	{
		_audioSource = GetComponent<AudioSource>();
	}

	public void Play(AudioClip audioClip, float pitch, double startTime, double attackTime, double sustainTime, double releaseTime)
	{
		int sampleRate = AudioSettings.outputSampleRate;
		double sustain = sustainTime > attackTime ? sustainTime - attackTime : 0.0;
		_envelope.Reset(attackTime, sustain, releaseTime, sampleRate);
		double delay = startTime > AudioSettings.dspTime ? startTime - AudioSettings.dspTime : 0.0;
		double samples = delay * sampleRate;
		_samplesUntilEnvelopeTrigger = samples < 0.0 ? (uint)(int)samples : (uint)samples;
		if (_audioSource != null)
		{
			_audioSource.clip = audioClip;
			_audioSource.pitch = pitch;
			_audioSource.PlayScheduled(startTime);
		}
	}

	private void OnAudioFilterRead(float[] buffer, int numChannels)
	{
		if (buffer == null || buffer.Length < 1)
		{
			return;
		}
		for (int i = 0; i < buffer.Length; i += numChannels)
		{
			float env;
			if (_samplesUntilEnvelopeTrigger != 0)
			{
				_samplesUntilEnvelopeTrigger--;
				env = 0f;
			}
			else
			{
				env = (float)_envelope.GetLevel();
			}
			for (int c = 0; c < numChannels && i + c < buffer.Length; c++)
			{
				buffer[i + c] *= env;
			}
		}
	}
}
