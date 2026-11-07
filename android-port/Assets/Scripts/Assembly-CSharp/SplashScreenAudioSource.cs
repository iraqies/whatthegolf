using System.Collections;
using UnityEngine;

public class SplashScreenAudioSource : MonoBehaviour
{
	[SerializeField]
	private float m_QuickFadeTime;

	[SerializeField]
	private float m_NormalFadeTime;

	private Coroutine fadeCoroutine;

	private AudioSource source;

	private void Awake()
	{
	}

	public void Play()
	{
	}

	public void OnSplashScreenComplete(bool skip)
	{
	}

	private IEnumerator FadeAndDestroy(float time)
	{
		return null;
	}
}
