using Core;
using UnityEngine;

public class ConfettiSpawner : MonoBehaviour
{
	private GolfGoal goal;

	private void OnEnable()
	{
		goal = GetComponentInParent<GolfGoal>();
		if (goal != null)
		{
			if (Level.HasInstance && Level.Instance != null)
			{
				Level.Instance.OnComplete -= Instance_OnComplete;
				Level.Instance.OnComplete += Instance_OnComplete;
			}
		}
		else if (Level.HasInstance && Level.Instance != null)
		{
			Level.Instance.OnComplete -= Instance_OnComplete;
			Level.Instance.OnComplete += Instance_OnComplete;
		}
	}

	private void Instance_OnComplete(Level.CompletedState obj)
	{
		Confetti.SpawnConfetti(transform);
	}
}
