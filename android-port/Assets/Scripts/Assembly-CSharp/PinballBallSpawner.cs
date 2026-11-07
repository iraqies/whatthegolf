using System.Collections.Generic;
using GolfGames.Pinball;
using UnityEngine;

public class PinballBallSpawner : MonoBehaviour
{
	public Pinball BallToSpawn;

	public List<AudioClip> SpawnClip;

	public float Probability;

	private void OnCollisionEnter2D(Collision2D other)
	{
	}
}
