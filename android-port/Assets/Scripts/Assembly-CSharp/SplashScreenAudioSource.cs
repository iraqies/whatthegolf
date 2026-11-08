using System.Collections;
using UnityEngine;

public class SplashScreenAudioSource : MonoBehaviour
{
	[SerializeField] private float m_QuickFadeTime = 0.25f;
	[SerializeField] private float m_NormalFadeTime = 1f;
	private Coroutine fadeCoroutine;
	private AudioSource source;

	private void Awake()
	{
		source = GetComponent<AudioSource>();
	}

	public void Play()
	{
		if (source == null) source = GetComponent<AudioSource>();
		if (source != null) source.Play();
	}

	public void OnSplashScreenComplete(bool skip)
	{
		StopAllCoroutines();
		StartCoroutine(FadeAndDestroy(skip ? m_QuickFadeTime : m_NormalFadeTime));
	}

	private IEnumerator FadeAndDestroy(float time)
	{
		if (source != null)
		{
			float startVol = source.volume;
			float elapsed = 0f;
			while (elapsed < time && source != null)
			{
				elapsed += Time.unscaledDeltaTime;
				source.volume = Mathf.Lerp(startVol, 0f, Mathf.Clamp01(elapsed / Mathf.Max(0.05f, time)));
				yield return null;
			}
		}
		if (gameObject != null)
			Destroy(gameObject);
	}
}
