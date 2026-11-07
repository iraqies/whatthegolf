using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaCharacters : MonoBehaviour
{
	[Serializable]
	public class ProgressAvatar
	{
		public PlayerColors.AvatarIDs ID;

		public Animator Animator;
	}

	public Animator SequenceAnimator;

	public List<ProgressAvatar> Player1Characters;

	public List<ProgressAvatar> Player2Characters;

	public List<ProgressAvatar> Player3Characters;

	public List<ProgressAvatar> Player4Characters;

	public Animator[] AnimatorsP1;

	public Animator[] AnimatorsP2;

	public Animator[] AnimatorsP3;

	public Animator[] AnimatorsP4;

	public float PreDelay;

	public float DelayBetweenCharacters;

	public bool OnlyRandomCharacter;

	private List<ProgressAvatar> allCharacters;

	public int DebugCharacter;

	public void Init(List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	public void StartSequence()
	{
	}

	private void DebugSequence()
	{
	}

	private IEnumerator DoAction()
	{
		return null;
	}

	private IEnumerator CharacterAnimationsRoutine()
	{
		return null;
	}
}
