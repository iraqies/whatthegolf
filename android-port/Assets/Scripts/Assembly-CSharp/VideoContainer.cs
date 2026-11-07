using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class VideoContainer : MonoBehaviour
{
	[SerializeField]
	private GameObject _defaultVideoPlayerRoot;

	[SerializeField]
	private VideoPlayer _defaultVideoPlayer;

	[SerializeField]
	private WorkingSwitchVideoPlayer _switchVideoPlayer;

	private UnityEvent _onEndReached;

	public bool isPlaying => false;

	public void Play(string url, Camera camera, bool loop, UnityAction onEndReached = null, VideoClip videoClip = null)
	{
	}

	private void ErrorReceived(VideoPlayer source, string message)
	{
	}

	private void LoopReached(VideoPlayer source)
	{
	}

	private void LoopReachedSwitch()
	{
	}

	public void Stop()
	{
	}
}
