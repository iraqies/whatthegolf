using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using CameraStack;
using Core;
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
	public float bounceFactor = 0.5f;
	public bool hasPriority;
	public bool getCameraFocus;
	public List<Participant> participants;
	public List<int> conversationLines;
	public float bubbleRotation;
	public bool ignoreActivatorTags;
	public bool UseRestartTimeLimit;
	public float ConversationRestartTimeLimit = 10f;
	public bool isAbleToTalk = true;
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
		m_anim = GetComponent<Animator>();
		if (speechAudio == null)
			speechAudio = GetComponent<SpeechAudioBase>();
		ListenForInterruption();
	}

	private void OnValidate()
	{
	}

	private void ListenForInterruption()
	{
		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.OnShoot += Interrupt;
			OverworldManager2d.Instance.OnLevelStarting = (Action<List<LevelData>>)Delegate.Combine(OverworldManager2d.Instance.OnLevelStarting, new Action<List<LevelData>>(_ => Interrupt()));
			OverworldManager2d.Instance.OnToggleOverworld += active =>
			{
				if (!active && speechBubble != null)
				{
					speechBubble.Hide(false);
					PoolSpeechBubble();
					isHandlingHit = false;
				}
			};
		}
	}

	private void OnParticleCollision(GameObject other)
	{
		if (isAbleToTalk)
			StartCoroutine(HandleHit());
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (!isAbleToTalk || other == null) return;
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
			m_conversationIndex = 0;
		}
	}

	public void Interrupt()
	{
		isInterrupted = true;
	}

	public void ForceStartSpeechBubble()
	{
		StartCoroutine(HandleHit());
	}

	public IEnumerator HandleHit(Action onDone = null, Action onTextShown = null, Func<string, string> OnPreprocessText = null)
	{
		if (isHandlingHit)
			yield break;
		isHandlingHit = true;
		if (delay > 0f)
			yield return new WaitForSeconds(delay);

		if (OverworldCamera.Instance != null)
			OverworldCamera.Instance.Shake(0.25f, 25f, 0.1f);
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && OnHitClip != null && OnHitClip.Count > 0)
			AudioManager.Instance.sfx.Play(OnHitClip);

		if (SpeechBubblePrefab != null)
		{
			GameObject go = GameObjectPool.Instance != null ? GameObjectPool.Instance.Pop(SpeechBubblePrefab) : null;
			if (go == null)
				go = Instantiate(SpeechBubblePrefab);
			if (go != null)
				speechBubble = go.GetComponent<SpeechBubbleUI>();
		}

		float rot = bubbleRotation;
		var section = GetComponentInParent<HubSection>();
		if (section != null && section.shouldRotateTilesForMobile && PlatformSettings.Instance != null)
		{
			var cur = PlatformSettings.Instance.GetCurrent();
			if (cur != null && cur.useRotatedOverworldAndCameraInLevels && Mathf.Abs(rot) < 1f)
				rot = -90f;
		}
		if (speechBubble != null)
			speechBubble.transform.rotation = Quaternion.Euler(0f, 0f, rot);

		float now = Time.realtimeSinceStartup;
		if (conversation == null || (UseRestartTimeLimit && now - lastConversationTime > ConversationRestartTimeLimit))
		{
			if (TextList != null)
			{
				conversation = TextList.NewConversation();
				lastConversationTime = now;
				m_conversationIndex = 0;
			}
		}

		var textInfo = conversation != null ? conversation.GetText() : null;
		currentParticipant = null;
		if (participants != null && participants.Count > 0)
		{
			int pIdx = 0;
			if (conversationLines != null && m_conversationIndex < conversationLines.Count)
				pIdx = Mathf.Clamp(conversationLines[m_conversationIndex], 0, participants.Count - 1);
			else
				pIdx = m_conversationIndex % participants.Count;
			currentParticipant = participants[pIdx];
			m_conversationIndex++;
		}

		Animator activeAnim = currentParticipant != null && currentParticipant.animator != null ? currentParticipant.animator : m_anim;
		if (activeAnim != null && textInfo != null && !textInfo.DontPlayTalkAnimation)
			activeAnim.SetBool("Talking", true);

		if (textInfo != null && speechBubble != null && !string.IsNullOrEmpty(textInfo.ID))
		{
			lastConversationTime = Time.realtimeSinceStartup;
			Vector2? prefPos = speechBubblePreferredCenterTransform != null ? (Vector2?)speechBubblePreferredCenterTransform.position : null;
			Transform spkTrans = currentParticipant != null && currentParticipant.transform != null ? currentParticipant.transform : transform;
			Vector2 offset = currentParticipant != null ? currentParticipant.bubbleOffset : Vector2.zero;
			Vector2 dir = currentParticipant != null && currentParticipant.bubbleDir.sqrMagnitude > 0.001f ? currentParticipant.bubbleDir : Vector2.up;
			Vector3 worldPivot = spkTrans.TransformPoint(new Vector3(offset.x, offset.y, 0f));
			Camera cam = OverworldCamera.Instance != null ? OverworldCamera.Instance.MainCamera : Camera.main;

			isInterrupted = false;
			var task = speechBubble.Show(textInfo.ID, new Vector2(worldPivot.x, worldPivot.y), prefPos, cam, dir, textInfo.isLocalized, OnPreprocessText);
			while (task != null && !task.isDone && !isInterrupted)
			{
				if (speechAudio != null)
					speechAudio.UpdateSpeech();
				yield return null;
			}
			onTextShown?.Invoke();
			if (activeAnim != null && !textInfo.DontPlayTalkAnimation)
				StartCoroutine(StopTalkingAnimation());
			while (!isInterrupted && speechBubble != null && speechBubble.gameObject.activeSelf)
			{
				yield return null;
			}
			if (speechBubble != null)
				speechBubble.Hide(true);
		}

		PoolSpeechBubble();
		onDone?.Invoke();
		isHandlingHit = false;
	}

	private IEnumerator StopTalkingAnimation()
	{
		if (DelayBeforeStopTalkAnimation > 0f)
			yield return new WaitForSeconds(DelayBeforeStopTalkAnimation);
		Animator activeAnim = currentParticipant != null && currentParticipant.animator != null ? currentParticipant.animator : m_anim;
		if (activeAnim != null)
			activeAnim.SetBool("Talking", false);
	}

	public void SetState(bool state)
	{
		isAbleToTalk = state;
	}

	private void PoolSpeechBubble()
	{
		if (speechBubble != null)
		{
			if (GameObjectPool.Instance != null)
				GameObjectPool.Instance.Push(speechBubble.gameObject);
			else
				Destroy(speechBubble.gameObject);
			speechBubble = null;
		}
	}

	private void OnDrawGizmos()
	{
	}
}
