using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class TriCloudManager : MonoBehaviour
{
	private delegate void DelegateCallback(int requestId, bool success, string error, IntPtr dataPointer, int dataLength);

	private static TriCloudManager _instance;

	private Dictionary<int, TriCloudResult> _results;

	public static TriCloudManager instance => null;

	[PreserveSig]
	private static extern int TriCloud_GetFileList(string cloudContainerId, string fileType);

	[PreserveSig]
	private static extern int TriCloud_FetchUserRecordID(string cloudContainerId);

	[PreserveSig]
	private static extern void TriCloud_SetDelegate(DelegateCallback callback);

	private static void DelegateMessageReceived(int requestId, bool success, string error, IntPtr dataPointer, int dataLength)
	{
	}

	private void ReturnResult(int requestId, TriCloudResult result)
	{
	}

	public IEnumerator FindCloudKitFilesCR(string cloudContainerId, string fileType, TriCloudQuery query)
	{
		return null;
	}

	public void FetchUserRecordID(string cloudContainerId, Action<TriCloudQuery> onDone)
	{
	}

	public IEnumerator FetchUserRecordIDCR(string cloudContainerId, Action<TriCloudQuery> onDone)
	{
		return null;
	}
}
