using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Audio;
using Core;
using I2.Loc;
using Menu;
using TMPro;
using Triband.Core;
using Unity.Notifications.iOS;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsMenu : AddressableSingleton<SettingsMenu>
{
	[Flags]
	public enum Location
	{
		Hub = 1,
		Overworld = 2,
		Level = 4
	}

	[SerializeField] private List<AnimateRectTransform> animators;
	public Animator CloseButtonAnimator;
	public GameObject SettingsBlocker;
	public CanvasGroup SettingsCanvasGroup;
	public List<SaveSlotElement> SaveSlots;
	public ClipSettingsCollection volumeSliderSFX;
	public ClipSettingsCollection hoverButtonSFX;
	public List<AudioClip> HoverOnButtonClips;
	public float Volume;
	public SettingsMenuCommon language;
	public SettingsMenuCommon music;
	public SettingsMenuCommon sfx;
	public SettingsMenuCommon quality;
	public SettingsMenuCommon analytics;
	public SettingsMenuCommon savefile;
	public SettingsMenuCommon fullscreen;
	public SettingsMenuCommon resolution;
	public SettingsMenuCommon notifications;
	public SettingsMenuCommon saveslot;
	public SettingsMenuCommon credits;
	public SettingsMenuCommon tutorial;
	public SettingsMenuCommon help;
	public SettingsMenuCommon termsOfUse;
	public SettingsMenuCommon switchGyroOn;
	public SettingsMenuCommon ReconfigureController;
	public SettingsMenuCommon useGyroShake;
	public SettingsMenuCommon useDebugNotifications;
	public TextMeshProUGUI debugDate;
	public SettingsMenuCommon debugAddDays;
	public SettingsMenuCommon debugSetWeek;
	public SettingsMenuCommon debugSetWeek5;
	public SettingsMenuCommon debugReceptionistIndex;
	public SettingsMenuCommon debugBoothTurtleIndex;
	public SettingsMenuCommon reloadHubButton;
	public MenuDialogueConfig receptionistConfig;
	public MenuDialogueConfig boothTurtleConfig;
	public SettingsMenuCommon incrementSessionCountButton;
	public GameObject debugStart;
	public SettingsMenuCommon seeMore;
	public TextMeshProUGUI versionText;
	public SettingsMenuCommon debugNotifications;
	public SettingsMenuCommon resetAchivements;
	public SettingsMenuCommon addAchivement;
	public SettingsMenuCommon thanksgiving;
	public SettingsMenuCommon secondOnboarding;
	public SettingsMenuCommon leaderBoardDebug;
	public NewsletterPopup helpPopup;
	public NewsletterPopup termsOfUsePopup;
	public CampaignStarter CampaignStarter;
	public List<SettingsMenuCommon> orderUI = new List<SettingsMenuCommon>();
	public List<SettingsMenuCommon> allOrderUI = new List<SettingsMenuCommon>();
	public MenuSettingsCrossPromotionAppleArcade CrossPromotion;
	private int selectedLine;
	private bool selectedLineLockedIn;
	private float selectedSwitchDelay;
	private float escapeDelay;
	private float playSoundDelay;
	public DebugMenu debugMenu;
	[SerializeField] private ScrollRect _scrollRect;
	[SerializeField] private AnimationCurveScriptableObj _animCurve;
	private Coroutine _animateToPositionCR;
	private bool _isInputDisabled;
	private bool isInited;
	private bool bla;
	public ScrollRect scrollRect;
	private List<string> _languages = new List<string>();

	public bool IsOpen => gameObject != null && gameObject.activeSelf;
	private AuthorizationStatus NotificationPermissionStatus => AuthorizationStatus.NotDetermined;
	private bool AreNotificationsEnabled => false;

	public override void Initialize()
	{
		if (scrollRect == null)
			scrollRect = _scrollRect ?? GetComponentInChildren<ScrollRect>(true);
		if (gameObject != null)
			gameObject.SetActive(false);
	}

	private void SnapToVertical(RectTransform target, bool immediate) { }

	private void InitAll()
	{
		if (isInited) return;
		isInited = true;
		if (scrollRect == null)
			scrollRect = _scrollRect ?? GetComponentInChildren<ScrollRect>(true);
		if (allOrderUI == null)
			allOrderUI = new List<SettingsMenuCommon>();
		if (orderUI == null)
			orderUI = new List<SettingsMenuCommon>();

		if (versionText != null)
			versionText.text = "v" + Application.version;
		if (debugStart != null)
			debugStart.SetActive(false);

		_languages = LocalizationManager.GetAllLanguages();
		if (_languages == null || _languages.Count == 0)
			_languages = new List<string> { "English" };

		getAsDropdown(ref language)?.Init(
			() => _languages,
			() => Mathf.Max(0, _languages.IndexOf(LocalizationManager.CurrentLanguage)),
			OnChangeLanguage,
			true,
			this);

		getAsSlider(ref music)?.Init(
			() => SaveGame.GetValue(AudioManager.Music_Volume, 5f),
			OnChangeMusic,
			true,
			this);

		getAsSlider(ref sfx)?.Init(
			() => SaveGame.GetValue(AudioManager.SFX_Volume, 5f),
			OnChangeSFX,
			true,
			this);

		getAsSlider(ref quality)?.Init(
			() => QualitySettings.GetQualityLevel(),
			OnChangeQuality,
			true,
			this);

		getAsToggle(ref analytics)?.Init(
			() => SaveGame.GetValue("ANALYTICS_ENABLED", true),
			OnChangeAnalytics,
			false,
			this);

		getAsToggle(ref fullscreen)?.Init(
			() => Screen.fullScreen,
			() => OnChangeFullscreen(Screen.fullScreen ? 0 : 1),
			false,
			this);

		getAsDropdown(ref resolution)?.Init(
			() => new List<string>(),
			() => 0,
			OnChangeResolution,
			false,
			this);

		getAsToggle(ref notifications)?.Init(
			NotificationToggleState,
			OnChangeNotifications,
			false,
			this);

		getAsToggle(ref switchGyroOn)?.Init(
			() => SaveGame.SwitchUseGyro,
			OnSwitchGyroChanged,
			false,
			this);

		getAsToggle(ref useGyroShake)?.Init(
			() => SaveGame.GetValue("USE_GYRO_SHAKE", true),
			OnGyroShakeChanged,
			true,
			this);

		getAsButtonRow(ref saveslot)?.Init(
			OnChangeSaveSlot,
			() => ClampSaveSlot(SaveGame.GetSaveSlot()),
			() => SaveGame.GetSaveSlotCount(),
			true,
			this,
			RefreshSaveSlot);

		getAsButton(ref savefile)?.Init(OnResetSaveSlotPressed, true, this);
		getAsButton(ref credits)?.Init(OnCreditsButtonPressed, true, this);
		getAsButton(ref tutorial)?.Init(OnTutorialPressed, true, this);
		getAsButton(ref help)?.Init(OnHelpPressed, false, this);
		getAsButton(ref termsOfUse)?.Init(OnTermsOfUsePressed, false, this);
		getAsButton(ref seeMore)?.Init(OnSeeMoreButtonPressed, false, this);
		getAsButton(ref ReconfigureController)?.Init(OnReconfigureController, false, this);

		getAsToggle(ref useDebugNotifications)?.Init(() => false, OnUseDebugNotifications, false, this);
		getAsButton(ref debugAddDays)?.Init(null, false, this);
		getAsButton(ref debugSetWeek)?.Init(null, false, this);
		getAsButton(ref debugSetWeek5)?.Init(null, false, this);
		getAsDropdown(ref debugReceptionistIndex)?.Init(() => new List<string>(), () => 0, SetReceptionistIndex, false, this);
		getAsDropdown(ref debugBoothTurtleIndex)?.Init(() => new List<string>(), () => 0, SetBoothTurtleIndex, false, this);
		getAsButton(ref reloadHubButton)?.Init(ReloadHub, false, this);
		getAsButton(ref incrementSessionCountButton)?.Init(null, false, this);
		getAsButton(ref debugNotifications)?.Init(null, false, this);
		getAsButton(ref resetAchivements)?.Init(null, false, this);
		getAsButton(ref addAchivement)?.Init(null, false, this);
		getAsButton(ref thanksgiving)?.Init(null, false, this);
		getAsButton(ref secondOnboarding)?.Init(PlaySecondOnboardingLevels, false, this);
		getAsButton(ref leaderBoardDebug)?.Init(null, false, this);

		RefreshSaveSlot();
	}

	private bool NotificationToggleState() => false;
	private void SetReceptionistIndex(int arg0) { }
	private void SetBoothTurtleIndex(int arg0) { }
	private void SetMenuDialogueIndex(int arg0, MenuDialogueConfig conf) { }
	private async void ReloadHub()
	{
		Close(false);
		if (HubSceneLoader.Instance != null)
			await HubSceneLoader.Instance.LoadSceneAsync(LoadSceneMode.Single, null, true);
	}

	private async void PlaySecondOnboardingLevels()
	{
		SetInteractable(false);
		Close(false);
		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null)
			OverworldManager2d.Instance.ToggleOverworld(false);
		if (PackStarterManager.Instance != null && RuntimeStoreData.instance != null && RuntimeStoreData.instance.secondOnboarding != null)
		{
			await PackStarterManager.Instance.StartPack(RuntimeStoreData.instance.secondOnboarding, false, false);
			await PackStarterManager.PackFinishedAsync();
		}
		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null)
			OverworldManager2d.Instance.ToggleOverworld(true);
	}

	private void Update()
	{
		if (InputHelper.GetAllPlayerButtonCancel())
			Close(true);
	}

	private void UpdateCurrentlySelectedSettingsItem() { }
	private void SetInputDelay(float delay) { }

	public async void Close(bool showMenu)
	{
		await CloseAsync(showMenu);
	}

	public async Task CloseAsync(bool showMenu)
	{
		SaveGame.Save(false);
		if (SettingsBlocker != null)
			SettingsBlocker.SetActive(false);
		float maxDur = 0f;
		if (animators != null)
		{
			foreach (var a in animators)
			{
				if (a != null)
				{
					float d = a.Hide();
					if (d > maxDur) maxDur = d;
				}
			}
		}
		if (maxDur > 0f)
			await Task.Delay(TimeSpan.FromSeconds(maxDur));
		if (gameObject != null)
			gameObject.SetActive(false);
		if (showMenu)
		{
			if ((LevelManager.Exists && LevelManager.Instance.IsInLevel()) || !OverworldManager2d.HasInstance)
			{
				if (QuickMenu.Instance != null)
					QuickMenu.Instance.ReturnFromSettings();
			}
			else if (Menu.Menu.Exists || Menu.Menu.Instance != null)
			{
				Menu.Menu.Instance.Show();
			}
		}
		else
		{
			if (!ModalWindowSingleton.IsAnyOpen() && (!Menu.Menu.Exists || !Menu.Menu.Instance.IsOpen()))
			{
				if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null)
					OverworldManager2d.Instance.EnableInteraction();
			}
		}
		if (UIBackgroundFader.Exists || UIBackgroundFader.Instance != null)
			UIBackgroundFader.Instance.Deregister();
	}

	public async void Show(bool snapToTop = true)
	{
		if (UIBackgroundFader.Exists || UIBackgroundFader.Instance != null)
			UIBackgroundFader.Instance.Register();
		if (SettingsBlocker != null)
			SettingsBlocker.SetActive(false);
		SetInteractable(true);
		if (CloseButtonAnimator != null)
		{
			bool showCloseBtn = true;
			if (PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null)
				showCloseBtn = PlatformSettings.Instance.GetCurrent().useBackButtonInMenus;
			CloseButtonAnimator.gameObject.SetActive(showCloseBtn);
		}
		if (animators != null)
		{
			foreach (var a in animators)
				a?.SetShow(false, true);
		}
		gameObject.SetActive(true);
		if (!isInited)
			InitAll();
		RefreshSaveSlot();
		if (CrossPromotion != null)
			CrossPromotion.RefreshDate();
		EnableContentByLocation(GetLocation());
		if (snapToTop && scrollRect != null)
			scrollRect.verticalNormalizedPosition = 1f;
		await Task.Yield();
		if (animators != null)
		{
			foreach (var a in animators)
				a?.Show();
		}
	}

	private Location GetLocation()
	{
		if (LevelManager.Exists && LevelManager.Instance.IsInLevel())
			return Location.Level;
		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null && OverworldManager2d.Instance.isHub)
			return Location.Hub;
		return Location.Overworld;
	}

	private void EnableContentByLocation(Location location)
	{
		if (allOrderUI == null) return;
		foreach (var item in allOrderUI)
		{
			if (item != null)
			{
				item.EnableByLocation(location);
				item.Refresh();
			}
		}
	}

	public void PlaySoundOnUpdateValue()
	{
		if (Time.unscaledTime < playSoundDelay) return;
		playSoundDelay = Time.unscaledTime + 0.08f;
		if (volumeSliderSFX != null && AudioManager.Instance != null)
			volumeSliderSFX.Play(AudioManager.Instance.uiEffects, Vector3.zero, 0f);
	}

	private void OnChangeFullscreen(int selected)
	{
		Screen.fullScreen = selected != 0;
	}

	private IEnumerator SetResolution() { yield break; }
	private int ClampSaveSlot(int s) => Mathf.Clamp(s, 0, 2);

	public async void OnChangeSaveSlot(int selected)
	{
		selected = ClampSaveSlot(selected);
		Close(false);
		bool isSameSlot = SaveGame.GetSaveSlot() == selected;
		var mw = ModalWindowSingleton.GetModalWindow(Core.UI.ModalWindowType.SaveSlotInfo);
		if (mw != null)
		{
			var info = mw.GetComponent<SaveSlotInfo>() ?? mw.GetComponentInChildren<SaveSlotInfo>(true);
			if (info != null)
			{
				info.Show(selected);
				if (SaveSlots != null && selected >= 0 && selected < SaveSlots.Count && SaveSlots[selected] != null)
					info.InstantiateFlagVisual(SaveSlots[selected].gameObject);
			}
			bla = true;
			string header = isSameSlot ? "ID_MENU_UI_RESET_SAVE_SLOT" : "ID_INGAME_UI_CONFIRM_SAVE_CHANGE";
			string desc = isSameSlot ? "ID_INGAME_UI_CONFIRM_SAVE_DELETION_DESCRIPTION" : "ID_INGAME_UI_CONFIRM_SAVE_CHANGE_DESCRIPTION";
			bool confirmed = await mw.ShowMenuAsync(false, false, header, desc, "ID_MENU_UI_YES", "ID_MENU_UI_NO", null, 0);
			if (isSameSlot)
			{
				if (confirmed)
					OnResetSaveSlotPressed();
				else
					Show(false);
			}
			else
			{
				if (confirmed)
				{
					ChangeSaveSlot(selected);
					ReloadHub();
				}
				else
				{
					Show(false);
				}
			}
			bla = false;
		}
		else
		{
			ChangeSaveSlot(selected);
		}
	}

	private void ChangeSaveSlot(int selected)
	{
		int clamped = ClampSaveSlot(selected);
		if (SaveGame.GetSaveSlot() == clamped)
		{
			RefreshSaveSlot();
			return;
		}
		SaveGame.SetSaveSlot(clamped);
		SaveGame.Save(false);
		RefreshSaveSlot();
		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.RefreshDoorsAndGoals();
		}
	}

	private void ResetAll()
	{
		if (allOrderUI == null) return;
		foreach (var item in allOrderUI)
			item?.ResetValues();
		RefreshSaveSlot();
	}

	private void OnResetSaveSlotPressed()
	{
		var mw = ModalWindowSingleton.GetModalWindow(Core.UI.ModalWindowType.Default);
		if (mw != null)
		{
			mw.ShowMenu(
				"ID_INGAME_UI_DOUBLE_CONFIRM_SAVE_DELETION",
				"ID_INGAME_UI_DOUBLE_CONFIRM_SAVE_DELETION_DESCRIPTION",
				() => ResetSaveSlot(SaveGame.GetSaveSlot()),
				SaveSlotWindowClosed,
				"ID_MENU_UI_YES",
				"ID_MENU_UI_NO",
				1);
		}
		else
		{
			ResetSaveSlot(SaveGame.GetSaveSlot());
		}
	}

	private async void ResetSaveSlot(int selected)
	{
		SaveGame.SetSaveSlot(ClampSaveSlot(selected));
		SaveGame.ClearSaveSlot();
		if (SaveSlots != null && selected >= 0 && selected < SaveSlots.Count && SaveSlots[selected] != null && SaveSlots[selected].PercentageCompletedText != null)
			SaveSlots[selected].PercentageCompletedText.text = "0%";
		bla = false;
		ResetAll();
		Close(false);
		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null)
			OverworldManager2d.Instance.DisableInteraction(true);
		await Task.Delay(500);
		if (RuntimeStoreData.instance != null && RuntimeStoreData.instance.mainCampaignPackDef != null && RuntimeStoreData.instance.mainCampaignPackDef.pack != null)
		{
			await PackStarterManager.StartPack(RuntimeStoreData.instance.mainCampaignPackDef.pack, false);
		}
	}

	private void SaveSlotWindowClosed()
	{
		bla = false;
		Show(false);
	}

	public void OnGyroShakeChanged()
	{
		bool next = !SaveGame.GetValue("USE_GYRO_SHAKE", true);
		SaveGame.SetValue("USE_GYRO_SHAKE", next, true);
	}

	private void OnReconfigureController() { }

	public void OnSwitchGyroChanged()
	{
		SaveGame.SwitchUseGyro = !SaveGame.SwitchUseGyro;
	}

	private async void OnTutorialPressed()
	{
		SetInteractable(false);
		Close(false);
		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null)
			OverworldManager2d.Instance.ToggleOverworld(false);
		if (PackStarterManager.Instance != null && RuntimeStoreData.instance != null && RuntimeStoreData.instance.mainOnboardingPack != null)
		{
			await PackStarterManager.Instance.StartPack(RuntimeStoreData.instance.mainOnboardingPack, false);
			await PackStarterManager.PackFinishedAsync();
		}
		else
		{
			var onboarding = FindObjectOfType<Onboarding>();
			if (onboarding != null)
				onboarding.StartOnBoarding(null, true);
		}
		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.ToggleOverworld(true);
			OverworldManager2d.Instance.EnableInteraction();
		}
	}

	private async void OnHelpPressed()
	{
		Close(false);
		SetInteractable(false);
		if (helpPopup != null)
			await helpPopup.ShowAndAwait();
		Show(false);
		SetInteractable(true);
	}

	private async void OnTermsOfUsePressed()
	{
		Close(false);
		SetInteractable(false);
		if (termsOfUsePopup != null)
			await termsOfUsePopup.ShowAndAwait();
		Show(false);
		SetInteractable(true);
	}

	private async void OnSeeMoreButtonPressed()
	{
		await CloseAsync(false);
		var mw = ModalWindowSingleton.GetModalWindow(Core.UI.ModalWindowType.Default);
		if (mw != null)
		{
			bool confirmed = await mw.ShowMenuAsync(false, false, "ID_MENU_UI_SEEMORE", "ID_MENU_UI_SEEMORE_DESCRIPTION", "ID_MENU_UI_YES", "ID_MENU_UI_NO", null, 0);
			if (confirmed)
			{
				if (LevelManager.Exists && LevelManager.Instance.IsInLevel())
				{
					if (QuickMenu.Instance != null)
						QuickMenu.Instance.ExitFromSettings();
					if (Level.HasInstance && Level.Instance != null)
						Level.Instance.Abort();
				}
				if (HubSceneLoader.Instance != null)
					await HubSceneLoader.Instance.LoadSceneAsync(LoadSceneMode.Single, null, false);
			}
			else
			{
				Show(false);
			}
		}
	}

	private void OnChangeLanguage(int selected)
	{
		if (_languages != null && selected >= 0 && selected < _languages.Count)
		{
			string lang = _languages[selected];
			if (LocalizationManager.HasLanguage(lang))
			{
				LocalizationManager.CurrentLanguage = lang;
				SaveGame.SetValue("LANGUAGE", lang, true);
			}
		}
	}

	private void OnChangeResolution(int selected) { }

	private void OnChangeQuality(float val)
	{
		int q = Mathf.Clamp(Mathf.RoundToInt(val), 0, Mathf.Max(0, QualitySettings.names.Length - 1));
		QualitySettings.SetQualityLevel(q);
		SaveGame.SetValue("QUALITY_LEVEL", q, true);
	}

	public void OnCreditsButtonPressed()
	{
		if (CreditsMenu.Exists || CreditsMenu.Instance != null)
		{
			SetInteractable(false);
			CreditsMenu.Instance.ShowCredits(() => SetInteractable(true));
		}
	}

	private void OnChangeMusic(float val)
	{
		SaveGame.SetValue(AudioManager.Music_Volume, val, false);
		float norm = val > 1.01f ? Mathf.Clamp01(val / 5f) : Mathf.Clamp01(val);
		AudioManager.SetMusicGain(norm);
	}

	private void OnChangeSFX(float val)
	{
		SaveGame.SetValue(AudioManager.SFX_Volume, val, false);
		float norm = val > 1.01f ? Mathf.Clamp01(val / 5f) : Mathf.Clamp01(val);
		AudioManager.SetSoundGain(norm);
	}

	private void OnChangeAnalytics()
	{
		bool next = !SaveGame.GetValue("ANALYTICS_ENABLED", true);
		SaveGame.SetValue("ANALYTICS_ENABLED", next, true);
	}

	internal void OnUseDebugNotifications() { }
	private void OnChangeNotifications() { }
	private void OnApplicationFocus(bool focus) { }
	private void SetPermission() { }
	public void OpenSettings() => Show(true);
	private int GetNewSelectedLine() => selectedLine;
	private void OnSelectedLineChanged(int newActive, bool immediate) { selectedLine = newActive; }

	private void SetInteractable(bool interactable)
	{
		if (SettingsCanvasGroup != null)
		{
			SettingsCanvasGroup.interactable = interactable;
			SettingsCanvasGroup.blocksRaycasts = interactable;
		}
	}

	public void OnDropdownSelected(bool lockedIn) { selectedLineLockedIn = lockedIn; }
	private static List<string> GetFullscreenOptions() => new List<string> { "Windowed", "Fullscreen" };

	private void RefreshSaveSlot()
	{
		if (SaveSlots == null) return;
		for (int i = 0; i < SaveSlots.Count; i++)
		{
			var el = SaveSlots[i];
			if (el == null) continue;
			string pct = SaveSlotInfo.TotalPercentageComplete(i);
			bool hasProgress = pct != "0%";
			el.SetState(hasProgress);
			if (el.PercentageCompletedText != null)
				el.PercentageCompletedText.text = pct;
			el.Toggle(i < SaveGame.GetSaveSlotCount());
		}
	}

	private SettingsMenuSlider getAsSlider(ref SettingsMenuCommon s) => s as SettingsMenuSlider;
	private SettingsMenuDropdown getAsDropdown(ref SettingsMenuCommon s) => s as SettingsMenuDropdown;
	private SettingsMenuToggle getAsToggle(ref SettingsMenuCommon s) => s as SettingsMenuToggle;
	private SettingsMenuButton getAsButton(ref SettingsMenuCommon s) => s as SettingsMenuButton;
	private SettingsMenuButtonRow getAsButtonRow(ref SettingsMenuCommon s) => s as SettingsMenuButtonRow;

	public void Register(SettingsMenuCommon settingsMenuCommon)
	{
		if (settingsMenuCommon != null && allOrderUI != null && !allOrderUI.Contains(settingsMenuCommon))
			allOrderUI.Add(settingsMenuCommon);
	}
}
