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
		timeOverworldLoaded = Time.realtimeSinceStartup;
	}

	private void Start()
	{
		completion = FindObjectOfType<OverworldCompletionPercentage>();
		timePlayed = GetPreviousPlayedTime();
	}

	private void Update()
	{
		if (paused) return;
		if (skipFrame)
		{
			skipFrame = false;
			return;
		}
		timePlayed += Time.unscaledDeltaTime;
	}

	private void OnApplicationPause(bool pause)
	{
		paused = pause;
		if (pause)
			Save(false);
		else
			skipFrame = true;
	}

	private void OnDestroy()
	{
		Save(true);
	}

	private void Save(bool gameClosing = false)
	{
		SaveGame.TimePlayed = Mathf.RoundToInt(timePlayed);
		SaveGame.Save(false);
	}

	public int GetPreviousPlayedTime()
	{
		return SaveGame.TimePlayed;
	}

	public void Pause(bool pause = true)
	{
		paused = pause;
	}

	public float GetTimePlayedThisSession()
	{
		return Time.realtimeSinceStartup - timeOverworldLoaded;
	}
}
