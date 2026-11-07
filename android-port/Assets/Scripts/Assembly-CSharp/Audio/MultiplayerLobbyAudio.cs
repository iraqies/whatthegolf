using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class MultiplayerLobbyAudio : MonoBehaviour
	{
		public AudioEventAsset sfxOnPlayerJoin;

		public AudioEventAsset sfxOnPlayerDisconnected;

		public AudioEventAsset sfxOnPlayerReady;

		public AudioEventAsset sfxOnPlayerUnready;

		public AudioEventAsset sfxOnStartingEndSequence;

		public AudioClipSettings sfxOnCountdownTick;

		public AmbientAudio endSequenceAmbience;

		private MultiplayerLobby lobby;

		private List<AmbientAudio> ambience;

		private void Awake()
		{
		}

		private void OnStartingEndSequence()
		{
		}

		private void OnMatchEnded(List<MultiplayerConfiguration.PlayerInfo> obj)
		{
		}

		private void OnCountdownTick(int id)
		{
		}

		private void OnPlayerJoin(MultiplayerLobby.LobbyPlayer player)
		{
		}

		private void OnPlayerDisconnected(MultiplayerLobby.LobbyPlayer player)
		{
		}

		private void OnPlayerReady(MultiplayerLobby.LobbyPlayer player)
		{
		}

		private void OnPlayerUnready(MultiplayerLobby.LobbyPlayer player)
		{
		}
	}
}
