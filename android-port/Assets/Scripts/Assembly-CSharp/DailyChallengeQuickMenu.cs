using System;
using System.Collections.Generic;
using System.Linq;
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

	public float MenuTransitionSpeed = 2f;

	public float ButtonTransitionSpeed = 2f;

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

	public float Volume = 0.5f;

	private List<Behaviour> currentBlockers = new List<Behaviour>();

	public bool CanShow = true;

	private MenuStateEnum menuState;

	private int currentActiveButton = -1;

	private int lastActiveButton = -1;

	private float transitionTimer;

	private float buttonSwitchDelay;

	private Dictionary<GolfBallController, bool> controllers;

	private string currentScene;

	private List<MenuButton> currentButtons;

	private Vector3 currentUIUp = Vector3.up;

	private Vector3 handposition;

	[CompilerGenerated]
	private static MenuOpenDelegate m_OnMenuStateChanged;

	public ReplayDaily ReplayDailyActions;

	public bool BlockInput;

	private bool ShouldHandBeVisible => InputHelper.IsNavigatingWithController();

	private Vector3 HandTarget
	{
		get
		{
			if (currentButtons == null || currentActiveButton < 0 || currentActiveButton >= currentButtons.Count)
				return Vector3.zero;
			var btn = currentButtons[currentActiveButton];
			if (btn == null || btn.Icon == null)
				return Vector3.zero;
			return btn.Icon.transform.position - currentUIUp * 62f;
		}
	}

	public static event MenuOpenDelegate OnMenuStateChanged
	{
		[CompilerGenerated]
		add
		{
			m_OnMenuStateChanged = (MenuOpenDelegate)Delegate.Combine(m_OnMenuStateChanged, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnMenuStateChanged = (MenuOpenDelegate)Delegate.Remove(m_OnMenuStateChanged, value);
		}
	}

	public void PlayConfirmationSFX()
	{
		if (ClickSFX != null && AudioManager.Instance != null)
		{
			ClickSFX.Play(AudioManager.Instance.uiEffects, Vector3.zero, 0f);
		}
	}

	private void Awake()
	{
		currentBlockers = new List<Behaviour>();
		if (Buttons != null)
		{
			foreach (var b in Buttons)
			{
				if (b != null && b.Icon != null)
				{
					var notify = b.Icon.gameObject.AddComponent<NotifyOnMouseOverImage>();
					if (notify != null)
					{
						notify.OnMouseOverEvent += OnMouseOverEvent;
						notify.OnMouseUpEvent += OnMouseUpEvent;
					}
				}
			}
			Buttons = Buttons.OrderBy(b => (b != null && b.Icon != null && b.Icon.transform.parent != null) ? b.Icon.transform.parent.GetSiblingIndex() : 0).ToList();
		}
		currentActiveButton = StartButton;
		if (Container != null && PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null)
		{
			Container.transform.localScale = Vector3.one * PlatformSettings.Instance.GetCurrent().QuickMenuScale;
		}
	}

	public void AddBlocker(Behaviour blockingBehaviour)
	{
		if (currentBlockers == null)
			currentBlockers = new List<Behaviour>();
		if (currentBlockers.Contains(blockingBehaviour))
			return;

		if (menuState == MenuStateEnum.TransitionIn || menuState == MenuStateEnum.Active)
		{
			menuState = MenuStateEnum.Inactive;
			if (MenuContainer != null)
				MenuContainer.localScale = Vector3.one;
			if (Background != null)
				Background.alpha = 0f;
			if (Container != null)
				Container.SetActive(false);
		}
		currentBlockers.Add(blockingBehaviour);
	}

	public void RemoveBlocker(Behaviour blockingBehaviour)
	{
		if (currentBlockers != null)
		{
			currentBlockers.Remove(blockingBehaviour);
		}
	}

	private void OnMouseUpEvent(GameObject icon)
	{
		if (menuState == MenuStateEnum.Active && currentButtons != null && currentActiveButton >= 0 && currentActiveButton < currentButtons.Count)
		{
			var btn = currentButtons[currentActiveButton];
			if (btn != null && btn.OnClick != null)
			{
				btn.OnClick.Invoke();
			}
		}
	}

	private void OnMouseOverEvent(GameObject icon)
	{
		if ((menuState == MenuStateEnum.TransitionIn || menuState == MenuStateEnum.Active) && currentButtons != null)
		{
			var found = currentButtons.FirstOrDefault(b => b != null && b.Icon != null && b.Icon.gameObject == icon);
			if (found != null)
			{
				currentActiveButton = currentButtons.IndexOf(found);
			}
		}
	}

	private void Update()
	{
		if (currentBlockers != null && currentBlockers.Count > 0)
			return;

		switch (menuState)
		{
			case MenuStateEnum.Inactive:
				HandleInactiveState();
				break;
			case MenuStateEnum.TransitionIn:
				HandleTransitionInState();
				break;
			case MenuStateEnum.Active:
				HandleActiveState();
				break;
			case MenuStateEnum.TransitionOut:
				HandleTransitionOutState();
				break;
		}
	}

	private void HandleTransitionInState()
	{
		if (Mathf.Approximately(transitionTimer, 0f))
		{
			var tc = FindObjectOfType<TimeControl>();
			if (tc != null)
			{
				tc.TogglePause(true);
			}
			controllers = new Dictionary<GolfBallController, bool>();
			var foundControllers = FindObjectsOfType<GolfBallController>();
			if (foundControllers != null)
			{
				foreach (var c in foundControllers)
				{
					if (c != null)
					{
						controllers.Add(c, c.enabled);
						c.enabled = false;
					}
				}
			}

			bool isPortrait = false;
			if (PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null && PlatformSettings.Instance.GetCurrent().useRotatedOverworldAndCameraInLevels)
			{
				if (LevelManager.Instance != null && LevelManager.Instance.IsInLevel() && LevelManager.Instance.GetCurrentLevelData() != null && LevelManager.Instance.GetCurrentLevelData().GetWindowType() == LevelData.WindowType.TwoD)
				{
					isPortrait = true;
				}
				else if (OverworldManager2d.Instance != null && OverworldManager2d.Instance.IsOverworldPlaying)
				{
					var sec = OverworldManager2d.Instance.FindCurrentHubSection();
					if (sec != null)
						isPortrait = sec.shouldRotateTilesForMobile;
				}
			}

			float zRot = isPortrait ? -90f : 0f;
			currentUIUp = isPortrait ? Vector3.right : Vector3.up;
			if (Container != null)
				Container.transform.localRotation = Quaternion.Euler(0f, 0f, zRot);
			if (selectionHand != null)
				selectionHand.gameObject.SetActive(false);
		}

		transitionTimer += Time.unscaledDeltaTime * MenuTransitionSpeed;
		if (Background != null)
		{
			Background.alpha = Mathf.Lerp(0f, 1f, Mathf.Pow(transitionTimer, 1.2f));
		}
		if (MenuContainer != null)
		{
			float s = Mathf.Clamp01(Mathf.SmoothStep(0f, 1f, transitionTimer));
			MenuContainer.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, s);
		}
		UpdateSelectionHand(10000f);
		if (transitionTimer >= 1f)
		{
			menuState = MenuStateEnum.Active;
			transitionTimer = 0f;
		}
	}

	private void HandleTransitionOutState()
	{
		transitionTimer += Time.unscaledDeltaTime * MenuTransitionSpeed;
		if (MenuContainer != null)
		{
			float s = Mathf.Clamp01(Mathf.SmoothStep(1f, 0f, transitionTimer));
			MenuContainer.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, s);
		}
		if (Background != null)
		{
			Background.alpha = Mathf.Lerp(1f, 0f, Mathf.Pow(transitionTimer, 1.2f));
		}
		if (transitionTimer >= 1f)
		{
			menuState = MenuStateEnum.Inactive;
			transitionTimer = 0f;
			var tc = FindObjectOfType<TimeControl>();
			if (tc != null)
			{
				tc.TogglePause(false);
			}
			if (controllers != null)
			{
				foreach (var kv in controllers)
				{
					if (kv.Key != null)
					{
						bool en = kv.Value && (winSceneUI == null || !winSceneUI.isShowingLeaderboards);
						kv.Key.enabled = en;
					}
				}
			}
			if (Container != null)
				Container.SetActive(false);
		}
	}

	private void HandleInactiveState()
	{
		if (MenuContainer != null)
			MenuContainer.localScale = Vector3.zero;
		if (CanShow && InputHelper.GetAllPlayerButtonOpenMenu() && (LevelManager.Instance == null || !LevelManager.Instance.IsTransitionActive()))
		{
			Show();
		}
	}

	public void Show()
	{
		if (menuState != MenuStateEnum.Inactive)
			return;

		if (Container != null)
			Container.SetActive(true);
		menuState = MenuStateEnum.TransitionIn;
		if (OpenSFX != null && AudioManager.Instance != null)
		{
			OpenSFX.Play(AudioManager.Instance.uiEffects, Vector3.zero, 0f);
		}
		currentButtons = new List<MenuButton>();
		if (Buttons != null)
		{
			foreach (var b in Buttons)
			{
				if (b != null && b.Icon != null && b.Icon.transform.parent != null)
				{
					b.Icon.transform.parent.gameObject.SetActive(true);
					currentButtons.Add(b);
				}
			}
		}
		currentButtons = currentButtons.OrderBy(c => (c != null && c.Icon != null && c.Icon.transform.parent != null) ? c.Icon.transform.parent.GetSiblingIndex() : 0).ToList();
		if (currentButtons.Count > 0)
		{
			currentActiveButton = Mathf.Clamp(currentActiveButton, 0, currentButtons.Count - 1);
		}
		handposition = HandTarget;
		if (selectionHand != null)
		{
			selectionHand.transform.position = handposition;
		}
		m_OnMenuStateChanged?.Invoke(true);
	}

	private void HandleActiveState()
	{
		buttonSwitchDelay -= Time.unscaledDeltaTime;
		if (MenuContainer != null)
			MenuContainer.localScale = Vector3.one;

		int horiz = InputHelper.GetAllPlayerAxisRoundedHorizontal();
		if (currentActiveButton != lastActiveButton && HoverSFX != null && AudioManager.Instance != null)
		{
			HoverSFX.Play(AudioManager.Instance.uiEffects, Vector3.zero, 0f);
		}
		if (horiz != 0 && buttonSwitchDelay <= 0f && !GKAccessPointFocused.IsFocused && currentButtons != null && currentButtons.Count > 0)
		{
			currentActiveButton = Mathf.Clamp(currentActiveButton + horiz, 0, currentButtons.Count - 1);
			buttonSwitchDelay = 0.2f;
		}

		if (!Application.isMobilePlatform && currentButtons != null)
		{
			for (int i = 0; i < currentButtons.Count; i++)
			{
				if (currentButtons[i] != null && currentButtons[i].Icon != null)
				{
					Transform t = currentButtons[i].Icon.transform;
					Vector3 targetScale = (i == currentActiveButton) ? (Vector3.one * 1.2f) : Vector3.one;
					t.localScale = Vector3.MoveTowards(t.localScale, targetScale, Time.unscaledDeltaTime * ButtonTransitionSpeed);
				}
			}
		}

		if (InputHelper.GetAllPlayerButtonConfirm() && !GKAccessPointFocused.IsFocused && currentButtons != null && currentActiveButton >= 0 && currentActiveButton < currentButtons.Count)
		{
			currentButtons[currentActiveButton].OnClick?.Invoke();
			PlayConfirmationSFX();
			m_OnMenuStateChanged?.Invoke(false);
		}

		if (InputHelper.GetAllPlayerButtonGoBack() || InputHelper.GetAllPlayerButtonCancel() || InputHelper.GetAllPlayerButtonOpenMenu())
		{
			CloseMenu();
			return;
		}

		UpdateSelectionHand(100f);
		lastActiveButton = currentActiveButton;
	}

	private void GameCenterAccessPointTrigger()
	{
	}

	private void UpdateSelectionHand(float speed)
	{
		if (selectionHand == null)
			return;

		bool shouldShow = ShouldHandBeVisible;
		if (selectionHand.gameObject.activeInHierarchy != shouldShow)
		{
			selectionHand.gameObject.SetActive(shouldShow);
		}
		if (!selectionHand.gameObject.activeInHierarchy)
			return;

		Vector3 target = HandTarget;
		if (speed < 0f)
		{
			selectionHand.transform.position = target;
			return;
		}
		handposition = Vector3.MoveTowards(handposition, target, speed * Time.unscaledDeltaTime * 20f);
		float bob = Mathf.Sin(Time.unscaledTime * 3f) * 6f;
		selectionHand.transform.position = handposition + currentUIUp * bob;
	}

	public void OpenMenu()
	{
		if (menuState == MenuStateEnum.Inactive)
		{
			Show();
		}
	}

	public void CloseMenu()
	{
		if (menuState == MenuStateEnum.Active)
		{
			menuState = MenuStateEnum.TransitionOut;
			m_OnMenuStateChanged?.Invoke(false);
			PlayConfirmationSFX();
		}
	}
}
