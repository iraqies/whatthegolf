using System.Collections.Generic;
using System.Linq;
using Chronos;
using Core;
using UnityEngine;
using Utility;

public class SpawnFallingObjects : MonoBehaviour
{
	[SerializeField]
	public List<Rigidbody> spawnObjects;

	[SerializeField]
	public float spawnInterval;

	[SerializeField]
	public int spawnAmount;

	[SerializeField]
	public Vector2 spawnTorqueForceRange = new Vector2(10f, 20f);

	[SerializeField]
	public Vector3 spawnForce;

	[SerializeField]
	public BoxCollider spawnArea;

	[SerializeField]
	public BoxCollider levelBounds;

	[SerializeField]
	public float radiusCheck = 3f;

	[SerializeField]
	public float timeChangeSpeed = 0.1f;

	[SerializeField]
	public float timeChangeBackSpeed = 0.1f;

	[SerializeField]
	public float startDelay = 10f;

	private float spawnTimer;

	private List<ObjectPool<Rigidbody>> pools;

	private List<Rigidbody> activeObjects;

	private Timeline timeline;

	private float timeScaleTarget;

	private float origTimeScale;

	private float heightOffsetToBall;

	private void Start()
	{
		timeline = GetComponent<Timeline>();
		activeObjects = new List<Rigidbody>();
		pools = new List<ObjectPool<Rigidbody>>();
		foreach (Rigidbody spawnObject in spawnObjects)
		{
			pools.Add(new ObjectPool<Rigidbody>(spawnObject.gameObject, 30));
		}
		spawnTimer = spawnInterval;
		Level.Instance.Ball.OnShoot += Ball_OnShoot;
		if (timeline != null)
		{
			origTimeScale = timeline.clock.localTimeScale;
			timeScaleTarget = timeline.clock.localTimeScale;
			timeline.clock.localTimeScale = 1f;
		}
		heightOffsetToBall = base.transform.position.y - Level.Instance.Ball.transform.position.y;
	}

	private void Ball_OnShoot(Vector3 obj)
	{
		timeScaleTarget = origTimeScale * 0.01f;
	}

	private void Update()
	{
		if (timeline != null)
		{
			spawnTimer += timeline.deltaTime;
		}
		else
		{
			spawnTimer += Time.deltaTime;
		}
		if (spawnTimer > spawnInterval)
		{
			for (int i = 0; i < spawnAmount; i++)
			{
				Vector3 vector;
				do
				{
					Vector3 vector2 = base.transform.position + spawnArea.center;
					float value = Random.value;
					float x = spawnArea.size.x;
					float value2 = Random.value;
					float y = spawnArea.size.y;
					float value3 = Random.value;
					float z = spawnArea.size.z;
					vector = vector2 + new Vector3((value - 0.5f) * x, (value2 - 0.5f) * y, (value3 - 0.5f) * z);
				}
				while (Physics.CheckSphere(vector, radiusCheck, 1 << LayerMask.NameToLayer("Car")));
				int index = Random.Range(0, pools.Count);
				GameObject gameObject = pools[index].Retrieve(Vector3.zero, default(Quaternion));
				gameObject.SetActive(true);
				Rigidbody component = gameObject.GetComponent<Rigidbody>();
				component.velocity = Vector3.zero;
				component.AddTorque(Random.onUnitSphere * Random.Range(spawnTorqueForceRange.x, spawnTorqueForceRange.y));
				gameObject.transform.rotation = Quaternion.LookRotation(Random.onUnitSphere);
				gameObject.transform.position = vector;
				activeObjects.Add(component);
				component.AddForce(spawnForce, ForceMode.Impulse);
			}
			spawnTimer = 0f;
		}
		for (int num = activeObjects.Count - 1; num >= 0; num--)
		{
			Rigidbody r = activeObjects[num];
			if (!levelBounds.bounds.Contains(r.transform.position))
			{
				ObjectPool<Rigidbody> objectPool = pools.FirstOrDefault((ObjectPool<Rigidbody> p) => p.ToString() == r.gameObject.name);
				if (objectPool != null)
				{
					objectPool.Release(r.gameObject, true);
					activeObjects.Remove(r);
				}
			}
		}
		if (startDelay > 0f)
		{
			startDelay -= Time.unscaledDeltaTime;
		}
		else
		{
			if (timeline != null)
			{
				timeline.clock.localTimeScale = Mathf.MoveTowards(timeline.clock.localTimeScale, timeScaleTarget, Time.deltaTime * timeChangeSpeed);
			}
			timeScaleTarget = Mathf.MoveTowards(timeScaleTarget, origTimeScale, Time.deltaTime * timeChangeBackSpeed);
		}
		base.transform.position = new Vector3(base.transform.position.x, Level.Instance.Ball.transform.position.y + heightOffsetToBall, base.transform.position.z);
	}
}
