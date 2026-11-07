using UnityEngine;

public class HighJumperAudio : MonoBehaviour
{
	[SerializeField]
	private AudioClip boardClip;

	[SerializeField]
	private float basePitch;

	[SerializeField]
	private float incrementPitch;

	private HighJumper jumper;

	private int verdictIndex;

	private void Start()
	{
	}

	private void PlaySpringBoardSound()
	{
	}
}
