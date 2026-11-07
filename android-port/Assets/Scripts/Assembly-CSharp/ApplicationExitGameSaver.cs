using UnityEngine;

public class ApplicationExitGameSaver : MonoBehaviour
{
	private float timeOverworldLoaded;

	private OverworldCompletionPercentage completion;

	private float timePlayed;

	private bool skipFrame;

	private bool paused;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	private void OnDestroy()
	{
	}

	private void Save(bool gameClosing = false)
	{
	}

	public int GetPreviousPlayedTime()
	{
		return 0;
	}

	public void Pause(bool pause = true)
	{
	}

	public float GetTimePlayedThisSession()
	{
		return 0f;
	}
}
