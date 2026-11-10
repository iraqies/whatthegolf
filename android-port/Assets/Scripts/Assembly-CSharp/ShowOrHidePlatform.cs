using System.Collections.Generic;
using UnityEngine;

public class ShowOrHidePlatform : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> toHide;

	[SerializeField]
	private List<GameObject> replaceBy;

	public bool isForAchievements;

	public bool isForLeaderboards;

	private void Start()
	{
		ToggleVisibility();
	}

	private void ToggleVisibility()
	{
		if (RuntimeStoreData.instance == null)
		{
			return;
		}
		bool hide = false;
		if (isForAchievements && !RuntimeStoreData.instance.supportsAchievements)
		{
			hide = true;
		}
		if (isForLeaderboards && RuntimeStoreData.instance.onlineLeaderboardType == PlatformSettings.OnlineLeaderboardType.None)
		{
			hide = true;
		}
		if (!hide)
		{
			return;
		}
		if (toHide != null)
		{
			for (int i = 0; i < toHide.Count; i++)
			{
				if (toHide[i] != null)
				{
					toHide[i].SetActive(false);
				}
			}
		}
		if (replaceBy != null)
		{
			for (int j = 0; j < replaceBy.Count; j++)
			{
				if (replaceBy[j] != null)
				{
					replaceBy[j].SetActive(true);
				}
			}
		}
	}
}
