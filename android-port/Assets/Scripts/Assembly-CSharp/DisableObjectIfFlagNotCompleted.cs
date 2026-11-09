using System.Collections.Generic;
using UnityEngine;

public class DisableObjectIfFlagNotCompleted : MonoBehaviour
{
	public List<OverworldGoal> goals;

	private void Awake()
	{
		if (goals == null) return;
		bool anyCompleted = false;
		foreach (var g in goals)
		{
			if (g != null && g.IsCompleted())
				anyCompleted = true;
		}
		if (!anyCompleted)
		{
			gameObject.SetActive(false);
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

	private void Goal_OnUpdateData(OverworldGoal goal)
	{
		if (goal != null && goal.IsCompleted())
		{
			gameObject.SetActive(true);
		}
	}
}
