using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class iOSOnlineServices : MonoBehaviour
{
	private enum GCState
	{
		None = 0,
		WaitingForGameCenter = 1,
		SignInAllowed = 2,
		NoGameCenter = 3,
		HasGameCenter = 4
	}

	public enum ReloadState
	{
		None = 0,
		Menu = 1,
		Overworld = 2,
		All = 3,
		NewUser = 4
	}

	private static iOSOnlineServices k_Instance;

	[SerializeField]
	private DialogBase m_ICloudUnavailableAlert;

	[SerializeField]
	private DialogBase m_GameCenterUnavailableAlert;

	[SerializeField]
	private ReconciliationDialog m_ReconciliationDialog;

	[SerializeField]
	private GameObject statusText;

	[CompilerGenerated]
	private Action<ReloadState> m_OnShouldReload;

	private Coroutine reloadWhenInASceneThatAllowsReloadCoroutine;

	private GCState _gcState;

	private ReloadState LastReloadState;

	private bool isWaitingForIcloud;

	private bool m_ResumeRoutine;

	public static iOSOnlineServices Instance => null;

	public static bool IsReady { get; set; }

	private GCState GameCenterState
	{
		get
		{
			return GCState.None;
		}
		set
		{
		}
	}

	public event Action<ReloadState> OnShouldReload
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	public void SetupCallbacks()
	{
	}

	private void OnSaveDoICloud(SaveGame.SaveSlot slot)
	{
	}

	private void UnsetCallbacks()
	{
	}

	private void OnDisable()
	{
	}

	private void Awake()
	{
	}

	private IEnumerator ReloadWhenInASceneThatAllowsReloadRoutine(ReloadState shouldReload)
	{
		return null;
	}

	public void IOSOnlineServices_OnShouldReload(ReloadState shouldReload)
	{
	}

	public IEnumerator PreloadSaveCR(string filename, Action<CloudSave.CloudSaveResult> OnDone)
	{
		return null;
	}

	private void OnLoadedSaveCacheSaveGame(SaveGame.SaveSlot slot)
	{
	}

	public void SetReadyForGameCenterLogin()
	{
	}

	private SaveGame.SaveData MergeSaves(SaveGame.SaveData a, SaveGame.SaveData b)
	{
		return null;
	}

	public IEnumerator MegaMergeAllSaveFilesCR()
	{
		return null;
	}

	public void Initialize(Action OnReady, Action OnSaveFilenameDetermined)
	{
	}

	private void SynchronizeSaves(bool force = false)
	{
	}

	private IEnumerator SynchronizeSavesCR(CloudSave.CloudSaveResult cachedCloudResult, Action<ReloadState> onDone)
	{
		return null;
	}

	public void TriggerReload(ReloadState reloadState)
	{
	}

	private IEnumerator DetermineGCUserAsync(Action<bool> onDone)
	{
		return null;
	}

	private void InitializeRoutine(Action OnReady, Action OnSaveFilenameDetermined)
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	private void TrySynchronizeOnStateChange(bool gameCenterOnly = false)
	{
	}

	private void SynchronizeGCUserAndSavesCR(bool gameCenterOnly = false)
	{
	}

	private void OnApplicationQuit()
	{
	}

	private IEnumerator RestartApp()
	{
		return null;
	}

	public IEnumerator DisplayGameCenterUnavailableDialog()
	{
		return null;
	}
}
