using Audio;
using UnityEngine;

public class ShowSpeechBubble : MonoBehaviour
{
	[SerializeField]
	protected GameObject SpeechBubblePrefab;

	[SerializeField]
	protected Animator anim;

	[SerializeField]
	protected SpeechAudioBase speechAudio;

	protected SpeechBubbleUI SpeechBubble;

	public bool IsInterrupted;

	protected bool IsHandlingHit;

	protected virtual void Start()
	{
	}

	private void ListenForInterruption()
	{
	}

	protected void PoolSpeechBubble()
	{
	}
}
