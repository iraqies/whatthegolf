using System;
using System.Collections;
using System.Collections.Generic;
using CameraStack;
using Core;
using UnityEngine;

public class ShowSpeechbubbleOnHit : ShowSpeechBubble
{
	public SpeechbubbleList TextList;
	public List<string> ActivatorTags;
	public List<AudioClip> OnHitClip;
	public float delay;
	public float bounceFactor = 0.5f;
	public Vector2 bubbleDir;
	public Vector2 localBubblePivot;
	public float bubbleRotation;
	public bool ignoreActivatorTags;
	public bool UseRestartTimeLimit;
	public float ConversationRestartTimeLimit = 10f;
	public bool isAbleToTalk = true;
	public Transform speechBubblePreferredCenterTransform;
	public Action onHit;
	private IConversation conversation;
	private float lastConversationTime;

	public bool textDisplayed { get; set; }

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (!isAbleToTalk || other == null)
			return;
		if (TextList == null && conversation == null)
			return;
		if (!ignoreActivatorTags && ActivatorTags != null && ActivatorTags.Count > 0)
		{
			if (other.gameObject == null || !ActivatorTags.Contains(other.gameObject.tag))
				return;
		}
		StartCoroutine(HandleHit());
		if (other.rigidbody != null)
			other.rigidbody.velocity *= bounceFactor;
	}

	public void ResetConversation()
	{
		if (TextList != null)
		{
			conversation = TextList.NewConversation();
			lastConversationTime = Time.realtimeSinceStartup;
		}
	}

	public void Interrupt()
	{
		IsInterrupted = true;
	}

	public void ForceStartSpeechBubble()
	{
		StartCoroutine(HandleHit());
	}

	public void ShowBubble() => ForceStartSpeechBubble();

	public IEnumerator HandleHit(Action onDone = null, Action onTextShown = null, Func<string, string> OnPreprocessText = null)
	{
		if (IsHandlingHit)
			yield break;
		onHit?.Invoke();
		IsHandlingHit = true;
		if (delay > 0f)
			yield return new WaitForSeconds(delay);

		if (OverworldCamera.Instance != null)
			OverworldCamera.Instance.Shake(0.25f, 25f, 0.1f);
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && OnHitClip != null && OnHitClip.Count > 0)
			AudioManager.Instance.sfx.Play(OnHitClip);

		if (SpeechBubblePrefab != null)
		{
			GameObject go = null;
			if (GameObjectPool.Instance != null)
				go = GameObjectPool.Instance.Pop(SpeechBubblePrefab);
			if (go == null)
				go = Instantiate(SpeechBubblePrefab);
			if (go != null)
				SpeechBubble = go.GetComponent<SpeechBubbleUI>();
		}

		float rot = bubbleRotation;
		var section = GetComponentInParent<HubSection>();
		if (section != null && section.shouldRotateTilesForMobile && PlatformSettings.Instance != null)
		{
			var cur = PlatformSettings.Instance.GetCurrent();
			if (cur != null && cur.useRotatedOverworldAndCameraInLevels && Mathf.Abs(rot) < 1f)
				rot = -90f;
		}
		if (SpeechBubble != null)
			SpeechBubble.transform.rotation = Quaternion.Euler(0f, 0f, rot);

		float now = Time.realtimeSinceStartup;
		if (conversation == null || (UseRestartTimeLimit && now - lastConversationTime > ConversationRestartTimeLimit))
		{
			if (TextList != null)
			{
				conversation = TextList.NewConversation();
				lastConversationTime = now;
			}
		}

		var textInfo = conversation != null ? conversation.GetText() : null;
		if (anim != null && textInfo != null && !textInfo.DontPlayTalkAnimation)
			anim.SetBool("Talking", true);

		if (textInfo != null)
		{
			lastConversationTime = Time.realtimeSinceStartup;
			Vector2? prefPos = null;
			if (speechBubblePreferredCenterTransform != null)
				prefPos = speechBubblePreferredCenterTransform.position;
			IsInterrupted = false;
			if (!string.IsNullOrEmpty(textInfo.ID) && SpeechBubble != null)
			{
				Vector3 worldPivot = transform.TransformPoint(new Vector3(localBubblePivot.x, localBubblePivot.y, 0f));
				Camera cam = OverworldCamera.Instance != null ? OverworldCamera.Instance.MainCamera : Camera.main;
				var task = SpeechBubble.Show(
					textInfo.ID,
					new Vector2(worldPivot.x, worldPivot.y),
					prefPos,
					cam,
					bubbleDir,
					textInfo.isLocalized,
					OnPreprocessText
				);
				while (task != null && !task.isDone && !IsInterrupted)
				{
					if (speechAudio != null)
						speechAudio.UpdateSpeech();
					yield return null;
				}
			}
			onTextShown?.Invoke();
			if (anim != null && !textInfo.DontPlayTalkAnimation)
				anim.SetBool("Talking", false);
			while (!IsInterrupted && SpeechBubble != null && SpeechBubble.gameObject.activeSelf)
			{
				yield return null;
			}
			if (SpeechBubble != null)
				SpeechBubble.Hide(true);
		}

		PoolSpeechBubble();
		onDone?.Invoke();
		IsHandlingHit = false;
		textDisplayed = true;
	}

	public void SetState(bool state)
	{
		isAbleToTalk = state;
	}

	private void OnDrawGizmos()
	{
	}

	public void SetConversation(IConversation conv)
	{
		conversation = conv;
	}
}
