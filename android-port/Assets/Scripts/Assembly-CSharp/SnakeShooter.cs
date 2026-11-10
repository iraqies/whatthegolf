using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class SnakeShooter : GolfBall2DShooterBase
{
	public List<GameObject> FoodItems;

	public GameObject Flag;

	public float SpawnInterval = 4f;

	public BoxCollider SpawnArea;

	public int EatGoal = 10;

	public LayerMask FoodLayer;

	public LayerMask WallLayer;

	public Snake2D SnakePart;

	public float Force;

	public RandomAudioClips EatClips;

	public RandomAudioClips FailClips;

	private readonly Dictionary<int, Vector2> directions = new Dictionary<int, Vector2>
	{
		{ 0, Vector2.right },
		{ 1, Vector2.up },
		{ 2, Vector2.left },
		{ 3, Vector2.down }
	};

	private Quaternion targetLookAt;

	private bool objectSpawnedAndAlive;

	private float objectSpawnTimer;

	private float eatCooldown;

	private bool dead;

	private bool nextSpawnIsFlag;

	private GameObject flagRef;

	private void Start()
	{
		targetLookAt = transform.rotation;
		SnakePart = FindObjectOfType<Snake2D>();
	}

	public override void OnShoot(Vector3 boost)
	{
		boost.Normalize();
		base.OnShoot(boost);
		if (Rigidbody != null)
		{
			Rigidbody.velocity = new Vector2(boost.x * Force, boost.y * Force);
		}
		Vector2 diff = (new Vector2(transform.forward.x - boost.x, transform.forward.y - boost.y)).normalized;
		targetLookAt = Quaternion.Euler(0f, 0f, Mathf.Atan2(diff.y, diff.x) * 57.29578f);
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		boost.Normalize();
		Vector2 diff = (new Vector2(transform.forward.x - boost.x, transform.forward.y - boost.y)).normalized;
		targetLookAt = Quaternion.Euler(0f, 0f, Mathf.Atan2(diff.y, diff.x) * 57.29578f);
	}

	private void Update()
	{
		transform.rotation = Quaternion.Slerp(transform.rotation, targetLookAt, Time.deltaTime * 10f);
		eatCooldown -= Time.deltaTime;
		objectSpawnTimer += Time.deltaTime;

		if (objectSpawnTimer >= SpawnInterval && !objectSpawnedAndAlive && SpawnArea != null)
		{
			Vector3 pos = SpawnArea.transform.position + SpawnArea.center;
			Vector3 size = SpawnArea.size;
			Vector2 spawnPt = new Vector2(pos.x + (Random.value - 0.5f) * size.x, pos.y + (Random.value - 0.5f) * size.y);
			int ballMask = 1 << LayerMask.NameToLayer("Ball");
			if (Physics2D.OverlapCircle(spawnPt, 6f, ballMask) == null)
			{
				GameObject prefab = nextSpawnIsFlag ? Flag : ((FoodItems != null && FoodItems.Count > 0) ? FoodItems[Random.Range(0, FoodItems.Count)] : null);
				if (prefab != null)
				{
					GameObject spawned = Instantiate(prefab);
					spawned.SetActive(true);
					spawned.transform.position = new Vector3(spawnPt.x, spawnPt.y, 0f);
					spawned.transform.rotation = Quaternion.Euler(0f, 0f, Random.Range(0, 360));
					objectSpawnedAndAlive = true;
					objectSpawnTimer = 0f;
					if (nextSpawnIsFlag)
					{
						flagRef = spawned;
					}
				}
			}
		}

		if (dead && Rigidbody != null)
		{
			Rigidbody.velocity = Vector2.zero;
		}
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col == null || col.gameObject == null)
			return;

		if (flagRef != null && col.gameObject == flagRef)
		{
			if (Rigidbody != null)
				Rigidbody.velocity = Vector2.zero;
			dead = true;
			if (Level.Instance != null && Level.Instance.Goal != null)
				Level.Instance.Goal.Complete();
			return;
		}

		int foodMask = FoodLayer;
		if ((foodMask | (1 << col.gameObject.layer)) == foodMask)
		{
			if (eatCooldown > 0f)
				return;
			ParticleSystem ps = col.transform.root.GetComponentInChildren<ParticleSystem>();
			if (ps != null)
			{
				ps.transform.SetParent(null, true);
				ps.Play();
			}
			Destroy(col.transform.root.gameObject);
			if (SnakePart != null)
				SnakePart.AddSegment();
			objectSpawnedAndAlive = false;
			eatCooldown = 0.5f;
			if (EatClips != null)
				EatClips.PlayRandomClip(transform.position);
			EatGoal--;
			if (EatGoal <= 0)
			{
				nextSpawnIsFlag = true;
			}
			return;
		}

		int wallMask = WallLayer;
		if ((wallMask | (1 << col.gameObject.layer)) == wallMask || col.gameObject.layer == LayerMask.NameToLayer("Ball"))
		{
			if (FailClips != null)
				FailClips.PlayRandomClip(null);
			if (Rigidbody != null)
				Rigidbody.velocity = Vector2.zero;
			if (Level.Instance != null)
				Level.Instance.Fail(true, true, null, 0f, true, "");
			dead = true;
		}
	}
}
