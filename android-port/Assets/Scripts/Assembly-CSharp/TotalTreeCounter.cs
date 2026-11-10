using UnityEngine;
using UnityEngine.Events;

public class TotalTreeCounter : MonoBehaviour
{
	public int amountOfTrees;

	public int totalTreesPopped;

	public UnityEvent OnAllPopped;

	private void Update()
	{
		if (totalTreesPopped == amountOfTrees)
		{
			OnAllPopped?.Invoke();
		}
	}
}
