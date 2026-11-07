using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenshotUtility : MonoBehaviour
{
	private LevelStarter levelStarter;

	private List<LevelData> levelDatas;

	private int levelIndex;

	private Scene tempScene;

	private void Start()
	{
	}

	private void Instance_OnLevelLoaded(LevelData levelData)
	{
	}

	private void FindAllLevelsInCurrentOverworld()
	{
	}

	private IEnumerator WaitAndTakeScreenshot(LevelData levelData)
	{
		return null;
	}
}
