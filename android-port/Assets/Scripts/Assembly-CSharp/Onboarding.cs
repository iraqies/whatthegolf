using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class Onboarding : MonoBehaviour
{
	private Action<float, int> m_OnOnboardingProgressChanged;
	private Action<LevelData> m_OnOnboardingLevelChanged;
	private Action m_OnReadyForMusic;
	private Action m_OnOnboardingCompleted;

	private ContentPack pack;
	public ECampaignType CampaignType;
	public bool RandomizeSecondOnboarding;

	public event Action<float, int> OnOnboardingProgressChanged
	{
		add => m_OnOnboardingProgressChanged = (Action<float, int>)Delegate.Combine(m_OnOnboardingProgressChanged, value);
		remove => m_OnOnboardingProgressChanged = (Action<float, int>)Delegate.Remove(m_OnOnboardingProgressChanged, value);
	}

	public event Action<LevelData> OnOnboardingLevelChanged
	{
		add => m_OnOnboardingLevelChanged = (Action<LevelData>)Delegate.Combine(m_OnOnboardingLevelChanged, value);
		remove => m_OnOnboardingLevelChanged = (Action<LevelData>)Delegate.Remove(m_OnOnboardingLevelChanged, value);
	}

	public event Action OnReadyForMusic
	{
		add => m_OnReadyForMusic = (Action)Delegate.Combine(m_OnReadyForMusic, value);
		remove => m_OnReadyForMusic = (Action)Delegate.Remove(m_OnReadyForMusic, value);
	}

	public event Action OnOnboardingCompleted
	{
		add => m_OnOnboardingCompleted = (Action)Delegate.Combine(m_OnOnboardingCompleted, value);
		remove => m_OnOnboardingCompleted = (Action)Delegate.Remove(m_OnOnboardingCompleted, value);
	}

	public void StartOnBoarding(ContentPack pack, bool allowMenuButtons, Action onAbortAction = null, Action<bool> onTransitionCoverAfter = null)
	{
		this.pack = pack;
		StartCoroutine(PlayOnboardingLevels(allowMenuButtons, onAbortAction, onTransitionCoverAfter));
	}

	private IEnumerator PlayOnboardingLevels(bool allowMenuButtons, Action onAbortAction = null, Action<bool> onTransitionCoverAfter = null)
	{
		m_OnReadyForMusic?.Invoke();
		bool isSecond = pack != null && pack.contentPackID == "CP_SECOND_ONBOARDING";
		var levels = GetLevels(isSecond);
		if (levels != null && levels.Count > 0 && LevelManager.Instance != null)
		{
			for (int i = 0; i < levels.Count; i++)
			{
				var lvl = levels[i];
				if (lvl == null) continue;
				m_OnOnboardingLevelChanged?.Invoke(lvl);
				m_OnOnboardingProgressChanged?.Invoke((float)i / levels.Count, i);
				bool levelDone = false;
				bool aborted = false;
				yield return LevelManager.Instance.Play(
					lvl,
					onComplete: _ => levelDone = true,
					onAbort: () => { aborted = true; levelDone = true; }
				);
				while (!levelDone)
					yield return null;
				if (aborted)
				{
					onAbortAction?.Invoke();
					yield break;
				}
			}
		}
		m_OnOnboardingCompleted?.Invoke();
	}

	private List<LevelData> GetLevels(bool isSecondOnboarding)
	{
		if (pack == null) return new List<LevelData>();
		var container = pack.onboardingContainer ?? pack.mainContainer;
		return container != null ? container.GetLevelDatas() : new List<LevelData>();
	}

	private List<LevelData> GetRandomList(int numberOfElements, List<LevelData> list)
	{
		return list ?? new List<LevelData>();
	}
}
