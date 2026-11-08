using System.Collections.Generic;
using Audio;
using Core;
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
		ListenForInterruption();
		if (speechAudio == null)
			speechAudio = GetComponent<SpeechAudioBase>();
	}

	private void ListenForInterruption()
	{
		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.OnShoot += OnOverworldShot;
			OverworldManager2d.Instance.OnLevelStarting = (System.Action<List<LevelData>>)System.Delegate.Combine(OverworldManager2d.Instance.OnLevelStarting, new System.Action<List<LevelData>>(OnLevelStarting));
			OverworldManager2d.Instance.OnToggleOverworld += OnToggleOverworld;
		}
	}

	private void OnOverworldShot()
	{
		IsInterrupted = true;
	}

	private void OnLevelStarting(List<LevelData> lvls)
	{
		IsInterrupted = true;
	}

	private void OnToggleOverworld(bool active)
	{
		if (!active && SpeechBubble != null)
		{
			SpeechBubble.Hide(false);
			PoolSpeechBubble();
			IsHandlingHit = false;
			if (anim != null)
				anim.SetBool("Talking", false);
		}
	}

	protected void PoolSpeechBubble()
	{
		if (SpeechBubble != null)
		{
			if (GameObjectPool.Instance != null)
				GameObjectPool.Instance.Push(SpeechBubble.gameObject);
			else
				Destroy(SpeechBubble.gameObject);
			SpeechBubble = null;
		}
	}
}
