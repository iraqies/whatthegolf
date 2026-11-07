using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class MultiplayerLevelCountdown : MonoBehaviour
{
	[SerializeField]
	private MultiplayerLobby Lobby;

	[SerializeField]
	private Transform AnimatorsParent;

	public ClipSettingsCollection BlobPopInClip;

	public float OutroTime;

	public float CircleStartRadius;

	public float AnimationSpeed;

	private CountdownAnimator[] animators;

	private bool beepPlayed;

	private List<SphericalGrayscaleEffect> greyScale;

	private List<Camera> newCams;

	private TimeControl timeControl;

	private QuickMenu quickMenu;

	private List<MultiplayerConfiguration.PlayerInfo> players;

	private void Start()
	{
	}

	private void OnBeep()
	{
	}

	private void OnLastBeep()
	{
	}

	private void OnLevelStarted(List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	private void SetupGreyScaleCameraForPlayer(MultiplayerConfiguration.PlayerInfo player, bool addOffset)
	{
	}

	private IEnumerator Countdown(List<MultiplayerConfiguration.PlayerInfo> players)
	{
		return null;
	}
}
