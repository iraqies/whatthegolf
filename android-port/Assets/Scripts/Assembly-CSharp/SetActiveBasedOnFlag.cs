using System.Collections.Generic;
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
	}

	private void Goal_OnUpdateData(OverworldGoal g)
	{
	}

	private bool IsComplete()
	{
		return false;
	}
}
