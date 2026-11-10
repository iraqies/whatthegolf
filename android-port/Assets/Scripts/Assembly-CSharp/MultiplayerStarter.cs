using System;
using System.Collections;
using Core;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

public class MultiplayerStarter : BasePackStarter
{
	public override bool StartPack(ContentPack container, params object[] additionalContext)
	{
		bool ok = SwitchInputHelper.RemapFor2Players();
		if (ok)
		{
			GameAnalytics.OnCampaignStarted(container, false);
			StartCoroutine(PlayPartyModeCR());
		}
		else
		{
			SwitchInputHelper.SetDefaultSwitchInput();
		}
		return ok;
	}

	private IEnumerator PlayPartyModeCR()
	{
		if (LevelManager.Instance != null)
		{
			yield return StartCoroutine(LevelManager.Instance.StartTransition());
		}

		bool loaded = false;
		UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle = default;
		try
		{
			handle = Addressables.LoadSceneAsync("PartyMode", LoadSceneMode.Single, true, 100);
		}
		catch (Exception)
		{
		}
		if (handle.IsValid())
		{
			yield return handle;
			loaded = true;
		}

		if (!loaded)
		{
			var op = SceneManager.LoadSceneAsync("PartyMode", LoadSceneMode.Single);
			if (op != null)
				yield return op;
		}
		OnPackDone?.Invoke(true);
	}
}
