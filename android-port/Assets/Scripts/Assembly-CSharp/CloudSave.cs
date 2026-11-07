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
	public const string ICLOUD_CONTAINER_ID = "iCloud.com.thelabelgames.golf.cloud";

	public static bool ICloudIsAvailable => false;

	public static event Action<bool> OnSuccessfulUploadOfSave
	{
		add { }
		remove { }
	}

	public static event Action OnRequireMainMenuReload
	{
		add { }
		remove { }
	}

	public static event Action OnRequireMainOverworldReload
	{
		add { }
		remove { }
	}

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	public static void Save(string filename, ReconcileType reconcileType, Action<SaveGame.SaveData> restartAfterCloudReconciliation = null)
	{
	}

	public static bool InitializeICloudDatabase() => false;

	public static Task<CloudSaveResult> DownloadSave(string filename)
	{
		return Task.FromResult(new CloudSaveResult
		{
			save = SaveGame.CurrentSave,
			iCloudData = new ICloudResult { success = false, clouddata = string.Empty },
			ParseError = false
		});
	}

	public static Task<SaveReconciliationResult> MergeCloudIntoLocal(SaveGame.SaveData cloudSave)
	{
		return Task.FromResult(new SaveReconciliationResult { Type = SaveType.Local, Data = SaveGame.CurrentSave });
	}

	public static bool MergeSaveGames(SaveGame.SaveData localSave, SaveGame.SaveData cloudSave, out SaveGame.SaveData mergedSave, out bool requiresOverworldReload, out bool requiresMenuReload)
	{
		mergedSave = localSave ?? SaveGame.CurrentSave;
		requiresOverworldReload = false;
		requiresMenuReload = false;
		return false;
	}

	public static Task<CloudSaveResult> GetDataFromFetchAsync(string filename) => DownloadSave(filename);

	public static IEnumerator DeleteBackupSaveRoutine()
	{
		yield break;
	}
}
