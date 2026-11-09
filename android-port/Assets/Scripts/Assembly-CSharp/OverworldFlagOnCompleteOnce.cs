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
		thisFlag = GetComponent<OverworldGoal>();
		if (thisFlag != null && thisFlag.IsCompleted())
		{
			wasAlreadyCompleted = true;
			exploded = true;
			onFlagAlreadyCompleted?.Invoke();
		}
	}

	private void Update()
	{
		if (!exploded && !wasAlreadyCompleted && thisFlag != null && thisFlag.IsCompleted())
		{
			exploded = true;
			onFlagCompleteFirstTime?.Invoke();
		}
	}
}
