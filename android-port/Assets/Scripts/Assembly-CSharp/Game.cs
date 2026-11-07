using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class Game : MonoBehaviour
{
	public SpriteRenderer retryRender;
	public HoleInOneTransition transition;
	public EffectsInOne effects;
	public float retryTimeoutThreshold = 5f;
	public ToggleControllerBasedOnAnotherController controllerToggler;
	public SpeechBubbleUI speechBubble;
	public Animator faceAnim;
	public LevelDotsUI levelDotsUI;
	public List<LevelMusicSettings> computerMusic;
	public static int strokes;

	private HoleInOneLevel[] levels;
	private float nextLostSpeechBubbleTime;
	private float lostSpeechBubbleInterval = 8f;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		strokes = 0;
	}

	private void PlayMusic(int musicIndex) { }

	private void ShowSpeechBubble(string text) { }

	private IEnumerator Start()
	{
		levels = GetComponentsInChildren<HoleInOneLevel>(true)
			.OrderBy(l => l.transform.GetSiblingIndex())
			.ToArray();
		if (levels == null || levels.Length == 0)
			yield break;

		for (int i = 0; i < levels.Length; i++)
			levels[i].gameObject.SetActive(i == 0);

		for (int i = 0; i < levels.Length; i++)
		{
			var cur = levels[i];
			cur.gameObject.SetActive(true);
			bool won = false;
			var goal = cur.GetComponentInChildren<GolfGoal>(true);
			if (goal != null)
			{
				goal.Reset();
				goal.OnGoal += _ => won = true;
			}
			while (!won)
				yield return null;
			yield return new WaitForSeconds(0.5f);
			if (i < levels.Length - 1)
				cur.gameObject.SetActive(false);
		}

		if (Level.HasInstance)
			Level.Instance.Complete("HOLE IN ONE!", 0.8f);
	}

	private void ResetLostSpeechBubbleTimeout()
	{
		nextLostSpeechBubbleTime = Time.time + lostSpeechBubbleInterval;
	}
}
