using System.Collections;
using System.Collections.Generic;
using CameraStack;
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
		if (other == null)
		{
			return;
		}
		if (other.rigidbody != null && other.rigidbody.GetComponent<OverworldBall2D>() == null)
		{
			return;
		}
		if (!ignoreActivatorTags && (ActivatorTags == null || !ActivatorTags.Contains(other.gameObject.tag)))
		{
			return;
		}
		StartCoroutine(HandleHit());
		if (other.rigidbody != null)
		{
			other.rigidbody.velocity *= bounceFactor;
		}
	}

	public IEnumerator HandleHit()
	{
		if (isHandlingHit)
		{
			yield break;
		}
		isHandlingHit = true;
		yield return new WaitForSeconds(delay);
		if (OverworldCamera.Instance != null)
		{
			OverworldCamera.Instance.Shake(0.25f, 25f, 0.1f);
		}
		if (RuntimeStoreData.instance != null && (int)RuntimeStoreData.instance.onlineLeaderboardType == 1)
		{
			if (playfabLeaderboard != null)
			{
				playfabLeaderboard.SetActive(value: true);
			}
		}
		else if (LeaderboardManager.Instance != null)
		{
			LeaderboardManager.Instance.ShowLeaderBoard(board);
		}
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null)
		{
			AudioManager.Instance.sfx.Play(OnHitClip);
		}
		isHandlingHit = false;
	}

	public OpenLeaderboardOnHit()
	{
		bounceFactor = 0.5f;
		ignoreActivatorTags = true;
	}
}
