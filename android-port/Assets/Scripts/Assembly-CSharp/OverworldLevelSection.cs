using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

[Serializable]
public class OverworldLevelSection
{
	public string name;

	public bool hasBoss;

	public Sprite image;

	public List<LevelData> levels;

	public string saveSpotId;

	public Transmogrif.BALLSHAPES ballShape;

	public string unlockTriggerId;

	[NonSerialized]
	public bool isAvailable;

	[NonSerialized]
	public float completionPercentage;

	public void Refresh()
	{
	}

	private bool GetIsAvailable()
	{
		return false;
	}

	private float GetCompletionPercentage()
	{
		return 0f;
	}
}
