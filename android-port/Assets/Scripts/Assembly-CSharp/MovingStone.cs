using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingStone : MonoBehaviour
{
	public bool isSuperPutt;

	public float tweenTime = 0.65f;

	public float offsetTime;

	public float waitTime = 0.2f;

	public List<Transform> targets;

	public AudioSource audioSource;

	public List<AudioClip> clipAtEnd;

	private Rigidbody2D rigid;

	private List<Vector3> targetPositions;

	private Coroutine lastRoutine;

	private bool didInitialize;

	private Rigidbody2D ball;

	private Vector2 lastBallPos;

	private float totalBallMovement;

	private float volume;

	private float pitch;

	public void Initialize()
	{
		rigid = GetComponent<Rigidbody2D>();
		GridFiller gridFiller = Object.FindObjectOfType<GridFiller>();
		targetPositions = new List<Vector3>();
		if (audioSource != null)
		{
			volume = audioSource.volume;
			pitch = audioSource.pitch;
		}
		if (targets != null && gridFiller != null && gridFiller.currentGroundMap != null)
		{
			foreach (Transform target in targets)
			{
				if (target != null)
				{
					Vector3Int cellPosition = gridFiller.currentGroundMap.WorldToCell(target.position);
					Vector3 vector = gridFiller.currentGroundMap.CellToWorld(cellPosition);
					Vector3 cellSize = gridFiller.currentGroundMap.cellSize;
					targetPositions.Add(vector + cellSize * 0.5f);
				}
			}
		}
		if (targetPositions.Count > 0)
		{
			base.transform.position = targetPositions[targetPositions.Count - 1];
		}
		if (OverworldBallManager.Instance != null)
		{
			OverworldBallManager.Instance.OnNewBall += Instance_OnNewBall;
			if (OverworldBallManager.Instance.Ball != null)
			{
				ball = OverworldBallManager.Instance.Ball.GetComponent<Rigidbody2D>();
			}
		}
		didInitialize = true;
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
		{
			ball = OverworldBallManager.Instance.Ball.GetComponent<Rigidbody2D>();
		}
	}

	private void OnEnable()
	{
		lastRoutine = StartCoroutine(Routine());
	}

	private void OnDisable()
	{
		if (lastRoutine != null)
		{
			StopCoroutine(lastRoutine);
		}
	}

	private void OnDrawGizmosSelected()
	{
		if (targets == null || targets.Count == 0 || targets[0] == null)
		{
			return;
		}
		Vector3 from = targets[0].position;
		foreach (Transform target in targets)
		{
			if (target != null)
			{
				Gizmos.DrawLine(from, target.position);
				from = target.position;
			}
		}
		if (targets[targets.Count - 1] != null)
		{
			Gizmos.DrawLine(targets[0].position, targets[targets.Count - 1].position);
		}
	}

	private void FixedUpdate()
	{
		if (!didInitialize)
		{
			return;
		}
		if (isSuperPutt)
		{
			if (ball != null)
			{
				totalBallMovement += (ball.position - lastBallPos).magnitude / 10f;
				lastBallPos = ball.position;
			}
		}
		else
		{
			totalBallMovement += Time.fixedDeltaTime;
		}
	}

	private IEnumerator Routine()
	{
		while (!didInitialize)
		{
			yield return null;
		}
		if (targetPositions == null || targetPositions.Count == 0)
		{
			yield break;
		}
		Vector3 prevPos = targetPositions[targetPositions.Count - 1];
		yield return null;
		yield return new WaitForSeconds(offsetTime);
		WaitForSeconds wait = new WaitForSeconds(waitTime);
		while (true)
		{
			foreach (Vector3 nextPos in targetPositions)
			{
				float startTime = totalBallMovement;
				float t = 0f;
				while (t < 1f)
				{
					t = (totalBallMovement - startTime) / tweenTime;
					float t2 = (isSuperPutt ? Mathf.Clamp01(t) : Mathf.Clamp01(TweenFunctions.EaseIn(t)));
					if (rigid != null)
					{
						rigid.MovePosition(Vector2.Lerp(prevPos, nextPos, t2));
					}
					yield return null;
				}
				if (rigid != null)
				{
					rigid.velocity = Vector2.zero;
				}
				yield return wait;
				prevPos = nextPos;
			}
		}
	}
}
