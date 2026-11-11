using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class JetpackJoyrideEnvironment : MonoBehaviour
{
	public float MoveSpeed = 10f;

	public List<Rigidbody2D> StaticObjects;

	public List<JetpackJoyrideBackgroundObject> BackgroundObjects;

	public Vector2 SpawnIntervalRange = new Vector2(1f, 3f);

	public Transform Challenges;

	public Vector2 challengeSpawnIntervalRange = new Vector2(1f, 3f);

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
		activeBackgroundObjects = new List<JetpackJoyrideBackgroundObject>();
		inactiveBackgroundObjects = new List<JetpackJoyrideBackgroundObject>(BackgroundObjects);
		nextChallengeSpawn = 0f;
		if (Challenges != null)
		{
			challenges = Challenges.GetComponentsInChildren<JetpackJoyrideChallenge>();
			for (int i = 0; i < challenges.Length; i++)
			{
				challenges[i].gameObject.SetActive(false);
			}
		}
		activeChallenges = new List<JetpackJoyrideChallenge>();
	}

	private void Update()
	{
		for (int num = activeBackgroundObjects.Count - 1; num >= 0; num--)
		{
			JetpackJoyrideBackgroundObject jetpackJoyrideBackgroundObject = activeBackgroundObjects[num];
			if (!jetpackJoyrideBackgroundObject.MoveWithPhysics)
			{
				jetpackJoyrideBackgroundObject.transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime * jetpackJoyrideBackgroundObject.MoveSpeedMod);
			}
			if (jetpackJoyrideBackgroundObject.transform.position.x < jetpackJoyrideBackgroundObject.BackgroundObjectEndPosition.position.x)
			{
				inactiveBackgroundObjects.Add(activeBackgroundObjects[num]);
				activeBackgroundObjects.RemoveAt(num);
			}
		}
		nextBackgroundSpawn -= Time.deltaTime;
		if (nextBackgroundSpawn <= 0f)
		{
			int index = Random.Range(0, activeBackgroundObjects.Count);
			if (inactiveBackgroundObjects.Count > 0)
			{
				index = Random.Range(0, inactiveBackgroundObjects.Count);
				activeBackgroundObjects.Add(inactiveBackgroundObjects[index]);
				inactiveBackgroundObjects[index].transform.position = inactiveBackgroundObjects[index].BackgroundObjectStartPosition.position;
				inactiveBackgroundObjects.RemoveAt(index);
			}
			nextBackgroundSpawn = Random.Range(SpawnIntervalRange.x, SpawnIntervalRange.y);
		}
		if (nextChallengeSpawn < 0f && Challenges != null && challenges.Length != 0)
		{
			List<JetpackJoyrideChallenge> list = (from c in challenges
				orderby c.Countdown descending
				group c by c.Countdown).First().ToList();
			int index2 = Random.Range(0, list.Count);
			list[index2].Countdown--;
			JetpackJoyrideChallenge jetpackJoyrideChallenge = Object.Instantiate(list[index2]);
			activeChallenges.Add(jetpackJoyrideChallenge);
			jetpackJoyrideChallenge.Spawn(ChallengeStartPosition.position);
			nextChallengeSpawn = jetpackJoyrideChallenge.Length + Random.Range(challengeSpawnIntervalRange.x, challengeSpawnIntervalRange.y);
		}
	}

	private void FixedUpdate()
	{
		nextChallengeSpawn -= Time.deltaTime;
		for (int num = activeChallenges.Count - 1; num >= 0; num--)
		{
			JetpackJoyrideChallenge challenge = activeChallenges[num];
			int index = num;
			challenge.Move(MoveSpeed, ChallengeEndPosition.position, delegate
			{
				Object.Destroy(challenge.gameObject);
				activeChallenges.RemoveAt(index);
			});
		}
		foreach (Rigidbody2D staticObject in StaticObjects)
		{
			staticObject.MovePosition(staticObject.position + Vector2.left * MoveSpeed * Time.deltaTime);
		}
		for (int num2 = activeBackgroundObjects.Count - 1; num2 >= 0; num2--)
		{
			if (activeBackgroundObjects[num2].MoveWithPhysics)
			{
				Rigidbody2D rigidbody = activeBackgroundObjects[num2].Rigidbody;
				rigidbody.MovePosition(rigidbody.position + Vector2.left * MoveSpeed * Time.deltaTime);
			}
		}
	}
}
