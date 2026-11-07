using System;
using System.Collections;
using System.Collections.Generic;
using Audio.Multiplayer;
using UnityEngine;

public class ProgressUICharacters : MonoBehaviour
{
	[Serializable]
	public class ProgressAvatar
	{
		public PlayerColors.AvatarIDs ID;

		public GameObject GameObject;

		public float MoveSpeed;

		public Animator Animator;
	}

	public ProgressUICharacterAudio progressUIAudio;

	public AnimationCurve CharacterMoveCurve;

	public List<ProgressAvatar> LeftCharacters;

	public List<ProgressAvatar> RightCharacters;

	public List<ProgressAvatar> TopCharacters;

	public List<ProgressAvatar> BottomCharacters;

	public List<ProgressAvatar> LeftCrownAvatar;

	public List<ProgressAvatar> RightCrownAvatar;

	private List<ProgressAvatar> activeCharacters;

	private Dictionary<ProgressAvatar, Vector3> offsets;

	private bool initialized;

	public void Initialize()
	{
	}

	public void SetCharacters(List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	public IEnumerator DoWinPose(PlayerColors.AvatarIDs winID)
	{
		return null;
	}

	public IEnumerator MoveCharacters(Vector3 to)
	{
		return null;
	}

	private IEnumerator MoveCharacter(ProgressAvatar avatar, Vector3 to, Action onDone)
	{
		return null;
	}

	public void ResetCharacters()
	{
	}
}
