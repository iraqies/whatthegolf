using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio;
using Core;
using Core.UI;
using Rewired;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Utility;

public class OverworldUI : MonoBehaviour
{
	[CompilerGenerated]
	private Action m_OnExitingOverworld;

	public RawImage Screenshot;
	public List<AudioClip> PopupClips;
	public ClipSettingsCollection CrownWonSequenceSFX;
	public float volume = 1f;
	public List<Button> buttonCancel;
	public RectTransform MenuContainer;
	public List<SubObjectiveUIElement> ChallengeElement;
	public RectTransform ChallengesContainer;
	public RectTransform ScreenshotContainer;
	public GameObject PlayAgainDialogContainer;
	public Button ExitOverworldButton;
	[SerializeField] private Sprite CloseSprite;
	[SerializeField] private Sprite MenuSprite;
	[SerializeField] private TextureLibrary screenshotTextureLibrary;
	public Animator PlayAgainAnimator;
	public Animator CrownWonAnimator;
	public Canvas PlayAgainCanvas;
	public Sprite NoIconReplacement;
	public RectTransform CloseButtonRect;
	public RectTransform CloseButtonRectRotated;
	public RectTransform ChallengeContainer;
	public AimMarker AimMarker;
	public GameObject CrownLocked;
	public GameObject CrownWon;
	public GameObject CrownWonTop;
	public RectTransform CrownToFlag;
	public RectTransform SelectionBox;
	public AnimationCurve AppearCurve;
	public AnimationCurve DisappearCurve;
	public CanvasGroup BackgroundImage;
	public CanvasGroup ScanlinesAlpha;
	public Animator KeyboardAnimator;
	public Animator ScanlinesAnimator;
	public RectTransform NextUpRectTransform;
	public Transition.TransitionEffect TransitionEffectType;

	private Vector3 activePosition;
	private Vector3 activePosition2D;
	private Player player;
	private int selectedChallengeIndex;
	private Vector3 currentChallengeVel;
	private float changeTimer;
	private bool crownWon;
	private CanvasScaler canvasScaler;
	private bool isClosing;
	private Action<string> onPlayLevelCallback;
	private Action onCloseCallback;
	private List<LevelData> allLevels;
	private OverworldGoal goal;
	private OverworldGoal previousGoal;
	private float screenshotSwitchTimer;
	private int currentSpriteIndex;
	private List<Texture> currentScreenshotSprites;
	private SVGImage selectionBoxImage;
	private float scanlinesTimer;
	private Dictionary<OverworldGoal, bool> goalUsesLandscapeCrown;
	private float closeTimer;
	private const float closeTimerMax = 10f;
	private bool _exiting;
	private bool shouldUpdate;

	public event Action OnExitingOverworld
	{
		[CompilerGenerated]
		add => m_OnExitingOverworld = (Action)Delegate.Combine(m_OnExitingOverworld, value);
		[CompilerGenerated]
		remove => m_OnExitingOverworld = (Action)Delegate.Remove(m_OnExitingOverworld, value);
	}

	private void Awake()
	{
		Initialize();
	}

	public void Initialize()
	{
		if (PlayAgainDialogContainer != null)
			PlayAgainDialogContainer.SetActive(false);
		if (AimMarker != null)
			AimMarker.Hide();
		if (ExitOverworldButton != null)
		{
			ExitOverworldButton.interactable = true;
			ExitOverworldButton.gameObject.SetActive(true);
			if (MenuSprite != null && ExitOverworldButton.image != null)
				ExitOverworldButton.image.sprite = MenuSprite;
			ExitOverworldButton.onClick.RemoveAllListeners();
			ExitOverworldButton.onClick.AddListener(ShowMenu);
		}
	}

	public void EnableReturnButton()
	{
		if (ExitOverworldButton != null)
			ExitOverworldButton.interactable = true;
	}

	public void DisableReturnButton(LevelData level)
	{
		if (ExitOverworldButton != null)
			ExitOverworldButton.interactable = false;
	}

	public void ExitToMenu()
	{
		ShowMenu();
	}

	public async void ShowMenu()
	{
		if (_exiting) return;
		bool prevActive = ExitOverworldButton != null && ExitOverworldButton.gameObject.activeSelf;
		if (ExitOverworldButton != null)
			ExitOverworldButton.gameObject.SetActive(false);
		if (Menu.Menu.Instance != null)
			await Menu.Menu.Instance.ShowAndAwait();
		if (ExitOverworldButton != null)
			ExitOverworldButton.gameObject.SetActive(prevActive);
	}

	public IEnumerator ExitToHub()
	{
		m_OnExitingOverworld?.Invoke();
		var task = HubSceneLoader.Instance.LoadSceneAsync(LoadSceneMode.Single);
		while (!task.IsCompleted)
			yield return null;
	}

	private void OnDestroy() { }

	public bool IsPlayAgainDialogActive()
	{
		return PlayAgainDialogContainer != null && PlayAgainDialogContainer.activeInHierarchy;
	}

	public void ShowPlayagainDialog(OverworldGoal goal, Action<string> onPlayLevelCallback, Action onCloseCallback)
	{
		this.goal = goal;
		this.onPlayLevelCallback = onPlayLevelCallback;
		this.onCloseCallback = onCloseCallback;
		string challengeId = null;
		if (goal != null && goal.levelData != null)
		{
			var ids = goal.levelData.GetChallengeLocalizationIDs();
			if (ids != null && ids.Count > 0)
				challengeId = ids[0];
		}
		onPlayLevelCallback?.Invoke(challengeId);
	}

	public void RefreshElements() { }
	public bool IsMenuActive() => Menu.Menu.Exists && Menu.Menu.Instance.IsOpen();
	private bool GetGoalUsedLandscape(OverworldGoal goal) => true;
	public void ChallengeCompleted(string challengeID) { }
	public void CloseUI() => Close();

	private void Close()
	{
		if (PlayAgainDialogContainer != null)
			PlayAgainDialogContainer.SetActive(false);
		onCloseCallback?.Invoke();
	}

	public void DisableUI()
	{
		if (ExitOverworldButton != null)
			ExitOverworldButton.gameObject.SetActive(false);
	}

	public void EnableUI()
	{
		if (ExitOverworldButton != null)
			ExitOverworldButton.gameObject.SetActive(true);
	}

	private void Update() { }
	private void ListenToCloseButton() { }
	private void UpdatePlayAgainDialog() { }
	private void StartCloseTimer() { }
	private void StopCloseTimer() { }
	private void UpdateAndHandleCloseTimer() { }

	public void ClearPlayagainDialog()
	{
		if (PlayAgainDialogContainer != null)
			PlayAgainDialogContainer.SetActive(false);
	}

	private void AddCancelListeners() { }
	private void RemoveAllListeners() { }
	private IEnumerator ShowRoutine() { yield break; }
	private bool NoneIsNull() => true;

	public void CloseInstant()
	{
		if (PlayAgainDialogContainer != null)
			PlayAgainDialogContainer.SetActive(false);
	}

	private IEnumerator HideRoutine()
	{
		CloseInstant();
		yield break;
	}
}
