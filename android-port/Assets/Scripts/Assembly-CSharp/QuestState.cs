using System.Collections.Generic;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class QuestState : MonoBehaviour
{
	public string DescriptionLocalizationID;

	public bool triggerAll = true;

	public int customTriggerCount = 1;

	public float particleSizeFactor = 1f;

	public UnityEvent OnCompleteEvent;

	public Dictionary<ChallengeTriggerBase, ParticleSystem> TriggerParticles = new Dictionary<ChallengeTriggerBase, ParticleSystem>();

	public int triggerCount { get; set; }

	public ChallengeTriggerBase[] triggers { get; set; }

	public int GetMaxTriggerCount()
	{
		if (triggerAll && triggers != null)
		{
			return triggers.Length;
		}
		return customTriggerCount;
	}

	public bool HasCompletedState()
	{
		return triggerCount >= GetMaxTriggerCount();
	}

	public void Init(GolfBallController controller, ParticleSystem HintParticleSystem)
	{
		triggers = GetComponentsInChildren<ChallengeTriggerBase>(true);
		TriggerParticles = new Dictionary<ChallengeTriggerBase, ParticleSystem>();
		if (triggers == null)
		{
			return;
		}
		for (int i = 0; i < triggers.Length; i++)
		{
			ChallengeTriggerBase trig = triggers[i];
			if (trig == null)
			{
				continue;
			}
			ParticleSystem ps = null;
			if (HintParticleSystem != null)
			{
				ps = Object.Instantiate(HintParticleSystem, trig.transform.position, Quaternion.identity);
				ps.transform.localScale = trig.transform.localScale * particleSizeFactor;
				ps.Play();
				ps.gameObject.SetActive(false);
				TriggerParticles[trig] = ps;
			}
			trig.enabled = false;
			ChallengeTriggerBase capturedTrig = trig;
			ParticleSystem capturedPs = ps;
			trig.OnTrigger += _ =>
			{
				triggerCount++;
				if (capturedTrig != null)
				{
					capturedTrig.enabled = false;
				}
				if (capturedPs != null)
				{
					capturedPs.Stop();
				}
				if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
				{
					LevelManager.Instance.InGameMenu.CountStroke(controller, triggerCount);
				}
			};
		}
	}

	public void OnStart()
	{
		if (triggers == null)
		{
			return;
		}
		for (int i = 0; i < triggers.Length; i++)
		{
			ChallengeTriggerBase trig = triggers[i];
			if (trig != null)
			{
				trig.enabled = true;
				if (TriggerParticles != null && TriggerParticles.TryGetValue(trig, out ParticleSystem ps) && ps != null)
				{
					ps.gameObject.SetActive(true);
				}
			}
		}
	}

	public void OnComplete()
	{
		if (TriggerParticles != null)
		{
			foreach (KeyValuePair<ChallengeTriggerBase, ParticleSystem> kvp in TriggerParticles)
			{
				if (kvp.Value != null)
				{
					Object.Destroy(kvp.Value.gameObject);
				}
			}
		}
		OnCompleteEvent?.Invoke();
	}
}
