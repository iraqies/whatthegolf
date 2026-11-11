using Core;
using UnityEngine;
using UnityEngine.Events;

public class PlayerReadyTrigger : MonoBehaviour
{
	private MultiplayerPlayList _playlist;

	private UnityAction<MultiplayerPlayList, int> _onPlayerReady;

	private UnityAction<MultiplayerPlayList, int> _onPlayerUnready;

	public void Configure(MultiplayerPlayList playlist, UnityAction<MultiplayerPlayList, int> onPlayerReady, UnityAction<MultiplayerPlayList, int> onPlayerUnready)
	{
		_playlist = playlist;
		_onPlayerReady = onPlayerReady;
		_onPlayerUnready = onPlayerUnready;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null)
		{
			return;
		}
		GolfBallController ctrl = other.GetComponentInParent<GolfBallController>();
		if (ctrl != null)
		{
			_onPlayerReady?.Invoke(_playlist, ctrl.PlayerIndex);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other == null)
		{
			return;
		}
		GolfBallController ctrl = other.GetComponentInParent<GolfBallController>();
		if (ctrl != null)
		{
			_onPlayerUnready?.Invoke(_playlist, ctrl.PlayerIndex);
		}
	}
}
