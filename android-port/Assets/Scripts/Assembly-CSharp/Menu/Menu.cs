using System;
using System.Threading.Tasks;
using Audio;
using Core;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Menu
{
	public class Menu : AddressableSingleton<Menu>
	{
		public enum Location
		{
			Hub = 0,
			MainCampaign = 1,
			Other = 2
		}

		[SerializeField] private AnimateRectTransform buttonAnimator;
		[SerializeField] private AnimateRectTransform teleportAnimatorPortrait;
		[SerializeField] private AnimateRectTransform teleportAnimatorLandscape;
		[SerializeField] private RectTransform buttonsAndLogoParent;
		[SerializeField] private Button quitButton;
		[SerializeField] private Button hubButton;
		[SerializeField] private Button settingsButton;
		[SerializeField] private OverworldTeleportMenu teleportMenuPortrait;
		[SerializeField] private OverworldTeleportMenu teleportMenuLandscape;
		[SerializeField] private MainMenuGameCenterAccessPointButton accessPointButton;
		[SerializeField] private Button defaultCloseButton;
		[SerializeField] private Button landscapeMainCampaignCloseButton;
		[SerializeField] private CanvasScaler canvasScaler;
		[SerializeField] private float buttonsPortraitOffset;
		[SerializeField] private float buttonsLandscapeOfset;
		public ClipSettingsCollection OpenSFX;

		private TaskCompletionSource<bool> tcs;
		private Location _location;
		private bool _isInteractable;

		private bool IsPortrait => Screen.width < Screen.height;
		private OverworldTeleportMenu currentTeleportMenu => IsPortrait ? teleportMenuPortrait : teleportMenuLandscape;
		private OverworldTeleportMenu otherTeleportMenu => IsPortrait ? teleportMenuLandscape : teleportMenuPortrait;

		public bool IsOpen() => gameObject != null && gameObject.activeSelf;

		public override void Initialize()
		{
			Init();
		}

		private void Awake()
		{
			Init();
		}

		public async Task ShowAndAwait()
		{
			tcs = new TaskCompletionSource<bool>();
			Show();
			await tcs.Task;
		}

		public void Init()
		{
			if (buttonAnimator != null)
				buttonAnimator.Hide();
			if (teleportAnimatorPortrait != null)
				teleportAnimatorPortrait.Hide();
			if (teleportAnimatorLandscape != null)
				teleportAnimatorLandscape.Hide();
			if (defaultCloseButton != null)
			{
				defaultCloseButton.onClick.RemoveAllListeners();
				defaultCloseButton.onClick.AddListener(CloseButtonClicked);
			}
			if (landscapeMainCampaignCloseButton != null)
			{
				landscapeMainCampaignCloseButton.onClick.RemoveAllListeners();
				landscapeMainCampaignCloseButton.onClick.AddListener(CloseButtonClicked);
			}
			if (hubButton != null)
			{
				hubButton.onClick.RemoveAllListeners();
				hubButton.onClick.AddListener(OnHubButtonClicked);
			}
			if (settingsButton != null)
			{
				settingsButton.onClick.RemoveAllListeners();
				settingsButton.onClick.AddListener(SettingsButtonClicked);
			}
			if (quitButton != null)
			{
				quitButton.onClick.RemoveAllListeners();
				quitButton.onClick.AddListener(OnQuitButtonClicked);
			}
			if (gameObject != null)
				gameObject.SetActive(false);
		}

		public async void Show()
		{
			if (IsOpen()) return;
			if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null)
				OverworldManager2d.Instance.DisableInteraction(true);
			DisableInteraction();
			_location = GetLocation();
			gameObject.SetActive(true);
			if (OpenSFX != null && AudioManager.Instance != null)
				OpenSFX.Play(AudioManager.Instance.uiEffects, Vector3.zero, 0f);
			if (accessPointButton != null)
			{
				accessPointButton.gameObject.SetActive(true);
				accessPointButton.Show();
			}
			if (quitButton != null)
			{
				bool showQuit = false;
				if (_location == Location.Hub && PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null && PlatformSettings.Instance.GetCurrent().menu != null)
					showQuit = PlatformSettings.Instance.GetCurrent().menu.showItemExit;
				quitButton.gameObject.SetActive(showQuit);
			}
			if (hubButton != null)
				hubButton.gameObject.SetActive(_location != Location.Hub);
			if (settingsButton != null)
				settingsButton.gameObject.SetActive(true);

			bool portrait = IsPortrait;
			if (defaultCloseButton != null)
				defaultCloseButton.gameObject.SetActive(portrait || _location != Location.MainCampaign);
			if (landscapeMainCampaignCloseButton != null)
				landscapeMainCampaignCloseButton.gameObject.SetActive(!portrait && _location == Location.MainCampaign);

			if (_location == Location.MainCampaign)
			{
				if (currentTeleportMenu != null)
				{
					currentTeleportMenu.gameObject.SetActive(true);
					currentTeleportMenu.Show();
				}
				if (otherTeleportMenu != null)
					otherTeleportMenu.gameObject.SetActive(false);
			}
			else
			{
				if (teleportMenuLandscape != null)
					teleportMenuLandscape.gameObject.SetActive(false);
				if (teleportMenuPortrait != null)
					teleportMenuPortrait.gameObject.SetActive(false);
			}

			SetButtonPositions(_location == Location.MainCampaign);
			if (UIBackgroundFader.Exists || UIBackgroundFader.Instance != null)
				UIBackgroundFader.Instance.Register();

			float dur = buttonAnimator != null ? buttonAnimator.Show() : 0f;
			if (_location == Location.MainCampaign)
			{
				if (portrait)
				{
					if (teleportAnimatorPortrait != null)
						teleportAnimatorPortrait.Show();
				}
				else
				{
					if (teleportAnimatorLandscape != null)
						teleportAnimatorLandscape.Show();
				}
			}
			if (dur > 0f)
				await Task.Delay(TimeSpan.FromSeconds(dur));
			EnableInteraction();
		}

		private Location GetLocation()
		{
			if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null)
			{
				var t = OverworldManager2d.Instance.overworldType;
				if (t == ECampaignType.Hub) return Location.Hub;
				if (t == ECampaignType.Main) return Location.MainCampaign;
				return Location.Other;
			}
			string s = SceneManager.GetActiveScene().name;
			if (s == "Hub_Overworld") return Location.Hub;
			if (s.Contains("main overworld")) return Location.MainCampaign;
			return Location.Other;
		}

		private void SetButtonPositions(bool isInMainCampaign)
		{
			bool portrait = Screen.width < Screen.height;
			if (canvasScaler != null)
			{
				canvasScaler.referenceResolution = new Vector2(portrait ? 1080f : 2400f, 1920f);
			}
			if (buttonsAndLogoParent != null)
			{
				if (portrait)
				{
					float y = isInMainCampaign && buttonsPortraitOffset > 0.01f ? (Screen.height / buttonsPortraitOffset) : 0f;
					Vector3 lp = buttonsAndLogoParent.localPosition;
					buttonsAndLogoParent.localPosition = new Vector3(lp.x, y, 0f);
				}
				else
				{
					float x = isInMainCampaign ? -buttonsLandscapeOfset : 0f;
					Vector3 lp = buttonsAndLogoParent.localPosition;
					buttonsAndLogoParent.localPosition = new Vector3(x, lp.y, 0f);
				}
			}
		}

		private void Update()
		{
			if (InputHelper.GetAllPlayerButtonCancel())
			{
				CloseButtonClicked();
			}
		}

		public async void Close()
		{
			await CloseAsync();
		}

		public async Task CloseAsync()
		{
			DisableInteraction();
			float dur = buttonAnimator != null ? buttonAnimator.Hide() : 0f;
			if (_location == Location.MainCampaign)
			{
				if (IsPortrait)
				{
					if (teleportAnimatorPortrait != null)
						teleportAnimatorPortrait.Hide();
				}
				else
				{
					if (teleportAnimatorLandscape != null)
						teleportAnimatorLandscape.Hide();
				}
			}
			if (dur > 0f)
				await Task.Delay(TimeSpan.FromSeconds(dur));
			tcs?.TrySetResult(true);
			if (gameObject != null)
				gameObject.SetActive(false);
			if (UIBackgroundFader.Exists || UIBackgroundFader.Instance != null)
				UIBackgroundFader.Instance.Deregister();
			if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null)
				OverworldManager2d.Instance.EnableInteraction();
		}

		public void OnQuitButtonClicked() => Application.Quit();

		public async void OnHubButtonClicked()
		{
			await CloseAsync();
			if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null && OverworldManager2d.Instance.ui != null)
			{
				OverworldManager2d.Instance.StartCoroutine(OverworldManager2d.Instance.ui.ExitToHub());
			}
			else
			{
				_ = HubSceneLoader.Instance.LoadSceneAsync(LoadSceneMode.Single);
			}
		}

		public void SettingsButtonClicked()
		{
			if (SettingsMenu.Instance != null)
				SettingsMenu.Instance.Show(true);
		}

		public async void CloseButtonClicked()
		{
			await CloseAsync();
		}

		public void DisableInteraction() => _isInteractable = false;
		public void EnableInteraction() => _isInteractable = true;
	}
}
