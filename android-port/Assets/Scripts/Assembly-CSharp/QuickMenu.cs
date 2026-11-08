using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio;
using Core;
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
	private Vector3 currentUIUp;
	private Vector3 handposition;

	public static QuickMenu Instance;
	private static MenuOpenDelegate m_OnMenuStateChanged;

	private bool ShouldHandBeVisible => menuState == MenuStateEnum.Active;
	private Vector3 HandTarget => Vector3.zero;

	public static event MenuOpenDelegate OnMenuStateChanged
	{
		add => m_OnMenuStateChanged = (MenuOpenDelegate)Delegate.Combine(m_OnMenuStateChanged, value);
		remove => m_OnMenuStateChanged = (MenuOpenDelegate)Delegate.Remove(m_OnMenuStateChanged, value);
	}

	public void PlayConfirmationSFX() { }

	private void Awake()
	{
		Instance = this;
		if (Container != null) Container.SetActive(false);
	}

	public void AddBlocker(Behaviour blockingBehaviour)
	{
		if (blockingBehaviour != null && !currentBlockers.Contains(blockingBehaviour))
			currentBlockers.Add(blockingBehaviour);
	}

	public void RemoveBlocker(Behaviour blockingBehaviour)
	{
		currentBlockers.Remove(blockingBehaviour);
	}

	private void OnMouseUpEvent(GameObject icon) { }
	private void OnMouseOverEvent(GameObject icon) { }

	private void Update()
	{
		if (InputHelper.GetAllPlayerButtonOpenMenu())
		{
			if (menuState == MenuStateEnum.Active) CloseMenu();
			else Show();
		}
	}

	private void HandleTransitionInState() { }
	private void HandleTransitionOutState() { }
	private void HandleInactiveState() { }

	public void Show()
	{
		menuState = MenuStateEnum.Active;
		if (Container != null) Container.SetActive(true);
		m_OnMenuStateChanged?.Invoke(true);
	}

	private void HandleActiveState() { }
	private void GameCenterAccessPointTrigger() { }
	private void UpdateSelectionHand(float speed) { }

	public void CloseMenu()
	{
		menuState = MenuStateEnum.Inactive;
		if (Container != null) Container.SetActive(false);
		m_OnMenuStateChanged?.Invoke(false);
	}

	public void OpenSettings() { }
	public void ReturnFromSettings() { }
	public void ExitFromSettings() => CloseMenu();

	public void ExitGame()
	{
		CloseMenu();
		if (Level.HasInstance) Level.Instance.Abort();
		else _ = HubSceneLoader.Instance.LoadSceneAsync(LoadSceneMode.Single);
	}

	public void SkipLevel()
	{
		CloseMenu();
		if (Level.HasInstance) Level.Instance.Complete("SKIPPED!", 0.2f);
	}

	public void ChangeGyroControls()
	{
		SaveGame.SwitchUseGyro = !SaveGame.SwitchUseGyro;
	}

	public void RestartLevel()
	{
		CloseMenu();
		if (Level.HasInstance) Level.Instance.Restart();
		else SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
