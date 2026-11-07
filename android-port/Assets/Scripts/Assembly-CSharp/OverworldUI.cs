using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio;
using Core;
using Core.UI;
using Rewired;
using UnityEngine;
using UnityEngine.UI;
using Utility;

public class OverworldUI : MonoBehaviour
{
	[CompilerGenerated]
	private Action m_OnExitingOverworld;

	public RawImage Screenshot;

	public List<AudioClip> PopupClips;

	public ClipSettingsCollection CrownWonSequenceSFX;

	public float volume;

	public List<Button> buttonCancel;

	public RectTransform MenuContainer;

	public List<SubObjectiveUIElement> ChallengeElement;

	public RectTransform ChallengesContainer;

	public RectTransform ScreenshotContainer;

	public GameObject PlayAgainDialogContainer;

	public Button ExitOverworldButton;

	[SerializeField]
	private Sprite CloseSprite;

	[SerializeField]
	private Sprite MenuSprite;

	[SerializeField]
	private TextureLibrary screenshotTextureLibrary;

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
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Initialize()
	{
	}

	public void EnableReturnButton()
	{
	}

	public void DisableReturnButton(LevelData level)
	{
	}

	public void ExitToMenu()
	{
	}

	public void ShowMenu()
	{
	}

	public IEnumerator ExitToHub()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	public bool IsPlayAgainDialogActive()
	{
		return false;
	}

	public void ShowPlayagainDialog(OverworldGoal goal, Action<string> onPlayLevelCallback, Action onCloseCallback)
	{
	}

	public void RefreshElements()
	{
	}

	public bool IsMenuActive()
	{
		return false;
	}

	private bool GetGoalUsedLandscape(OverworldGoal goal)
	{
		return false;
	}

	public void ChallengeCompleted(string challengeID)
	{
	}

	public void CloseUI()
	{
	}

	private void Close()
	{
	}

	public void DisableUI()
	{
	}

	public void EnableUI()
	{
	}

	private void Update()
	{
	}

	private void ListenToCloseButton()
	{
	}

	private void UpdatePlayAgainDialog()
	{
	}

	private void StartCloseTimer()
	{
	}

	private void StopCloseTimer()
	{
	}

	private void UpdateAndHandleCloseTimer()
	{
	}

	public void ClearPlayagainDialog()
	{
	}

	private void AddCancelListeners()
	{
	}

	private void RemoveAllListeners()
	{
	}

	private IEnumerator ShowRoutine()
	{
		return null;
	}

	private bool NoneIsNull()
	{
		return false;
	}

	public void CloseInstant()
	{
	}

	private IEnumerator HideRoutine()
	{
		return null;
	}
}
