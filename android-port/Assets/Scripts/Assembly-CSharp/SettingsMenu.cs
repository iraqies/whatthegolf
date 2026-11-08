using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Audio;
using Core;
using Menu;
using TMPro;
using Triband.Core;
using Unity.Notifications.iOS;
using UnityEngine;
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
	public List<SettingsMenuCommon> orderUI;
	public List<SettingsMenuCommon> allOrderUI;
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

	public bool IsOpen => gameObject != null && gameObject.activeSelf;
	private AuthorizationStatus NotificationPermissionStatus => AuthorizationStatus.NotDetermined;
	private bool AreNotificationsEnabled => false;

	public override void Initialize()
	{
		if (gameObject != null)
			gameObject.SetActive(false);
	}

	private void SnapToVertical(RectTransform target, bool immediate) { }

	private void InitAll()
	{
		if (isInited) return;
		isInited = true;
		if (versionText != null)
			versionText.text = "v" + Application.version;
	}

	private bool NotificationToggleState() => false;
	private void SetReceptionistIndex(int arg0) { }
	private void SetBoothTurtleIndex(int arg0) { }
	private void SetMenuDialogueIndex(int arg0, MenuDialogueConfig conf) { }
	private void ReloadHub() { }
	private void PlaySecondOnboardingLevels() { }

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
		if (CloseButtonAnimator != null && PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null)
			CloseButtonAnimator.gameObject.SetActive(PlatformSettings.Instance.GetCurrent().useBackButtonInMenus);
		if (animators != null)
		{
			foreach (var a in animators)
				a?.SetShow(false, true);
		}
		gameObject.SetActive(true);
		if (!isInited)
			InitAll();
		EnableContentByLocation(GetLocation());
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

	private void EnableContentByLocation(Location location) { }
	public void PlaySoundOnUpdateValue() { }
	private void OnChangeFullscreen(int selected) { }
	private IEnumerator SetResolution() { yield break; }
	private int ClampSaveSlot(int s) => Mathf.Clamp(s, 0, 3);
	public void OnChangeSaveSlot(int selected) { }
	private void ChangeSaveSlot(int selected) { }
	private void ResetAll() { }
	private void OnResetSaveSlotPressed() { }
	private void ResetSaveSlot(int selected) { }
	private void SaveSlotWindowClosed() { }
	public void OnGyroShakeChanged() { }
	private void OnReconfigureController() { }
	public void OnSwitchGyroChanged() { }
	private void OnTutorialPressed() { }
	private void OnHelpPressed() { }
	private void OnTermsOfUsePressed() { }
	private void OnSeeMoreButtonPressed() { }
	private void OnChangeLanguage(int selected) { }
	private void OnChangeResolution(int selected) { }
	private void OnChangeQuality(float val) { }
	public void OnCreditsButtonPressed() { }
	private void OnChangeMusic(float val) => AudioManager.SetMusicGain(val);
	private void OnChangeSFX(float val) => AudioManager.SetSoundGain(val);
	private void OnChangeAnalytics() { }
	internal void OnUseDebugNotifications() { }
	private void OnChangeNotifications() { }
	private void OnApplicationFocus(bool focus) { }
	private void SetPermission() { }
	public void OpenSettings() => Show(true);
	private int GetNewSelectedLine() => 0;
	private void OnSelectedLineChanged(int newActive, bool immediate) { }

	private void SetInteractable(bool interactable)
	{
		if (SettingsCanvasGroup != null)
		{
			SettingsCanvasGroup.interactable = interactable;
			SettingsCanvasGroup.blocksRaycasts = interactable;
		}
	}

	public void OnDropdownSelected(bool lockedIn) { }
	private static List<string> GetFullscreenOptions() => new List<string>();
	private void RefreshSaveSlot() { }
	private SettingsMenuSlider getAsSlider(ref SettingsMenuCommon s) => s as SettingsMenuSlider;
	private SettingsMenuDropdown getAsDropdown(ref SettingsMenuCommon s) => s as SettingsMenuDropdown;
	private SettingsMenuToggle getAsToggle(ref SettingsMenuCommon s) => s as SettingsMenuToggle;
	private SettingsMenuButton getAsButton(ref SettingsMenuCommon s) => s as SettingsMenuButton;
	private SettingsMenuButtonRow getAsButtonRow(ref SettingsMenuCommon s) => s as SettingsMenuButtonRow;
	public void Register(SettingsMenuCommon settingsMenuCommon) { }
}
