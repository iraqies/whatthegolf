using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class AASplashScreen : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup logoCanvasGroup;

	[SerializeField]
	private AAScreens splashScreens;

	[SerializeField]
	private VideoContainer videoContainer;

	[SerializeField]
	private Camera videoCamera;

	[SerializeField]
	private SplashScreenAudioSource splashAudioSource;

	private static bool splashScreenExecuted;

	private bool tribandLogoDone;

	private Coroutine tribandLogoCR;

	private Logo logo;

	private IVideoPathProvider videoPathProvider;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	private void Awake()
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	private bool shouldShowLogoScreen()
	{
		return false;
	}

	public IEnumerator Show(Action OnCoveredBySplash = null, Action OnCompleted = null, Action OnCanShowGCBanner = null)
	{
		return null;
	}

	private void StartLogoAnimation()
	{
	}

	private void OnLogoAnimationEnd(bool skipped)
	{
	}

	private bool CheckForButtonSkip()
	{
		return false;
	}

	private IEnumerator ShowTribandLogoCR(UnityAction onDone)
	{
		return null;
	}
}
