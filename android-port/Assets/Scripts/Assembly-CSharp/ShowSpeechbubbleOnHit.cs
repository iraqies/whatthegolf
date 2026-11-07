using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSpeechbubbleOnHit : ShowSpeechBubble
{
	public SpeechbubbleList TextList;

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

	public Action onHit;

	private IConversation conversation;

	private float lastConversationTime;

	public bool textDisplayed { get; set; }

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

	private void OnDrawGizmos()
	{
	}

	public void SetConversation(IConversation conv)
	{
	}
}
