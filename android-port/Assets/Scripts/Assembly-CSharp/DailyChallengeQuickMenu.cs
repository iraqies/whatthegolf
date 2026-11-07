using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class DailyChallengeQuickMenu : MonoBehaviour
{
	[Serializable]
	public class MenuButton
	{
		public SVGImage Icon;

		public UnityEvent OnClick;
	}

	public delegate void MenuOpenDelegate(bool state);

	private enum MenuStateEnum
	{
		Inactive = 0,
		TransitionIn = 1,
		Active = 2,
		TransitionOut = 3
	}

	public WinSceneUI winSceneUI;

	public List<MenuButton> Buttons;

	public Transform MenuContainer;

	public float MenuTransitionSpeed;

	public float ButtonTransitionSpeed;

	public int StartButton;

	public CanvasGroup Background;

	public GameObject Container;

	public Transform selectionHand;

	public ClipSettingsCollection HoverSFX;

	public ClipSettingsCollection ClickSFX;

	public ClipSettingsCollection OpenSFX;

	public List<AudioClip> HoverOnButtonClips;

	public List<AudioClip> ButtonSelectedClips;

	public List<AudioClip> MenuOpening;

	public List<AudioClip> MenuClosing;

	public float Volume;

	private List<Behaviour> currentBlockers;

	public bool CanShow;

	private MenuStateEnum menuState;

	private int currentActiveButton;

	private int lastActiveButton;

	private float transitionTimer;

	private float buttonSwitchDelay;

	private Dictionary<GolfBallController, bool> controllers;

	private string currentScene;

	private List<MenuButton> currentButtons;

	private Vector3 currentUIUp;

	private Vector3 handposition;

	[CompilerGenerated]
	private static MenuOpenDelegate m_OnMenuStateChanged;

	public ReplayDaily ReplayDailyActions;

	public bool BlockInput;

	private bool ShouldHandBeVisible => false;

	private Vector3 HandTarget => default;

	public static event MenuOpenDelegate OnMenuStateChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void PlayConfirmationSFX()
	{
	}

	private void Awake()
	{
	}

	public void AddBlocker(Behaviour blockingBehaviour)
	{
	}

	public void RemoveBlocker(Behaviour blockingBehaviour)
	{
	}

	private void OnMouseUpEvent(GameObject icon)
	{
	}

	private void OnMouseOverEvent(GameObject icon)
	{
	}

	private void Update()
	{
	}

	private void HandleTransitionInState()
	{
	}

	private void HandleTransitionOutState()
	{
	}

	private void HandleInactiveState()
	{
	}

	public void Show()
	{
	}

	private void HandleActiveState()
	{
	}

	private void GameCenterAccessPointTrigger()
	{
	}

	private void UpdateSelectionHand(float speed)
	{
	}

	public void OpenMenu()
	{
	}

	public void CloseMenu()
	{
	}
}
