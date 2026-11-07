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

	private void Awake() { }

	private IEnumerator Start()
	{
		yield break;
	}

	private bool shouldShowLogoScreen() => false;

	public IEnumerator Show(Action OnCoveredBySplash = null, Action OnCompleted = null, Action OnCanShowGCBanner = null)
	{
		OnCoveredBySplash?.Invoke();
		OnCanShowGCBanner?.Invoke();
		yield return null;
		if (gameObject != null)
			gameObject.SetActive(false);
		OnCompleted?.Invoke();
	}

	private void StartLogoAnimation() { }
	private void OnLogoAnimationEnd(bool skipped) { }
	private bool CheckForButtonSkip() => true;

	private IEnumerator ShowTribandLogoCR(UnityAction onDone)
	{
		onDone?.Invoke();
		yield break;
	}
}
