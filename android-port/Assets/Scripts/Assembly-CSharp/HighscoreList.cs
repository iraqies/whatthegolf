using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreList : MonoBehaviour
{
	public LeaderboardBoard board;

	public int entries;

	public int extraCount;

	public DailyChallengeScoreEntry YourBest;

	public Animator YourScoreArrow;

	public bool RefreshOnEnable;

	public GameObject EntryPrefab;

	public Transform EntriesRoot;

	public TextMeshProUGUI NoConnectionText;

	public TextMeshProUGUI title;

	public TextMeshProLocalized titleLocalized;

	public Color EntryColorEven;

	public Color EntryColorOdd;

	public ScrollRect ScrollRect;

	private List<DailyChallengeScoreEntry> Scores;

	private Task runnningRoutine;

	private CancellationTokenSource cts;

	private int retries;

	private bool _haveEntriesBeenInitialized;

	private string[,] names;

	private List<string> forenames;

	private List<string> surnames;

	public void RefreshEntryColors(Color newColor)
	{
	}

	private bool ShouldRefresh()
	{
		return false;
	}

	private void OnEnable()
	{
	}

	private IEnumerator CheckConnection()
	{
		return null;
	}

	private void Awake()
	{
	}

	public void InitEntries()
	{
	}

	private void SetTitle()
	{
	}

	public void Reset()
	{
	}

	public void StartRefreshLeaderboard(float delay = 0f)
	{
	}

	public void RefreshInstant()
	{
	}

	private void ResetEntries()
	{
	}

	private void RefreshList(float delay = 0f)
	{
	}

	private void GetLeaderboard(bool success, List<LeaderboardEntry> leaderboard)
	{
	}

	private IEnumerator ProcessLeaderboard(List<LeaderboardEntry> leaderboard)
	{
		return null;
	}

	private void InitNameGenerator()
	{
	}

	private string GenerateName()
	{
		return null;
	}

	private void FillInExtras(List<LeaderboardEntry> leaderboard)
	{
	}

	private int CalcTotalPar()
	{
		return 0;
	}

	private void SortAndReindex(List<LeaderboardEntry> leaderboard)
	{
	}

	private int LeaderboardEntryComparer(LeaderboardEntry e1, LeaderboardEntry e2)
	{
		return 0;
	}

	public void UpdateInput(float deltaTime)
	{
	}
}
