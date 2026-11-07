using System;
using System.Collections.Generic;
using UnityEngine;

public class IntroSequence : MonoBehaviour
{
	[Serializable]
	public class IntroSequenceCharacter
	{
		public PlayerColors.AvatarIDs ID;

		public GameObject UIContainer;

		public GameObject Name;
	}

	public MultiplayerLobby Lobby;

	public Animator SequenceAnimator;

	public List<IntroSequenceCharacter> LeftCharacters;

	public List<IntroSequenceCharacter> RightCharacters;

	public SVGImage LeftBackground;

	public SVGImage RightBackground;

	public Canvas Canvas;

	public Action OnSequenceStarting;

	public Action OnSequenceEnding;

	private bool firstLevel;

	private void Awake()
	{
	}

	private void OnLevelStarted(List<MultiplayerConfiguration.PlayerInfo> obj)
	{
	}

	private void OnMatchStarting(List<MultiplayerLobby.LobbyPlayer> players)
	{
	}
}
