using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLeaderboardOnHit : MonoBehaviour
{
	public GameObject playfabLeaderboard;

	public List<string> ActivatorTags;

	public List<AudioClip> OnHitClip;

	public float delay;

	public float bounceFactor;

	public bool ignoreActivatorTags;

	public LeaderboardBoard board;

	private bool isHandlingHit;

	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	public IEnumerator HandleHit()
	{
		return null;
	}
}
