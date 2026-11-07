using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

public static class CloudSave
{
	public enum SaveType
	{
		None = 0,
		Local = 1,
		RequireMainMenuReload = 2,
		Identical = 3,
		UUID = 4,
		ReconciliationLocal = 5,
		RequiresMainOverworldReload = 6
	}

	public enum ReconcileType
	{
		UserChoice = 0,
		NoReconcile = 1,
		ForceLocal = 2,
		CreateNew = 3
	}

	public struct SaveReconciliationResult
	{
		public SaveType Type;

		public SaveGame.SaveData Data;
	}

	public class ICloudResult
	{
		public string clouddata;

		public bool success;
	}

	public class CloudSaveResult
	{
		public SaveGame.SaveData save;

		public ICloudResult iCloudData;

		public bool ParseError;
	}

	public const float CLOUD_REQUEST_TIMEOUT = 10f;

	public const float CLOUD_REQUEST_TIMEOUT_STARTUP = 5f;

	public const float GC_INITIAL_REQUEST_TIMEOUT = 1f;

	[CompilerGenerated]
	private static Action<bool> m_OnSuccessfulUploadOfSave;

	private const bool VERBOSE = false;

	private static readonly Logger dbg;

	private const string RECORD_TYPE = "SaveGame";

	private static string BackupRecordID;

	private static float minimumSecondsForComparingSaves;

	public const string ICLOUD_CONTAINER_ID = "iCloud.com.thelabelgames.golf.cloud";

	private const string TAG = "CloudSave";

	private static readonly object threadLock;

	private static bool saveInProgress;

	private static bool cancelSaves;

	[CompilerGenerated]
	private static Action m_OnRequireMainMenuReload;

	[CompilerGenerated]
	private static Action m_OnRequireMainOverworldReload;

	private static int waitingSaveThreads;

	public static bool ICloudIsAvailable => false;

	public static event Action<bool> OnSuccessfulUploadOfSave
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

	public static event Action OnRequireMainMenuReload
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

	public static event Action OnRequireMainOverworldReload
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

	static CloudSave()
	{
	}

	public static void Save(string filename, ReconcileType reconcileType, Action<SaveGame.SaveData> restartAfterCloudReconciliation = null)
	{
	}

	public static bool InitializeICloudDatabase()
	{
		return false;
	}

	public static Task<CloudSaveResult> DownloadSave(string filename)
	{
		return null;
	}

	public static Task<SaveReconciliationResult> MergeCloudIntoLocal(SaveGame.SaveData cloudSave)
	{
		return null;
	}

	private static SaveReconciliationResult GetBestSave(SaveGame.SaveData localSave, SaveGame.SaveData cloudSave, SaveReconciliationResult result)
	{
		return default;
	}

	private static void MergeField(int saveslot, string key, SaveGame.SaveData mergedSave, SaveGame.SaveData otherSave, Func<object, object, object> merge)
	{
	}

	private static void MergeBooleanField(int saveslot, string key, SaveGame.SaveData mergedSave, SaveGame.SaveData otherSave, bool best)
	{
	}

	private static void MergeIntegerField(int saveslot, string key, SaveGame.SaveData mergedSave, SaveGame.SaveData otherSave, bool max)
	{
	}

	private static List<string> ParseList(object list)
	{
		return null;
	}

	private static bool MergeListField(int saveslot, string key, SaveGame.SaveData mergedSave, SaveGame.SaveData otherSave, bool additive, bool mergedIsLocal)
	{
		return false;
	}

	private static void MergeSettingsSlot(SaveGame.SaveData mergedSave, SaveGame.SaveData otherSave, bool mergedIsLocal)
	{
	}

	private static bool MergeSaveSlot(int saveslot, SaveGame.SaveData mergedSave, SaveGame.SaveData otherSave, bool mergedIsLocal)
	{
		return false;
	}

	private static bool MergeOverworld(int saveslot, SaveGame.SaveData mergedSave, SaveGame.SaveData otherSave, bool requiresReload, SaveGame.OverWorldData overworld, bool mergedIsLocal)
	{
		return false;
	}

	private static bool CheckIfNewSaveSlot(int saveslot, SaveGame.SaveData mergedSave, SaveGame.SaveData otherSave, out bool newestSaveSlotIsOther)
	{
		newestSaveSlotIsOther = default;
		return false;
	}

	public static bool MergeSaveGames(SaveGame.SaveData localSave, SaveGame.SaveData cloudSave, out SaveGame.SaveData mergedSave, out bool requiresOverworldReload, out bool requiresMenuReload)
	{
		mergedSave = null;
		requiresOverworldReload = default;
		requiresMenuReload = default;
		return false;
	}

	private static Task SaveAsync(string filename, ReconcileType reconcileType, Action<SaveGame.SaveData> restartAfterCloudReconciliation)
	{
		return null;
	}

	private static Task SaveAsync_Internal(string filename)
	{
		return null;
	}

	private static Task<ICloudResult> FetchAsync(string filename)
	{
		return null;
	}

	public static Task<CloudSaveResult> GetDataFromFetchAsync(string filename)
	{
		return null;
	}

	public static IEnumerator DeleteBackupSaveRoutine()
	{
		return null;
	}

	private static Task UpdateAsync(string filename)
	{
		return null;
	}

	private static Task<SaveReconciliationResult> ReconcileSave(string fileUrl, bool performReconciliation)
	{
		return null;
	}
}
