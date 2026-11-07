using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;

public class Onboarding : MonoBehaviour
{
	[CompilerGenerated]
	private Action<float, int> m_OnOnboardingProgressChanged;

	[CompilerGenerated]
	private Action<LevelData> m_OnOnboardingLevelChanged;

	[CompilerGenerated]
	private Action m_OnReadyForMusic;

	[CompilerGenerated]
	private Action m_OnOnboardingCompleted;

	private ContentPack pack;

	public ECampaignType CampaignType;

	public bool RandomizeSecondOnboarding;

	public event Action<float, int> OnOnboardingProgressChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<LevelData> OnOnboardingLevelChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnReadyForMusic
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnOnboardingCompleted
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void StartOnBoarding(ContentPack pack, bool allowMenuButtons, Action onAbortAction = null, Action<bool> onTransitionCoverAfter = null)
	{
	}

	private IEnumerator PlayOnboardingLevels(bool allowMenuButtons, Action onAbortAction = null, Action<bool> onTransitionCoverAfter = null)
	{
		return null;
	}

	private List<LevelData> GetLevels(bool isSecondOnboarding)
	{
		return null;
	}

	private List<LevelData> GetRandomList(int numberOfElements, List<LevelData> list)
	{
		return null;
	}
}
