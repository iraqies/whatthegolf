using UnityEngine;
using UnityEngine.Events;

public class OverworldFlagOnComplete : MonoBehaviour
{
	private OverworldGoal thisFlag;

	private bool flagIsCompleted;

	public UnityEvent onFlagComplete;

	private void Start()
	{
		thisFlag = GetComponent<OverworldGoal>();
		if (thisFlag != null && thisFlag.IsCompleted())
		{
			flagIsCompleted = true;
			onFlagComplete?.Invoke();
		}
	}

	private void Update()
	{
		if (!flagIsCompleted && thisFlag != null && thisFlag.IsCompleted())
		{
			flagIsCompleted = true;
			onFlagComplete?.Invoke();
		}
	}
}
