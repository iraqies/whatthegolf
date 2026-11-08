using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public class OverworldLevelData : ScriptableObject
{
	public List<OverworldLevelSection> Sections;
	public List<Sprite> SectionImages;

	public OverworldLevelSection FindSection(string name)
	{
		if (Sections == null) return null;
		return Sections.FirstOrDefault(s => s != null && s.name == name);
	}

	public void CacheCurrentState()
	{
		if (Sections == null) return;
		for (int i = 0; i < Sections.Count; i++)
		{
			Sections[i]?.Refresh();
		}
	}
}
