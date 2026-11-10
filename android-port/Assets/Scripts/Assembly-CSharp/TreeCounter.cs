using UnityEngine;

public class TreeCounter : MonoBehaviour
{
	public TotalTreeCounter totalCounter;

	private bool popped;

	public void AddOneCount()
	{
		if (!popped && totalCounter != null)
		{
			totalCounter.totalTreesPopped++;
			popped = true;
		}
	}
}
