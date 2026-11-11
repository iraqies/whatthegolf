using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldAndFireWave : FrogKingBaseWave
{
	public List<GameObject> Prefabs;

	public string ChildNameToScale;

	public Vector2 TentacleScaleMod = new Vector2(0.8f, 1.2f);

	public float TentacleSpacing = 20f;

	public Vector2 TentacleDelay;

	public float TentacleLife = 10f;

	public float WaveDuration = 4f;

	public float SpawnStartX = -100f;

	public float WaveSize = 200f;

	public int GabSize = 2;

	public float HoldTime = 2f;

	public float MoveSpeed = 1f;

	private List<GameObject> activeObjects = new List<GameObject>();

	public override IEnumerator WaveRoutine(SHMUPFrogKing frogKing)
	{
		StartCoroutine(WaveAnimationsRoutine());
		int numToSpawn = Mathf.FloorToInt(WaveSize / Mathf.Abs(TentacleSpacing));
		int randGab = Random.Range(1, numToSpawn - GabSize);
		TryPlayOneshot(sfxOneshotOnSpawn, FindMidpoint(numToSpawn, frogKing.transform.position.z - 100f));
		float x = SpawnStartX;
		float i = 0f;
		while (i < (float)numToSpawn)
		{
			if (i < (float)randGab || i >= (float)(randGab + GabSize))
			{
				GameObject gameObject = Object.Instantiate(Prefabs[Random.Range(0, Prefabs.Count)], new Vector3(x, 0f, frogKing.transform.position.z - 120f), Quaternion.Euler(0f, Random.Range(-20, 20), 0f));
				Transform transform = (string.IsNullOrEmpty(ChildNameToScale) ? gameObject.transform : gameObject.transform.Find(ChildNameToScale));
				if (transform != null)
				{
					transform.localScale *= Random.Range(TentacleScaleMod.x, TentacleScaleMod.y);
				}
				Animator component = gameObject.gameObject.GetComponent<Animator>();
				component.speed *= Random.Range(TentacleScaleMod.x, 1f);
				component.Update(0f);
				component.SetTrigger("Charge");
				activeObjects.Add(gameObject);
				StartCoroutine(TentacleLifeRoutine(gameObject, frogKing.transform));
			}
			if (TentacleDelay.magnitude > 0f)
			{
				yield return new WaitForSeconds(Random.Range(TentacleDelay.x, TentacleDelay.y));
			}
			x += TentacleSpacing;
			i += 1f;
		}
		yield return new WaitForSeconds(WaveDuration - (float)frogKing.HitsTaken);
	}

	public Vector3 FindMidpoint(int amount, float z)
	{
		return new Vector3(SpawnStartX + TentacleSpacing * (float)amount * 0.5f, 0f, z);
	}

	public override void OnSinkReset()
	{
		base.OnSinkReset();
		foreach (GameObject activeObject in activeObjects)
		{
			Object.Destroy(activeObject);
		}
		activeObjects.Clear();
		StopAllCoroutines();
	}

	private IEnumerator TentacleLifeRoutine(GameObject tentacle, Transform frog)
	{
		Vector3 offset = tentacle.transform.position - frog.position;
		yield return StartCoroutine(pTween.To(HoldTime, delegate
		{
			tentacle.transform.position = frog.position + offset;
		}));
		yield return StartCoroutine(pTween.To(5f, delegate
		{
			tentacle.transform.position += Vector3.back * Time.deltaTime * MoveSpeed;
		}));
		Object.Destroy(tentacle);
	}
}
