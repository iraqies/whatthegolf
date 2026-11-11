using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentacleWallWave : FrogKingBaseWave
{
	public List<GameObject> TentaclePrefabs;

	public Vector2 TentacleScaleMod = new Vector2(0.8f, 1.2f);

	public float TentacleSpacing = 20f;

	public Vector2 TentacleDelay;

	public float TentacleLife = 10f;

	public float WaveDuration = 4f;

	public float SpawnStartX = -100f;

	public float WaveSize = 200f;

	public int GabSize = 2;

	public string ChildNameToScale;

	private List<GameObject> activeObjects = new List<GameObject>();

	public override IEnumerator WaveRoutine(SHMUPFrogKing frogKing)
	{
		StartCoroutine(WaveAnimationsRoutine());
		int count = Mathf.FloorToInt(WaveSize / Mathf.Abs(TentacleSpacing));
		int gapStart = Random.Range(1, count - 2);
		if (frogKing != null)
		{
			Vector3 mid = FindMidpoint(count, frogKing.transform.position.z - 100f);
			TryPlayOneshot(sfxOneshotOnSpawn, mid);
		}
		float curX = SpawnStartX;
		for (int i = 0; i < count; i++)
		{
			if (i < gapStart || i >= gapStart + GabSize)
			{
				if (TentaclePrefabs != null && TentaclePrefabs.Count > 0 && frogKing != null)
				{
					GameObject prefab = TentaclePrefabs[Random.Range(0, TentaclePrefabs.Count)];
					float zPos = frogKing.transform.position.z - 100f;
					Quaternion rot = Quaternion.Euler(0f, Random.Range(-20, 20), 0f);
					GameObject tentacle = Instantiate(prefab, new Vector3(curX, 0f, zPos), rot);
					Transform scaleTarget = string.IsNullOrEmpty(ChildNameToScale)
						? tentacle.transform
						: tentacle.transform.Find(ChildNameToScale);
					if (scaleTarget != null)
					{
						scaleTarget.localScale *= Random.Range(TentacleScaleMod.x, TentacleScaleMod.y);
					}
					Animator anim = tentacle.GetComponent<Animator>();
					if (anim != null)
					{
						anim.speed *= Random.Range(TentacleScaleMod.x, 1f);
						anim.Update(0f);
					}
					if (activeObjects != null)
					{
						activeObjects.Add(tentacle);
					}
					StartCoroutine(TentacleLifeRoutine(tentacle));
				}
				if (TentacleDelay.magnitude > 0f)
				{
					yield return new WaitForSeconds(Random.Range(TentacleDelay.x, TentacleDelay.y));
				}
			}
			curX += TentacleSpacing;
		}
		StartCoroutine(FrogKingSpawnWaveRoutine());
		if (frogKing != null)
		{
			yield return new WaitForSeconds(WaveDuration - 0.5f * frogKing.HitsTaken);
		}
	}

	public Vector3 FindMidpoint(int amount, float z)
	{
		return new Vector3(SpawnStartX + TentacleSpacing * amount * 0.5f, 0f, z);
	}

	public override void OnSinkReset()
	{
		base.OnSinkReset();
		if (activeObjects != null)
		{
			foreach (GameObject go in activeObjects)
			{
				if (go != null)
				{
					Destroy(go);
				}
			}
			activeObjects.Clear();
		}
		StopAllCoroutines();
	}

	private IEnumerator TentacleLifeRoutine(GameObject tentacle)
	{
		yield return new WaitForSeconds(TentacleLife);
		if (tentacle != null)
		{
			Destroy(tentacle);
		}
	}
}
