using UnityEngine;

public class AudioFade : MonoBehaviour
{
	private float m_volumeIncrement;

	private int m_sampleRate;

	private float m_gain;

	private bool fadeOut;

	public bool Fading { get; private set; }

	private void Start()
	{
	}

	public void FadeIn(float time)
	{
	}

	public void FadeOut(float time)
	{
	}

	public void Reset()
	{
	}

	private void SetLevel()
	{
	}

	private void OnAudioFilterRead(float[] buffer, int numChannels)
	{
	}
}
