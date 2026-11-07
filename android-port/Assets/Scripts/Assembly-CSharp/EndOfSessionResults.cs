using System.Collections.Generic;
using UnityEngine;

public class EndOfSessionResults : MonoBehaviour
{
	public TextMeshProLocalized WinnerLabel;

	public List<TextMeshProLocalized> WinnerScore;

	private void Awake()
	{
	}

	private void AnnounceWinner(MultiplayerLevelInfo info)
	{
	}
}
