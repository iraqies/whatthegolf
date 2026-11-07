using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;

public abstract class OverworldMusicChanger : MonoBehaviour
{
	[CompilerGenerated]
	private Action<OverworldMusicData, List<OverworldGoal>> m_OnMusicTriggered;

	public event Action<OverworldMusicData, List<OverworldGoal>> OnMusicTriggered
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public virtual void Init()
	{
	}

	public void TriggerMusic(OverworldMusicData data, List<OverworldGoal> goals)
	{
	}
}
