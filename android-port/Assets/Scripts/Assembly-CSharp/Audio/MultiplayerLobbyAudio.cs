using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200133B")]
	public class MultiplayerLobbyAudio : MonoBehaviour
	{
		[Token(Token = "0x40066DE")]
		[FieldOffset(Offset = "0x18")]
		public AudioEventAsset sfxOnPlayerJoin;

		[Token(Token = "0x40066DF")]
		[FieldOffset(Offset = "0x20")]
		public AudioEventAsset sfxOnPlayerDisconnected;

		[Token(Token = "0x40066E0")]
		[FieldOffset(Offset = "0x28")]
		public AudioEventAsset sfxOnPlayerReady;

		[Token(Token = "0x40066E1")]
		[FieldOffset(Offset = "0x30")]
		public AudioEventAsset sfxOnPlayerUnready;

		[Token(Token = "0x40066E2")]
		[FieldOffset(Offset = "0x38")]
		public AudioEventAsset sfxOnStartingEndSequence;

		[Token(Token = "0x40066E3")]
		[FieldOffset(Offset = "0x40")]
		public AudioClipSettings sfxOnCountdownTick;

		[Token(Token = "0x40066E4")]
		[FieldOffset(Offset = "0x48")]
		public AmbientAudio endSequenceAmbience;

		[Token(Token = "0x40066E5")]
		[FieldOffset(Offset = "0x50")]
		private MultiplayerLobby lobby;

		[Token(Token = "0x40066E6")]
		[FieldOffset(Offset = "0x58")]
		private List<AmbientAudio> ambience;

		[Token(Token = "0x60059AF")]
		[Address(RVA = "0x15823E0", Offset = "0x15823E0", VA = "0x15823E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60059B0")]
		[Address(RVA = "0x1582860", Offset = "0x1582860", VA = "0x1582860")]
		private void OnStartingEndSequence()
		{
		}

		[Token(Token = "0x60059B1")]
		[Address(RVA = "0x15829A4", Offset = "0x15829A4", VA = "0x15829A4")]
		private void OnMatchEnded(List<MultiplayerConfiguration.PlayerInfo> obj)
		{
		}

		[Token(Token = "0x60059B2")]
		[Address(RVA = "0x15829E0", Offset = "0x15829E0", VA = "0x15829E0")]
		private void OnCountdownTick(int id)
		{
		}

		[Token(Token = "0x60059B3")]
		[Address(RVA = "0x1582A18", Offset = "0x1582A18", VA = "0x1582A18")]
		private void OnPlayerJoin(MultiplayerLobby.LobbyPlayer player)
		{
		}

		[Token(Token = "0x60059B4")]
		[Address(RVA = "0x1582A60", Offset = "0x1582A60", VA = "0x1582A60")]
		private void OnPlayerDisconnected(MultiplayerLobby.LobbyPlayer player)
		{
		}

		[Token(Token = "0x60059B5")]
		[Address(RVA = "0x1582AA8", Offset = "0x1582AA8", VA = "0x1582AA8")]
		private void OnPlayerReady(MultiplayerLobby.LobbyPlayer player)
		{
		}

		[Token(Token = "0x60059B6")]
		[Address(RVA = "0x1582AF0", Offset = "0x1582AF0", VA = "0x1582AF0")]
		private void OnPlayerUnready(MultiplayerLobby.LobbyPlayer player)
		{
		}

		[Token(Token = "0x60059B7")]
		[Address(RVA = "0x1582B38", Offset = "0x1582B38", VA = "0x1582B38")]
		public MultiplayerLobbyAudio()
		{
		}
	}
}
