using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ThanksgivingPrize : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> Prefabs;

	[SerializeField]
	private List<ParticleSystem> poofParticles;

	[SerializeField]
	private Transform spawnPosition;

	[SerializeField]
	private float waitBetweenSpawn;

	[SerializeField]
	private float randomPos;

	[SerializeField]
	private UnityEvent OnSpawn;

	public void Spawn(int num)
	{
		if (poofParticles != null)
		{
			for (int i = 0; i < poofParticles.Count; i++)
			{
				if (poofParticles[i] != null)
				{
					poofParticles[i].Play();
				}
			}
		}
		StartCoroutine(SpawnCR(num));
	}

	private IEnumerator SpawnCR(int num)
	{
		for (int i = 0; i < num; i++)
		{
			if (Prefabs != null && Prefabs.Count > 0)
			{
				GameObject spawned = Object.Instantiate(Prefabs[Random.Range(0, Prefabs.Count)], spawnPosition);
				spawned.transform.localPosition = new Vector3(Random.Range(0f - randomPos, randomPos), 0f, Random.Range(0f - randomPos, randomPos));
				Vector3 targetScale = spawned.transform.localScale;
				Rigidbody component = spawned.GetComponent<Rigidbody>();
				if (component != null && spawnPosition != null)
				{
					component.AddExplosionForce(35f, spawnPosition.position, 10f, 10f, ForceMode.VelocityChange);
				}
				StartCoroutine(pTween.To(0.4f, 0f, 1f, delegate(float t)
				{
					if (spawned != null)
					{
						spawned.transform.localScale = Vector3.Lerp(Vector3.zero, targetScale, Mathf.Clamp01(t));
					}
				}));
			}
			OnSpawn?.Invoke();
			yield return new WaitForSeconds(waitBetweenSpawn);
		}
	}

	public ThanksgivingPrize()
	{
		waitBetweenSpawn = 0.2f;
	}
}
