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

	private void PlayMusic(int musicIndex)
	{
		if (computerMusic != null && musicIndex >= 0 && musicIndex < computerMusic.Count)
		{
			if (AudioManager.Instance != null && AudioManager.Instance.music != null)
				AudioManager.Instance.music.SetLevelMusic(computerMusic[musicIndex], false, null);
		}
		else
		{
			Debug.LogWarning("Missing music for level", gameObject);
		}
	}

	private void ShowSpeechBubble(string text)
	{
		if (speechBubble != null)
		{
			speechBubble.Show(text, speechBubble.transform.position, null, null, null, Vector2.up, false);
		}
	}

	private IEnumerator Start()
	{
		var sceneLevels = new List<HoleInOneLevel>();
		if (gameObject.scene.IsValid())
		{
			var roots = gameObject.scene.GetRootGameObjects();
			for (int r = 0; r < roots.Length; r++)
			{
				if (roots[r] != null)
					sceneLevels.AddRange(roots[r].GetComponentsInChildren<HoleInOneLevel>(true));
			}
		}
		if (sceneLevels.Count == 0)
		{
			sceneLevels.AddRange(FindObjectsOfType<HoleInOneLevel>(true));
		}

		levels = sceneLevels
			.OrderBy(l => l != null ? l.transform.GetSiblingIndex() : 0)
			.ToArray();

		for (int k = 0; k < levels.Length; k++)
		{
			if (levels[k] != null && levels[k].gameObject.activeSelf)
				levels[k].gameObject.SetActive(false);
		}

		effects = FindObjectOfType<EffectsInOne>();
		if (transition != null)
			transition.InstantIn();

		strokes = 0;
		bool isFirstTryOfLevel = true;

		if (levelDotsUI != null)
			levelDotsUI.Initialize(levels.Length);

		if (levels.Length > 0 && levels[0] != null && levels[0].dialogStart != null)
		{
			if (speechBubble != null)
				speechBubble.Hide(true);
			var conv = levels[0].dialogStart.NewConversation();
			if (conv != null && conv.MoveNext() && conv.Current != null)
				ShowSpeechBubble(conv.Current.text);
			if (faceAnim != null)
				faceAnim.SetBool("IsTalking", true);
			nextLostSpeechBubbleTime = Time.time;
		}

		int i = 0;
		int count = levels.Length;
		while (i < count)
		{
			if (isFirstTryOfLevel && i > 0 && levels[i] != null && levels[i].dialogStart != null)
			{
				yield return new WaitForSeconds(0.3f);
				if (speechBubble != null)
					speechBubble.Hide(true);
				var conv = levels[i].dialogStart.NewConversation();
				if (conv != null && conv.MoveNext() && conv.Current != null)
					ShowSpeechBubble(conv.Current.text);
				if (faceAnim != null)
					faceAnim.SetBool("IsTalking", true);
				ResetLostSpeechBubbleTimeout();
			}

			PlayMusic(i);
			HoleInOneLevel template = levels[i];
			if (template == null)
			{
				i++;
				continue;
			}

			if (faceAnim != null)
			{
				faceAnim.SetInteger("Personality", template.personalityState);
				faceAnim.SetBool("IsHappy", false);
			}

			if (levelDotsUI != null)
				levelDotsUI.currentDotIndex = i;
			if (retryRender != null)
				retryRender.enabled = false;

			bool isPlaying = true;
			bool didWin = false;
			Vector3 endPos = Vector3.zero;

			HoleInOneLevel curLevel = Instantiate(template, template.transform.parent);
			curLevel.gameObject.SetActive(true);

			Killable[] killables = curLevel.GetComponentsInChildren<Killable>(true);
			Winable[] winables = curLevel.GetComponentsInChildren<Winable>(true);
			BallShooter shooter = curLevel.GetComponentInChildren<BallShooter>(true);

			if (shooter != null && controllerToggler != null)
				controllerToggler.OtherController = shooter.GolfBallController;

			Vector3 startPos = shooter != null ? shooter.transform.position : Vector3.zero;

			if (effects != null)
				effects.FindBall();

			bool endTransDone = false;
			if (transition != null)
				transition.EndTransition(startPos, () => endTransDone = true);
			else
				endTransDone = true;

			if (shooter != null)
				shooter.OnShootEvent += OnShoot;

			if (killables != null)
			{
				for (int k = 0; k < killables.Length; k++)
				{
					Killable killable = killables[k];
					if (killable != null)
					{
						killable.OnKilled += () =>
						{
							isPlaying = false;
							if (killable != null)
								endPos = killable.transform.position;
						};
					}
				}
			}

			if (winables != null)
			{
				for (int w = 0; w < winables.Length; w++)
				{
					Winable winable = winables[w];
					if (winable != null)
					{
						winable.OnWon += pos =>
						{
							isPlaying = false;
							didWin = true;
							endPos = pos;
						};
					}
				}
			}

			while (!endTransDone)
				yield return null;

			if (faceAnim != null)
				faceAnim.SetBool("IsTalking", false);

			float timer = 0f;
			while (isPlaying)
			{
				if (shooter != null && shooter.didShoot)
				{
					timer += Time.deltaTime;
					if (timer > retryTimeoutThreshold + curLevel.extraRetryTimeout)
					{
						didWin = false;
						isPlaying = false;
					}
				}
				yield return null;
			}

			if (shooter != null && shooter.GolfBallController != null)
			{
				shooter.GolfBallController.CancelShooting();
				shooter.GolfBallController.enabled = false;
			}

			bool starTransDone = false;
			if (transition != null)
				transition.StarTransition(endPos, didWin, () => starTransDone = true);
			else
				starTransDone = true;

			if (didWin)
			{
				if (i == levels.Length - 1 && faceAnim != null)
					faceAnim.SetBool("IsHappy", true);
				yield return new WaitForSeconds(0.1f);
				i++;
				isFirstTryOfLevel = true;
			}
			else
			{
				isFirstTryOfLevel = false;
				if (Time.time > nextLostSpeechBubbleTime && levels[i] != null && levels[i].dialogLose != null)
				{
					if (speechBubble != null)
						speechBubble.Hide(true);
					var conv = levels[i].dialogLose.NewConversation();
					if (conv != null && conv.MoveNext() && conv.Current != null)
						ShowSpeechBubble(conv.Current.text);
					if (faceAnim != null)
						faceAnim.SetBool("IsTalking", true);
					ResetLostSpeechBubbleTimeout();
				}
			}

			while (!starTransDone)
				yield return null;

			if (curLevel != null)
				Destroy(curLevel.gameObject);

			yield return new WaitForSeconds(0.1f);
		}

		if (levelDotsUI != null)
			levelDotsUI.currentDotIndex = levels.Length;

		Level level = GetComponent<Level>();
		if (level == null && Level.HasInstance)
			level = Level.Instance;
		if (level != null)
			level.ForceCompletion(0f);
	}

	private void OnShoot(Vector2 boost)
	{
		strokes++;
		if (retryRender != null)
			retryRender.enabled = true;
	}

	private void ResetLostSpeechBubbleTimeout()
	{
		nextLostSpeechBubbleTime = Time.time + lostSpeechBubbleInterval;
	}
}
