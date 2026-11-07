using UnityEngine;

public class ReadSceneNames : MonoBehaviour
{
	private static object _lock;

	private static bool applicationIsQuitting;

	private static ReadSceneNames instance;

	public string sceneFilename;

	public string[] scenes;

	public static ReadSceneNames Instance => null;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	private void OnDestroy()
	{
	}

	private string BuildLoadFilename()
	{
		return null;
	}

	private void LoadLevelNames()
	{
	}
}
