using System.Collections;
using TMPro;
using UnityEngine;

public class WinnerStats : MonoBehaviour
{
	public TextMeshPro text;

	public AudioClip sfxShootOutBall;

	public float PercentageCompleted;

	public Animator textAnimator;

	private OverworldMainDoorPlate plate;

	private ApplicationExitGameSaver exitGameSaver;

	private const string overworldKey = "ID_OVERWORLD_STATS";

	private void Awake()
	{
	}

	public void Init()
	{
	}

	private void WinnerStats_OnStateChange(bool state, bool onload)
	{
	}

	private void WinnerStats_ReuseWire(bool state, bool onload)
	{
	}

	public IEnumerator ShootOutBall()
	{
		return null;
	}

	public bool TryGetStrokes(out int strokes)
	{
		strokes = default;
		return false;
	}

	public bool TryGetTime(out float time)
	{
		time = default;
		return false;
	}

	private void UpdateState()
	{
	}

	private void SaveStats(int strokes, int timePlayed)
	{
	}

	private string GetFormatedTimeString(float timePlayed)
	{
		return null;
	}
}
