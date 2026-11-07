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

	[SerializeField] private DialogBase m_ICloudUnavailableAlert;
	[SerializeField] private DialogBase m_GameCenterUnavailableAlert;
	[SerializeField] private ReconciliationDialog m_ReconciliationDialog;
	[SerializeField] private GameObject statusText;

	private Action<ReloadState> m_OnShouldReload;
	private GCState _gcState = GCState.NoGameCenter;
	private ReloadState LastReloadState;
	private bool isWaitingForIcloud;
	private bool m_ResumeRoutine;

	public static iOSOnlineServices Instance
	{
		get
		{
			if (k_Instance == null)
			{
				k_Instance = FindObjectOfType<iOSOnlineServices>();
				if (k_Instance == null)
				{
					var go = new GameObject("iOSOnlineServices");
					k_Instance = go.AddComponent<iOSOnlineServices>();
					DontDestroyOnLoad(go);
				}
			}
			return k_Instance;
		}
	}

	public static bool IsReady { get; set; } = true;

	private GCState GameCenterState
	{
		get => _gcState;
		set => _gcState = value;
	}

	public event Action<ReloadState> OnShouldReload
	{
		add => m_OnShouldReload = (Action<ReloadState>)Delegate.Combine(m_OnShouldReload, value);
		remove => m_OnShouldReload = (Action<ReloadState>)Delegate.Remove(m_OnShouldReload, value);
	}

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		IsReady = true;
	}

	public void SetupCallbacks() { }
	private void OnSaveDoICloud(SaveGame.SaveSlot slot) { }
	private void UnsetCallbacks() { }
	private void OnDisable() { }

	private void Awake()
	{
		if (k_Instance == null)
		{
			k_Instance = this;
			DontDestroyOnLoad(gameObject);
		}
		IsReady = true;
	}

	public void IOSOnlineServices_OnShouldReload(ReloadState shouldReload) { }

	public IEnumerator PreloadSaveCR(string filename, Action<CloudSave.CloudSaveResult> OnDone)
	{
		OnDone?.Invoke(new CloudSave.CloudSaveResult { save = SaveGame.CurrentSave, iCloudData = new CloudSave.ICloudResult { success = false } });
		yield break;
	}

	public void SetReadyForGameCenterLogin() => IsReady = true;

	public IEnumerator MegaMergeAllSaveFilesCR()
	{
		IsReady = true;
		yield break;
	}

	public void Initialize(Action OnReady, Action OnSaveFilenameDetermined)
	{
		IsReady = true;
		OnSaveFilenameDetermined?.Invoke();
		OnReady?.Invoke();
	}

	public void TriggerReload(ReloadState reloadState)
	{
		m_OnShouldReload?.Invoke(reloadState);
	}

	public IEnumerator DisplayGameCenterUnavailableDialog()
	{
		yield break;
	}
}
