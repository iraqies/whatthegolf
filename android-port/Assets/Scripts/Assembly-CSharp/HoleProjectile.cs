using System.Collections;
using System.Linq;
using UnityEngine;

public class HoleProjectile : MonoBehaviour
{
	public GameObject holeToInstantiate;

	public MeshRenderer holeRender;

	[SerializeField]
	private float distThres = 2f;

	private Transform closest;

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || other.gameObject == null)
		{
			return;
		}
		string layerName = LayerMask.LayerToName(other.gameObject.layer);
		if (layerName == "Ground")
		{
			HotdogHole[] holes = Object.FindObjectsOfType<HotdogHole>();
			Transform[] holeTransforms = holes != null ? holes.Select(h => h.transform).ToArray() : new Transform[0];
			if (GetDistToClosestHole(holeTransforms) < distThres)
			{
				DestroyHole();
			}
			else
			{
				Spawn();
			}
		}
		else if (layerName == "Obstacle")
		{
			DestroyHole();
		}
	}

	private void Spawn()
	{
		if (holeToInstantiate != null)
		{
			Object.Instantiate(holeToInstantiate, transform.position, Quaternion.identity);
		}
		Object.Destroy(transform.root.gameObject);
	}

	private void DestroyHole()
	{
		StartCoroutine(DestoryCR());
	}

	private IEnumerator DestoryCR()
	{
		if (holeRender != null)
		{
			holeRender.enabled = false;
		}
		ParticleSystem ps = GetComponentInChildren<ParticleSystem>();
		if (ps != null)
		{
			ps.Play();
		}
		yield return new WaitForSeconds(0.5f);
		Object.Destroy(transform.root.gameObject);
	}

	private float GetDistToClosestHole(Transform[] enemies)
	{
		if (enemies == null || enemies.Length == 0)
		{
			return float.PositiveInfinity;
		}
		float minDist = float.PositiveInfinity;
		for (int i = 0; i < enemies.Length; i++)
		{
			if (enemies[i] != null)
			{
				float d = Vector3.Distance(transform.position, enemies[i].position);
				if (d < minDist)
				{
					minDist = d;
					closest = enemies[i];
				}
			}
		}
		return minDist;
	}
}
