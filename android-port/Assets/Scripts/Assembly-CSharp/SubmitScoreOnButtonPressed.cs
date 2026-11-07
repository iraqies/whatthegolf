using UnityEngine;

public class SubmitScoreOnButtonPressed : MonoBehaviour
{
	public OverworldMainButton button;

	public LeaderboardBoard board;

	public UnlockAchievement achievement;

	public string savegameID;

	[SerializeField]
	private bool isSubmittedToScore;

	private void Start()
	{
	}

	private void Button_OnInit()
	{
	}

	private void SubmitScore(OverworldMainButton o = null)
	{
	}
}
