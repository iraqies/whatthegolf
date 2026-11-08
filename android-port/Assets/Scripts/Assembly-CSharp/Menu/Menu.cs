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
		private bool _isOpen;

		private bool IsPortrait => Screen.height > Screen.width;
		private OverworldTeleportMenu currentTeleportMenu => IsPortrait ? teleportMenuPortrait : teleportMenuLandscape;
		private OverworldTeleportMenu otherTeleportMenu => IsPortrait ? teleportMenuLandscape : teleportMenuPortrait;

		public bool IsOpen() => _isOpen;

		public override void Initialize()
		{
			Init();
		}

		private void Awake()
		{
			Init();
		}

		public Task ShowAndAwait()
		{
			Show();
			tcs = new TaskCompletionSource<bool>();
			return tcs.Task;
		}

		public void Init()
		{
			if (quitButton != null) quitButton.gameObject.SetActive(false);
			if (accessPointButton != null) accessPointButton.gameObject.SetActive(false);
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
			Close();
		}

		public void Show()
		{
			_isOpen = true;
			gameObject.SetActive(true);
			if (otherTeleportMenu != null)
				otherTeleportMenu.gameObject.SetActive(false);
			if (currentTeleportMenu != null)
			{
				currentTeleportMenu.Show();
			}
			if (hubButton != null)
				hubButton.gameObject.SetActive(GetLocation() != Location.Hub);
			EnableInteraction();
		}

		private Location GetLocation()
		{
			string s = SceneManager.GetActiveScene().name;
			if (s == "Hub_Overworld") return Location.Hub;
			if (s.Contains("main overworld")) return Location.MainCampaign;
			return Location.Other;
		}

		private void SetButtonPositions(bool isInMainCampaign) { }
		private void Update() { }

		public void Close()
		{
			_isOpen = false;
			DisableInteraction();
			if (otherTeleportMenu != null)
				otherTeleportMenu.gameObject.SetActive(false);
			if (currentTeleportMenu != null)
				currentTeleportMenu.gameObject.SetActive(false);
			if (gameObject != null)
				gameObject.SetActive(false);
			tcs?.TrySetResult(true);
		}

		public Task CloseAsync()
		{
			Close();
			return Task.CompletedTask;
		}

		public void OnQuitButtonClicked() => Application.Quit();

		public void OnHubButtonClicked()
		{
			Close();
			_ = HubSceneLoader.Instance.LoadSceneAsync(LoadSceneMode.Single);
		}

		public void SettingsButtonClicked()
		{
			if (SettingsMenu.Exists || SettingsMenu.Instance != null)
				SettingsMenu.Instance.Show();
		}

		public void CloseButtonClicked() => Close();
		private void DisableInteraction() => _isInteractable = false;
		private void EnableInteraction() => _isInteractable = true;
	}
}
