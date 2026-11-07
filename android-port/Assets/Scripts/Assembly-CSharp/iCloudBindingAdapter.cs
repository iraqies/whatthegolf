using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2000CC4")]
public static class iCloudBindingAdapter
{
	[Token(Token = "0x6003C62")]
	[Address(RVA = "0x1763F6C", Offset = "0x1763F6C", VA = "0x1763F6C")]
	public static bool areiCloudCredentialsValid()
	{
		return default;
	}

	[Token(Token = "0x6003C63")]
	[Address(RVA = "0x1763F74", Offset = "0x1763F74", VA = "0x1763F74")]
	public static void getCloudSavesList(float timeout, Action<List<SaveFileInfo>> onDone, Action<List<SaveFileInfo>> onDoneAfterTimeout)
	{
	}

	[Token(Token = "0x6003C64")]
	[Address(RVA = "0x1763FC0", Offset = "0x1763FC0", VA = "0x1763FC0")]
	public static List<SaveFileInfo> getLocalSavesList()
	{
		return null;
	}

	[Token(Token = "0x6003C65")]
	[Address(RVA = "0x1763FE4", Offset = "0x1763FE4", VA = "0x1763FE4")]
	public static void fetchRecord(string recordType, string recordId, Action<Dictionary<string, string>> cloudKitFetchRecordSucceededEvent, Action<string> cloudKitFetchRecordFailedEvent)
	{
	}

	[Token(Token = "0x6003C66")]
	[Address(RVA = "0x1763FEC", Offset = "0x1763FEC", VA = "0x1763FEC")]
	public static void saveRecord(string recordType, string recordId, string title, string path, Action cloudKitSaveRecordSucceededEvent, Action<string> cloudKitSaveRecordFailedEvent)
	{
	}

	[Token(Token = "0x6003C67")]
	[Address(RVA = "0x1763FF4", Offset = "0x1763FF4", VA = "0x1763FF4")]
	public static void updateRecord(string recordType, string recordId, string title, string path, Action cloudKitUpdateRecordSucceededEvent, Action<string> cloudKitUpdateRecordFailedEvent)
	{
	}

	[Token(Token = "0x6003C68")]
	[Address(RVA = "0x1763FFC", Offset = "0x1763FFC", VA = "0x1763FFC")]
	public static void deleteRecord(string recordId, Action cloudKitUpdateRecordSucceededEvent, Action<string> cloudKitUpdateRecordFailedEvent)
	{
	}

	[Token(Token = "0x6003C69")]
	[Address(RVA = "0x1764004", Offset = "0x1764004", VA = "0x1764004")]
	public static bool selectDatabase(bool usePrivateDatabase, [Optional] string containerIdentifier)
	{
		return default;
	}
}
