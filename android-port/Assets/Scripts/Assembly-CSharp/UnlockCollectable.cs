using UnityEngine;

public class UnlockCollectable : MonoBehaviour
{
	public Collectable CollectableToUnlock;

	public GameObject UnlockedIndicator;

	private void OnTriggerEnter2D(Collider2D collider)
	{
	}

	private void OnDisable()
	{
	}
}
