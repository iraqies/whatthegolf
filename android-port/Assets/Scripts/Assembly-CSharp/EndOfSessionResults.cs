using System.Collections.Generic;
using System.Linq;
using Core;
using TMPro;
using UnityEngine;

public class EndOfSessionResults : MonoBehaviour
{
	public TextMeshProLocalized WinnerLabel;

	public List<TextMeshProLocalized> WinnerScore;

	private void Awake()
	{
		if (Level.Instance != null)
		{
			Level.Instance.OnMultiplayerSetup += AnnounceWinner;
		}
	}

	private void AnnounceWinner(MultiplayerLevelInfo info)
	{
		MultiplayerConfiguration config = Level.Instance != null ? Level.Instance.GetMultiplayerConfiguration() : null;
		if (config == null || config.Players == null || config.Players.Count == 0)
		{
			return;
		}
		int maxPoints = config.Players.Max(p => p != null ? p.Points : 0);
		List<MultiplayerConfiguration.PlayerInfo> winners = config.Players.Where(p => p != null && p.Points == maxPoints).ToList();
		if (WinnerLabel != null)
		{
			WinnerLabel.ChangeText(winners.Count > 1 ? "WINNERS!" : "WINNER!");
		}
		if (WinnerScore != null)
		{
			for (int i = 0; i < winners.Count && i < WinnerScore.Count; i++)
			{
				if (WinnerScore[i] != null)
				{
					WinnerScore[i].gameObject.SetActive(true);
					TMP_Text tmp = WinnerScore[i].GetComponent<TMP_Text>();
					if (tmp != null)
					{
						if (winners[i].Avatar != null)
						{
							tmp.color = winners[i].Avatar.BaseColor;
						}
						tmp.text = winners[i].DisplayName;
					}
				}
			}
		}
	}
}
