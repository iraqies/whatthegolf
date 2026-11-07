using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MusicState : MonoBehaviour
{
	[CompilerGenerated]
	private Action<MusicState, bool, Action, bool> m_OnPlay;

	public string id;

	public string stateRefId;

	public uint shortID;

	public MusicPlaylist playlist;

	public float lastStart;

	public event Action<MusicState, bool, Action, bool> OnPlay
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

	public void UpdatePlaying()
	{
	}

	public void Play(bool fromLoading, Action onLoaded = null, bool ignoreTransition = false)
	{
	}
}
