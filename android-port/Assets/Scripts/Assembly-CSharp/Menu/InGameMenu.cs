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

		private void Awake() => Init();

		public void Init()
		{
			rectTrans = GetComponent<RectTransform>();
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
		}

		public void DisableCloseButton() { }
		public void ForceScreenChangeHide() => HideMenu();
		private void Instance_OnLevelWillUnload() => HideMenu();

		public void Instance_OnLevelLoaded(LevelData level)
		{
			if (levelName != null && level != null)
				levelName.text = level.name;
		}

		public bool ToggleLevelName() => true;

		public void ShowMenu()
		{
			if (menuCanvas != null) menuCanvas.enabled = true;
			gameObject.SetActive(true);
		}

		public void HideMenu()
		{
			if (menuCanvas != null) menuCanvas.enabled = false;
		}

		public void DeactivateMenu() => gameObject.SetActive(false);
		public void ToggleTopButtonTransparency(bool isVisible) { }
		public void ToggleRestartButton(bool state) { if (restartButton != null) restartButton.gameObject.SetActive(state); }
		public void ToggleExitButton(bool state) { if (exitButton != null) exitButton.gameObject.SetActive(state); }
		public void ActivateMenu() => gameObject.SetActive(true);
		public void ToggleLookUp(bool state) { if (LookUpText != null) LookUpText.SetActive(state); }
		public void SetStrokeCounterSettings(StrokeCounter.CounterTypes counterType, bool useExternalCountActivator) { }
		public StrokeCounter GetStrokeCounter() => strokeCounter;
		public void SetStrokeCounterSettings(int initialStrokes, StrokeCounter.CounterTypes counterType, bool useExternalCountActivator, int playerIndex = 0) { }
		public void ToggleStrokeCounter(bool state) { if (strokeCounterContainer != null) strokeCounterContainer.gameObject.SetActive(state); }
		public void CountStroke(GolfBallController shooter, int strokes) { }
		public void CountStroke(int playerIndex, int strokes) { }
		public void CountStroke(int strokes) { }
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

		public void ResetStrokes(int resetToThis = 0) => Game.strokes = resetToThis;
		public void ToggleLeaderCrown(bool state) { }
		public void ResetStrokes(int playerId, int resetToThis = 0) => Game.strokes = resetToThis;
		public void SetOrientation(LevelData.WindowType window) { }
		public void ChallengeCompleted(string title) { }
		public void ChallengeFailed(string title) { }
		public void ShowChallengeInfo(string text) { }
		public void ShowChallengeInfo(string text, Sprite[] icons) { }
		public IEnumerator ShowText(string text, float duration) { yield break; }
		public void ShowUndockMessage() { }
		public void HideUndockMessage() { }
		public void EnableBuildText() { }
		public void DisableBuildText() { }
		public void SetActiveBuildText(bool enable) { }
		private void FindBuildText() { }
		public void ShowFullScreenText(string text, float duration) { }
		public void ShowInformationText(string text, float duration, bool aboveTransition = false) { }
		public void SetChallengeInfoToShowForMinSeconds(bool show) { }
	}
}
