using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
		private float ballSpeed = 30f;

		private bool _isInitialized;

		private void OnEnable()
		{
			if (!_isInitialized)
			{
				_isInitialized = true;
				SubscribeToTunnel();
			}
			SetState();
		}

		private void Init()
		{
			_isInitialized = true;
			SubscribeToTunnel();
		}

		private void Update()
		{
			SetState();
		}

		private void SetState()
		{
			bool show = ShouldShow();
			if (gameObject.activeSelf != show)
			{
				gameObject.SetActive(show);
			}
		}

		private bool ShouldShow()
		{
			ECampaignType last = SaveGame.LastPlayedCampaignType;
			switch (contentType)
			{
			case ContentType.SpecialNew:
			{
				var special = DailyChallenges.GetSpecialPack();
				return special != null && !DailyChallenges.HasSpecialBeenPlayedBefore();
			}
			case ContentType.EpisodesNew:
			{
				int pOlympics = SaveGame.GetCompletedPercentage(ECampaignType.Olympics, null, true);
				int pSnow = SaveGame.GetCompletedPercentage(ECampaignType.Snow, null, true);
				int pAlive = SaveGame.GetCompletedPercentage(ECampaignType.Alive, null, true);
				int pAmongus = SaveGame.GetCompletedPercentage(ECampaignType.Amongus, null, true);
				if (pOlympics == 0 || pSnow == 0 || pAlive == 0 || pAmongus == 0)
				{
					return !ShouldShowEpisodesContinue(last);
				}
				return false;
			}
			case ContentType.EpisodesContinue:
				return ShouldShowEpisodesContinue(last);
			case ContentType.MainCampaignContinue:
				if (last == ECampaignType.Main)
				{
					int pct = SaveGame.GetCompletedPercentage(ECampaignType.Main, null, true);
					return pct > 0 && pct < 100;
				}
				return false;
			default:
				return false;
			}
		}

		private bool ShouldShowEpisodesContinue(ECampaignType lastPlayedCampaignType)
		{
			if ((uint)(lastPlayedCampaignType - 2) <= 2u || (uint)(lastPlayedCampaignType - 6) <= 1u)
			{
				int pct = SaveGame.GetCompletedPercentage(lastPlayedCampaignType, null, true);
				return pct > 0 && pct < 100;
			}
			return false;
		}

		private void SubscribeToTunnel()
		{
			if (shortcutTunnel != null)
			{
				shortcutTunnel.OnBallExitTunnel += BallExitedTunnel;
			}
		}

		private void BallExitedTunnel(ShortcutTunnel tunnel)
		{
			if (OverworldManager2d.Instance == null || OverworldManager2d.Instance.ball == null)
			{
				return;
			}
			if (OverworldManager2d.Instance.ball.Velocity.x <= 0f)
			{
				return;
			}
			if (contentType == ContentType.EpisodesNew)
			{
				string target = null;
				if (SaveGame.GetCompletedPercentage(ECampaignType.Olympics, null, true) == 0)
					target = "CP_SPORTY_SPORTS";
				else if (SaveGame.GetCompletedPercentage(ECampaignType.Snow, null, true) == 0)
					target = "CP_SNOWY_SNOW";
				else if (SaveGame.GetCompletedPercentage(ECampaignType.Alive, null, true) == 0)
					target = "CP_ALIVE";
				else if (SaveGame.GetCompletedPercentage(ECampaignType.Amongus, null, true) == 0)
					target = "CP_AMONGUS";
				if (!string.IsNullOrEmpty(target))
				{
					GoToSaveSpot(target);
				}
			}
			else if (contentType == ContentType.EpisodesContinue)
			{
				string target = PackConstants.CampaignTypeToPackConstant(SaveGame.LastPlayedCampaignType);
				if (!string.IsNullOrEmpty(target))
				{
					GoToSaveSpot(target);
				}
			}
		}

		private async void GoToSaveSpot(string packConstant)
		{
			if (saveSpots == null) return;
			SaveSpot saveSpot = saveSpots.FirstOrDefault((SaveSpot s) => s != null && s.gameObject.activeInHierarchy && s.ID == packConstant);
			if (saveSpot == null)
			{
				Debug.LogWarning("Could not find save spot for pack " + packConstant + "!");
				return;
			}
			if (OverworldManager2d.Instance == null || OverworldManager2d.Instance.ball == null) return;
			OverworldBall2D ball = OverworldManager2d.Instance.ball;
			while (ball != null && saveSpot != null && ball.transform.position.x < saveSpot.transform.position.x)
			{
				Vector2 right = Vector2.right;
				ball.Velocity = new Vector3(right.x * ballSpeed, right.y * ballSpeed, 0f);
				await Task.Yield();
			}
			if (ball != null)
			{
				ball.StopBall(true);
			}
			if (OverworldManager2d.Instance != null)
			{
				OverworldManager2d.Instance.EnableInteraction();
			}
		}
	}
}
