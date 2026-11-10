using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Audio;
using Core;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class DailyChallengePackStarter : BasePackStarter
{
	[SerializeField]
	private int numLevelsToPlay = 1;

	[SerializeField]
	private TransitionColorDefinition defaultColors;

	private bool endTransition;

	public bool isSpecialPackStarterHack;

	[SerializeField]
	private LevelMusicSettings winMusic;

	public bool isActive;

	[SerializeField]
	private List<LevelData> BlacklistMusicLevels;

	[SerializeField]
	private LevelMusicSettings dailyChallengeMusic;

	[SerializeField]
	private bool ShouldSubmitScore;

	protected readonly string bestScoreKey = "DailyBestScore";

	protected bool inTransition;

	private ContentPack _pack;

	private int levelIndexForPaginator;

	protected int strokesToSubmit;

	protected Coroutine submitScoreRoutine;

	public SceneInstance winSceneInstance;

	public bool isDailyPlaying
	{
		get
		{
			return DailyChallenges.Instance != null && DailyChallenges.Instance.isDailyPlaying;
		}
		set
		{
			if (DailyChallenges.Instance != null)
				DailyChallenges.Instance.isDailyPlaying = value;
			isActive = value;
		}
	}

	private DailyChallengePagination Paginator
	{
		get
		{
			if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
				return LevelManager.Instance.InGameMenu.DailyChallengePagination;
			return null;
		}
	}

	private void ShowDailyPagination(int levelCount)
	{
		levelIndexForPaginator = 0;
		if (Paginator != null)
			Paginator.Enable(levelCount);
	}

	private void HideDailyPagination()
	{
		if (Paginator != null)
			Paginator.Disable();
	}

	private void CompleteIcon()
	{
		if (Paginator != null)
			Paginator.CompleteIcon(levelIndexForPaginator);
		levelIndexForPaginator++;
	}

	private void ActivateIcon()
	{
		if (Paginator != null)
			Paginator.ActivateIcon(levelIndexForPaginator);
	}

	public void PlayLevels(bool isDailyPlayed, int lastScore = -1)
	{
		StartCoroutine(PlayRoutine(isDailyPlayed, lastScore));
	}

	public void AllowEndTransition()
	{
		endTransition = true;
	}

	private IEnumerator PlayRoutine(bool isDailyPlayed = false, int lastScore = -1)
	{
		GameAnalytics.OnCampaignStarted(_pack, false);
		enabled = false;
		endTransition = false;

		var pack = GetLevelPack();
		yield return StartCoroutine(StartTransition(pack));

		AllowEndTransition();
		if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
			LevelManager.Instance.InGameMenu.ActivateMenu();

		if (pack != null && pack.music != null && pack.music.baseMusicData != null)
			dailyChallengeMusic = pack.music;

		List<LevelData> levels = pack != null ? pack.GetLevelDatas() : new List<LevelData>();
		if (levels != null && numLevelsToPlay > 0 && levels.Count > numLevelsToPlay)
			levels = levels.Take(numLevelsToPlay).ToList();

		if (AudioManager.Instance != null && AudioManager.Instance.AmbientPlayer != null)
			AudioManager.Instance.AmbientPlayer.SetAmbients(new List<AmbientAudio>());

		int totalStrokes = 0;
		bool aborted = false;
		bool completedAll = false;
		DateTime startDay = DailyChallenges.GetToday();

		if (levels != null)
		{
			ShowDailyPagination(levels.Count);
			for (int i = 0; i < levels.Count; i++)
			{
				if (aborted) break;
				var lvl = levels[i];
				if (lvl == null) continue;

				if (pack != null && !pack.IsSpecial)
				{
					lvl.userCustomTransitionColor = true;
					lvl.customTransitionEffectIndex = Transition.TransitionEffect.Daily;
					lvl.useCustomTransitionEffect = false;
				}

				if (i == 0)
					yield return StartCoroutine(WaitForTransitionIfNeeded());

				bool isLast = i == levels.Count - 1;
				int prevStrokes = totalStrokes;

				if (LevelManager.Instance != null)
				{
					yield return StartCoroutine(LevelManager.Instance.Play(
						lvl,
						onLevelLoaded: _ => ActivateIcon(),
						onComplete: cs =>
						{
							if (cs != null)
								totalStrokes = cs.Strokes;
							CompleteIcon();
							if (isLast)
								completedAll = true;
						},
						onFail: fs =>
						{
							if (fs != null)
								totalStrokes = fs.Strokes;
						},
						onAbort: () => aborted = true,
						onTransitionCoverAfter: _ => { },
						skipTransitionIn: i > 0,
						skipTransitionOut: isLast,
						strokesFromPreviousLevels: prevStrokes,
						resetStrokesWhenFinished: isLast,
						showStrokeCounter: true,
						alwaysReloadOnFail: true,
						addStrokesOnFailToStrokesFromPreviousLevels: () => true
					));
				}
			}
		}

		enabled = true;
		if (completedAll && !aborted && pack != null)
		{
			if (!isSpecialPackStarterHack)
			{
				if (PackIsNotYetPlayedToday(pack))
				{
					SaveGame.NumTimeDailyPlayed = SaveGame.NumTimeDailyPlayed + 1;
					if (DailyChallenges.Instance != null)
						DailyChallenges.Instance.NewPackWasCompletedToday = true;
				}
				SaveGame.LastDayPlayed = DailyChallenges.DateToString(startDay);
				SaveGame.LastScore = totalStrokes;
			}
			if (DailyChallenges.Instance != null)
				DailyChallenges.Instance.lastPackPlayed = pack;
			DailyChallenges.SetIsDailyPackPlayed(pack);

			if (submitScoreRoutine != null)
				StopCoroutine(submitScoreRoutine);
			if (LevelManager.Instance != null)
				submitScoreRoutine = LevelManager.Instance.StartCoroutine(SubmitScore(totalStrokes, 0f, 5));
			OnAllLevelsComplete();
		}
		else if (aborted)
		{
			Close(true);
		}
	}

	private IEnumerator StartTransition(DailyChallengeLevelDataContainer pack)
	{
		if (LevelManager.Instance == null) yield break;
		yield return StartCoroutine(LevelManager.Instance.StartTransition(
			default, null, false, false, false,
			isSpecialPackStarterHack && pack != null && pack.HasCustomTransition ? Transition.TransitionEffect.SpecialDay : Transition.TransitionEffect.Daily,
			pack != null ? pack.TransitionPrefab : null
		));
	}

	private bool PackIsNotYetPlayedToday(DailyChallengeLevelDataContainer pack)
	{
		if (pack == null) return false;
		var played = SaveGame.DailyPacksPlayed;
		if (played == null || played.Count == 0) return true;
		if (pack.IsSpecial)
			return !played.Any(x => x != null && x.StartsWith(pack.PackName));
		string last = played.LastOrDefault();
		return last == null || !last.StartsWith(pack.PackName);
	}

	private void OnPlayerAbort(bool s)
	{
		if (DailyChallenges.WasLastPlayedToday())
			OnAllLevelsComplete();
		else
			Close(true);
	}

	public int GetDayAsInt()
	{
		DateTime today = DailyChallenges.GetToday();
		return today.Year * 365 + today.DayOfYear;
	}

	public virtual DailyChallengeLevelDataContainer GetLevelPack()
	{
		if (isSpecialPackStarterHack)
			return DailyChallenges.GetSpecialPack(DailyChallenges.GetToday());
		return DailyChallenges.GetNormalPack(DailyChallenges.GetToday());
	}

	public override bool StartPack(ContentPack pack, params object[] additionalContext)
	{
		_pack = pack;
		isDailyPlaying = true;
		if (ProcessDeepLink.Instance != null && ProcessDeepLink.Instance.HasEvent)
		{
			StartCoroutine(PlayRoutine());
			return true;
		}
		var lvlPack = GetLevelPack();
		if (PackIsNotYetPlayedToday(lvlPack))
		{
			StartCoroutine(PlayRoutine());
		}
		else
		{
			StartCoroutine(LoadMuseumScene(isSpecialPackStarterHack));
		}
		return true;
	}

	private void OnAllLevelsComplete()
	{
		HideDailyPagination();
		StartCoroutine(LoadMuseumScene(isSpecialPackStarterHack));
	}

	private void OpenMuseumScene(bool isSpecial)
	{
		StartCoroutine(LoadMuseumScene(isSpecial));
	}

	private IEnumerator LoadMuseumScene(bool isSpecial)
	{
		if (LevelManager.Instance != null)
		{
			if (!LevelManager.Instance.IsTransitionActive())
				yield return StartCoroutine(LevelManager.Instance.StartTransition());
			else
				yield return StartCoroutine(WaitForTransitionIfNeeded());
		}

		if (AudioManager.Instance != null && AudioManager.Instance.music != null)
			AudioManager.Instance.music.SetLevelMusic(winMusic, false);

		AsyncOperationHandle<SceneInstance> handle = default;
		bool loaded = false;
		try
		{
			handle = Addressables.LoadSceneAsync("DailyChallengeWinScene", LoadSceneMode.Additive, true, 100);
		}
		catch
		{
		}

		if (handle.IsValid())
		{
			while (!handle.IsDone)
				yield return null;
			if (handle.Status == AsyncOperationStatus.Succeeded)
			{
				winSceneInstance = handle.Result;
				loaded = true;
			}
		}

		if (loaded)
		{
			var winUI = FindObjectOfType<WinSceneUI>();
			if (winUI != null)
				winUI.Init(isSpecial);
		}

		if (LevelManager.Instance != null && LevelManager.Instance.IsTransitionActive())
		{
			yield return StartCoroutine(LevelManager.Instance.EndTransition(false, 0f));
		}

		if (!loaded)
		{
			Close(false);
		}
	}

	private IEnumerator WaitForTransitionIfNeeded()
	{
		yield break;
	}

	public async void Close(bool isAborted)
	{
		isDailyPlaying = false;
		if (isAborted)
		{
			if (Paginator != null)
				Paginator.DisableInstantly();
		}
		else
		{
			HideDailyPagination();
		}

		var pack = GetLevelPack();
		if (LevelManager.Instance != null)
		{
			var cr = StartTransition(pack);
			while (cr.MoveNext())
				await System.Threading.Tasks.Task.Yield();
		}

		OnPackDone?.Invoke(!isAborted);

		SceneInstance? toUnload = isAborted ? null : (SceneInstance?)winSceneInstance;
		if (HubSceneLoader.Instance != null)
		{
			await HubSceneLoader.Instance.LoadSceneAsync(LoadSceneMode.Single, toUnload, false);
		}

		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.StartMusicWithoutTransition();
		}
	}

	protected virtual IEnumerator SubmitScore(int strokes, float pause = 0f, int retries = 5)
	{
		strokesToSubmit = strokes;
		if (pause > 0f)
			yield return new WaitForSecondsRealtime(pause);
		submitScoreRoutine = null;
	}

	protected void SubmitScoreCallback(bool succes, int retries)
	{
		submitScoreRoutine = null;
	}
}
