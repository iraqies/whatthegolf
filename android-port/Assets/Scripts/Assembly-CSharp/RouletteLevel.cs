using System.Collections;
using Core;
using UnityEngine;

public class RouletteLevel : MonoBehaviour
{
	[SerializeField]
	private GolfBallController golfBallController;

	[SerializeField]
	private GolfBallShooterBase golfBallShooter;

	[SerializeField]
	private Rigidbody golfBallPrefab;

	[SerializeField]
	private Transform golfBallSpawnPosition;

	private IEnumerator Start()
	{
		return null;
	}
}
