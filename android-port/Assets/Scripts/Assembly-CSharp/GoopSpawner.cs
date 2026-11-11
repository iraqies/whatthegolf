using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utility;

public class GoopSpawner : MonoBehaviour
{
	public GameObject GoopBubblePrefab;

	public Transform[] GoopSpots;

	private List<GameObject> m_cachedGoops;

	public float Cooldown;

	public float CoopClipLength = 4f;

	private ObjectPool<GameObject> goopPool;

	private float spawnTimer;

	public float ScaleOverride;

	public bool usedIn3DLevel;

	private void Awake()
	{
		goopPool = new ObjectPool<GameObject>(GoopBubblePrefab, 20);
		goopPool.SetPoolTransformParent(base.transform);
		m_cachedGoops = new List<GameObject>();
	}

	private void OnDisable()
	{
		StopAllCoroutines();
		for (int num = m_cachedGoops.Count - 1; num >= 0; num--)
		{
			GameObject item = m_cachedGoops[num];
			m_cachedGoops.Remove(item);
			goopPool.Release(item, resetTransform: false);
		}
	}

	private void Update()
	{
		spawnTimer += Time.deltaTime;
		if (spawnTimer > Cooldown)
		{
			Vector3 position = GoopSpots[Random.Range(0, GoopSpots.Length)].position;
			GameObject gameObject = goopPool.Retrieve(position, Quaternion.identity, base.transform);
			if (ScaleOverride != 0f)
			{
				gameObject.transform.localScale = new Vector3(ScaleOverride, ScaleOverride, ScaleOverride);
			}
			if (usedIn3DLevel)
			{
				gameObject.transform.LookAt(Camera.main.transform.position);
			}
			m_cachedGoops.Add(gameObject);
			StartCoroutine(CheckIfDone(gameObject));
			spawnTimer = 0f;
		}
	}

	private IEnumerator CheckIfDone(GameObject goop)
	{
		yield return new WaitForSeconds(CoopClipLength);
		goopPool.Release(goop);
		m_cachedGoops.Remove(goop);
	}
}
