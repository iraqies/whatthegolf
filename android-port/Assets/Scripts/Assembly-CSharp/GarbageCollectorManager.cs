using System.Collections;
using UnityEngine;

public class GarbageCollectorManager
{
	private static ulong collectionNanoseconds;

	private static int levelsBetweenRegularGCCollect;

	private static int levelsBetweenRegularUnloadUnused;

	private int levelCounter;

	private int unusedAssetCounter;

	private static GarbageCollectorManager instance;

	private int multiplayerGarbageCount;

	private OverworldUI UI;

	public static GarbageCollectorManager Instance => null;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	public void AttachToOverworld(OverworldUI ui)
	{
	}

	public void DettachToOverworld()
	{
	}

	public IEnumerator CollectBetweenMultiplayerLevelsRoutine()
	{
		return null;
	}

	private void OnAbandon(OverworldGoal og)
	{
	}

	private void OnWin(OverworldGoal og, bool b2)
	{
	}

	private void TryCollectGarbage(bool isAvoidingUnusedAssets = true)
	{
	}

	public IEnumerator TryUnloadUnusedAssetsRoutine()
	{
		return null;
	}

	private void OnExitOverworld()
	{
	}
}
