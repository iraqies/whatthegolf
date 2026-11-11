using System.Collections;
using Audio;
using Core;
using UnityEngine;

public class MarioEndFlag : MonoBehaviour
{
	public float FlagMoveSpeed = 1f;

	public ScheduleHarmonics harmonicsOnEnd;

	private float baseVolume = 0.2f;

	private float bonusVolume = 0.5f;

	private float increaseOverTime = 1f;

	private Rigidbody player;

	private bool isDone;

	private Vector3 debugStart;

	private void Awake()
	{
		debugStart = transform.position;
	}

	public void DebugReset()
	{
		transform.position = debugStart;
		isDone = false;
	}

	private void OnCollisionEnter(Collision other)
	{
		if (isDone || other == null || other.transform == null || other.transform.tag != "Player")
		{
			return;
		}
		isDone = true;
		GolfBallController gbc = other.gameObject.GetComponent<GolfBallController>();
		if (gbc != null)
		{
			gbc.enabled = false;
			if (gbc.shootArrow != null)
			{
				gbc.shootArrow.Hide();
			}
		}
		if (other.rigidbody != null)
		{
			other.rigidbody.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
			other.rigidbody.isKinematic = true;
			StartCoroutine(MovePlayerAndFlagDown(other.rigidbody));
		}
		if (harmonicsOnEnd != null)
		{
			harmonicsOnEnd.StartScheduleLoop();
		}
	}

	private IEnumerator MovePlayerAndFlagDown(Rigidbody player)
	{
		float timer = 0f;
		while (player != null && player.transform.position.y > 0.25f)
		{
			yield return new WaitForFixedUpdate();
			transform.position += Vector3.down * FlagMoveSpeed * Time.deltaTime;
			if (player != null)
			{
				player.MovePosition(player.position + Vector3.down * FlagMoveSpeed * Time.deltaTime);
			}
			if (harmonicsOnEnd != null)
			{
				float vol = baseVolume + Mathf.Clamp01(timer / Mathf.Max(0.01f, increaseOverTime)) * bonusVolume;
				harmonicsOnEnd.SetVolume(vol);
			}
			timer += Time.fixedDeltaTime;
		}
		if (harmonicsOnEnd != null)
		{
			harmonicsOnEnd.StopScheduleLoop();
		}
		if (player != null)
		{
			player.isKinematic = false;
		}
		if (Level.Instance != null)
		{
			Level.Instance.Complete();
		}
	}
}
