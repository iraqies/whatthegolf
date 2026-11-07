using System;
using System.Threading.Tasks;
using Core;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class HubSceneLoader : AddressableSingleton<HubSceneLoader>
{
	public Action BaseSceneLoaded;

	private int _loadCount;

	private bool _busyLoading;

	public bool HasBeenLoadedBefore => false;

	public bool IsHubBusyLoading => false;

	public bool IsHubLoaded => false;

	public Task LoadSceneAsync(LoadSceneMode loadSceneMode = LoadSceneMode.Single, SceneInstance? sceneToUnload = null, bool forceReload = false)
	{
		return null;
	}
}
