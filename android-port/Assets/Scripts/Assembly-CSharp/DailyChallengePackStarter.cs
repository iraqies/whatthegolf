using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;
using UnityEngine.ResourceManagement.ResourceProviders;

public class DailyChallengePackStarter : BasePackStarter
{
	[SerializeField]
	private int numLevelsToPlay;

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

	protected readonly string bestScoreKey;

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
			return false;
		}
		set
		{
		}
	}

	private DailyChallengePagination Paginator => null;

	private void ShowDailyPagination(int levelCount)
	{
	}

	private void HideDailyPagination()
	{
	}

	private void CompleteIcon()
	{
	}

	private void ActivateIcon()
	{
	}

	public void PlayLevels(bool isDailyPlayed, int lastScore = -1)
	{
	}

	public void AllowEndTransition()
	{
	}

	private IEnumerator PlayRoutine(bool isDailyPlayed = false, int lastScore = -1)
	{
		return null;
	}

	private IEnumerator StartTransition(DailyChallengeLevelDataContainer pack)
	{
		return null;
	}

	private bool PackIsNotYetPlayedToday(DailyChallengeLevelDataContainer pack)
	{
		return false;
	}

	private void OnPlayerAbort(bool s)
	{
	}

	public int GetDayAsInt()
	{
		return 0;
	}

	public virtual DailyChallengeLevelDataContainer GetLevelPack()
	{
		return null;
	}

	public override bool StartPack(ContentPack pack, params object[] additionalContext)
	{
		return false;
	}

	private void OnAllLevelsComplete()
	{
	}

	private void OpenMuseumScene(bool isSpecial)
	{
	}

	private IEnumerator LoadMuseumScene(bool isSpecial)
	{
		return null;
	}

	private IEnumerator WaitForTransitionIfNeeded()
	{
		return null;
	}

	public void Close(bool isAborted)
	{
	}

	protected virtual IEnumerator SubmitScore(int strokes, float pause = 0f, int retries = 5)
	{
		return null;
	}

	protected void SubmitScoreCallback(bool succes, int retries)
	{
	}
}
