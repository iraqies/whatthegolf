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
	public bool IsHubLoaded => SceneManager.GetActiveScene().name == "Hub_Overworld";

	public async Task LoadSceneAsync(LoadSceneMode loadSceneMode = LoadSceneMode.Single, SceneInstance? sceneToUnload = null, bool forceReload = false)
	{
		if (_busyLoading) return;
		_busyLoading = true;
		try
		{
			AsyncOperationHandle<SceneInstance> handle = default;
			try
			{
				handle = Addressables.LoadSceneAsync("Hub_Overworld", loadSceneMode, true);
			}
			catch (Exception)
			{
			}
			if (handle.IsValid())
			{
				while (!handle.IsDone)
					await Task.Yield();
			}
			else
			{
				var op = SceneManager.LoadSceneAsync("Hub_Overworld", loadSceneMode);
				while (op != null && !op.isDone)
					await Task.Yield();
			}
			_loadCount++;
			BaseSceneLoaded?.Invoke();
		}
		finally
		{
			_busyLoading = false;
		}
	}
}
