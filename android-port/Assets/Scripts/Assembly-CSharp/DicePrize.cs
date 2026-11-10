using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class DicePrize : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> Prefabs;

	[SerializeField]
	private List<Transform> DiceSides;

	[SerializeField]
	private Rigidbody rb;

	[SerializeField]
	private Transform spawnPosition;

	[SerializeField]
	private ParticleSystem poof;

	private List<GameObject> Spawned;

	[SerializeField]
	private float waitBetweenSpawn;

	[SerializeField]
	private float randomPos;

	[SerializeField]
	private UnityEvent OnSpawn;

	public static Vector3 RandomPointInBounds(Bounds bounds)
	{
		return new Vector3(Random.Range(bounds.min.x, bounds.max.x), Random.Range(bounds.min.y, bounds.max.y), Random.Range(bounds.min.z, bounds.max.z));
	}

	public void StartCheck()
	{
		StopAllCoroutines();
		StartCoroutine(WaitForDiceZeroVelocity());
	}

	private IEnumerator WaitForDiceZeroVelocity()
	{
		yield return new WaitForSeconds(0.3f);
		yield return new WaitUntil(() => rb == null || rb.velocity.magnitude < 0.01f);
		CheckDiceValue();
	}

	private void CheckDiceValue()
	{
		if (DiceSides != null && DiceSides.Count > 0)
		{
			Transform item = DiceSides.OrderByDescending((Transform d) => d.transform.position.y).First();
			Spawn(DiceSides.IndexOf(item) + 1);
		}
	}

	private void Spawn(int num)
	{
		if (poof != null)
		{
			poof.Play();
		}
		StartCoroutine(SpawnCR(num));
	}

	private IEnumerator SpawnCR(int num)
	{
		for (int i = 0; i < num; i++)
		{
			if (Prefabs != null && Prefabs.Count > 0)
			{
				GameObject gameObject = Object.Instantiate(Prefabs[i % Prefabs.Count], spawnPosition);
				gameObject.transform.localPosition = new Vector3(Random.Range(0f - randomPos, randomPos), 0f, Random.Range(0f - randomPos, randomPos));
				Rigidbody component = gameObject.GetComponent<Rigidbody>();
				if (component != null && spawnPosition != null)
				{
					component.AddExplosionForce(40f, spawnPosition.position, 10f, 10f, ForceMode.VelocityChange);
				}
			}
			OnSpawn?.Invoke();
			yield return new WaitForSeconds(waitBetweenSpawn);
		}
	}

	public DicePrize()
	{
		waitBetweenSpawn = 0.2f;
	}
}
