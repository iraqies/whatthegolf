using System;
using System.Collections;
using System.Threading.Tasks;
using Core;
using UnityEngine;

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

		private NotificationConfiguration notifs => null;
		private bool IsImpossiblePack => !string.IsNullOrEmpty(pack) && pack.Contains("IMPOSSIBLE");
		private ContentPackDef PackDef
		{
			get
			{
				if (packDef == null && RuntimeStoreData.instance != null && RuntimeStoreData.instance.contentPacksDefs != null)
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
				return packDef;
			}
		}

		private void Start() => SetState();
		private void Update() { }

		private void SetState()
		{
			bool done = IsCompleted();
			if (completedFlag != null) completedFlag.SetActive(done);
			if (uncompletedFlag != null) uncompletedFlag.SetActive(!done);
		}

		public virtual void OnCollisionEnter2D(Collision2D collision)
		{
			if (collision != null && collision.collider.GetComponentInParent<OverworldBall2D>() != null)
				StartPack();
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other != null && other.GetComponentInParent<OverworldBall2D>() != null)
				StartPack();
		}

		public void StartPack()
		{
			if (!string.IsNullOrEmpty(pack))
				_ = StartFlag(pack);
			else if (PackDef?.pack != null)
				_ = PackStarterManager.StartPack(PackDef.pack, false);
		}

		private IEnumerator DisableOverworldWithDelay() { yield break; }
		private void DisableInteraction() { }
		private void EnableInteraction() { }
		private WTGNotification GetNotification() => default;
		private bool IsCompleted() => !string.IsNullOrEmpty(pack) && SaveGame.IsContentPackComplete(pack);

		public static async Task<bool> StartFlag(string packId)
		{
			if (string.IsNullOrEmpty(packId)) return false;
			if (RuntimeStoreData.instance != null && RuntimeStoreData.instance.contentPacksDefs != null)
			{
				foreach (var c in RuntimeStoreData.instance.contentPacksDefs)
				{
					if (c != null && c.pack != null && (c.pack.contentPackID == packId || c.pack.name == packId))
						return await PackStarterManager.StartPack(c.pack, false);
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
