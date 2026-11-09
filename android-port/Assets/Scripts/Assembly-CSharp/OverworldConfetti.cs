using System.Collections;
using UnityEngine;

public class OverworldConfetti : MonoBehaviour
{
	public OverworldManager2d Manager;

	public ConfettiSpawner Spawner;

	private void Start()
	{
		if (Manager == null)
			Manager = OverworldManager2d.Instance;
		if (Manager != null)
		{
			Manager.OnlevelCompleted -= OnlevelCompleted;
			Manager.OnlevelCompleted += OnlevelCompleted;
		}
	}

	private void OnlevelCompleted(OverworldGoal overworldGoal, bool parUnlocked)
	{
		if (overworldGoal != null && Spawner != null && gameObject.activeInHierarchy)
			StartCoroutine(DelayedSpawn(overworldGoal, parUnlocked));
	}

	private IEnumerator DelayedSpawn(OverworldGoal overworldGoal, bool isCrown)
	{
		yield return new WaitForSeconds(0.25f);
		if (overworldGoal != null)
			Confetti.SpawnConfetti(overworldGoal.transform);
	}
}
