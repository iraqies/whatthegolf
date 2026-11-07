using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeSaveGamesDetector : MonoBehaviour
{
	private static ArcadeSaveGamesDetector _instance;

	public static ArcadeSaveGamesDetector instance => null;

	public List<SaveFileInfo> GetLocalSavesList()
	{
		return null;
	}

	public List<SaveFileInfo> GetLocalSavesList(string saveDirectory)
	{
		return null;
	}

	public void GetCloudSavesSortedByLastModified(float timeout, Action<List<SaveFileInfo>> onDone, Action<List<SaveFileInfo>> onDoneAfterTimeout)
	{
	}

	private IEnumerator GetCloudSavesSortedByLastModifiedCR(float timeout, Action<List<SaveFileInfo>> onDone, Action<List<SaveFileInfo>> onDoneAfterTimeout)
	{
		return null;
	}
}
