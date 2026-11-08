using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public static class OverworldSceneLoader
{
	public static async void LoadOverworld(ContentPack pack, bool tunnel)
	{
		await TryLoadOverworld(pack, tunnel);
	}

	public static async Task<bool> TryLoadOverworld(ContentPack pack, bool tunnel)
	{
		if (pack == null)
			return false;

		bool tunnelNull = pack.tunnelLoaderSceneReference.IsNull();
		bool overworldNull = pack.overworldSceneReference.IsNull();
		if (tunnelNull && overworldNull)
			return false;

		if (tunnel && !tunnelNull)
		{
			return await LoadSceneFromReferenceAsync(pack.tunnelLoaderSceneReference, "main overworld tunnel loader");
		}

		if (!overworldNull)
		{
			string sceneName = pack.overworldSceneReference != null ? pack.overworldSceneReference.SceneName : null;
			if (string.Equals(sceneName, "Hub_Overworld", StringComparison.OrdinalIgnoreCase) && HubSceneLoader.Instance != null)
			{
				await HubSceneLoader.Instance.LoadSceneAsync(LoadSceneMode.Single);
				return true;
			}
			return await LoadSceneFromReferenceAsync(pack.overworldSceneReference, sceneName);
		}

		return false;
	}

	private static async Task<bool> LoadSceneFromReferenceAsync(AssetReferenceScene sceneRef, string fallbackSceneName)
	{
		string sceneName = (sceneRef != null && !string.IsNullOrEmpty(sceneRef.SceneName)) ? sceneRef.SceneName : fallbackSceneName;
		if (!string.IsNullOrEmpty(sceneName) && Application.CanStreamedLevelBeLoaded(sceneName))
		{
			AsyncOperation op = null;
			try
			{
				op = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
			}
			catch (Exception)
			{
			}
			if (op != null)
			{
				while (!op.isDone)
					await Task.Yield();
				return true;
			}
		}

		if (sceneRef != null && !string.IsNullOrEmpty(sceneRef.AssetGUID))
		{
			AsyncOperationHandle<SceneInstance> handle = default;
			try
			{
				handle = Addressables.LoadSceneAsync(sceneRef, LoadSceneMode.Single, true, 100);
			}
			catch (Exception)
			{
			}
			if (handle.IsValid())
			{
				while (!handle.IsDone)
					await Task.Yield();
				if (handle.Status == AsyncOperationStatus.Succeeded)
					return true;
			}
		}

		if (!string.IsNullOrEmpty(sceneName))
		{
			AsyncOperationHandle<SceneInstance> handleByName = default;
			try
			{
				handleByName = Addressables.LoadSceneAsync(sceneName, LoadSceneMode.Single, true, 100);
			}
			catch (Exception)
			{
			}
			if (handleByName.IsValid())
			{
				while (!handleByName.IsDone)
					await Task.Yield();
				if (handleByName.Status == AsyncOperationStatus.Succeeded)
					return true;
			}
		}

		return false;
	}
}
