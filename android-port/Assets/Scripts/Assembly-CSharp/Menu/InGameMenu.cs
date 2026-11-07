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
		[SerializeField]
		private RectTransform strokeCounterContainer;

		[SerializeField]
		private StrokeCounter strokeCounter;

		[SerializeField]
		private Transition transition;

		[SerializeField]
		private GameObject menuButton;

		[SerializeField]
		private Button exitButton;

		[SerializeField]
		private Button restartButton;

		[SerializeField]
		private Canvas menuCanvas;

		[SerializeField]
		private TextMeshProUGUI levelName;

		[SerializeField]
		private ChallengeCompletedUI ChallengeUI;

		[SerializeField]
		private ChallengeCompletedUI ChallengeFailedUI;

		[SerializeField]
		private InGameChallengeInfo ChallengeInfo;

		[SerializeField]
		private InGameChallengeInfo ChallengeInfoTop;

		[SerializeField]
		private GameObject LookUpText;

		[SerializeField]
		private SwitchUndockMessage UndockMessage;

		[SerializeField]
		private InGameFullScreenText fullScreenText;

		[SerializeField]
		private IngameInformationText informationText;

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
		}

		public void Init()
		{
		}

		public void DisableCloseButton()
		{
		}

		public void ForceScreenChangeHide()
		{
		}

		private void Instance_OnLevelWillUnload()
		{
		}

		public void Instance_OnLevelLoaded(LevelData level)
		{
		}

		public bool ToggleLevelName()
		{
			return false;
		}

		public void ShowMenu()
		{
		}

		public void HideMenu()
		{
		}

		public void DeactivateMenu()
		{
		}

		public void ToggleTopButtonTransparency(bool isVisible)
		{
		}

		public void ToggleRestartButton(bool state)
		{
		}

		public void ToggleExitButton(bool state)
		{
		}

		public void ActivateMenu()
		{
		}

		public void ToggleLookUp(bool state)
		{
		}

		public void SetStrokeCounterSettings(StrokeCounter.CounterTypes counterType, bool useExternalCountActivator)
		{
		}

		public StrokeCounter GetStrokeCounter()
		{
			return null;
		}

		public void SetStrokeCounterSettings(int initialStrokes, StrokeCounter.CounterTypes counterType, bool useExternalCountActivator, int playerIndex = 0)
		{
		}

		public void ToggleStrokeCounter(bool state)
		{
		}

		public void CountStroke(GolfBallController shooter, int strokes)
		{
		}

		public void CountStroke(int playerIndex, int strokes)
		{
		}

		public void CountStroke(int strokes)
		{
		}

		public void EnableMenu()
		{
		}

		public void DisableMenu()
		{
		}

		public void AbandonLevel()
		{
		}

		public void RestartLevel()
		{
		}

		public void ResetStrokes(int resetToThis = 0)
		{
		}

		public void ToggleLeaderCrown(bool state)
		{
		}

		public void ResetStrokes(int playerId, int resetToThis = 0)
		{
		}

		public void SetOrientation(LevelData.WindowType window)
		{
		}

		public void ChallengeCompleted(string title)
		{
		}

		public void ChallengeFailed(string title)
		{
		}

		public void ShowChallengeInfo(string text)
		{
		}

		public void ShowChallengeInfo(string text, Sprite[] icons)
		{
		}

		public IEnumerator ShowText(string text, float duration)
		{
			return null;
		}

		public void ShowUndockMessage()
		{
		}

		public void HideUndockMessage()
		{
		}

		public void EnableBuildText()
		{
		}

		public void DisableBuildText()
		{
		}

		public void SetActiveBuildText(bool enable)
		{
		}

		private void FindBuildText()
		{
		}

		public void ShowFullScreenText(string text, float duration)
		{
		}

		public void ShowInformationText(string text, float duration, bool aboveTransition = false)
		{
		}

		public void SetChallengeInfoToShowForMinSeconds(bool show)
		{
		}
	}
}
