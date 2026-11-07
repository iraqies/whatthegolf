using System;
using System.Collections;
using Core;
using UnityEngine;
using UnityEngine.ResourceManagement.ResourceProviders;

public class Loading : MonoBehaviour
{
	private enum StartingPoint
	{
		ONBOARDING = 0,
		SECONDONBOARDING = 1,
		HUB = 2
	}

	public Onboarding Onboarding;

	public XboxSplashScreen xboxSplashScreen;

	public PlaystationSplashScreen playstationSplashScreen;

	public GameObject quickmenu;

	public Color SwitchTransitionColor;

	public bool forceSecondOnboarding;

	private Camera camera;

	[NonSerialized]
	public bool IsLoaded;

	private Color transitionColor;

	private static Loading instance;

	private SceneInstance _loadingSceneInstance;

	public bool isOnboardingRunning { get; private set; }

	public static bool IsCreated => false;

	public static bool IsReady => false;

	public void Init(SceneInstance sceneInstance)
	{
	}

	private void OnDestroy()
	{
	}

	private IEnumerator InitCR()
	{
		return null;
	}

	private void CreateConsentPopupRequests()
	{
	}

	private void DownloadMusic()
	{
	}

	private void StartODR(LevelData obj)
	{
	}

	private void LoadHub()
	{
	}

	private StartingPoint WhereToStart()
	{
		return StartingPoint.ONBOARDING;
	}

	private bool IsUserBeginner()
	{
		return false;
	}

	private bool HasOnlyPlayedMainCampaign()
	{
		return false;
	}

	private IEnumerator StartOnBoardingRoutine(ContentPack pack, bool allowMenuButtons, bool isMainOnboarding)
	{
		return null;
	}

	public void AbandonButtonClicked()
	{
	}

	private IEnumerator OnboardingAbandoned()
	{
		return null;
	}
}
