using System;
using System.Collections;
using Core;
using Core.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Menu
{
	public class InGameMenu : MonoBehaviour
	{
		[SerializeField] private RectTransform strokeCounterContainer;
		[SerializeField] private StrokeCounter strokeCounter;
		[SerializeField] private Transition transition;
		[SerializeField] private GameObject menuButton;
		[SerializeField] private Button exitButton;
		[SerializeField] private Button restartButton;
		[SerializeField] private Canvas menuCanvas;
		[SerializeField] private TextMeshProUGUI levelName;
		[SerializeField] private ChallengeCompletedUI ChallengeUI;
		[SerializeField] private ChallengeCompletedUI ChallengeFailedUI;
		[SerializeField] private InGameChallengeInfo ChallengeInfo;
		[SerializeField] private InGameChallengeInfo ChallengeInfoTop;
		[SerializeField] private GameObject LookUpText;
		[SerializeField] private SwitchUndockMessage UndockMessage;
		[SerializeField] private InGameFullScreenText fullScreenText;
		[SerializeField] private IngameInformationText informationText;
		public DailyChallengePagination DailyChallengePagination;
		public Action OnAbandonButtonClicked;
		public Action OnRestartButtonClicked;

		private RectTransform rectTrans;
		private GameObject currentFailScreen;
		private GameObject currentTitleScreen;
		private GameObject currentWinScreen;
		private TextWithShadow currentWinMessage;
		private Button[] menuButtons;
		private TextMeshProUGUI buildText;

		private void Awake()
		{
			if (menuCanvas != null)
				rectTrans = menuCanvas.GetComponent<RectTransform>();
			if (menuButton != null)
			{
				menuButton.SetActive(false);
				menuButtons = menuButton.GetComponentsInChildren<Button>(true);
			}
			Init();
		}

		public void Init()
		{
			if (strokeCounter != null)
				strokeCounter.Init();
			if (fullScreenText != null)
			{
				fullScreenText.Init();
				fullScreenText.HideInstantly();
			}
			if (informationText != null)
				informationText.ClearText();
			if (DailyChallengePagination != null)
				DailyChallengePagination.DisableInstantly();
			if (exitButton != null)
			{
				exitButton.onClick.RemoveAllListeners();
				exitButton.onClick.AddListener(AbandonLevel);
			}
			if (restartButton != null)
			{
				restartButton.onClick.RemoveAllListeners();
				restartButton.onClick.AddListener(RestartLevel);
			}
			if (UndockMessage != null)
				UndockMessage.gameObject.SetActive(false);
			if (LookUpText != null)
				LookUpText.SetActive(false);
			if (ChallengeUI != null)
				ChallengeUI.gameObject.SetActive(false);
			if (ChallengeFailedUI != null)
				ChallengeFailedUI.gameObject.SetActive(false);
			if (ChallengeInfo != null)
				ChallengeInfo.gameObject.SetActive(false);
			if (ChallengeInfoTop != null)
				ChallengeInfoTop.gameObject.SetActive(false);
			if (LevelManager.Exists && LevelManager.Instance != null)
			{
				LevelManager.Instance.OnLevelLoaded -= Instance_OnLevelLoaded;
				LevelManager.Instance.OnLevelLoaded += Instance_OnLevelLoaded;
				LevelManager.Instance.OnLevelWillUnload -= Instance_OnLevelWillUnload;
				LevelManager.Instance.OnLevelWillUnload += Instance_OnLevelWillUnload;
			}
			HideMenu();
		}

		public void DisableCloseButton()
		{
			if (exitButton != null)
				exitButton.interactable = false;
		}

		public void ForceScreenChangeHide()
		{
			if (transition != null)
				StartCoroutine(transition.EndTransition(false, 0f));
		}

		private void Instance_OnLevelWillUnload()
		{
			if (levelName != null)
				levelName.text = string.Empty;
			HideMenu();
		}

		public void Instance_OnLevelLoaded(LevelData level)
		{
			if (level == null) return;
			SetOrientation(level.GetWindowType());
			if (levelName != null)
				levelName.text = level.SceneName;
		}

		public bool ToggleLevelName()
		{
			if (levelName == null) return false;
			bool next = !levelName.gameObject.activeSelf;
			levelName.gameObject.SetActive(next);
			return next;
		}

		public void ShowMenu()
		{
			if (menuButton != null)
				menuButton.SetActive(true);
		}

		public void HideMenu()
		{
			if (menuButton != null)
				menuButton.SetActive(false);
		}

		public void DeactivateMenu()
		{
			if (menuButton != null)
				menuButton.transform.position += Vector3.up * 100f;
		}

		public void ToggleTopButtonTransparency(bool isVisible)
		{
			if (menuButton == null) return;
			var cg = menuButton.GetComponent<CanvasGroup>();
			if (cg != null)
				cg.alpha = isVisible ? 1f : 0f;
		}

		public void ToggleRestartButton(bool state)
		{
			if (restartButton != null)
				restartButton.interactable = state;
		}

		public void ToggleExitButton(bool state)
		{
			if (exitButton != null)
				exitButton.interactable = state;
		}

		public void ActivateMenu()
		{
			if (menuButton != null)
				menuButton.transform.localPosition = Vector3.zero;
		}

		public void ToggleLookUp(bool state)
		{
			if (LookUpText != null)
				LookUpText.SetActive(state);
		}

		public void SetStrokeCounterSettings(StrokeCounter.CounterTypes counterType, bool useExternalCountActivator)
		{
			if (strokeCounter != null)
			{
				strokeCounter.gameObject.SetActive(true);
				strokeCounter.CounterType = counterType;
				strokeCounter.UseExternalCountActivator = useExternalCountActivator;
				strokeCounter.SetInitialStrokes(false, -1, 0);
			}
		}

		public StrokeCounter GetStrokeCounter() => strokeCounter;

		public void SetStrokeCounterSettings(int initialStrokes, StrokeCounter.CounterTypes counterType, bool useExternalCountActivator, int playerIndex = 0)
		{
			if (strokeCounter != null)
			{
				strokeCounter.gameObject.SetActive(true);
				strokeCounter.CounterType = counterType;
				strokeCounter.UseExternalCountActivator = useExternalCountActivator;
				strokeCounter.SetInitialStrokes(true, initialStrokes, playerIndex);
			}
		}

		public void ToggleStrokeCounter(bool state)
		{
			if (strokeCounter != null)
				strokeCounter.gameObject.SetActive(state);
			if (strokeCounterContainer != null)
				strokeCounterContainer.gameObject.SetActive(state);
		}

		public void CountStroke(GolfBallController shooter, int strokes)
		{
			if (shooter != null && strokeCounter != null)
				strokeCounter.CountStroke(shooter.PlayerIndex, strokes);
		}

		public void CountStroke(int playerIndex, int strokes)
		{
			if (strokeCounter != null)
				strokeCounter.CountStroke(playerIndex, strokes);
		}

		public void CountStroke(int strokes)
		{
			if (strokeCounter != null)
				strokeCounter.CountStroke(strokes);
		}

		public void EnableMenu() => ActivateMenu();
		public void DisableMenu() => DeactivateMenu();

		public void AbandonLevel()
		{
			OnAbandonButtonClicked?.Invoke();
			if (Level.HasInstance) Level.Instance.Abort();
		}

		public void RestartLevel()
		{
			OnRestartButtonClicked?.Invoke();
			if (Level.HasInstance) Level.Instance.Restart();
		}

		public void ResetStrokes(int resetToThis = 0)
		{
			Game.strokes = resetToThis;
			if (strokeCounter != null)
				strokeCounter.Reset(resetToThis);
		}

		public void ToggleLeaderCrown(bool state)
		{
			if (strokeCounter != null)
				strokeCounter.ToggleLeaderCrown(state);
		}

		public void ResetStrokes(int playerId, int resetToThis = 0)
		{
			Game.strokes = resetToThis;
			if (strokeCounter != null)
				strokeCounter.ResetForPlayer(playerId, resetToThis);
		}

		public void SetOrientation(LevelData.WindowType window) { }
		public void ChallengeCompleted(string title) { }
		public void ChallengeFailed(string title) { }
		public void ShowChallengeInfo(string text) { }
		public void ShowChallengeInfo(string text, Sprite[] icons) { }
		public IEnumerator ShowText(string text, float duration)
		{
			if (currentWinScreen != null)
				currentWinScreen.SetActive(true);
			if (currentWinMessage != null)
				currentWinMessage.text = text ?? string.Empty;
			yield return new WaitForSecondsRealtime(duration);
			if (currentWinMessage != null)
				currentWinMessage.text = string.Empty;
			if (currentWinScreen != null)
				currentWinScreen.SetActive(false);
		}

		public void ShowUndockMessage() { }
		public void HideUndockMessage() { if (UndockMessage != null) UndockMessage.gameObject.SetActive(false); }
		public void EnableBuildText() { }
		public void DisableBuildText() { }
		public void SetActiveBuildText(bool enable) { }
		private void FindBuildText() { }
		public void ShowFullScreenText(string text, float duration) { }
		public void ShowInformationText(string text, float duration, bool aboveTransition = false) { }
		public void SetChallengeInfoToShowForMinSeconds(bool show) { }
	}
}
