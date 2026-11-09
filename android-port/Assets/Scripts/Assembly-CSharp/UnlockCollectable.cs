using UnityEngine;

public class UnlockCollectable : MonoBehaviour
{
	public Collectable CollectableToUnlock;

	public GameObject UnlockedIndicator;

	private void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider == null || collider.gameObject == null || !collider.gameObject.CompareTag("Player"))
			return;
		if (CollectableToUnlock == null || CollectableToUnlock.IsUnlocked())
			return;

		CollectableToUnlock.Unlock();
		if (UnlockedIndicator != null)
			UnlockedIndicator.SetActive(true);
		StartCoroutine(pTween.To(5f, _ => { }).Then(() =>
		{
			if (UnlockedIndicator != null)
				UnlockedIndicator.SetActive(false);
		}));
	}

	private void OnDisable()
	{
		if (UnlockedIndicator != null)
			UnlockedIndicator.SetActive(false);
	}
}
