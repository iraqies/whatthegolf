using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

public class PackStarterManager : MonoBehaviour
{
	[SerializeField] private List<PackStarterDef> packStarters = new List<PackStarterDef>();
	private static PackStarterManager instance;
	public Action<ContentPack> PackStarted;
	public Action<string, bool> PackFinished;
	public string lastPackId;

	public static PackStarterManager Instance
	{
		get
		{
			if (instance == null)
			{
				instance = FindObjectOfType<PackStarterManager>();
				if (instance == null)
				{
					var go = new GameObject("PackStarterManager");
					instance = go.AddComponent<PackStarterManager>();
					DontDestroyOnLoad(go);
				}
			}
			return instance;
		}
		private set => instance = value;
	}

	private void Awake()
	{
		instance = this;
	}

	public static Task<bool> StartPack(ContentPack pack, bool isLevelNotification, params object[] args)
	{
		return Instance.StartPack((IPackWithData)pack, isLevelNotification, args);
	}

	public async Task<bool> StartPack(IPackWithData pack, bool isLevelNotification, params object[] args)
	{
		if (pack == null) return false;
		lastPackId = pack.PackID;
		if (pack is ContentPack cp)
		{
			PackStarted?.Invoke(cp);
			SaveGame.SetOverworld(cp.campaignType);
			SaveGame.IncrementContentPackPlayCount(cp.contentPackID);

			if (packStarters != null)
			{
				foreach (var def in packStarters)
				{
					if (def != null && def.starter != null && def.contentPackIds != null && def.contentPackIds.Contains(cp.contentPackID))
					{
						return await StartPack(pack, def.starter, args);
					}
				}
			}

			string sceneName = ResolveOverworldScene(cp);
			if (!string.IsNullOrEmpty(sceneName))
			{
				try
				{
					var h = Addressables.LoadSceneAsync(sceneName, LoadSceneMode.Single, true);
					if (h.IsValid())
					{
						while (!h.IsDone) await Task.Yield();
						return true;
					}
				}
				catch { }
				if (Application.CanStreamedLevelBeLoaded(sceneName))
				{
					var op = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
					while (op != null && !op.isDone) await Task.Yield();
					return true;
				}
			}
		}
		return false;
	}

	private static string ResolveOverworldScene(ContentPack cp)
	{
		if (cp == null) return "main overworld new";
		string id = (cp.contentPackID ?? cp.name ?? "").ToLowerInvariant();
		if (id.Contains("sport") || id.Contains("olympic")) return "Sports_Overworld";
		if (id.Contains("snow") || id.Contains("winter")) return "SnowySnow Overworld";
		if (id.Contains("hole") || id.Contains("living")) return "LivingThings_Overworld";
		if (id.Contains("impossible")) return "Impossible_Overworld";
		if (id.Contains("hotdog")) return "Hotdog_Overworld";
		if (id.Contains("hub")) return "Hub_Overworld";
		var cat = WTGPortCatalog.Instance;
		if (cat != null && cat.episodes != null)
		{
			foreach (var ep in cat.episodes)
			{
				if (ep.pack == cp && !string.IsNullOrEmpty(ep.overworldScene))
					return ep.overworldScene;
			}
		}
		return "main overworld new";
	}

	private Task<bool> StartPack(IPackWithData pack, BasePackStarter starter, params object[] args)
	{
		if (starter != null && pack is ContentPack cp)
		{
			bool ok = starter.StartPack(cp, args);
			return Task.FromResult(ok);
		}
		return Task.FromResult(false);
	}

	private void PackCompleted(bool didComplete)
	{
		PackFinished?.Invoke(lastPackId, didComplete);
	}

	public static Task PackFinishedAsync() => Task.CompletedTask;
}
