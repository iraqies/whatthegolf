using System.Collections.Generic;
using UnityEngine;

namespace Hub
{
	public class HubArrowSign : MonoBehaviour
	{
		public enum ContentType
		{
			SpecialNew = 0,
			EpisodesNew = 1,
			EpisodesContinue = 2,
			MainCampaignContinue = 3
		}

		[SerializeField]
		private ContentType contentType;

		[SerializeField]
		private ShortcutTunnel shortcutTunnel;

		[SerializeField]
		private List<SaveSpot> saveSpots;

		[SerializeField]
		private float ballSpeed;

		private bool _isInitialized;

		private void OnEnable()
		{
		}

		private void Init()
		{
		}

		private void Update()
		{
		}

		private void SetState()
		{
		}

		private bool ShouldShow()
		{
			return false;
		}

		private bool ShouldShowEpisodesContinue(ECampaignType lastPlayedCampaignType)
		{
			return false;
		}

		private void SubscribeToTunnel()
		{
		}

		private void BallExitedTunnel(ShortcutTunnel tunnel)
		{
		}

		private void GoToSaveSpot(string packConstant)
		{
		}
	}
}
