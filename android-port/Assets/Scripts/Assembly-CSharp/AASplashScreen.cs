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

	private bool shouldShowLogoScreen() => true;

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

		StartLogoAnimation();
		while (!tribandLogoDone)
		{
			if (CheckForButtonSkip())
			{
				OnLogoAnimationEnd(true);
				break;
			}
			yield return null;
		}

		if (logoCanvasGroup != null)
			logoCanvasGroup.alpha = 0f;
		OnCanShowGCBanner?.Invoke();
		if (gameObject != null)
			gameObject.SetActive(false);
		OnCompleted?.Invoke();
	}

	private void StartLogoAnimation()
	{
		if (!shouldShowLogoScreen())
		{
			tribandLogoDone = true;
			return;
		}
		if (splashAudioSource != null)
		{
			splashAudioSource.transform.SetParent(null);
			DontDestroyOnLoad(splashAudioSource.gameObject);
			splashAudioSource.Play();
		}
		tribandLogoDone = false;
		logo = Logo.Instance;
		if (logo != null)
		{
			logo.gameObject.SetActive(true);
			if (videoCamera != null)
				videoCamera.enabled = false;
			if (logo.mountainGenerator != null)
				logo.mountainGenerator.BuildMountain();
			if (logo.logoAnimationDesktopCam != null)
			{
				logo.logoAnimationDesktopCam.gameObject.SetActive(true);
				logo.logoAnimationDesktopCam.depth = 50f;
			}
			if (logo.logoAnimationMobileCam != null)
				logo.logoAnimationMobileCam.gameObject.SetActive(false);
		}
		tribandLogoCR = StartCoroutine(ShowTribandLogoCR(() => OnLogoAnimationEnd(false)));
	}

	private void OnLogoAnimationEnd(bool skipped)
	{
		if (splashAudioSource != null)
			splashAudioSource.OnSplashScreenComplete(skipped);
		tribandLogoDone = true;
		if (videoCamera != null)
			videoCamera.enabled = true;
		if (logo != null)
		{
			logo.gameObject.SetActive(false);
			Destroy(logo.gameObject);
			logo = null;
		}
		if (tribandLogoCR != null)
		{
			StopCoroutine(tribandLogoCR);
			tribandLogoCR = null;
		}
	}

	private bool CheckForButtonSkip() => InputHelper.TouchedOrMouseClicked() || InputHelper.GetAllPlayerButtonConfirm() || InputHelper.GetAllPlayerButtonCancel();

	private IEnumerator ShowTribandLogoCR(UnityAction onDone)
	{
		if (logoCanvasGroup != null)
		{
			logoCanvasGroup.gameObject.SetActive(true);
			yield return StartCoroutine(pTween.To(0.35f, 0f, 1f, t =>
			{
				if (logoCanvasGroup != null)
					logoCanvasGroup.alpha = 1f - t;
			}));
		}
		yield return new WaitForSeconds(2.5f);
		if (logoCanvasGroup != null)
		{
			yield return StartCoroutine(pTween.To(0.25f, 0f, 1f, t =>
			{
				if (logoCanvasGroup != null)
					logoCanvasGroup.alpha = t;
			}));
		}
		onDone?.Invoke();
	}
}
