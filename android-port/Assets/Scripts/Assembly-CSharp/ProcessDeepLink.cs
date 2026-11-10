using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Hub;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProcessDeepLink : WTGSingleton<ProcessDeepLink>
{
	private WTGNotification? _notification;

	public Action OnDeepLinkActivatedEvent;

	public bool HadEventThisSession;

	public List<WTGNotification> AllNotifications
	{
		get
		{
			if (WTGSingleton<WTGNotificationsManager>.Instance != null && WTGSingleton<WTGNotificationsManager>.Instance.AllNotifications != null)
			{
				return WTGSingleton<WTGNotificationsManager>.Instance.AllNotifications;
			}
			return new List<WTGNotification>();
		}
	}

	private bool IsLoaded => Loading.IsReady;

	public bool HasEvent => IsLoaded && _notification.HasValue;

	public bool HasChallengeEvent => HasEvent && _notification.Value.Type == ENotificationType.Pack;

	protected override void OnInit()
	{
		Application.deepLinkActivated += OnDeepLinkActivated;
	}

	private void OnEnable()
	{
		string url = Application.absoluteURL;
		if (!string.IsNullOrEmpty(url))
		{
			OnDeepLinkActivated(url);
		}
	}

	private void TestDeepLink_PlayTogetherChallenge()
	{
		OnDeepLinkActivated("whatthegolf://play?id=challenge_play_together");
	}

	private void TestDeepLink_SpecialEvent()
	{
		OnDeepLinkActivated("whatthegolf://play?id=special_event_winter");
	}

	public void OnDeepLinkActivated(string url)
	{
		if (HasEvent)
			return;

		Debug.Log("DeepLink activated: " + url);
		_notification = GetNotificationFromUrl(url);
		if (_notification.HasValue)
		{
			HadEventThisSession = true;
			OnDeepLinkActivatedEvent?.Invoke();
			GoToEvent();
		}
		else
		{
			Debug.LogError("Could not parse deep link url: " + url);
		}
	}

	private async void GoToEvent()
	{
		if (!_notification.HasValue)
			return;

		await GoToHubFromAnywhereAsync();
		if (!_notification.HasValue)
			return;

		WTGNotification val = _notification.Value;
		if (val.skipGameboyPopup)
		{
			if (OverworldManager2d.Instance != null)
				OverworldManager2d.Instance.DisableInteraction(false);

			var def = val.Pack;
			if (def != null)
			{
				var pack = def.GetPack();
				if (pack != null)
				{
					await FlagPackStarter.StartFlag(pack.PackID);
				}
			}
			DismissNotification();
		}
		else
		{
			ShowCard();
		}
	}

	private async void ShowCard()
	{
		if (!_notification.HasValue)
			return;

		if (GameboyPopup.Instance != null)
		{
			await GameboyPopup.Instance.ShowWithResult(_notification.Value, DismissNotification, true, GameboyPopup.Type.DeepLink, false);
		}
	}

	private WTGNotification? GetNotificationFromUrl(string url)
	{
		if (string.IsNullOrEmpty(url))
			return null;

		WTGNotification? result = null;
		string[] parts = url.Split('?');
		if (parts != null && parts.Length > 1)
		{
			string prefix = parts[0];
			if (!string.IsNullOrEmpty(prefix) && prefix.StartsWith("whatthegolf://", StringComparison.OrdinalIgnoreCase))
			{
				string idLower = parts[1] != null ? parts[1].ToLower() : "";
				var all = AllNotifications;
				if (all != null)
				{
					var found = all.FirstOrDefault(n => n.Id != null && n.Id.ToLower() == idLower);
					if (found.IsValid)
						result = found;
				}
			}

			if (!string.IsNullOrEmpty(prefix) && prefix.Contains("http"))
			{
				int qIdx = url.IndexOf("?", StringComparison.OrdinalIgnoreCase);
				if (qIdx >= 0 && qIdx + 1 < url.Length)
				{
					string query = url.Substring(qIdx + 1);
					string[] qParts = query.Split(new char[] { '&', '#', '/' });
					if (qParts != null)
					{
						for (int i = 0; i < qParts.Length; i++)
						{
							string kvStr = qParts[i];
							if (string.IsNullOrEmpty(kvStr))
								continue;
							string[] kv = kvStr.Split('=');
							if (kv != null && kv.Length == 2 && string.Equals(kv[0], "id", StringComparison.OrdinalIgnoreCase))
							{
								string targetId = kv[1];
								var all = AllNotifications;
								if (all != null)
								{
									var found = all.FirstOrDefault(n => n.Id == targetId);
									if (found.IsValid)
										result = found;
								}
							}
						}
					}
				}
			}
		}

		if (result.HasValue && result.Value.IsValid)
			return result;
		return null;
	}

	private void DismissNotification()
	{
		_notification = null;
	}

	public async Task GoToHubFromAnywhereAsync(bool force = false)
	{
		await this.WaitAsync(GoToHubFromAnywhere());
	}

	public IEnumerator AbandonLevelIfAny()
	{
		if (LevelManager.Instance != null && LevelManager.Instance.IsInLevel())
		{
			yield return null;
			while (LevelManager.Instance != null && LevelManager.Instance.IsTransitionActive())
				yield return null;
			if (LevelManager.Instance != null && LevelManager.Instance.IsInLevel())
			{
				if (LevelManager.Instance.getIsReallyInLevel && Level.Instance != null)
				{
					Level.Instance.Abort();
					yield return null;
				}
				else
				{
					yield return null;
				}
			}
		}
	}

	private IEnumerator GoToHubFromAnywhere()
	{
		if (!SaveGame.loaded)
			yield return new WaitUntil(() => SaveGame.loaded);

		if (LevelManager.Instance != null && LevelManager.Instance.IsTransitionActive())
			yield return new WaitUntil(() => LevelManager.Instance == null || !LevelManager.Instance.IsTransitionActive());

		if (Loading.IsCreated && !Loading.IsReady)
			yield return new WaitUntil(() => Loading.IsReady);

		if (Menu.Menu.Exists && Menu.Menu.Instance != null && Menu.Menu.Instance.IsOpen())
			Menu.Menu.Instance.Close();

		if (ModalWindowSingleton.Exists && ModalWindowSingleton.IsAnyOpen())
			ModalWindowSingleton.ForceClose();

		if (SettingsMenu.Exists && SettingsMenu.Instance != null && SettingsMenu.Instance.IsOpen)
		{
			yield return SettingsMenu.Instance.CloseAsync(false);
		}

		yield return StartCoroutine(AbandonLevelIfAny());

		yield return new WaitUntil(() => OverworldManager2d.Instance != null);
		yield return new WaitUntil(() => OverworldManager2d.Instance != null && OverworldManager2d.Instance.IsOverworldPlaying);

		if (HubSceneLoader.Instance != null && HubSceneLoader.Instance.IsHubBusyLoading)
			yield return new WaitUntil(() => HubSceneLoader.Instance == null || !HubSceneLoader.Instance.IsHubBusyLoading);

		if (OverworldManager2d.Instance != null && !OverworldManager2d.Instance.isHub && HubSceneLoader.Instance != null)
		{
			yield return HubSceneLoader.Instance.LoadSceneAsync(LoadSceneMode.Single, null, false).YieldTask();
		}
	}
}
