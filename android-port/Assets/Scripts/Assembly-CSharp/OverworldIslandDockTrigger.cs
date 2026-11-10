using UnityEngine;

public class OverworldIslandDockTrigger : MonoBehaviour
{
	public OverworldIsland Island;

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (Island != null)
		{
			Island.OnPierTriggerEnter(other);
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}
}
