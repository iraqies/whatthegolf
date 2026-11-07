using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WinSequence : MonoBehaviour
{
	[Serializable]
	public class AvatarCard
	{
		public GameObject Card;

		public PlayerColors.AvatarIDs Avatar;
	}

	public List<AvatarCard> AvatarCardsP1;

	public List<AvatarCard> AvatarCardsP2;

	public Animator Animator;

	public MultiplayerLobby Lobby;

	public Canvas Canvas;

	private Camera camera;

	public Animator HoldToExitAnimator;

	public Image StatsPanelImage;

	public TextMeshProLocalized WinnerNameText;

	public TextMeshProUGUI P1StrokesText;

	public TextMeshProUGUI P2StrokesText;

	public TextMeshProUGUI AllStrokesText;

	public TextMeshProUGUI P1TimeText;

	public TextMeshProUGUI P2TimeText;

	public TextMeshProUGUI AllTimeText;

	public TextMeshProLocalized P1TimeLabel;

	public TextMeshProLocalized P2TimeLabel;

	public TextMeshProLocalized P1StrokeLabel;

	public TextMeshProLocalized P2StrokeLabel;

	public Sprite defaultButtonSprite;

	public Sprite playstationButtonSprite;

	public SVGImage holdToExitButtonImage;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void MatchEnded(List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	private void SetMatchStats(List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	private IEnumerator DelayStartCounting(List<MultiplayerConfiguration.PlayerInfo> players)
	{
		return null;
	}

	private IEnumerator CountStats(MultiplayerConfiguration.PlayerInfo player, TextMeshProUGUI textField, Action onDone)
	{
		return null;
	}

	public void FinishCounting(string trigger)
	{
	}
}
