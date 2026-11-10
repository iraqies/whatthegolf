using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Core;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreList : MonoBehaviour
{
	public LeaderboardBoard board;

	public int entries = 50;

	public int extraCount = 20;

	public DailyChallengeScoreEntry YourBest;

	public Animator YourScoreArrow;

	public bool RefreshOnEnable = true;

	public GameObject EntryPrefab;

	public Transform EntriesRoot;

	public TextMeshProUGUI NoConnectionText;

	public TextMeshProUGUI title;

	public TextMeshProLocalized titleLocalized;

	public Color EntryColorEven;

	public Color EntryColorOdd;

	public ScrollRect ScrollRect;

	private List<DailyChallengeScoreEntry> Scores = new List<DailyChallengeScoreEntry>();

	private Task runnningRoutine;

	private CancellationTokenSource cts;

	private int retries = 10;

	private bool _haveEntriesBeenInitialized;

	private string[,] names = new string[,]
	{
		{ "Tiger", "Woods" },
		{ "John", "Daly" },
		{ "Phil", "Mickelson" },
		{ "Happy", "Gilmore" },
		{ "Shooter", "McGavin" },
		{ "Chubbs", "Peterson" },
		{ "Rory", "McIlroy" },
		{ "Jack", "Nicklaus" },
		{ "Arnold", "Palmer" },
		{ "Vijay", "Singh" },
		{ "Ernie", "Els" },
		{ "Sergio", "Garcia" },
		{ "Bubba", "Watson" },
		{ "Jordan", "Spieth" },
		{ "Dustin", "Johnson" },
		{ "Rickie", "Fowler" },
		{ "Annika", "Sorenstam" }
	};

	private List<string> forenames;

	private List<string> surnames;

	public void RefreshEntryColors(Color newColor)
	{
		if (Scores == null)
			return;
		foreach (var s in Scores)
		{
			if (s != null && s.isEvenNumbered)
			{
				s.SetBaggroundColor(newColor);
			}
		}
	}

	private bool ShouldRefresh()
	{
		return RuntimeStoreData.instance == null || RuntimeStoreData.instance.onlineLeaderboardType != PlatformSettings.OnlineLeaderboardType.None;
	}

	private void OnEnable()
	{
		StartCoroutine(CheckConnection());
		if (ShouldRefresh() && RefreshOnEnable)
		{
			StartRefreshLeaderboard(0.1f);
			retries = 5;
		}
	}

	private IEnumerator CheckConnection()
	{
		while (ShouldRefresh())
		{
			bool connected = LeaderboardManager.Instance != null && LeaderboardManager.Instance.IsConnected();
			if (NoConnectionText != null)
			{
				NoConnectionText.gameObject.SetActive(!connected);
			}
			yield return new WaitForSeconds(1f);
		}
	}

	private void Awake()
	{
		SetTitle();
		InitEntries();
	}

	public void InitEntries()
	{
		if (_haveEntriesBeenInitialized)
			return;
		_haveEntriesBeenInitialized = true;
		if (Scores == null)
			Scores = new List<DailyChallengeScoreEntry>();

		for (int i = 0; i < entries; i++)
		{
			if (EntryPrefab != null && EntriesRoot != null)
			{
				GameObject inst = Instantiate(EntryPrefab, EntriesRoot);
				DailyChallengeScoreEntry entry = inst.GetComponent<DailyChallengeScoreEntry>();
				if (entry != null)
				{
					entry.Clear();
					Scores.Add(entry);
					bool isEven = (i & 1) == 0;
					entry.SetBaggroundColor(isEven ? EntryColorEven : EntryColorOdd);
					if (isEven)
						entry.isEvenNumbered = true;
				}
			}
		}
	}

	private void SetTitle()
	{
		string titleId = null;
		switch (board)
		{
			case LeaderboardBoard.Completed50:
				titleId = "LEADERBOARD_TITLE_50";
				break;
			case LeaderboardBoard.Completed75:
				titleId = "LEADERBOARD_TITLE_75";
				break;
			case LeaderboardBoard.Completed100:
				titleId = "LEADERBOARD_TITLE_100";
				break;
			case LeaderboardBoard.Finished:
				titleId = "LEADERBOARD_TITLE_FINISHED";
				break;
		}
		if (titleLocalized != null && !string.IsNullOrEmpty(titleId))
		{
			titleLocalized.ChangeText(titleId);
		}
	}

	public void Reset()
	{
		if (Scores == null)
			return;
		foreach (var s in Scores)
		{
			if (s != null)
			{
				s.Clear();
				s.gameObject.SetActive(false);
			}
		}
	}

	public void StartRefreshLeaderboard(float delay = 0f)
	{
		SetTitle();
		if (ShouldRefresh())
		{
			cts?.Cancel();
			RefreshList(delay);
		}
	}

	public void RefreshInstant()
	{
		ResetEntries();
		if (LeaderboardManager.Instance != null)
		{
			LeaderboardManager.Instance.RequestLeaderboard(board, entries, GetLeaderboard);
		}
	}

	private void ResetEntries()
	{
		Reset();
		if (Scores != null && Scores.Count > 0 && Scores[0] != null)
		{
			Scores[0].gameObject.SetActive(true);
			if (Scores[0].Alpha != null)
				Scores[0].Alpha.alpha = 1f;
			Scores[0].SetData(0, "DAILY_LOADING_SCORES", -1, false, true);
		}
		if (YourBest != null)
		{
			YourBest.SetData(0, "", 0, false, false);
			if (YourBest.PositionText != null)
				YourBest.PositionText.text = "-";
			if (YourScoreArrow != null)
				YourScoreArrow.gameObject.SetActive(false);
		}
	}

	private async void RefreshList(float delay = 0f)
	{
		ResetEntries();
		if (delay > 0f)
		{
			cts = new CancellationTokenSource();
			try
			{
				await Task.Delay(TimeSpan.FromSeconds(delay), cts.Token);
			}
			catch (TaskCanceledException)
			{
				return;
			}
		}
		if (LeaderboardManager.Instance != null)
		{
			LeaderboardManager.Instance.RequestLeaderboard(board, entries, GetLeaderboard);
		}
		cts = null;
	}

	private void GetLeaderboard(bool success, List<LeaderboardEntry> leaderboard)
	{
		if (this == null || gameObject == null || !ShouldRefresh())
			return;

		if (success && leaderboard != null)
		{
			if (Scores != null)
			{
				foreach (var s in Scores)
				{
					if (s != null)
					{
						s.Clear();
						s.gameObject.SetActive(false);
					}
				}
			}
			if (isActiveAndEnabled)
			{
				StartCoroutine(ProcessLeaderboard(leaderboard));
			}
		}
		else if (!PlatformSettings.IsConsole)
		{
			if (isActiveAndEnabled && retries >= 2)
			{
				RefreshList(5f);
			}
			retries--;
		}
	}

	private IEnumerator ProcessLeaderboard(List<LeaderboardEntry> leaderboard)
	{
		if (YourBest != null)
		{
			YourBest.SetData(0, "", 0, false, false);
			if (YourBest.PositionText != null)
				YourBest.PositionText.text = "-";
			if (YourScoreArrow != null)
				YourScoreArrow.gameObject.SetActive(false);
		}

		LeaderboardEntry playerEntry = leaderboard != null ? leaderboard.FirstOrDefault(e => e != null && e.isPlayer) : null;
		bool hadPlayerEntry = playerEntry != null;

		if (!hadPlayerEntry && LeaderboardManager.Instance != null)
		{
			bool done = false;
			LeaderboardManager.Instance.RequestPlayerData(board, (succes, entry) =>
			{
				done = true;
				playerEntry = entry;
			});
			while (!done)
			{
				yield return null;
			}
		}

		if (board == LeaderboardBoard.DailyChallenge)
		{
			FillInExtras(leaderboard);
		}
		SortAndReindex(leaderboard);

		if (!hadPlayerEntry && playerEntry != null && leaderboard != null && leaderboard.Count > 0)
		{
			int maxIdx = Mathf.Min(entries, leaderboard.Count) - 1;
			int thresholdScore = maxIdx >= 0 ? leaderboard[maxIdx].score : int.MaxValue;
			if (playerEntry.score <= thresholdScore)
			{
				leaderboard.Add(playerEntry);
				SortAndReindex(leaderboard);
			}
		}

		if (YourBest != null && playerEntry != null)
		{
			YourBest.SetData(playerEntry.position + 1, null, playerEntry.score, false, false);
			if (YourScoreArrow != null)
				YourScoreArrow.gameObject.SetActive(true);
		}

		if (leaderboard != null && Scores != null)
		{
			int idx = 0;
			foreach (var item in leaderboard)
			{
				if (idx >= entries || idx >= Scores.Count)
					break;
				if (item == null || string.IsNullOrEmpty(item.name))
					continue;

				var scoreRow = Scores[idx];
				if (scoreRow != null)
				{
					scoreRow.SetData(idx + 1, item.name, item.score, item.isPlayer, false);
					scoreRow.gameObject.SetActive(true);
					int capturedIdx = idx;
					StartCoroutine(pTween.To(0.06f, t =>
					{
						if (Scores != null && capturedIdx < Scores.Count && Scores[capturedIdx] != null && Scores[capturedIdx].Alpha != null)
						{
							Scores[capturedIdx].Alpha.alpha = Mathf.Pow(t, 1.2f);
						}
					}));
				}
				if (idx % 3 == 0)
				{
					yield return new WaitForSeconds(0.01f);
				}
				idx++;
			}
		}
	}

	private void InitNameGenerator()
	{
		forenames = new List<string>();
		surnames = new List<string>();
	}

	private string GenerateName()
	{
		if (forenames == null || surnames == null)
			InitNameGenerator();

		if (forenames.Count == 0 && names != null)
		{
			int len = names.GetLength(0);
			for (int i = 0; i < len; i++)
			{
				forenames.Add(names[i, 0]);
				surnames.Add(names[i, 1]);
			}
			System.Random rng = new System.Random(DateTime.UtcNow.DayOfYear);
			forenames = forenames.OrderBy(_ => rng.Next()).ToList();
			surnames = surnames.OrderBy(_ => rng.Next()).ToList();
		}

		if (forenames.Count == 0 || surnames.Count == 0)
			return "GolfBall";

		string full = forenames[0] + " " + surnames[0];
		forenames.RemoveAt(0);
		surnames.RemoveAt(0);
		return full;
	}

	private void FillInExtras(List<LeaderboardEntry> leaderboard)
	{
		if (leaderboard == null)
			return;

		DateTime dt = LeaderboardServer.Instance != null ? LeaderboardServer.Instance.GetDateTime() : DateTime.UtcNow;
		UnityEngine.Random.InitState(dt.Year * 365 + dt.DayOfYear);
		InitNameGenerator();

		HashSet<string> generatedNames = new HashSet<string>();
		int safety = extraCount * 2;
		while (generatedNames.Count < extraCount && safety > 0)
		{
			safety--;
			string n = GenerateName();
			if (generatedNames.Contains(n))
			{
				n += UnityEngine.Random.Range(1, 100).ToString();
			}
			generatedNames.Add(n);
		}

		int minScore = (board == LeaderboardBoard.DailyChallenge) ? (CalcTotalPar() + 10) : 1000;
		int range = (board == LeaderboardBoard.DailyChallenge) ? 42 : 1000;

		for (int i = 0; i < extraCount && generatedNames.Count > 0; i++)
		{
			int score = UnityEngine.Random.Range(minScore, minScore + range);
			string chosenName = generatedNames.First();
			generatedNames.Remove(chosenName);
			leaderboard.Add(new LeaderboardEntry
			{
				name = chosenName,
				score = score
			});
		}
	}

	private int CalcTotalPar()
	{
		var pack = DailyChallenges.GetNormalPack();
		if (pack == null)
			return 20;
		var levels = pack.GetLevels();
		if (levels == null)
			return 20;

		int total = 0;
		foreach (var lvl in levels)
		{
			if (lvl != null)
			{
				int par = lvl.StrokesToPar;
				total += (par <= 0 || par > 400) ? 10 : par;
			}
		}
		return total;
	}

	private void SortAndReindex(List<LeaderboardEntry> leaderboard)
	{
		if (leaderboard == null)
			return;

		leaderboard.Sort(LeaderboardEntryComparer);
		for (int i = 0; i < leaderboard.Count; i++)
		{
			if (leaderboard[i] != null)
			{
				leaderboard[i].position = i;
			}
		}
	}

	private int LeaderboardEntryComparer(LeaderboardEntry e1, LeaderboardEntry e2)
	{
		if (e1 == null || e2 == null)
			return 0;
		float v1 = e1.score - (e1.isPlayer ? 0.5f : 0f);
		float v2 = e2.score - (e2.isPlayer ? 0.5f : 0f);
		return v1.CompareTo(v2);
	}

	public void UpdateInput(float deltaTime)
	{
		if (!isActiveAndEnabled || ScrollRect == null || ScrollRect.content == null)
			return;

		float vPos = ScrollRect.verticalNormalizedPosition;
		int vert = InputHelper.GetAllPlayerAxisRoundedVertical();
		float height = ScrollRect.content.sizeDelta.y;
		if (height <= 0.99f)
			return;

		float step = Mathf.Max(0.001f, height);
		ScrollRect.verticalNormalizedPosition = Mathf.Clamp01(vPos + deltaTime * vert * step);
	}
}
