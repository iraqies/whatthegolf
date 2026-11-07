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

	public float CoopClipLength;

	private ObjectPool<GameObject> goopPool;

	private float spawnTimer;

	public float ScaleOverride;

	public bool usedIn3DLevel;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private IEnumerator CheckIfDone(GameObject goop)
	{
		return null;
	}
}
