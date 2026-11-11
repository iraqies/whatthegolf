using System;
using System.Collections.Generic;
using UnityEngine;
using Utility;

public class SpawnFromVolumeTowardsTarget : MonoBehaviour, IObjectPooler
{
	public Rigidbody2D ObjectToSpawn;

	public BoxCollider2D SpawnVolume;

	public Transform Target;

	public float SpawnInterval;

	public float firstSpawnDelay;

	public float offset;

	private float timer;

	private ObjectPool<GameObject> objectPool;

	private List<GameObject> activeObject;

	public ObjectPool<GameObject> GetPool => objectPool;

	private void Start()
	{
		if (ObjectToSpawn != null)
		{
			objectPool = new ObjectPool<GameObject>(ObjectToSpawn.gameObject, 20);
		}
		activeObject = new List<GameObject>();
		timer = SpawnInterval - firstSpawnDelay;
	}

	private void Update()
	{
		timer += Time.deltaTime;
		if (timer >= SpawnInterval && SpawnVolume != null && objectPool != null && Target != null)
		{
			Bounds b = SpawnVolume.bounds;
			float x = b.center.x + UnityEngine.Random.Range(-b.extents.x, b.extents.x);
			float y = b.center.y + UnityEngine.Random.Range(-b.extents.y, b.extents.y);
			Vector3 spawnPos = new Vector3(x, y, 0f);
			GameObject go = objectPool.Retrieve(spawnPos, Quaternion.identity);
			float angle = UnityEngine.Random.Range(1, 30);
			Vector3 vel = CalculateVelocityForTarget(spawnPos, Target.position, angle);
			if (go != null)
			{
				Rigidbody2D rb = go.GetComponent<Rigidbody2D>();
				if (rb != null)
				{
					rb.velocity = new Vector2(vel.x, vel.y);
				}
				if (activeObject != null)
				{
					activeObject.Add(go);
				}
			}
			timer = 0f;
		}
		if (activeObject != null && objectPool != null)
		{
			for (int i = activeObject.Count - 1; i >= 0; i--)
			{
				GameObject go = activeObject[i];
				if (go != null && !go.activeSelf)
				{
					objectPool.Release(go, true);
					activeObject.Remove(go);
				}
			}
		}
	}

	private void OnDisable()
	{
		if (activeObject != null)
		{
			foreach (GameObject go in activeObject)
			{
				if (go != null && go.activeSelf)
				{
					go.SetActive(false);
				}
			}
		}
	}

	public Vector3 CalculateVelocityForTarget(Vector3 startPosition, Vector3 target, float initialAngle)
	{
		float g = Physics.gravity.magnitude;
		float rad = initialAngle * ((float)Math.PI / 180f);
		float planarDist = Vector3.Distance(new Vector3(target.x, 0f, target.z), new Vector3(startPosition.x, 0f, startPosition.z));
		float yOffset = startPosition.y - target.y;
		float cos = Mathf.Cos(rad);
		float sin = Mathf.Sin(rad);
		float tan = Mathf.Tan(rad);
		float denom = yOffset + tan * planarDist;
		if (denom <= 0.0001f || Mathf.Abs(cos) <= 0.0001f)
		{
			return (target - startPosition).normalized * 10f;
		}
		float speed = (1f / cos) * Mathf.Sqrt(0.5f * g * planarDist * planarDist / denom);
		Vector3 localVel = new Vector3(0f, sin * speed, cos * speed);
		float angle = Vector3.Angle(Vector3.forward, new Vector3(target.x - startPosition.x, 0f, target.z - startPosition.z));
		if (target.x < startPosition.x)
		{
			angle = -angle;
		}
		return Quaternion.AngleAxis(angle, Vector3.up) * localVel;
	}
}
