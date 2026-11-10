using System;
using System.Threading.Tasks;
using Core;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class HubSceneLoader : AddressableSingleton<HubSceneLoader>
{
	public Action BaseSceneLoaded;
	private int _loadCount;
	private bool _busyLoading;

	public bool HasBeenLoadedBefore => _loadCount > 0;
	public bool IsHubBusyLoading => _busyLoading;
	public bool IsHubLoaded => SceneManager.GetSceneByName("Hub_Overworld").isLoaded;

	public async Task LoadSceneAsync(LoadSceneMode loadSceneMode = LoadSceneMode.Single, SceneInstance? sceneToUnload = null, bool forceReload = false)
	{
		if (_busyLoading) return;
		_busyLoading = true;
		try
		{
			if (gameObject != null)
				gameObject.SetActive(true);
			SaveGame.SetOverworld(ECampaignType.Hub);
			SaveGame.IncrementContentPackPlayCount("CP_HUB");

			bool wasHubLoaded = IsHubLoaded;
			if (!wasHubLoaded || forceReload)
			{
				if (LevelManager.Exists && LevelManager.Instance != null && LevelManager.Instance.transition != null && !LevelManager.Instance.transition.IsShowing)
				{
					await LevelManager.Instance.StartTransition();
				}

				AsyncOperationHandle<SceneInstance> handle = default;
				bool loaded = false;
				try
				{
					handle = Addressables.LoadSceneAsync("Hub_Overworld", loadSceneMode, true, 100);
				}
				catch (Exception)
				{
				}

				if (handle.IsValid())
				{
					while (!handle.IsDone)
						await Task.Yield();
					if (handle.Status == AsyncOperationStatus.Succeeded)
					{
						while (!handle.Result.Scene.isLoaded)
							await Task.Yield();
						loaded = true;
					}
				}

				if (!loaded)
				{
					var op = SceneManager.LoadSceneAsync("Hub_Overworld", loadSceneMode);
					while (op != null && !op.isDone)
						await Task.Yield();
				}
			}

			_loadCount++;

			if (sceneToUnload.HasValue && sceneToUnload.Value.Scene.IsValid() && sceneToUnload.Value.Scene.isLoaded)
			{
				try
				{
					Addressables.UnloadSceneAsync(sceneToUnload.Value, true);
				}
				catch (Exception)
				{
				}
			}

			if (GameboyPopup.Instance == null)
			{
				try
				{
					await GameboyPopup.Load();
				}
				catch (Exception)
				{
				}
			}

			BaseSceneLoaded?.Invoke();

			if (wasHubLoaded && LevelManager.Exists && LevelManager.Instance != null && LevelManager.Instance.transition != null && LevelManager.Instance.transition.IsShowing)
			{
				await LevelManager.Instance.EndTransition(false, 0f);
			}
		}
		finally
		{
			_busyLoading = false;
		}
	}
}
