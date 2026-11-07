using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class ShowSpeechbubbleOnHit_Quest : MonoBehaviour
{
	public GameObject SpeechBubblePrefab;

	public GameObject QuestItemParticlesPrefab;

	public LevelData QuestLevelData;

	public SpeechbubbleList TextList;

	public SpeechbubbleList TextListQuestComplete;

	public QuestItemBehaviour QuestItemPrefab;

	public Transform QuestItemContainer;

	public GameObject QuestMarker;

	public Camera QuestCamera;

	public UnityEvent OnQuestCompleted;

	public List<string> ActivatorTags;

	public List<AudioClip> OnHitClip;

	public float delay;

	public float bounceFactor;

	public Vector2 bubbleDir;

	public Vector2 localBubblePivot;

	public float bubbleRotation;

	public bool ignoreActivatorTags;

	public bool UseRestartTimeLimit;

	public float ConversationRestartTimeLimit;

	public bool isAbleToTalk;

	public Transform speechBubblePreferredCenterTransform;

	public SpeechAudioBase speechAudio;

	private SpeechBubbleUI speechBubble;

	private Animator questItemBubble;

	private QuestItemBehaviour questItem;

	private bool isHandlingHit;

	private bool isInterrupted;

	private IConversation conversation;

	private float lastConversationTime;

	private bool questCompleted;

	public Animator anim;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void QuestIsCompleted()
	{
	}

	private void ListenForInterruption()
	{
	}

	private void QuestSetup()
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
