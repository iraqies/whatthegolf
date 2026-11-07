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

	[SerializeField]
	private List<AnimateRectTransform> animators;

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

	[SerializeField]
	private ScrollRect _scrollRect;

	[SerializeField]
	private AnimationCurveScriptableObj _animCurve;

	private Coroutine _animateToPositionCR;

	private bool _isInputDisabled;

	private bool isInited;

	private bool bla;

	public ScrollRect scrollRect;

	public bool IsOpen => false;

	private AuthorizationStatus NotificationPermissionStatus => AuthorizationStatus.NotDetermined;

	private bool AreNotificationsEnabled => false;

	private void SnapToVertical(RectTransform target, bool immediate)
	{
	}

	private void InitAll()
	{
	}

	private bool NotificationToggleState()
	{
		return false;
	}

	private void SetReceptionistIndex(int arg0)
	{
	}

	private void SetBoothTurtleIndex(int arg0)
	{
	}

	private void SetMenuDialogueIndex(int arg0, MenuDialogueConfig conf)
	{
	}

	private void ReloadHub()
	{
	}

	private void PlaySecondOnboardingLevels()
	{
	}

	private void Update()
	{
	}

	private void UpdateCurrentlySelectedSettingsItem()
	{
	}

	private void SetInputDelay(float delay)
	{
	}

	public void Close(bool showMenu)
	{
	}

	public Task CloseAsync(bool showMenu)
	{
		return null;
	}

	public void Show(bool snapToTop = true)
	{
	}

	private Location GetLocation()
	{
		return (Location)0;
	}

	private void EnableContentByLocation(Location location)
	{
	}

	public void PlaySoundOnUpdateValue()
	{
	}

	private void OnChangeFullscreen(int selected)
	{
	}

	private IEnumerator SetResolution()
	{
		return null;
	}

	private int ClampSaveSlot(int s)
	{
		return 0;
	}

	public void OnChangeSaveSlot(int selected)
	{
	}

	private void ChangeSaveSlot(int selected)
	{
	}

	private void ResetAll()
	{
	}

	private void OnResetSaveSlotPressed()
	{
	}

	private void ResetSaveSlot(int selected)
	{
	}

	private void SaveSlotWindowClosed()
	{
	}

	public void OnGyroShakeChanged()
	{
	}

	private void OnReconfigureController()
	{
	}

	public void OnSwitchGyroChanged()
	{
	}

	private void OnTutorialPressed()
	{
	}

	private void OnHelpPressed()
	{
	}

	private void OnTermsOfUsePressed()
	{
	}

	private void OnSeeMoreButtonPressed()
	{
	}

	private void OnChangeLanguage(int selected)
	{
	}

	private void OnChangeResolution(int selected)
	{
	}

	private void OnChangeQuality(float val)
	{
	}

	public void OnCreditsButtonPressed()
	{
	}

	private void OnChangeMusic(float val)
	{
	}

	private void OnChangeSFX(float val)
	{
	}

	private void OnChangeAnalytics()
	{
	}

	internal void OnUseDebugNotifications()
	{
	}

	private void OnChangeNotifications()
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}

	private void SetPermission()
	{
	}

	public void OpenSettings()
	{
	}

	private int GetNewSelectedLine()
	{
		return 0;
	}

	private void OnSelectedLineChanged(int newActive, bool immediate)
	{
	}

	private void SetInteractable(bool interactable)
	{
	}

	public void OnDropdownSelected(bool lockedIn)
	{
	}

	private static List<string> GetFullscreenOptions()
	{
		return null;
	}

	private void RefreshSaveSlot()
	{
	}

	private SettingsMenuSlider getAsSlider(ref SettingsMenuCommon s)
	{
		return null;
	}

	private SettingsMenuDropdown getAsDropdown(ref SettingsMenuCommon s)
	{
		return null;
	}

	private SettingsMenuToggle getAsToggle(ref SettingsMenuCommon s)
	{
		return null;
	}

	private SettingsMenuButton getAsButton(ref SettingsMenuCommon s)
	{
		return null;
	}

	private SettingsMenuButtonRow getAsButtonRow(ref SettingsMenuCommon s)
	{
		return null;
	}

	public void Register(SettingsMenuCommon settingsMenuCommon)
	{
	}
}
