using System;
using System.Collections;
using Core;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;
using WhatTheGolf.LevelDesigner;

public class LevelDesignerStarter : BasePackStarter
{
	private static ContentPack _pack;

	[SerializeField]
	private ModalWindow _earlyAccessDialog;

	public override bool StartPack(ContentPack container, params object[] additionalContext)
	{
		if (LevelManager.Instance != null)
		{
			LevelManager.Instance.StartCoroutine(LoadDesignerOrCommunityCR(container));
			return true;
		}
		StartCoroutine(LoadDesignerOrCommunityCR(container));
		return true;
	}

	private IEnumerator LoadDesignerOrCommunityCR(ContentPack pack)
	{
		_pack = pack;
		bool dialogDone = true;
		bool openUrl = false;
		if (_earlyAccessDialog != null)
		{
			dialogDone = false;
			_earlyAccessDialog.ShowMenuWithClose(
				false, false,
				"ID_LEVEL_DESIGNER_EARLY_ACCESS_HEADER",
				"ID_LEVEL_DESIGNER_EARLY_ACCESS_DESCRIPTION",
				() => { openUrl = true; dialogDone = true; },
				() => { dialogDone = true; },
				() => { dialogDone = true; }
			);
		}
		while (!dialogDone)
			yield return null;

		if (openUrl)
		{
			Application.OpenURL("https://discord.gg/triband");
		}

		GameAnalytics.OnCampaignStarted(pack, false);
		if (LevelManager.Instance != null)
		{
			yield return StartCoroutine(LevelManager.Instance.StartTransition());
		}

		bool loaded = false;
		UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle = default;
		try
		{
			handle = Addressables.LoadSceneAsync("LevelDesigner", LoadSceneMode.Single, true, 100);
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
			var op = SceneManager.LoadSceneAsync("LevelDesigner", LoadSceneMode.Single);
			if (op != null)
				yield return op;
		}

		MainController.Startup(StateType.Menu);
		OnPackDone?.Invoke(true);
	}
}
