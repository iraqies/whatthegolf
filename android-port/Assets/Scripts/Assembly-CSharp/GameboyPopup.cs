using System;
using System.Collections;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class GameboyPopup : PopupController
{
	public enum Type
	{
		DeepLink = 0,
		PushNotif = 1,
		Hub = 2,
		WhatsNew = 3
	}

	private const NotificationSystemType localizationType = NotificationSystemType.Gameboy;

	private Action _onClosedClicked;

	private Action _onPlayClicked;

	private static GameboyPopup instance;

	[SerializeField]
	private GameObject InactiveParent;

	[SerializeField]
	private TextMeshProUGUI DaysLeftText;

	[SerializeField]
	private SVGImage DioramaImage;

	[SerializeField]
	private SVGImage DioramaImageLevelNotifications;

	[SerializeField]
	private HighscoreList HighscoreList;

	[SerializeField]
	private Animator CloseButtonAnimator;

	[SerializeField]
	private RectTransform ContainerTransform;

	[SerializeField]
	private GameObject LeaderboardButton;

	[SerializeField]
	private TextMeshProLocalized DescriptionText;

	[SerializeField]
	private TextMeshProLocalized TitleText;

	[SerializeField]
	private GameObject ImpossibleChallengeLeaderboard;

	private bool startLevelsOnPlayClicked;

	private static string gameNotificationsPlayerPrefsId;

	private Type _type;

	private TaskCompletionSource<bool> tcs;

	private bool _isShowingLeaderboard;

	public static string SeenNotifications => null;

	public static GameboyPopup Instance
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public static Task Load()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	protected override void Update()
	{
	}

	public Task<bool> ShowWithResult(WTGNotification notification, Action onPopupDismissed, bool startLevelsOnPlayClicked, Type type, bool showImpossibleLeaderboard = false)
	{
		return null;
	}

	private void InitLeaderboard(ContentPack pack)
	{
	}

	public void Show(WTGNotification notification, bool forceShow, Type type)
	{
	}

	public static bool HasBeenSeenBefore(string notificationId)
	{
		return false;
	}

	private IEnumerator Show(ContentPackDef packContainer, IPackWithData pack, LocalizationData locData, bool isLevelNotification)
	{
		return null;
	}

	public void OnLeaderboardClicked()
	{
	}

	public void OnHideLeaderboardClicked()
	{
	}

	public IEnumerator HideLeaderboard()
	{
		return null;
	}

	private IEnumerator ShowLeaderboard()
	{
		return null;
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool confirmed, bool invokeCallbacks)
	{
	}

	protected override void OnPlay()
	{
	}

	public void StartPack(IPackWithData pack)
	{
	}

	public void SetState(bool isAvailable, bool showImpossibleLeaderboard)
	{
	}
}
