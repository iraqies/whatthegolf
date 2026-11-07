using System.Collections.Generic;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class QuestState : MonoBehaviour
{
	public string DescriptionLocalizationID;

	public bool triggerAll;

	public int customTriggerCount;

	public float particleSizeFactor;

	public UnityEvent OnCompleteEvent;

	public Dictionary<ChallengeTriggerBase, ParticleSystem> TriggerParticles;

	public int triggerCount { get; set; }

	public ChallengeTriggerBase[] triggers { get; set; }

	public int GetMaxTriggerCount()
	{
		return 0;
	}

	public bool HasCompletedState()
	{
		return false;
	}

	public void Init(GolfBallController controller, ParticleSystem HintParticleSystem)
	{
	}

	public void OnStart()
	{
	}

	public void OnComplete()
	{
	}
}
