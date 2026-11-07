using System.Threading.Tasks;
using Audio;
using Core;
using UnityEngine;
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

		[SerializeField]
		private AnimateRectTransform buttonAnimator;

		[SerializeField]
		private AnimateRectTransform teleportAnimatorPortrait;

		[SerializeField]
		private AnimateRectTransform teleportAnimatorLandscape;

		[SerializeField]
		private RectTransform buttonsAndLogoParent;

		[SerializeField]
		private Button quitButton;

		[SerializeField]
		private Button hubButton;

		[SerializeField]
		private Button settingsButton;

		[SerializeField]
		private OverworldTeleportMenu teleportMenuPortrait;

		[SerializeField]
		private OverworldTeleportMenu teleportMenuLandscape;

		[SerializeField]
		private MainMenuGameCenterAccessPointButton accessPointButton;

		[SerializeField]
		private Button defaultCloseButton;

		[SerializeField]
		private Button landscapeMainCampaignCloseButton;

		[SerializeField]
		private CanvasScaler canvasScaler;

		[SerializeField]
		private float buttonsPortraitOffset;

		[SerializeField]
		private float buttonsLandscapeOfset;

		public ClipSettingsCollection OpenSFX;

		private TaskCompletionSource<bool> tcs;

		private Location _location;

		private bool _isInteractable;

		private bool IsPortrait => false;

		private OverworldTeleportMenu currentTeleportMenu => null;

		private OverworldTeleportMenu otherTeleportMenu => null;

		public bool IsOpen()
		{
			return false;
		}

		public Task ShowAndAwait()
		{
			return null;
		}

		public void Init()
		{
		}

		public void Show()
		{
		}

		private Location GetLocation()
		{
			return Location.Hub;
		}

		private void SetButtonPositions(bool isInMainCampaign)
		{
		}

		private void Update()
		{
		}

		public void Close()
		{
		}

		public Task CloseAsync()
		{
			return null;
		}

		public void OnQuitButtonClicked()
		{
		}

		public void OnHubButtonClicked()
		{
		}

		public void SettingsButtonClicked()
		{
		}

		public void CloseButtonClicked()
		{
		}

		private void DisableInteraction()
		{
		}

		private void EnableInteraction()
		{
		}
	}
}
