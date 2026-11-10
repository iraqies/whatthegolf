using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Core;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Hub
{
	public class FlagPackStarter : MonoBehaviour
	{
		[SerializeField] private GameObject crown;
		[SerializeField] private GameObject completedFlag;
		[SerializeField] private GameObject uncompletedFlag;
		[SerializeField] private Collider2D circleCollider;
		[SerializeField] private Collider2D boxCollider;
		[SerializeField] private bool dontDisableOverworld;
		[SerializeField] private WhatTheCarPopup carPopup;
		private DayOfWeek lastUpdate;
		[SerializeField] public string pack;
		[NonSerialized] private ContentPackDef packDef;

		private static NotificationConfiguration _cachedNotifs;
		private NotificationConfiguration notifs
		{
			get
			{
				if (_cachedNotifs == null)
				{
					try
					{
						var handle = Addressables.LoadAssetAsync<NotificationConfiguration>("NotificationConfiguration");
						_cachedNotifs = handle.WaitForCompletion();
					}
					catch
					{
					}
					if (_cachedNotifs == null)
					{
						var found = Resources.FindObjectsOfTypeAll<NotificationConfiguration>();
						if (found != null && found.Length > 0)
						{
							_cachedNotifs = found[0];
						}
					}
				}
				return _cachedNotifs;
			}
		}

		private bool IsImpossiblePack => pack == "CP_IMPOSSIBLE_LIVING_ROOM" || pack == "CP_IMPOSSIBLE_LIVING_ROOM_EASY" || pack == "CP_IMPOSSIBLE_LIVING_ROOM_MEDIUM" || pack == "CP_IMPOSSIBLE_LIVING_ROOM_HARD";

		private ContentPackDef PackDef
		{
			get
			{
				if (packDef == null && RuntimeStoreData.instance != null)
				{
					packDef = RuntimeStoreData.instance.TryGetContent(pack);
					if (packDef == null && RuntimeStoreData.instance.contentPacksDefs != null)
					{
						foreach (var c in RuntimeStoreData.instance.contentPacksDefs)
						{
							if (c != null && c.pack != null && (c.pack.contentPackID == pack || c.pack.name == pack))
							{
								packDef = c;
								break;
							}
						}
					}
				}
				return packDef;
			}
		}

		private void Start()
		{
			lastUpdate = DailyChallenges.GetToday().DayOfWeek;
			SetState();
		}

		private void Update()
		{
			if (pack == "CP_DAILY_CHALLENGE")
			{
				DayOfWeek today = DailyChallenges.GetToday().DayOfWeek;
				if (today != lastUpdate)
				{
					lastUpdate = today;
					SetState();
				}
			}
		}

		private void SetState()
		{
			bool done = IsCompleted();
			if (crown != null) crown.SetActive(false);
			if (completedFlag != null) completedFlag.SetActive(done);
			if (uncompletedFlag != null) uncompletedFlag.SetActive(!done);
		}

		public virtual async void OnCollisionEnter2D(Collision2D collision)
		{
			if (collision == null || collision.transform == null || !collision.transform.CompareTag("Ball"))
			{
				return;
			}
			var ball = (collision.rigidbody != null) ? collision.rigidbody.GetComponent<OverworldBall2D>() : collision.collider.GetComponentInParent<OverworldBall2D>();
			if (ball == null || !ball.CheckUseInteractiveThing())
			{
				return;
			}
			ball.HitFlag();
			DisableInteraction();
			WTGNotification notif = GetNotification();
			if (GameboyPopup.Instance != null && notif.IsValid && !notif.skipGameboyPopup)
			{
				bool confirmed = await GameboyPopup.Instance.ShowWithResult(notif, null, startLevelsOnPlayClicked: false, GameboyPopup.Type.Hub, IsImpossiblePack);
				if (confirmed)
				{
					StartPack();
				}
				else
				{
					EnableInteraction();
				}
			}
			else
			{
				StartPack();
			}
		}

		public async void StartPack()
		{
			ContentPack cp = PackDef.GetPack();
			if (cp == null && !string.IsNullOrEmpty(pack))
			{
				var cat = WTGPortCatalog.Instance;
				if (cat != null && cat.episodes != null)
				{
					foreach (var ep in cat.episodes)
					{
						if (ep.pack != null && (ep.pack.contentPackID == pack || ep.packId == pack))
						{
							cp = ep.pack;
							break;
						}
					}
				}
			}
			bool started = await PackStarterManager.StartPack(cp, isLevelNotification: false, Array.Empty<object>());
			if (started)
			{
				if (!dontDisableOverworld)
				{
					StartCoroutine(DisableOverworldWithDelay());
				}
				await PackStarterManager.PackFinishedAsync();
				SetState();
				if (OverworldManager2d.Instance != null)
				{
					OverworldManager2d.Instance.ToggleOverworld(true);
				}
				if (pack == "CP_SHOW_TO_A_FRIEND" && carPopup != null)
				{
					await carPopup.ShowAndAwait();
				}
			}
			EnableInteraction();
		}

		private IEnumerator DisableOverworldWithDelay()
		{
			yield return new WaitForSecondsRealtime(0.5f);
			if (OverworldManager2d.Instance != null)
			{
				OverworldManager2d.Instance.ToggleOverworld(false);
			}
		}

		private void DisableInteraction()
		{
			if (circleCollider != null) circleCollider.enabled = false;
			if (boxCollider != null) boxCollider.enabled = false;
			if (OverworldManager2d.Instance != null)
			{
				if (OverworldManager2d.Instance.ball != null)
				{
					OverworldManager2d.Instance.ball.StopBall(true);
				}
				OverworldManager2d.Instance.DisableInteraction(false);
			}
		}

		private void EnableInteraction()
		{
			if (OverworldManager2d.Instance != null)
			{
				OverworldManager2d.Instance.EnableInteraction();
			}
			if (circleCollider != null) circleCollider.enabled = true;
			if (boxCollider != null) boxCollider.enabled = true;
		}

		private WTGNotification GetNotification()
		{
			string id = pack;
			if (pack == "CP_DAILY_CHALLENGE")
			{
				var daily = DailyChallenges.GetNormalPack();
				if (daily != null) id = daily.PackName;
			}
			else if (pack == "CP_SPECIAL_EVENT")
			{
				var special = DailyChallenges.GetSpecialPack();
				if (special != null) id = special.PackName;
			}
			var cfg = notifs;
			if (cfg != null && cfg.Notifications != null && !string.IsNullOrEmpty(id))
			{
				string lower = id.ToLower();
				foreach (var n in cfg.Notifications)
				{
					if (!string.IsNullOrEmpty(n.Id) && n.Id.ToLower() == lower)
					{
						return n;
					}
				}
			}
			return default;
		}

		private bool IsCompleted()
		{
			if (pack == "CP_DAILY_CHALLENGE")
			{
				var daily = DailyChallenges.GetNormalPack();
				if (daily == null) return false;
				string sid = daily.GetStringID();
				var played = SaveGame.DailyPacksPlayed;
				return played != null && played.Any((string d) => d != null && d.StartsWith(sid));
			}
			if (pack == "CP_SPECIAL_EVENT")
			{
				var special = DailyChallenges.GetSpecialPack();
				if (special == null) return false;
				string sid = special.GetStringID();
				string year = DailyChallenges.GetToday().Year.ToString();
				var played = SaveGame.DailyPacksPlayed;
				return played != null && played.Any((string d) => d != null && d.StartsWith(sid) && d.EndsWith(year));
			}
			return !string.IsNullOrEmpty(pack) && SaveGame.IsContentPackComplete(pack);
		}

		public static async Task<bool> StartFlag(string packId)
		{
			if (string.IsNullOrEmpty(packId)) return false;
			var flags = FindObjectsOfType<FlagPackStarter>();
			if (flags != null)
			{
				var flag = flags.FirstOrDefault((FlagPackStarter f) => f != null && f.pack == packId);
				if (flag != null)
				{
					flag.StartPack();
					return true;
				}
			}
			if (RuntimeStoreData.instance != null)
			{
				var def = RuntimeStoreData.instance.TryGetContent(packId);
				if (def != null && def.pack != null)
				{
					var owData = SaveGame.GetOverworldData(ECampaignType.Hub);
					if (owData != null)
					{
						owData.SavePosition = packId;
					}
					return await PackStarterManager.StartPack(def.pack, isLevelNotification: false, Array.Empty<object>());
				}
			}
			var cat = WTGPortCatalog.Instance;
			if (cat != null && cat.episodes != null)
			{
				foreach (var ep in cat.episodes)
				{
					if (ep.pack != null && (ep.pack.contentPackID == packId || ep.packId == packId))
						return await PackStarterManager.StartPack(ep.pack, false);
				}
			}
			return false;
		}
	}
}
