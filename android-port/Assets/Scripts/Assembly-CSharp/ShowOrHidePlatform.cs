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
	}

	private void ToggleVisibility()
	{
	}
}
