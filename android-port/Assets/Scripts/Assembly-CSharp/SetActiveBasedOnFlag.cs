using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SetActiveBasedOnFlag : MonoBehaviour
{
	public List<OverworldGoal> goals;

	public bool stateOnComplete;

	public bool stateOnIncomplete;

	[SerializeField]
	private bool requireAll;

	private void Awake()
	{
		if (IsComplete())
		{
			gameObject.SetActive(stateOnComplete);
		}
		else
		{
			gameObject.SetActive(stateOnIncomplete);
			if (goals != null)
			{
				foreach (var g in goals)
				{
					if (g != null)
					{
						g.OnUpdateData -= Goal_OnUpdateData;
						g.OnUpdateData += Goal_OnUpdateData;
					}
				}
			}
		}
	}

	private void Goal_OnUpdateData(OverworldGoal g)
	{
		if (IsComplete())
		{
			gameObject.SetActive(stateOnComplete);
			if (goals != null)
			{
				foreach (var goal in goals)
				{
					if (goal != null)
						goal.OnUpdateData -= Goal_OnUpdateData;
				}
			}
		}
	}

	private bool IsComplete()
	{
		if (goals == null || goals.Count == 0)
			return false;
		if (requireAll)
			return goals.All(g => g != null && g.IsCompleted());
		return goals.Any(g => g != null && g.IsCompleted());
	}
}
