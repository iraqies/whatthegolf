using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class WinnerStats : MonoBehaviour
{
	public TextMeshPro text;

	public AudioClip sfxShootOutBall;

	public float PercentageCompleted = 100f;

	public Animator textAnimator;

	private OverworldMainDoorPlate plate;

	private ApplicationExitGameSaver exitGameSaver;

	private const string overworldKey = "ID_OVERWORLD_STATS";

	private void Awake()
	{
		exitGameSaver = UnityEngine.Object.FindObjectOfType<ApplicationExitGameSaver>();
	}

	public void Init()
	{
		plate = GetComponent<OverworldMainDoorPlate>();
		if (textAnimator != null)
		{
			textAnimator.keepAnimatorControllerStateOnDisable = true;
		}
		if (TryGetStrokes(out int _))
		{
			if (plate != null)
			{
				plate.SetState(true, true);
			}
			UpdateState();
			if (textAnimator != null)
			{
				textAnimator.SetBool("Visible", true);
			}
			if (plate != null)
			{
				plate.OnStateChange += WinnerStats_ReuseWire;
			}
		}
		else if (plate != null)
		{
			plate.OnStateChange += WinnerStats_OnStateChange;
			if (plate.isOn)
			{
				UpdateState();
				if (textAnimator != null)
				{
					textAnimator.SetBool("Visible", true);
				}
			}
		}
	}

	private void WinnerStats_OnStateChange(bool state, bool onload)
	{
		if (state)
		{
			UpdateState();
			if (!onload)
			{
				StartCoroutine(ShootOutBall());
			}
		}
	}

	private void WinnerStats_ReuseWire(bool state, bool onload)
	{
		if (state && !onload)
		{
			StartCoroutine(ShootOutBall());
		}
	}

	public IEnumerator ShootOutBall()
	{
		OverworldBall2D ball = OverworldBallManager.Instance != null ? OverworldBallManager.Instance.Ball : null;
		if (ball != null)
		{
			ball.enabled = false;
		}
		yield return new WaitForSeconds(0.5f);
		if (ball != null)
		{
			ball.SetColliders(true);
			ball.enabled = true;
			if (plate != null && plate.returningBallTransform != null)
			{
				ball.transform.position = plate.returningBallTransform.position;
				ball.ShowAndEnable();
				ball.Velocity = plate.returningBallTransform.right * 15f;
			}
		}
		if (sfxShootOutBall != null && AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
		{
			AudioManager.Instance.shortEffects.Play(sfxShootOutBall, s => s.transform.position = transform.position, 0f, false);
		}
		if (textAnimator != null)
		{
			textAnimator.SetBool("Visible", true);
		}
	}

	public bool TryGetStrokes(out int strokes)
	{
		strokes = SaveGame.OverworldStrokes;
		if (Mathf.Approximately(PercentageCompleted, 0f))
		{
			strokes = SaveGame.OverworldStrokes0Pct;
		}
		else if (Mathf.Approximately(PercentageCompleted, 50f))
		{
			strokes = SaveGame.OverworldStrokes50Pct;
		}
		else if (Mathf.Approximately(PercentageCompleted, 75f))
		{
			strokes = SaveGame.OverworldStrokes75Pct;
		}
		else if (Mathf.Approximately(PercentageCompleted, 100f))
		{
			strokes = SaveGame.OverworldStrokes100Pct;
		}
		return strokes > 0;
	}

	public bool TryGetTime(out float time)
	{
		time = SaveGame.TimePlayed;
		if (Mathf.Approximately(PercentageCompleted, 0f))
		{
			time = SaveGame.TimePlayed0Pct;
		}
		else if (Mathf.Approximately(PercentageCompleted, 50f))
		{
			time = SaveGame.TimePlayed50Pct;
		}
		else if (Mathf.Approximately(PercentageCompleted, 75f))
		{
			time = SaveGame.TimePlayed75Pct;
		}
		else if (Mathf.Approximately(PercentageCompleted, 100f))
		{
			time = SaveGame.TimePlayed100Pct;
		}
		return time > 0f;
	}

	private void UpdateState()
	{
		if (!TryGetStrokes(out int strokes) || !TryGetTime(out float timePlayed))
		{
			strokes = SaveGame.OverworldStrokes;
			timePlayed = exitGameSaver != null ? exitGameSaver.GetPreviousPlayedTime() : SaveGame.TimePlayed;
			SaveStats(strokes, Mathf.RoundToInt(timePlayed));
		}
		if (text != null)
		{
			string timeStr = GetFormatedTimeString(timePlayed);
			text.text = string.Format("{0}%\nStrokes: {1}\nTime: {2}", Mathf.RoundToInt(PercentageCompleted), strokes, timeStr);
		}
	}

	private void SaveStats(int strokes, int timePlayed)
	{
		if (Mathf.Approximately(PercentageCompleted, 0f))
		{
			SaveGame.OverworldStrokes0Pct = strokes;
			SaveGame.TimePlayed0Pct = timePlayed;
		}
		else if (Mathf.Approximately(PercentageCompleted, 50f))
		{
			SaveGame.OverworldStrokes50Pct = strokes;
			SaveGame.TimePlayed50Pct = timePlayed;
		}
		else if (Mathf.Approximately(PercentageCompleted, 75f))
		{
			SaveGame.OverworldStrokes75Pct = strokes;
			SaveGame.TimePlayed75Pct = timePlayed;
		}
		else if (Mathf.Approximately(PercentageCompleted, 100f))
		{
			SaveGame.OverworldStrokes100Pct = strokes;
			SaveGame.TimePlayed100Pct = timePlayed;
		}
	}

	private string GetFormatedTimeString(float timePlayed)
	{
		TimeSpan ts = TimeSpan.FromSeconds(Mathf.Max(0f, timePlayed));
		return string.Format("{0:00}:{1:00}:{2:00}", (int)ts.TotalHours, ts.Minutes, ts.Seconds);
	}
}
