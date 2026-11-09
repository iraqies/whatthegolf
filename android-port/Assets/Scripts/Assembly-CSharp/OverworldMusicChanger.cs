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
		add => m_OnMusicTriggered = (Action<OverworldMusicData, List<OverworldGoal>>)Delegate.Combine(m_OnMusicTriggered, value);
		[CompilerGenerated]
		remove => m_OnMusicTriggered = (Action<OverworldMusicData, List<OverworldGoal>>)Delegate.Remove(m_OnMusicTriggered, value);
	}

	public virtual void Init()
	{
	}

	public void TriggerMusic(OverworldMusicData data, List<OverworldGoal> goals)
	{
		m_OnMusicTriggered?.Invoke(data, goals);
		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null && OverworldManager2d.Instance.overworldMusic != null && data != null)
		{
			OverworldManager2d.Instance.overworldMusic.StartWithoutTransition(data);
		}
	}
}
