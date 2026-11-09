using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class SnakeShooter : GolfBall2DShooterBase
{
	public List<GameObject> FoodItems;

	public GameObject Flag;

	public float SpawnInterval;

	public BoxCollider SpawnArea;

	public int EatGoal;

	public LayerMask FoodLayer;

	public LayerMask WallLayer;

	public Snake2D SnakePart;

	public float Force;

	public RandomAudioClips EatClips;

	public RandomAudioClips FailClips;

	private readonly Dictionary<int, Vector2> directions;

	private Quaternion targetLookAt;

	private bool objectSpawnedAndAlive;

	private float objectSpawnTimer;

	private float eatCooldown;

	private bool dead;

	private bool nextSpawnIsFlag;

	private GameObject flagRef;

	private void Start()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, 15f, 5f, (Force > 0f ? Force : 22f), 5f);
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
	}
}
