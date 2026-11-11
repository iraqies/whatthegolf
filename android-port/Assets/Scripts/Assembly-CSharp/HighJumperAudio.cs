using System;
using UnityEngine;

public class HighJumperAudio : MonoBehaviour
{
	[SerializeField]
	private AudioClip boardClip;

	[SerializeField]
	private float basePitch = 1.2f;

	[SerializeField]
	private float incrementPitch = 0.2f;

	private HighJumper jumper;

	private int verdictIndex;

	private void Start()
	{
		jumper = GetComponent<HighJumper>();
		if (jumper != null)
		{
			HighJumper highJumper = jumper;
			highJumper.onJump = (Action)Delegate.Combine(highJumper.onJump, new Action(PlaySpringBoardSound));
		}
	}

	private void PlaySpringBoardSound()
	{
		if (AudioManager.Instance != null && AudioManager.Instance.golf != null)
		{
			AudioManager.Instance.golf.Play(boardClip, delegate
			{
			});
		}
	}
}
