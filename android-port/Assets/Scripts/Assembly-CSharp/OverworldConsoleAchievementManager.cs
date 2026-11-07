using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class OverworldConsoleAchievementManager : GolfBehaviour
{
	[SerializeField]
	private int numberOfUniqueIds;

	[SerializeField]
	private UnlockAchievement a;

	[SerializeField]
	private List<OverworldConsole> consoles;

	private void Start()
	{
	}

	private void OnSpeechShown(SpeechbubbleList l)
	{
	}

	private string NameToID(string s)
	{
		return null;
	}
}
