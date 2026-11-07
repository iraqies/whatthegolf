using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

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
		return false;
	}

	private void Show()
	{
	}

	private void Hide()
	{
	}

	public void StartButtonClicked()
	{
	}

	private IEnumerator PlayRoutine()
	{
		return null;
	}

	private Task GoToHub()
	{
		return null;
	}

	private void Update()
	{
	}

	private void SubmitScoreAndRefreshLeaderboard(int strokes)
	{
	}

	private IEnumerator SubmitScore(int strokes, float pause = 0f, int retries = 5)
	{
		return null;
	}

	private void SubmitScoreCallback(bool succes, int retries)
	{
	}

	private void SetLevelPack(LevelDataContainerWithChallenge pack)
	{
	}
}
