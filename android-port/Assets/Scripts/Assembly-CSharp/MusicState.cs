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
		add => m_OnPlay = (Action<MusicState, bool, Action, bool>)Delegate.Combine(m_OnPlay, value);
		[CompilerGenerated]
		remove => m_OnPlay = (Action<MusicState, bool, Action, bool>)Delegate.Remove(m_OnPlay, value);
	}

	public void UpdatePlaying()
	{
		playlist?.UpdatePlaying();
	}

	public void Play(bool fromLoading, Action onLoaded = null, bool ignoreTransition = false)
	{
		lastStart = Time.unscaledTime;
		if (m_OnPlay != null)
		{
			m_OnPlay.Invoke(this, fromLoading, onLoaded, ignoreTransition);
		}
		else
		{
			if (playlist != null)
				StartCoroutine(playlist.Play(AudioSettings.dspTime, false, MusicTransition.DestinationSyncTo.EntryCue, 0.0, null));
			onLoaded?.Invoke();
		}
	}
}
