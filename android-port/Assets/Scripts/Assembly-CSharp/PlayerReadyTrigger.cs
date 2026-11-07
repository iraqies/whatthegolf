using UnityEngine;
using UnityEngine.Events;

public class PlayerReadyTrigger : MonoBehaviour
{
	private MultiplayerPlayList _playlist;

	private UnityAction<MultiplayerPlayList, int> _onPlayerReady;

	private UnityAction<MultiplayerPlayList, int> _onPlayerUnready;

	public void Configure(MultiplayerPlayList playlist, UnityAction<MultiplayerPlayList, int> onPlayerReady, UnityAction<MultiplayerPlayList, int> onPlayerUnready)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
