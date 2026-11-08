using System;
using System.Collections;
using UnityEngine;

public class GarbageCollectorManager
{
	private static ulong collectionNanoseconds = 30000000UL;
	private static int levelsBetweenRegularGCCollect = 5;
	private static int levelsBetweenRegularUnloadUnused = 9;
	private int levelCounter;
	private int unusedAssetCounter;
	private static GarbageCollectorManager instance;
	private int multiplayerGarbageCount;
	private OverworldUI UI;

	public static GarbageCollectorManager Instance => instance ?? (instance = new GarbageCollectorManager());

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		collectionNanoseconds = 30000000UL;
		levelsBetweenRegularGCCollect = 5;
		levelsBetweenRegularUnloadUnused = 9;
	}

	public void AttachToOverworld(OverworldUI ui)
	{
		UI = ui;
		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.OnlevelAbandoned -= OnAbandon;
			OverworldManager2d.Instance.OnlevelAbandoned += OnAbandon;
			OverworldManager2d.Instance.OnlevelCompleted -= OnWin;
			OverworldManager2d.Instance.OnlevelCompleted += OnWin;
		}
	}

	public void DettachToOverworld()
	{
		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.OnlevelAbandoned -= OnAbandon;
			OverworldManager2d.Instance.OnlevelCompleted -= OnWin;
		}
	}

	public IEnumerator CollectBetweenMultiplayerLevelsRoutine()
	{
		TryCollectGarbage(true);
		yield break;
	}

	private void OnAbandon(OverworldGoal og) => TryCollectGarbage(false);
	private void OnWin(OverworldGoal og, bool b2) => TryCollectGarbage(false);

	private void TryCollectGarbage(bool isAvoidingUnusedAssets = true)
	{
		levelCounter++;
		unusedAssetCounter++;
		if (levelCounter >= levelsBetweenRegularGCCollect)
		{
			levelCounter = 0;
			GC.Collect(0, GCCollectionMode.Optimized, false);
		}
	}

	public IEnumerator TryUnloadUnusedAssetsRoutine()
	{
		if (unusedAssetCounter >= levelsBetweenRegularUnloadUnused)
		{
			unusedAssetCounter = 0;
			yield return Resources.UnloadUnusedAssets();
		}
	}

	private void OnExitOverworld()
	{
		GC.Collect(0, GCCollectionMode.Optimized, false);
	}
}
