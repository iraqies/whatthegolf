using UnityEngine;
using UnityEngine.Events;

public class OverworldFlagOnCompleteOnce : MonoBehaviour
{
	private OverworldGoal thisFlag;

	private bool wasAlreadyCompleted;

	private bool exploded;

	public UnityEvent onFlagCompleteFirstTime;

	public UnityEvent onFlagAlreadyCompleted;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
