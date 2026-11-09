using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using CameraStack;
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
	public float bounceFactor = 0.5f;
	public Vector2 bubbleDir = Vector2.up;
	public Vector2 localBubblePivot;
	public float bubbleRotation;
	public bool ignoreActivatorTags;
	public bool UseRestartTimeLimit;
	public float ConversationRestartTimeLimit = 10f;
	public bool isAbleToTalk = true;
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
		ListenForInterruption();
		if (anim == null)
			anim = GetComponent<Animator>();
		if (speechAudio == null)
			speechAudio = GetComponent<SpeechAudioBase>();
		QuestSetup();
	}

	private void Update()
	{
		if (!questCompleted && questItem != null && questItem.isCollected)
		{
			QuestIsCompleted();
		}
	}

	private void QuestIsCompleted()
	{
		if (questCompleted) return;
		questCompleted = true;
		if (QuestLevelData != null)
			QuestLevelData.IsCompletedInSaveGame = true;
		if (QuestMarker != null)
			QuestMarker.SetActive(false);
		if (QuestItemParticlesPrefab != null && questItem != null)
			Instantiate(QuestItemParticlesPrefab, questItem.transform.position, Quaternion.identity);
		if (questItem != null)
			questItem.DestroyAfterCompletion();
		if (TextListQuestComplete != null)
			conversation = TextListQuestComplete.NewConversation();
		OnQuestCompleted?.Invoke();
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
					if (anim != null)
						anim.SetBool("Talking", false);
				}
			};
		}
	}

	private void QuestSetup()
	{
		if (QuestLevelData != null && QuestLevelData.IsCompletedInSaveGame)
		{
			questCompleted = true;
			if (QuestMarker != null)
				QuestMarker.SetActive(false);
			OnQuestCompleted?.Invoke();
			return;
		}
		if (QuestItemPrefab != null && QuestItemContainer != null)
		{
			questItem = Instantiate(QuestItemPrefab, QuestItemContainer);
			questItem.transform.position = QuestItemContainer.position;
		}
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
		var list = questCompleted && TextListQuestComplete != null ? TextListQuestComplete : TextList;
		if (list != null)
		{
			conversation = list.NewConversation();
			lastConversationTime = Time.realtimeSinceStartup;
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
		var list = questCompleted && TextListQuestComplete != null ? TextListQuestComplete : TextList;
		if (conversation == null || (UseRestartTimeLimit && now - lastConversationTime > ConversationRestartTimeLimit))
		{
			if (list != null)
			{
				conversation = list.NewConversation();
				lastConversationTime = now;
			}
		}

		var textInfo = conversation != null ? conversation.GetText() : null;
		if (anim != null && textInfo != null && !textInfo.DontPlayTalkAnimation)
			anim.SetBool("Talking", true);

		if (textInfo != null && speechBubble != null && !string.IsNullOrEmpty(textInfo.ID))
		{
			lastConversationTime = Time.realtimeSinceStartup;
			Vector2? prefPos = speechBubblePreferredCenterTransform != null ? (Vector2?)speechBubblePreferredCenterTransform.position : null;
			Vector3 worldPivot = transform.TransformPoint(new Vector3(localBubblePivot.x, localBubblePivot.y, 0f));
			Camera cam = OverworldCamera.Instance != null ? OverworldCamera.Instance.MainCamera : Camera.main;

			isInterrupted = false;
			var task = speechBubble.Show(textInfo.ID, new Vector2(worldPivot.x, worldPivot.y), prefPos, cam, bubbleDir, textInfo.isLocalized, OnPreprocessText);
			while (task != null && !task.isDone && !isInterrupted)
			{
				if (speechAudio != null)
					speechAudio.UpdateSpeech();
				yield return null;
			}
			onTextShown?.Invoke();
			if (anim != null && !textInfo.DontPlayTalkAnimation)
				anim.SetBool("Talking", false);
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
