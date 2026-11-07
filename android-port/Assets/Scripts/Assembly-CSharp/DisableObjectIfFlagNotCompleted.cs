using System.Collections.Generic;
using UnityEngine;

public class DisableObjectIfFlagNotCompleted : MonoBehaviour
{
	public List<OverworldGoal> goals;

	private void Awake()
	{
	}

	private void Goal_OnUpdateData(OverworldGoal goal)
	{
	}
}
