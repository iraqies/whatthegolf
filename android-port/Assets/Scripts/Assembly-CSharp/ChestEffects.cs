using UnityEngine;

public class ChestEffects : MonoBehaviour
{
	[SerializeField]
	public ConfettiSpawner confettiSpawner;

	public void SpawnConfetti()
	{
		if (confettiSpawner != null)
		{
			confettiSpawner.RemoteSpawn(confettiSpawner.transform.position, false);
		}
	}
}
