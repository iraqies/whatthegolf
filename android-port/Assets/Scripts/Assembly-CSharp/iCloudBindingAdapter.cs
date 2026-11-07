using System;
using System.Collections.Generic;

public static class iCloudBindingAdapter
{
	public static bool areiCloudCredentialsValid()
	{
		return false;
	}

	public static void getCloudSavesList(float timeout, Action<List<SaveFileInfo>> onDone, Action<List<SaveFileInfo>> onDoneAfterTimeout)
	{
	}

	public static List<SaveFileInfo> getLocalSavesList()
	{
		return null;
	}

	public static void fetchRecord(string recordType, string recordId, Action<Dictionary<string, string>> cloudKitFetchRecordSucceededEvent, Action<string> cloudKitFetchRecordFailedEvent)
	{
	}

	public static void saveRecord(string recordType, string recordId, string title, string path, Action cloudKitSaveRecordSucceededEvent, Action<string> cloudKitSaveRecordFailedEvent)
	{
	}

	public static void updateRecord(string recordType, string recordId, string title, string path, Action cloudKitUpdateRecordSucceededEvent, Action<string> cloudKitUpdateRecordFailedEvent)
	{
	}

	public static void deleteRecord(string recordId, Action cloudKitUpdateRecordSucceededEvent, Action<string> cloudKitUpdateRecordFailedEvent)
	{
	}

	public static bool selectDatabase(bool usePrivateDatabase, string containerIdentifier = null)
	{
		return false;
	}
}
