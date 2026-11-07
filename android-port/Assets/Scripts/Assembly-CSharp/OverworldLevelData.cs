using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class OverworldLevelData : ScriptableObject
{
	public List<OverworldLevelSection> Sections;

	public List<Sprite> SectionImages;

	public OverworldLevelSection FindSection(string name)
	{
		return null;
	}

	public void CacheCurrentState()
	{
	}
}
