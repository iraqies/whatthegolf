using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class AASplashScreen : MonoBehaviour
{
	[SerializeField] private CanvasGroup logoCanvasGroup;
	[SerializeField] private AAScreens splashScreens;
	[SerializeField] private VideoContainer videoContainer;
	[SerializeField] private Camera videoCamera;
	[SerializeField] private SplashScreenAudioSource splashAudioSource;

	private static bool splashScreenExecuted;
	private bool tribandLogoDone;
	private Coroutine tribandLogoCR;
	private Logo logo;
	private IVideoPathProvider videoPathProvider;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		splashScreenExecuted = false;
	}

	private void Awake()
	{
		if (logoCanvasGroup != null)
			logoCanvasGroup.alpha = 0f;
	}

	private IEnumerator Start()
	{
		yield break;
	}

	private bool shouldShowLogoScreen() => false;

	public IEnumerator Show(Action OnCoveredBySplash = null, Action OnCompleted = null, Action OnCanShowGCBanner = null)
	{
		if (splashScreenExecuted)
		{
			OnCoveredBySplash?.Invoke();
			OnCanShowGCBanner?.Invoke();
			if (gameObject != null) gameObject.SetActive(false);
			OnCompleted?.Invoke();
			yield break;
		}
		splashScreenExecuted = true;
		gameObject.SetActive(true);
		OnCoveredBySplash?.Invoke();
		if (splashAudioSource != null)
		{
			splashAudioSource.transform.SetParent(null);
			DontDestroyOnLoad(splashAudioSource.gameObject);
			splashAudioSource.Play();
		}
		yield return StartCoroutine(ShowTribandLogoCR(() => tribandLogoDone = true));
		OnCanShowGCBanner?.Invoke();
		if (splashAudioSource != null)
			splashAudioSource.OnSplashScreenComplete(false);
		if (gameObject != null)
			gameObject.SetActive(false);
		OnCompleted?.Invoke();
	}

	private void StartLogoAnimation() { }
	private void OnLogoAnimationEnd(bool skipped) { }
	private bool CheckForButtonSkip() => InputHelper.TouchedOrMouseClicked() || InputHelper.GetAllPlayerButtonConfirm();

	private IEnumerator ShowTribandLogoCR(UnityAction onDone)
	{
		if (logoCanvasGroup != null)
		{
			logoCanvasGroup.gameObject.SetActive(true);
			float t = 0f;
			while (t < 0.45f)
			{
				t += Time.unscaledDeltaTime;
				logoCanvasGroup.alpha = Mathf.Clamp01(t / 0.45f);
				if (CheckForButtonSkip()) break;
				yield return null;
			}
			logoCanvasGroup.alpha = 1f;
			float hold = 0f;
			while (hold < 1.1f)
			{
				hold += Time.unscaledDeltaTime;
				if (CheckForButtonSkip()) break;
				yield return null;
			}
			t = 0f;
			while (t < 0.35f)
			{
				t += Time.unscaledDeltaTime;
				logoCanvasGroup.alpha = 1f - Mathf.Clamp01(t / 0.35f);
				yield return null;
			}
			logoCanvasGroup.alpha = 0f;
		}
		onDone?.Invoke();
	}
}
