using Audio;
using Core;
using UnityEngine;

public class SpawnHotdogsChallenge : Challenge
{
	public int SpawnsToWin = 10;

	public HotdogVendor Vendor;

	public AudioClipSettings clip;

	public float maxPitch = 1.5f;

	public float maxVolume = 1f;

	private float nextClipTime;

	private float pitchIncrementPerSpawn;

	private float volumeIncrementPerSpawn;

	private int count;

	private GolfBallController controller;

	private void Awake()
	{
		if (clip != null && SpawnsToWin > 0)
		{
			pitchIncrementPerSpawn = (maxPitch - clip.Pitch.Value) / SpawnsToWin;
			volumeIncrementPerSpawn = (maxVolume - clip.Volume.Value) / SpawnsToWin;
		}
	}

	private void Start()
	{
	}

	private void OnHotdogSpawned(GolfBallController controller)
	{
		if (Time.time >= nextClipTime)
		{
			if (clip != null && AudioManager.Instance != null)
				clip.Play(AudioManager.Instance.sfx, Vector3.zero, 0f);
			nextClipTime = Time.time + 0.1f;
		}
		count++;
		if (clip != null)
		{
			clip.Pitch.Value += pitchIncrementPerSpawn;
			clip.Volume.Value += volumeIncrementPerSpawn;
		}
		if (LevelManager.Exists && LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
		{
			LevelManager.Instance.InGameMenu.CountStroke(controller, count);
		}
		if (count >= SpawnsToWin)
		{
			Complete();
		}
	}

	protected override void Activate()
	{
		if (Vendor != null)
		{
			Vendor.OnHotdogSpawned -= OnHotdogSpawned;
			Vendor.OnHotdogSpawned += OnHotdogSpawned;
		}
		if (LevelManager.Exists && LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
		{
			LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(SpawnsToWin, StrokeCounter.CounterTypes.CardsAppearing, true, 0);
		}
	}
}
