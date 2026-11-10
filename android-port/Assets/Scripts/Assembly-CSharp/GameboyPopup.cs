using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Menu;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;

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

	private static string gameNotificationsPlayerPrefsId = "SEEN_GAMEBOY_NOTIFICATIONS";

	private Type _type;

	private TaskCompletionSource<bool> tcs;

	private bool _isShowingLeaderboard;

	public static string SeenNotifications => PlayerPrefs.GetString(gameNotificationsPlayerPrefsId);

	public static GameboyPopup Instance
	{
		get
		{
			if (instance == null)
			{
				instance = FindObjectOfType<GameboyPopup>(includeInactive: true);
				if (instance == null)
				{
					GameObject prefab = null;
					try
					{
						var handle = Addressables.LoadAssetAsync<GameObject>("GameboyPopup");
						prefab = handle.WaitForCompletion();
					}
					catch
					{
					}
					if (prefab == null)
					{
						prefab = Resources.Load<GameObject>("Prefabs/GameboyPopup") ?? Resources.Load<GameObject>("Prefabs/Gameboy Popup");
					}
					if (prefab != null)
					{
						var go = Instantiate(prefab);
						instance = go.GetComponent<GameboyPopup>();
					}
				}
			}
			return instance;
		}
		private set
		{
			if (instance != null && instance != value)
			{
				Destroy(instance.gameObject);
			}
			instance = value;
			if (instance != null)
			{
				DontDestroyOnLoad(instance.gameObject);
			}
		}
	}

	public static async Task Load()
	{
		if (instance == null)
		{
			try
			{
				var handle = Addressables.LoadAssetAsync<GameObject>("GameboyPopup");
				await handle.Task;
			}
			catch
			{
			}
		}
	}

	private void Awake()
	{
		Instance = this;
		if (container != null)
		{
			container.SetShow(false, true);
		}
	}

	private void Start()
	{
		var scaler = GetComponentInChildren<UnityEngine.UI.CanvasScaler>();
		if (scaler != null)
		{
			scaler.matchWidthOrHeight = 1f;
		}
	}

	protected override void Update()
	{
		base.Update();
		if (_isShowingLeaderboard)
		{
			if (InputHelper.IsNavigatingWithController() || InputHelper.IsNavigatingWithKeyboard())
			{
				if (InputHelper.GetAllPlayerButtonGoBack() || InputHelper.GetAllPlayerButtonCancel())
				{
					OnHideLeaderboardClicked();
					return;
				}
			}
			if (HighscoreList != null)
			{
				HighscoreList.UpdateInput(Time.deltaTime);
			}
		}
	}

	public async Task<bool> ShowWithResult(WTGNotification notification, Action onPopupDismissed, bool startLevelsOnPlayClicked, Type type, bool showImpossibleLeaderboard = false)
	{
		if (tcs != null && tcs.Task != null && !tcs.Task.IsCompleted)
		{
			tcs.TrySetResult(result: false);
			if (container != null)
			{
				float d = container.GetLongestTransition(container.hidden);
				if (d > 0f)
				{
					await Task.Delay(TimeSpan.FromSeconds(d));
				}
			}
		}
		await Task.Yield();
		tcs = new TaskCompletionSource<bool>();
		this.startLevelsOnPlayClicked = startLevelsOnPlayClicked;
		_onClosedClicked = (Action)Delegate.Combine(onPopupDismissed, (Action)delegate
		{
			tcs?.TrySetResult(result: false);
		});
		_onPlayClicked = (Action)Delegate.Combine(onPopupDismissed, (Action)delegate
		{
			tcs?.TrySetResult(result: true);
		});
		DailyChallengeLevelDataContainer challengePack = notification.ChallengePack as DailyChallengeLevelDataContainer;
		bool isEventActive = challengePack == null;
		if (!isEventActive)
		{
			var special = DailyChallenges.GetSpecialPack();
			isEventActive = special != null && special.NotificationID == challengePack.NotificationID;
		}
		SetState(isEventActive, showImpossibleLeaderboard);
		if (showImpossibleLeaderboard)
		{
			InitLeaderboard(notification.Pack.GetPack());
		}
		Show(notification, forceShow: true, type);
		bool result = await tcs.Task;
		if (container != null)
		{
			float d2 = container.GetLongestTransition(container.hidden);
			if (d2 > 0f)
			{
				await Task.Delay(TimeSpan.FromSeconds(d2));
			}
		}
		this.startLevelsOnPlayClicked = true;
		return result;
	}

	private void InitLeaderboard(ContentPack pack)
	{
		if (HighscoreList != null)
		{
			if (pack != null)
			{
				HighscoreList.board = pack.leaderboard;
			}
			HighscoreList.InitEntries();
			HighscoreList.Reset();
			HighscoreList.StartRefreshLeaderboard(0f);
		}
	}

	public void Show(WTGNotification notification, bool forceShow, Type type)
	{
		_type = type;
		if (!forceShow)
		{
			if (!notification.ValidateCriteria(-1, "", "", DailyChallenges.GetToday()))
			{
				return;
			}
			if (HasBeenSeenBefore(notification.Id))
			{
				return;
			}
		}
		string seen = PlayerPrefs.GetString(gameNotificationsPlayerPrefsId);
		if (!string.IsNullOrEmpty(notification.Id))
		{
			PlayerPrefs.SetString(gameNotificationsPlayerPrefsId, seen + notification.Id + "|");
		}
		ContentPackDef packContainer = notification.Pack;
		IPackWithData pack = notification.ChallengePack;
		if (pack == null && packContainer != null)
		{
			pack = packContainer.GetPack();
		}
		string desc = !string.IsNullOrEmpty(notification.GameboyDescription) ? notification.GameboyDescription : notification.LocalizationId;
		string title = !string.IsNullOrEmpty(notification.GameboyTitle) ? notification.GameboyTitle : notification.LocalizationIdTitle;
		LocalizationData locData = new LocalizationData(NotificationSystemType.Gameboy, desc, title, notification.Image);
		StartCoroutine(Show(packContainer, pack, locData, notification.Type == ENotificationType.Level));
	}

	public static bool HasBeenSeenBefore(string notificationId)
	{
		if (string.IsNullOrEmpty(notificationId))
		{
			return false;
		}
		string seen = PlayerPrefs.GetString(gameNotificationsPlayerPrefsId);
		return !string.IsNullOrEmpty(seen) && seen.Contains(notificationId);
	}

	private IEnumerator Show(ContentPackDef packContainer, IPackWithData pack, LocalizationData locData, bool isLevelNotification)
	{
		if (play != null)
		{
			play.UpdatePack(packContainer, pack);
		}
		if (isLevelNotification)
		{
			if (DioramaImageLevelNotifications != null)
			{
				DioramaImageLevelNotifications.enabled = true;
				DioramaImageLevelNotifications.sprite = locData.image;
			}
			if (DioramaImage != null)
			{
				DioramaImage.enabled = false;
			}
		}
		else
		{
			if (DioramaImageLevelNotifications != null)
			{
				DioramaImageLevelNotifications.enabled = false;
			}
			if (DioramaImage != null)
			{
				DioramaImage.enabled = true;
				DioramaImage.sprite = locData.image;
			}
		}
		if (DescriptionText != null)
		{
			DescriptionText.ChangeText(locData.localizationID);
		}
		if (TitleText != null)
		{
			TitleText.ChangeText(locData.localizationTitleID);
		}
		base.Show();
		yield return null;
	}

	public async void OnLeaderboardClicked()
	{
		Hide(confirmed: false, invokeCallbacks: false);
		if (container != null)
		{
			float d = container.Hide();
			if (d > 0f)
			{
				await Task.Delay(TimeSpan.FromSeconds(d));
			}
		}
		await Task.Yield();
		StartCoroutine(ShowLeaderboard());
	}

	public void OnHideLeaderboardClicked()
	{
		StartCoroutine(HideLeaderboard());
		base.Show();
	}

	public IEnumerator HideLeaderboard()
	{
		_isShowingLeaderboard = false;
		if (CloseButtonAnimator != null)
		{
			CloseButtonAnimator.gameObject.SetActive(value: false);
		}
		yield return StartCoroutine(pTween.To(0.5f, delegate(float t)
		{
			if (ContainerTransform != null)
			{
				float num = TweenFunctions.EaseOut(Mathf.Clamp01(1f - t));
				ContainerTransform.anchoredPosition = new Vector2(0f, Mathf.Lerp(-2000f, 0f, num));
			}
		}));
		if (ContainerTransform != null)
		{
			ContainerTransform.gameObject.SetActive(value: false);
		}
		if (UIBackgroundFader.Instance != null)
		{
			UIBackgroundFader.Instance.Deregister();
		}
		if (ImpossibleChallengeLeaderboard != null)
		{
			ImpossibleChallengeLeaderboard.SetActive(value: false);
		}
	}

	private IEnumerator ShowLeaderboard()
	{
		_isShowingLeaderboard = true;
		if (CloseButtonAnimator != null)
		{
			CloseButtonAnimator.gameObject.SetActive(value: true);
		}
		if (ImpossibleChallengeLeaderboard != null)
		{
			ImpossibleChallengeLeaderboard.SetActive(value: true);
		}
		if (ContainerTransform != null)
		{
			ContainerTransform.gameObject.SetActive(value: true);
		}
		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.DisableInteraction(true);
		}
		if (UIBackgroundFader.Instance != null)
		{
			UIBackgroundFader.Instance.Register();
		}
		yield return StartCoroutine(pTween.To(0.5f, delegate(float t)
		{
			if (ContainerTransform != null)
			{
				float num = TweenFunctions.EaseOut(Mathf.Clamp01(t));
				ContainerTransform.anchoredPosition = new Vector2(0f, Mathf.Lerp(-2000f, 0f, num));
			}
		}));
		if (HighscoreList != null)
		{
			HighscoreList.StartRefreshLeaderboard(0f);
		}
	}

	protected override void OnOpen()
	{
		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.DisableInteraction(true);
		}
	}

	protected override void OnClose(bool confirmed, bool invokeCallbacks)
	{
		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.EnableInteraction();
		}
		if (invokeCallbacks && !confirmed)
		{
			_onClosedClicked?.Invoke();
		}
	}

	protected override void OnPlay()
	{
		if (startLevelsOnPlayClicked && play != null && play.CurrentPack != null)
		{
			StartPack(play.CurrentPack);
		}
		_onPlayClicked?.Invoke();
	}

	public async void StartPack(IPackWithData pack)
	{
		if (pack != null)
		{
			await Hub.FlagPackStarter.StartFlag(pack.PackID);
		}
	}

	public void SetState(bool isAvailable, bool showImpossibleLeaderboard)
	{
		if (play != null)
		{
			play.gameObject.SetActive(isAvailable);
		}
		if (LeaderboardButton != null)
		{
			LeaderboardButton.SetActive(showImpossibleLeaderboard);
		}
		if (InactiveParent != null)
		{
			InactiveParent.SetActive(!isAvailable);
		}
		if (!isAvailable && DaysLeftText != null && Localization.Instance != null)
		{
			DaysLeftText.text = Localization.Instance.GetString("ID_MENU_SPECIAL_EVENT_EXPIRED", false, null);
		}
	}
}
