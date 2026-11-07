using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
	public SpriteRenderer retryRender;

	public HoleInOneTransition transition;

	public EffectsInOne effects;

	public float retryTimeoutThreshold;

	public ToggleControllerBasedOnAnotherController controllerToggler;

	public SpeechBubbleUI speechBubble;

	public Animator faceAnim;

	public LevelDotsUI levelDotsUI;

	public List<LevelMusicSettings> computerMusic;

	public static int strokes;

	private HoleInOneLevel[] levels;

	private float nextLostSpeechBubbleTime;

	private float lostSpeechBubbleInterval;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	private void PlayMusic(int musicIndex)
	{
	}

	private void ShowSpeechBubble(string text)
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	private void ResetLostSpeechBubbleTimeout()
	{
	}
}
