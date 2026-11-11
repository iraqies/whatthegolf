using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Rewired;
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
		if (holdToExitButtonImage != null)
		{
			holdToExitButtonImage.sprite = defaultButtonSprite;
		}
		if (base.transform.parent != null)
		{
			camera = base.transform.parent.GetComponentInChildren<Camera>();
			if (camera != null)
			{
				camera.transform.SetParent(base.transform);
				camera.gameObject.SetActive(false);
			}
		}
	}

	private void Start()
	{
		if (Lobby != null)
		{
			Lobby.OnMatchEnded = (Action<List<MultiplayerConfiguration.PlayerInfo>>)Delegate.Combine(Lobby.OnMatchEnded, new Action<List<MultiplayerConfiguration.PlayerInfo>>(MatchEnded));
		}
	}

	private void MatchEnded(List<MultiplayerConfiguration.PlayerInfo> players)
	{
		if (camera != null)
		{
			camera.gameObject.SetActive(true);
		}
		if (Canvas != null)
		{
			Canvas.gameObject.SetActive(true);
		}
		if (HoldToExitAnimator != null)
		{
			HoldToExitAnimator.SetBool("IsVisible", false);
		}
		if (players == null || players.Count < 2)
		{
			return;
		}
		players = players.OrderBy((MultiplayerConfiguration.PlayerInfo p) => (int)p.Side).ToList();
		if (AvatarCardsP1 != null)
		{
			foreach (AvatarCard item in AvatarCardsP1)
			{
				if (item != null && item.Card != null && players[0].Avatar != null)
				{
					item.Card.SetActive(players[0].Avatar.AvatarID == item.Avatar);
				}
			}
		}
		if (AvatarCardsP2 != null)
		{
			foreach (AvatarCard item2 in AvatarCardsP2)
			{
				if (item2 != null && item2.Card != null && players[1].Avatar != null)
				{
					item2.Card.SetActive(players[1].Avatar.AvatarID == item2.Avatar);
				}
			}
		}
		SetMatchStats(players);
		StartCoroutine(DelayStartCounting(players));
	}

	private void SetMatchStats(List<MultiplayerConfiguration.PlayerInfo> players)
	{
		if (players == null || players.Count < 2)
		{
			return;
		}
		if (WinnerNameText != null)
		{
			if (players[0].ArenaLooser)
			{
				WinnerNameText.ChangeTextAfterTranslation(players[1].DisplayName);
			}
			else if (players[1].ArenaLooser)
			{
				WinnerNameText.ChangeTextAfterTranslation(players[0].DisplayName);
			}
			else if (Localization.Instance != null)
			{
				WinnerNameText.ChangeTextAfterTranslation(Localization.Instance.GetString("ID_MULTIPLAYER_DRAW"));
			}
		}
		if (P1StrokesText != null)
		{
			P1StrokesText.text = players[0].Strokes.ToString();
		}
		if (P2StrokesText != null)
		{
			P2StrokesText.text = players[1].Strokes.ToString();
		}
		if (AllStrokesText != null)
		{
			AllStrokesText.text = (players[0].Strokes + players[1].Strokes).ToString();
		}
		if (P1TimeText != null && players[0].TimeSpent != null)
		{
			P1TimeText.text = ToElapsedString(players[0].TimeSpent.Elapsed);
		}
		if (P2TimeText != null && players[1].TimeSpent != null)
		{
			P2TimeText.text = ToElapsedString(players[1].TimeSpent.Elapsed);
		}
		if (AllTimeText != null && players[0].TimeSpent != null && players[1].TimeSpent != null)
		{
			AllTimeText.text = ToElapsedString(players[0].TimeSpent.Elapsed + players[1].TimeSpent.Elapsed);
		}
		if (StatsPanelImage != null)
		{
			PlayerColors.AvatarData avatarData = (players[0].ArenaLooser ? players[1].Avatar : players[0].Avatar);
			if (avatarData != null)
			{
				StatsPanelImage.color = avatarData.IntroBackgroundColor + new Color(0f, 0f, 0f, 1f);
			}
		}
		if (Localization.Instance != null)
		{
			string @string = Localization.Instance.GetString("ID_MULTIPLAYER_PLAYER_STROKES");
			if (P1StrokeLabel != null)
			{
				P1StrokeLabel.ChangeTextAfterTranslation(string.Format(@string, players[0].DisplayName));
			}
			if (P2StrokeLabel != null)
			{
				P2StrokeLabel.ChangeTextAfterTranslation(string.Format(@string, players[1].DisplayName));
			}
			string string2 = Localization.Instance.GetString("ID_MULTIPLAYER_PLAYER_TIME");
			if (P1TimeLabel != null)
			{
				P1TimeLabel.ChangeTextAfterTranslation(string.Format(string2, players[0].DisplayName));
			}
			if (P2TimeLabel != null)
			{
				P2TimeLabel.ChangeTextAfterTranslation(string.Format(string2, players[1].DisplayName));
			}
		}
	}

	private static string ToElapsedString(TimeSpan ts)
	{
		return ts.Hours.ToString("00") + ":" + ts.Minutes.ToString("00") + ":" + ts.Seconds.ToString("00");
	}

	private IEnumerator DelayStartCounting(List<MultiplayerConfiguration.PlayerInfo> players)
	{
		yield return new WaitForSeconds(1f);
		if (players != null && players.Count >= 2)
		{
			if (players[0].ArenaLooser)
			{
				FinishCounting("WinP2");
			}
			else if (players[1].ArenaLooser)
			{
				FinishCounting("WinP1");
			}
			else
			{
				Debug.LogWarning("No winner found, this should not be possible!");
			}
		}
		yield return new WaitForSeconds(1.25f);
		if (HoldToExitAnimator != null)
		{
			HoldToExitAnimator.SetBool("IsVisible", true);
			HoldToExitAnimator.SetFloat("HoldTime", 0f);
		}
		float holdTimer = 0f;
		while (holdTimer < 1.25f)
		{
			bool flag = false;
			if (ReInput.players != null)
			{
				foreach (Player allPlayer in ReInput.players.AllPlayers)
				{
					if (allPlayer != null && (allPlayer.GetButton("Mouse Shoot") || allPlayer.GetButton("Shoot") || allPlayer.GetButton("Confirm UI")))
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				holdTimer += Time.deltaTime;
				if (HoldToExitAnimator != null)
				{
					HoldToExitAnimator.SetBool("Holding", true);
				}
			}
			else
			{
				holdTimer -= Time.deltaTime;
				if (holdTimer < 0f)
				{
					holdTimer = 0f;
					if (HoldToExitAnimator != null)
					{
						HoldToExitAnimator.SetBool("Holding", false);
					}
				}
			}
			if (HoldToExitAnimator != null)
			{
				HoldToExitAnimator.SetFloat("HoldTime", holdTimer / 1.25f);
			}
			yield return null;
		}
		if (HoldToExitAnimator != null)
		{
			HoldToExitAnimator.SetTrigger("FinishedHolding");
		}
		yield return null;
		if (HoldToExitAnimator != null)
		{
			HoldToExitAnimator.SetBool("Holding", false);
			HoldToExitAnimator.SetBool("IsVisible", false);
		}
		if (Lobby != null)
		{
			Lobby.WinSequenceFinished();
		}
		if (camera != null)
		{
			camera.gameObject.SetActive(false);
		}
		if (Canvas != null)
		{
			Canvas.gameObject.SetActive(false);
		}
	}

	private IEnumerator CountStats(MultiplayerConfiguration.PlayerInfo player, TextMeshProUGUI textField, Action onDone)
	{
		if (player == null)
		{
			yield break;
		}
		int count = 0;
		WaitForSeconds wait = new WaitForSeconds(1f / Mathf.Max(1f, player.Strokes));
		while (count < player.Strokes)
		{
			count++;
			if (textField != null)
			{
				textField.text = count.ToString();
			}
			yield return wait;
		}
		onDone?.Invoke();
	}

	public void FinishCounting(string trigger)
	{
		if (Animator != null)
		{
			Animator.SetTrigger(trigger);
		}
	}
}
