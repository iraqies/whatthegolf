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
					var prefab = Resources.Load<GameObject>("Prefabs/PackStarterManager");
					if (prefab != null)
					{
						var go = Instantiate(prefab);
						go.name = "PackStarterManager";
						instance = go.GetComponent<PackStarterManager>();
					}
					if (instance == null)
					{
						var go = new GameObject("PackStarterManager");
						instance = go.AddComponent<PackStarterManager>();
					}
					DontDestroyOnLoad(instance.gameObject);
				}
			}
			return instance;
		}
		private set => instance = value;
	}

	private void Awake()
	{
		instance = this;
		DontDestroyOnLoad(gameObject);
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
					if (def != null && def.starter != null && def.isLevelNotificationStarter == isLevelNotification && def.contentPackIds != null && def.contentPackIds.Contains(cp.contentPackID))
					{
						return await StartPack(pack, def.starter, args);
					}
				}
			}

			return await OverworldSceneLoader.TryLoadOverworld(cp, false);
		}
		return false;
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
