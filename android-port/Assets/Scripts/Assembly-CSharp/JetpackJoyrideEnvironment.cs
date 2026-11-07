using System.Collections.Generic;
using UnityEngine;

public class JetpackJoyrideEnvironment : MonoBehaviour
{
	public float MoveSpeed;

	public List<Rigidbody2D> StaticObjects;

	public List<JetpackJoyrideBackgroundObject> BackgroundObjects;

	public Vector2 SpawnIntervalRange;

	public Transform Challenges;

	public Vector2 challengeSpawnIntervalRange;

	public Transform ChallengeStartPosition;

	public Transform ChallengeEndPosition;

	private List<JetpackJoyrideChallenge> activeChallenges;

	private List<JetpackJoyrideBackgroundObject> activeBackgroundObjects;

	private List<JetpackJoyrideBackgroundObject> inactiveBackgroundObjects;

	private float nextBackgroundSpawn;

	private float nextChallengeSpawn;

	private JetpackJoyrideChallenge[] challenges;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}
}
