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
	public AimMarker aimMarker => AimMarker;
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
		if (_exiting) yield break;
		_exiting = true;
		if (OverworldManager2d.Instance != null)
			OverworldManager2d.Instance.DisableInteraction(true);
		if (ExitOverworldButton != null && ExitOverworldButton.onClick != null)
			ExitOverworldButton.onClick.RemoveAllListeners();
		SaveThrobber.ShowThrobber(1f);
		if (LevelManager.Instance != null)
			yield return StartCoroutine(LevelManager.Instance.StartTransition(default, null, false, false, false, TransitionEffectType, null));
		m_OnExitingOverworld?.Invoke();
		if (HubSceneLoader.Instance != null)
		{
			var task = HubSceneLoader.Instance.LoadSceneAsync(LoadSceneMode.Single);
			while (task != null && !task.IsCompleted)
				yield return null;
		}
		else
		{
			SaveGame.SetOverworld(ECampaignType.Hub);
			SceneManager.LoadSceneAsync("Hub_Overworld", LoadSceneMode.Single);
		}
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
		isClosing = false;

		if (PlayAgainDialogContainer == null)
		{
			onCloseCallback?.Invoke();
			return;
		}

		PlayAgainDialogContainer.SetActive(true);
		bool isRotated = goal != null && goal.IsRotated2D();
		if (PlayAgainAnimator != null)
		{
			PlayAgainAnimator.keepAnimatorControllerStateOnDisable = true;
			PlayAgainAnimator.SetBool("Rotated", isRotated);
			PlayAgainAnimator.Play("Show");
		}
		if (KeyboardAnimator != null)
			KeyboardAnimator.SetBool("Show", !isRotated);
		if (ExitOverworldButton != null)
			ExitOverworldButton.interactable = false;

		if (MenuContainer != null)
		{
			if (PlatformSettings.IsMobile)
				MenuContainer.rotation = Quaternion.Euler(0f, 0f, isRotated ? -90f : 0f);
			else
				MenuContainer.rotation = Quaternion.identity;
		}
		if (CloseButtonRect != null)
			CloseButtonRect.gameObject.SetActive(!isRotated);
		if (CloseButtonRectRotated != null)
			CloseButtonRectRotated.gameObject.SetActive(isRotated);

		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && PopupClips != null && PopupClips.Count > 0)
			AudioManager.Instance.sfx.Play(PopupClips, s => { if (s != null) s.volume = volume; }, true, 0f, false);

		AddCancelListeners();
		allLevels = goal != null ? goal.GetAllGoalLevels() : new List<LevelData>();
		RefreshElements();
		previousGoal = goal;
		shouldUpdate = true;
		closeTimer = closeTimerMax;
	}

	public void RefreshElements()
	{
		closeTimer = closeTimerMax;
		if (ChallengeElement == null || ChallengeElement.Count == 0)
			return;

		for (int i = 1; i < ChallengeElement.Count; i++)
		{
			if (ChallengeElement[i] != null)
			{
				ChallengeElement[i].ChallengeID = null;
				ChallengeElement[i].ChallengeTitleID = null;
				ChallengeElement[i].gameObject.SetActive(false);
			}
		}

		if (NextUpRectTransform != null)
			NextUpRectTransform.gameObject.SetActive(false);

		var firstElem = ChallengeElement[0];
		if (firstElem != null)
		{
			firstElem.ChallengeID = null;
			firstElem.gameObject.SetActive(true);
			if (firstElem.Button != null)
			{
				firstElem.Button.interactable = true;
				firstElem.Button.onClick.RemoveAllListeners();
				firstElem.Button.onClick.AddListener(() =>
				{
					var cb = onPlayLevelCallback;
					selectedChallengeIndex = 0;
					if (firstElem.sfxOnSelect != null && AudioManager.Instance != null)
						firstElem.sfxOnSelect.Play(AudioManager.Instance.sfx, Vector3.zero, 0f);
					RemoveAllListeners();
					CloseInstant();
					cb?.Invoke(firstElem.ChallengeID);
				});
			}
		}

		if (allLevels == null && goal != null)
			allLevels = goal.GetAllGoalLevels();

		int elemIdx = 1;
		if (allLevels != null)
		{
			foreach (var lvl in allLevels)
			{
				if (lvl == null || lvl.levelChallenges == null || lvl.levelChallenges.Count == 0)
					continue;
				var completed = lvl.CompletedChallenges ?? new List<string>();
				for (int c = 0; c < lvl.levelChallenges.Count && elemIdx < ChallengeElement.Count; c++)
				{
					var ch = lvl.levelChallenges[c];
					var elem = ChallengeElement[elemIdx];
					if (ch == null || elem == null) continue;
					elem.ChallengeID = ch.ID;
					elem.ChallengeTitleID = ch.LocalizationID;
					elem.gameObject.SetActive(true);
					bool isDone = completed.Contains(ch.ID);
					if (isDone) elem.Unlock(0f);
					else elem.Lock();

					if (elem.Button != null)
					{
						string capturedId = ch.ID;
						int capturedIdx = elemIdx;
						var capturedElem = elem;
						elem.Button.interactable = true;
						elem.Button.onClick.RemoveAllListeners();
						elem.Button.onClick.AddListener(() =>
						{
							var cb = onPlayLevelCallback;
							selectedChallengeIndex = capturedIdx;
							if (capturedElem.sfxOnSelect != null && AudioManager.Instance != null)
								capturedElem.sfxOnSelect.Play(AudioManager.Instance.sfx, Vector3.zero, 0f);
							RemoveAllListeners();
							CloseInstant();
							cb?.Invoke(capturedId);
						});
					}
					elemIdx++;
				}
			}
		}

		bool allDone = goal != null && goal.IsFullyCompleted();
		if (CrownLocked != null) CrownLocked.SetActive(!allDone);
		if (CrownWon != null) CrownWon.SetActive(allDone);
	}

	public bool IsMenuActive() => Menu.Menu.Exists && Menu.Menu.Instance.IsOpen();
	private bool GetGoalUsedLandscape(OverworldGoal goal) => true;

	public void ChallengeCompleted(string challengeID)
	{
		if (ChallengeElement != null)
		{
			foreach (var elem in ChallengeElement)
			{
				if (elem != null && elem.ChallengeID == challengeID)
					elem.Unlock(0.4f);
			}
		}
		if (goal != null && goal.IsFullyCompleted())
		{
			crownWon = true;
			goal.ForceShowCrown();
		}
	}

	public void CloseUI() => Close();

	private void Close()
	{
		if (isClosing) return;
		isClosing = true;
		ClearPlayagainDialog();
	}

	public void DisableUI()
	{
		if (ExitOverworldButton != null)
			ExitOverworldButton.gameObject.SetActive(false);
		shouldUpdate = false;
	}

	public void EnableUI()
	{
		if (ExitOverworldButton != null)
			ExitOverworldButton.gameObject.SetActive(true);
		shouldUpdate = true;
	}

	private void Update()
	{
		if (!shouldUpdate) return;
		if (PlayAgainDialogContainer != null && PlayAgainDialogContainer.activeInHierarchy)
		{
			if (closeTimer > 0f)
			{
				closeTimer = Mathf.Max(0f, closeTimer - Time.unscaledDeltaTime);
				if (closeTimer == 0f)
				{
					ClearPlayagainDialog();
					closeTimer = -1f;
				}
			}
		}
	}

	private void ListenToCloseButton() { }
	private void UpdatePlayAgainDialog() { }
	private void StartCloseTimer() => closeTimer = closeTimerMax;
	private void StopCloseTimer() => closeTimer = -1f;
	private void UpdateAndHandleCloseTimer() { }

	public void ClearPlayagainDialog()
	{
		RemoveAllListeners();
		if (PlayAgainDialogContainer != null && PlayAgainDialogContainer.activeSelf)
		{
			StartCoroutine(HideRoutine());
		}
		else
		{
			CloseInstant();
		}
	}

	private void AddCancelListeners()
	{
		if (buttonCancel == null) return;
		foreach (var btn in buttonCancel)
		{
			if (btn != null && btn.onClick != null)
			{
				btn.onClick.RemoveAllListeners();
				btn.onClick.AddListener(CloseUI);
			}
		}
	}

	private void RemoveAllListeners()
	{
		if (buttonCancel != null)
		{
			foreach (var btn in buttonCancel)
				if (btn != null && btn.onClick != null) btn.onClick.RemoveAllListeners();
		}
		if (ChallengeElement != null)
		{
			foreach (var elem in ChallengeElement)
				if (elem != null && elem.Button != null && elem.Button.onClick != null) elem.Button.onClick.RemoveAllListeners();
		}
	}

	private IEnumerator ShowRoutine() { yield break; }
	private bool NoneIsNull() => true;

	public void CloseInstant()
	{
		RemoveAllListeners();
		var cb = onCloseCallback;
		onCloseCallback = null;
		goal = null;
		if (PlayAgainDialogContainer != null)
			PlayAgainDialogContainer.SetActive(false);
		EnableReturnButton();
		isClosing = false;
		crownWon = false;
		cb?.Invoke();
	}

	private IEnumerator HideRoutine()
	{
		StopCloseTimer();
		if (PlayAgainAnimator != null)
			PlayAgainAnimator.SetTrigger("Hide");
		yield return new WaitForSecondsRealtime(0.15f);
		CloseInstant();
	}
}
