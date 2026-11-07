using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WindowsSplashScreen : MonoBehaviour
{
	public List<string> changeToTallScenes;

	public List<string> changeToWideScenes;

	public Vector2 tallResolution;

	public Vector2 wideResolution;

	private void Start()
	{
	}

	private void OnSceneLoaded(Scene prevScene, Scene nextScene)
	{
	}
}
