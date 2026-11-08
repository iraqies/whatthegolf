using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Audio;
using Core;
using Menu;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

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

	public List<MenuButton> Buttons = new List<MenuButton>();
	public MenuButton GyroButton;
	public Transform MenuContainer;
	public float MenuTransitionSpeed = 8f;
	public float ButtonTransitionSpeed = 10f;
	public List<string> ScenesWithoutMenu = new List<string>();
	public List<string> AllowInSpecialScenes = new List<string>();
	public GameObject Container;
	public Transform selectionHand;
	public GameObject UseGyro;
	public GameObject UseStick;
	public ClipSettingsCollection HoverSFX;
	public ClipSettingsCollection ClickSFX;
	public ClipSettingsCollection OpenSFX;
	public List<AudioClip> HoverOnButtonClips = new List<AudioClip>();
	public List<AudioClip> ButtonSelectedClips = new List<AudioClip>();
	public List<AudioClip> MenuOpening = new List<AudioClip>();
	public List<AudioClip> MenuClosing = new List<AudioClip>();
	public float Volume = 1f;

	private List<Behaviour> currentBlockers = new List<Behaviour>();
	private MenuStateEnum menuState;
	private int currentActiveButton;
	private int lastActiveButton;
	private float transitionTimer;
	private float buttonSwitchDelay;
	private Dictionary<GolfBallController, bool> controllers = new Dictionary<GolfBallController, bool>();
	private string currentScene;
	private List<MenuButton> currentButtons = new List<MenuButton>();
	private Vector3 currentUIUp = Vector3.up;
	private Vector3 handposition;

	public static QuickMenu Instance;
	private static MenuOpenDelegate m_OnMenuStateChanged;

	private bool ShouldHandBeVisible => InputHelper.IsNavigatingWithController();
	private Vector3 HandTarget
	{
		get
		{
			if (currentButtons != null && currentActiveButton >= 0 && currentActiveButton < currentButtons.Count)
			{
				var b = currentButtons[currentActiveButton];
				if (b != null && b.Icon != null)
					return b.Icon.transform.position - currentUIUp * 62f;
			}
			return Vector3.zero;
		}
	}

	public static event MenuOpenDelegate OnMenuStateChanged
	{
		add => m_OnMenuStateChanged = (MenuOpenDelegate)Delegate.Combine(m_OnMenuStateChanged, value);
		remove => m_OnMenuStateChanged = (MenuOpenDelegate)Delegate.Remove(m_OnMenuStateChanged, value);
	}

	public void PlayConfirmationSFX()
	{
		if (ClickSFX != null && AudioManager.Instance != null)
			ClickSFX.Play(AudioManager.Instance.uiEffects, Vector3.zero, 0f);
	}

	private void Awake()
	{
		if (Instance != null && Instance != this)
		{
			Destroy(gameObject);
			return;
		}
		Instance = this;
		currentBlockers = new List<Behaviour>();
		if (Buttons != null)
		{
			foreach (var b in Buttons)
			{
				if (b != null && b.Icon != null)
				{
					var notify = b.Icon.gameObject.GetComponent<NotifyOnMouseOverImage>() ?? b.Icon.gameObject.AddComponent<NotifyOnMouseOverImage>();
					notify.OnMouseOverEvent -= OnMouseOverEvent;
					notify.OnMouseOverEvent += OnMouseOverEvent;
					notify.OnMouseUpEvent -= OnMouseUpEvent;
					notify.OnMouseUpEvent += OnMouseUpEvent;
				}
			}
		}
		if (GyroButton != null && GyroButton.Icon != null)
		{
			var notify = GyroButton.Icon.gameObject.GetComponent<NotifyOnMouseOverImage>() ?? GyroButton.Icon.gameObject.AddComponent<NotifyOnMouseOverImage>();
			notify.OnMouseOverEvent -= OnMouseOverEvent;
			notify.OnMouseOverEvent += OnMouseOverEvent;
			notify.OnMouseUpEvent -= OnMouseUpEvent;
			notify.OnMouseUpEvent += OnMouseUpEvent;
		}
		if (Buttons != null)
			Buttons = Buttons.OrderBy(b => b != null && b.Icon != null ? b.Icon.transform.position.x : 0f).ToList();

		currentScene = SceneManager.GetActiveScene().name;
		currentActiveButton = 0;
		SceneManager.activeSceneChanged += (oldScene, newScene) => currentScene = newScene.name;

		if (UseGyro != null) UseGyro.SetActive(SaveGame.SwitchUseGyro);
		if (UseStick != null) UseStick.SetActive(!SaveGame.SwitchUseGyro);
		DontDestroyOnLoad(gameObject);
		if (Container != null)
		{
			float scale = PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null ? PlatformSettings.Instance.GetCurrent().QuickMenuScale : 1f;
			if (scale <= 0.01f) scale = 1f;
			Container.transform.localScale = Vector3.one * scale;
			Container.SetActive(false);
		}
		if (MenuContainer != null)
			MenuContainer.localScale = Vector3.zero;
	}

	public void AddBlocker(Behaviour blockingBehaviour)
	{
		if (blockingBehaviour == null || currentBlockers.Contains(blockingBehaviour))
			return;
		if (menuState == MenuStateEnum.TransitionIn || menuState == MenuStateEnum.Active)
		{
			menuState = MenuStateEnum.Inactive;
			if (MenuContainer != null) MenuContainer.localScale = Vector3.one;
			if (Container != null) Container.SetActive(false);
		}
		currentBlockers.Add(blockingBehaviour);
	}

	public void RemoveBlocker(Behaviour blockingBehaviour)
	{
		currentBlockers.Remove(blockingBehaviour);
	}

	private void OnMouseUpEvent(GameObject icon)
	{
		if (menuState != MenuStateEnum.Active || currentButtons == null) return;
		OnMouseOverEvent(icon);
		if (currentActiveButton >= 0 && currentActiveButton < currentButtons.Count)
		{
			var b = currentButtons[currentActiveButton];
			if (b != null)
			{
				PlayConfirmationSFX();
				b.OnClick?.Invoke();
			}
		}
	}

	private void OnMouseOverEvent(GameObject icon)
	{
		if ((menuState == MenuStateEnum.TransitionIn || menuState == MenuStateEnum.Active) && currentButtons != null)
		{
			int idx = currentButtons.FindIndex(b => b != null && b.Icon != null && b.Icon.gameObject == icon);
			if (idx >= 0)
				currentActiveButton = idx;
		}
	}

	private void Update()
	{
		if (ScenesWithoutMenu != null && ScenesWithoutMenu.Contains(currentScene))
		{
			if (MenuContainer != null) MenuContainer.localScale = Vector3.zero;
			return;
		}
		for (int i = currentBlockers.Count - 1; i >= 0; i--)
		{
			if (currentBlockers[i] == null)
				currentBlockers.RemoveAt(i);
		}
		if (currentBlockers.Count > 0) return;

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
			if (tc != null) tc.TogglePause(true);
			controllers = new Dictionary<GolfBallController, bool>();
			foreach (var c in FindObjectsOfType<GolfBallController>())
			{
				if (c != null)
				{
					controllers[c] = c.enabled;
					c.enabled = false;
				}
			}
			currentUIUp = Vector3.up;
			if (Container != null)
				Container.transform.localRotation = Quaternion.identity;
			if (selectionHand != null)
				selectionHand.gameObject.SetActive(false);
		}
		transitionTimer += Time.unscaledDeltaTime * MenuTransitionSpeed;
		float t = Mathf.Clamp01(Mathf.SmoothStep(0f, 1f, transitionTimer));
		if (MenuContainer != null)
			MenuContainer.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, t);
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
		float t = Mathf.Clamp01(Mathf.SmoothStep(1f, 0f, transitionTimer));
		if (MenuContainer != null)
			MenuContainer.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, t);
		if (transitionTimer >= 1f)
		{
			menuState = MenuStateEnum.Inactive;
			transitionTimer = 0f;
			var tc = FindObjectOfType<TimeControl>();
			if (tc != null) tc.TogglePause(false);
			if (controllers != null)
			{
				foreach (var kv in controllers)
				{
					if (kv.Key != null)
						kv.Key.enabled = kv.Value;
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
		if (InputHelper.GetAllPlayerButtonOpenMenu())
		{
			if (LevelManager.Exists && LevelManager.Instance.IsTransitionActive())
				return;
			if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null && !OverworldManager2d.Instance.IsOverworldPlaying)
				return;
			if (!Level.HasInstance && AllowInSpecialScenes != null && !AllowInSpecialScenes.Contains(currentScene))
				return;
			Show();
		}
	}

	public void Show()
	{
		if (menuState != MenuStateEnum.Inactive) return;
		if (UIBackgroundFader.Exists || UIBackgroundFader.Instance != null)
			UIBackgroundFader.Instance.Register();
		if (Container != null)
			Container.SetActive(true);
		menuState = MenuStateEnum.TransitionIn;
		if (OpenSFX != null && AudioManager.Instance != null)
			OpenSFX.Play(AudioManager.Instance.uiEffects, Vector3.zero, 0f);

		currentButtons = new List<MenuButton>();
		if (Buttons != null)
		{
			foreach (var b in Buttons)
			{
				if (b == null) continue;
				bool disabled = b.DisableInScenes != null && b.DisableInScenes.Contains(currentScene);
				if (b.Icon != null && b.Icon.transform.parent != null)
					b.Icon.transform.parent.gameObject.SetActive(!disabled);
				if (!disabled)
					currentButtons.Add(b);
			}
		}
		if (GyroButton != null && GyroButton.Icon != null && GyroButton.Icon.transform.parent != null)
		{
			GyroButton.Icon.transform.parent.gameObject.SetActive(false);
		}
		currentButtons = currentButtons.OrderBy(b => b.Icon != null ? b.Icon.transform.position.x : 0f).ToList();
		currentActiveButton = Mathf.Max(0, currentButtons.Count - 1);
		handposition = HandTarget;
		if (selectionHand != null)
			selectionHand.position = handposition;
		m_OnMenuStateChanged?.Invoke(true);
	}

	private void HandleActiveState()
	{
		buttonSwitchDelay -= Time.unscaledDeltaTime;
		if (MenuContainer != null)
			MenuContainer.localScale = Vector3.one;

		int horiz = InputHelper.GetAllPlayerAxisRoundedHorizontal();
		if (horiz != 0 && buttonSwitchDelay <= 0f && currentButtons != null && currentButtons.Count > 0)
		{
			currentActiveButton = Mathf.Clamp(currentActiveButton + horiz, 0, currentButtons.Count - 1);
			buttonSwitchDelay = 0.2f;
		}

		if (!Application.isMobilePlatform && currentButtons != null)
		{
			for (int i = 0; i < currentButtons.Count; i++)
			{
				var b = currentButtons[i];
				if (b != null && b.Icon != null)
				{
					Vector3 targetScale = (i == currentActiveButton) ? Vector3.one * 1.2f : Vector3.one;
					b.Icon.transform.localScale = Vector3.MoveTowards(b.Icon.transform.localScale, targetScale, Time.unscaledDeltaTime * ButtonTransitionSpeed);
				}
			}
		}

		if (InputHelper.GetAllPlayerButtonConfirm() && currentButtons != null && currentActiveButton >= 0 && currentActiveButton < currentButtons.Count)
		{
			var b = currentButtons[currentActiveButton];
			b?.OnClick?.Invoke();
			PlayConfirmationSFX();
			m_OnMenuStateChanged?.Invoke(false);
		}

		if (InputHelper.GetAllPlayerButtonOpenMenu() || InputHelper.GetAllPlayerButtonCancel())
		{
			CloseMenu();
			m_OnMenuStateChanged?.Invoke(false);
			PlayConfirmationSFX();
		}

		UpdateSelectionHand(100f);
		lastActiveButton = currentActiveButton;
	}

	private void GameCenterAccessPointTrigger() { }

	private void UpdateSelectionHand(float speed)
	{
		if (selectionHand == null) return;
		bool vis = ShouldHandBeVisible;
		if (selectionHand.gameObject.activeInHierarchy != vis)
			selectionHand.gameObject.SetActive(vis);
		if (vis)
		{
			handposition = Vector3.MoveTowards(handposition, HandTarget, speed * Time.unscaledDeltaTime * 20f);
			selectionHand.position = handposition + currentUIUp * (Mathf.Sin(Time.unscaledTime * 3f) * 6f);
		}
	}

	public void CloseMenu()
	{
		if (menuState == MenuStateEnum.Active)
		{
			menuState = MenuStateEnum.TransitionOut;
			if (UIBackgroundFader.Exists || UIBackgroundFader.Instance != null)
				UIBackgroundFader.Instance.Deregister();
		}
	}

	public void OpenSettings()
	{
		if (SettingsMenu.Instance != null)
		{
			AddBlocker(SettingsMenu.Instance);
			if (UIBackgroundFader.Exists || UIBackgroundFader.Instance != null)
				UIBackgroundFader.Instance.Deregister();
			if (MenuContainer != null)
			{
				MenuContainer.localScale = Vector3.zero;
				MenuContainer.gameObject.SetActive(false);
			}
			SettingsMenu.Instance.Show(true);
		}
	}

	public void ReturnFromSettings()
	{
		if (controllers != null)
		{
			foreach (var kv in controllers)
				if (kv.Key != null) kv.Key.enabled = kv.Value;
		}
		if (SettingsMenu.Exists)
			RemoveBlocker(SettingsMenu.Instance);
		if (MenuContainer != null)
			MenuContainer.gameObject.SetActive(true);
		Show();
		currentActiveButton = 1;
	}

	public void ExitFromSettings()
	{
		if (SettingsMenu.Exists)
			RemoveBlocker(SettingsMenu.Instance);
		if (MenuContainer != null)
			MenuContainer.gameObject.SetActive(true);
	}

	public void ExitGame()
	{
		CloseMenu();
		if (Level.HasInstance && Level.Instance != null)
			Level.Instance.Abort();
		else if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null && OverworldManager2d.Instance.ui != null)
			OverworldManager2d.Instance.ui.ExitToMenu();
		else
			_ = HubSceneLoader.Instance.LoadSceneAsync(LoadSceneMode.Single);
	}

	public void SkipLevel()
	{
		CloseMenu();
		if (Level.HasInstance && Level.Instance != null && Level.Instance.Goal != null)
			Level.Instance.Complete("SKIPPED!", 0f);
	}

	public void ChangeGyroControls()
	{
		SaveGame.SwitchUseGyro = !SaveGame.SwitchUseGyro;
		if (UseGyro != null) UseGyro.SetActive(SaveGame.SwitchUseGyro);
		if (UseStick != null) UseStick.SetActive(!SaveGame.SwitchUseGyro);
	}

	public void RestartLevel()
	{
		CloseMenu();
		if (Level.HasInstance && Level.Instance != null)
			Level.Instance.Restart();
	}
}
