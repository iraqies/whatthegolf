using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Audio;
using Core;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ImpossibleChallengeMenu : BasePackStarter
{
	[SerializeField]
	private TextMeshProLocalized TitleLabel;

	private ContentPack contentPack;
	private LevelDataContainerWithChallenge levelPack;
	private List<LevelDataAndChallenge> levelsToPlay;

	[SerializeField]
	private DailyChallengeCompleted CompletedScreen;

	[SerializeField]
	private LevelMusicSettings ChallengeMusic;

	private int strokesToSubmit;
	private Coroutine submitScoreRoutine;
	private bool scoreIsSubmitted;

	public override bool StartPack(ContentPack container, params object[] additionalContext)
	{
		contentPack = container;
		if (container != null)
		{
			SetLevelPack(container.mainContainer as LevelDataContainerWithChallenge);
		}
		Show();
		return true;
	}

	private void Show()
	{
		enabled = true;
		gameObject.SetActive(true);
		if (OverworldManager2d.Instance != null)
			OverworldManager2d.Instance.DisableInteraction(true);
		StartButtonClicked();
	}

	private void Hide()
	{
		if (GameboyPopup.Instance != null)
			GameboyPopup.Instance.OnHideLeaderboardClicked();
	}

	public void StartButtonClicked()
	{
		if (!enabled) return;
		if (CompletedScreen != null && CompletedScreen.gameObject.activeSelf && !CompletedScreen.closing)
			return;
		enabled = false;
		StartCoroutine(PlayRoutine());
	}

	private IEnumerator PlayRoutine()
	{
		enabled = false;
		GameAnalytics.OnCampaignStarted(contentPack, false);
		if (AudioManager.Instance != null && AudioManager.Instance.AmbientPlayer != null)
			AudioManager.Instance.AmbientPlayer.SetAmbients(new List<AmbientAudio>());

		bool completedAll = false;
		bool aborted = false;
		int totalStrokes = 0;

		if (levelsToPlay != null && LevelManager.Instance != null)
		{
			for (int i = 0; i < levelsToPlay.Count; i++)
			{
				if (aborted) break;
				var item = levelsToPlay[i];
				if (item == null || item.level == null) continue;
				if (AudioManager.Instance != null && AudioManager.Instance.music != null)
				{
					var music = (item.level.music != null && item.level.music.baseMusicData != null) ? item.level.music : ChallengeMusic;
					AudioManager.Instance.music.SetLevelMusic(music, false);
				}

				string challengeId = string.IsNullOrEmpty(item.challengeID) ? null : item.challengeID;
				bool isLast = i == levelsToPlay.Count - 1;
				int prevStrokes = i > 0 ? totalStrokes : 0;

				yield return StartCoroutine(LevelManager.Instance.Play(
					item.level,
					onTransitionCoverBefore: () =>
					{
						if (OverworldManager2d.Instance != null)
							OverworldManager2d.Instance.ToggleOverworld(false);
					},
					onComplete: cs =>
					{
						if (cs != null)
							totalStrokes = cs.Strokes;
						if (isLast)
							completedAll = true;
					},
					onFail: fs =>
					{
						if (fs != null)
							totalStrokes = fs.Strokes;
					},
					onAbort: () => aborted = true,
					skipTransitionIn: i > 0,
					skipTransitionOut: !isLast,
					strokesFromPreviousLevels: prevStrokes,
					resetStrokesWhenFinished: isLast,
					showStrokeCounter: true,
					challengeID: challengeId,
					alwaysReloadOnFail: true,
					addStrokesOnFailToStrokesFromPreviousLevels: () => true,
					hideLevelCompletionText: true
				));
			}
		}

		GameAnalytics.OnCampaignEnded(completedAll);
		OnPackDone?.Invoke(!aborted);
		yield return GoToHub();

		if (OverworldManager2d.Instance != null)
		{
			if (completedAll && CompletedScreen != null)
			{
				OverworldManager2d.Instance.DisableInteraction(true);
				CompletedScreen.Show(totalStrokes, true);
				SubmitScoreAndRefreshLeaderboard(totalStrokes);
			}
			else
			{
				OverworldManager2d.Instance.EnableInteraction();
			}
		}
	}

	private async Task GoToHub()
	{
		if (HubSceneLoader.Instance != null)
			await HubSceneLoader.Instance.LoadSceneAsync(LoadSceneMode.Single);
	}

	private void Update()
	{
		if (InputHelper.GetAllPlayerButtonOpenMenu() || InputHelper.GetAllPlayerButtonCancel())
		{
			Hide();
		}
	}

	private void SubmitScoreAndRefreshLeaderboard(int strokes)
	{
		scoreIsSubmitted = false;
		if (submitScoreRoutine != null)
			StopCoroutine(submitScoreRoutine);
		submitScoreRoutine = StartCoroutine(SubmitScore(strokes, 0f, 5));
	}

	private IEnumerator SubmitScore(int strokes, float pause = 0f, int retries = 5)
	{
		strokesToSubmit = strokes;
		if (pause > 0f)
			yield return new WaitForSecondsRealtime(pause);
		scoreIsSubmitted = true;
		submitScoreRoutine = null;
	}

	private void SubmitScoreCallback(bool succes, int retries)
	{
		submitScoreRoutine = null;
		scoreIsSubmitted = true;
	}

	private void SetLevelPack(LevelDataContainerWithChallenge pack)
	{
		levelPack = pack;
		if (pack != null)
		{
			levelsToPlay = pack.GetLevelDatasWithChallenges();
			if (TitleLabel != null && contentPack != null)
				TitleLabel.ChangeText(contentPack.titleID);
		}
	}
}
