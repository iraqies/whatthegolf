using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class QuickMenu : MonoBehaviour
{
	[Serializable]
	public class MenuButton
	{
		public SVGImage Icon;

		public Sprite IconSprite;

		public UnityEvent OnClick;

		public List<string> DisableInScenes;
	}

	public delegate void MenuOpenDelegate(bool state);

	private enum MenuStateEnum
	{
		Inactive = 0,
		TransitionIn = 1,
		Active = 2,
		TransitionOut = 3
	}

	public List<MenuButton> Buttons;

	public MenuButton GyroButton;

	public Transform MenuContainer;

	public float MenuTransitionSpeed;

	public float ButtonTransitionSpeed;

	public List<string> ScenesWithoutMenu;

	public List<string> AllowInSpecialScenes;

	public GameObject Container;

	public Transform selectionHand;

	public GameObject UseGyro;

	public GameObject UseStick;

	public ClipSettingsCollection HoverSFX;

	public ClipSettingsCollection ClickSFX;

	public ClipSettingsCollection OpenSFX;

	public List<AudioClip> HoverOnButtonClips;

	public List<AudioClip> ButtonSelectedClips;

	public List<AudioClip> MenuOpening;

	public List<AudioClip> MenuClosing;

	public float Volume;

	private List<Behaviour> currentBlockers;

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

	public static QuickMenu Instance;

	[CompilerGenerated]
	private static MenuOpenDelegate m_OnMenuStateChanged;

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

	public void CloseMenu()
	{
	}

	public void OpenSettings()
	{
	}

	public void ReturnFromSettings()
	{
	}

	public void ExitFromSettings()
	{
	}

	public void ExitGame()
	{
	}

	public void SkipLevel()
	{
	}

	public void ChangeGyroControls()
	{
	}

	public void RestartLevel()
	{
	}
}
