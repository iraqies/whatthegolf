using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class ShowSpeechbubbleOnHit_Conversation : MonoBehaviour
{
	[Serializable]
	public class Participant
	{
		public string name;

		public Transform transform;

		public Animator animator;

		public List<AudioClip> OnHitClip;

		public Vector2 bubbleDir;

		public Vector2 bubbleOffset;
	}

	public GameObject SpeechBubblePrefab;

	public SpeechbubbleList TextList;

	public float DelayBeforeStopTalkAnimation;

	public List<string> ActivatorTags;

	public List<AudioClip> OnHitClip;

	public float delay;

	public float bounceFactor;

	public bool hasPriority;

	public bool getCameraFocus;

	public List<Participant> participants;

	public List<int> conversationLines;

	public float bubbleRotation;

	public bool ignoreActivatorTags;

	public bool UseRestartTimeLimit;

	public float ConversationRestartTimeLimit;

	public bool isAbleToTalk;

	public Transform speechBubblePreferredCenterTransform;

	public SpeechAudioBase speechAudio;

	private SpeechBubbleUI speechBubble;

	private bool isHandlingHit;

	private bool isInterrupted;

	private IConversation conversation;

	private float lastConversationTime;

	private Participant currentParticipant;

	private Animator m_anim;

	private int m_conversationIndex;

	private bool m_isLooping;

	private void Awake()
	{
	}

	private void OnValidate()
	{
	}

	private void ListenForInterruption()
	{
	}

	private void OnParticleCollision(GameObject other)
	{
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	public void ResetConversation()
	{
	}

	public void Interrupt()
	{
	}

	public void ForceStartSpeechBubble()
	{
	}

	public IEnumerator HandleHit(Action onDone = null, Action onTextShown = null, Func<string, string> OnPreprocessText = null)
	{
		return null;
	}

	private IEnumerator StopTalkingAnimation()
	{
		return null;
	}

	public void SetState(bool state)
	{
	}

	private void PoolSpeechBubble()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
