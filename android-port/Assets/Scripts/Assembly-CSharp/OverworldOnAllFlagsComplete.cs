using UnityEngine;
using UnityEngine.Events;

public class OverworldOnAllFlagsComplete : MonoBehaviour
{
	private OverworldButton2D overWorldButton;

	private bool allFlagsCompleted;

	public UnityEvent onAllFlagsCompleted;

	private void Start()
	{
		overWorldButton = GetComponent<OverworldButton2D>();
	}

	private void Update()
	{
		if (!allFlagsCompleted && overWorldButton != null && overWorldButton.CanOpen)
		{
			allFlagsCompleted = true;
			onAllFlagsCompleted?.Invoke();
		}
	}
}
