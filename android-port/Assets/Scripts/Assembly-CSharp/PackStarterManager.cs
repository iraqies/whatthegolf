using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using UnityEngine;

public class PackStarterManager : AddressableSingleton<PackStarterManager>
{
	[SerializeField] private List<PackStarterDef> packStarters = new List<PackStarterDef>();
	public Action<ContentPack> PackStarted;
	public Action<string, bool> PackFinished;
	public string lastPackId;

	private void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}

	public static Task<bool> StartPack(ContentPack pack, bool isLevelNotification, params object[] args)
	{
		return Instance.StartPack((IPackWithData)pack, isLevelNotification, args);
	}

	public async Task<bool> StartPack(IPackWithData pack, bool isLevelNotification, params object[] args)
	{
		if (pack == null) return false;
		BasePackStarter starter = null;
		if (packStarters != null)
		{
			var foundDef = packStarters.FirstOrDefault(def =>
				def != null &&
				def.isLevelNotificationStarter == isLevelNotification &&
				def.contentPackIds != null &&
				def.contentPackIds.Contains(pack.PackID));
			if (foundDef != null)
				starter = foundDef.starter;
		}
		return await StartPack(pack, starter, args);
	}

	private async Task<bool> StartPack(IPackWithData pack, BasePackStarter starter, params object[] args)
	{
		if (pack == null) return false;
		ContentPack cp = pack as ContentPack;
		if (cp == null)
		{
			if (pack.PackName == "SpecialEvent")
				cp = RuntimeStoreData.instance != null ? RuntimeStoreData.instance.specialEventsPack.GetPack() : null;
			else
				cp = RuntimeStoreData.instance != null ? RuntimeStoreData.instance.dailyChallengePack.GetPack() : null;
		}

		if (starter != null && cp != null)
		{
			starter.OnPackDone = PackCompleted;
			lastPackId = pack.PackID;
			bool ok = starter.StartPack(cp, args);
			if (ok)
			{
				SaveGame.IncrementContentPackPlayCount(pack.PackID);
				PackStarted?.Invoke(cp);
				return true;
			}
			return false;
		}

		if (cp != null)
		{
			lastPackId = cp.contentPackID;
			SaveGame.SetOverworld(cp.campaignType);
			SaveGame.IncrementContentPackPlayCount(cp.contentPackID);
			PackStarted?.Invoke(cp);
			bool loaded = await OverworldSceneLoader.TryLoadOverworld(cp, false);
			PackCompleted(loaded);
			return loaded;
		}

		return false;
	}

	private void PackCompleted(bool didComplete)
	{
		PackFinished?.Invoke(lastPackId, didComplete);
	}

	public static async Task PackFinishedAsync()
	{
		var tcs = new TaskCompletionSource<bool>();
		Action<string, bool> handler = null;
		handler = (id, done) =>
		{
			if (Instance != null)
				Instance.PackFinished -= handler;
			tcs.TrySetResult(done);
		};
		if (Instance != null)
		{
			Instance.PackFinished += handler;
			await tcs.Task;
			Instance.PackFinished -= handler;
		}
	}
}
