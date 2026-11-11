using UnityEngine;

public class SimpleSamplerVoice : MonoBehaviour
{
	private AudioSource _audioSource;

	public void Play(AudioClip audioClip, double startTime)
	{
		if (_audioSource != null)
		{
			_audioSource.clip = audioClip;
			_audioSource.PlayScheduled(startTime);
		}
	}

	private void Awake()
	{
		_audioSource = GetComponent<AudioSource>();
	}
}
