using UnityEngine;
using UnityEngine.Events;

public class EventOnFlagComplete : MonoBehaviour
{
	[SerializeField]
	private OverworldGoal goals;

	public UnityEvent _event;

	[SerializeField]
	private bool requireAll;

	private void Start()
	{
	}

	private bool IsComplete()
	{
		return false;
	}
}
