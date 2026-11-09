using System.Collections;
using UnityEngine;

public class EvilFlagOther2D : MonoBehaviour
{
	public Transform[] positionsToMoveTo;

	public float velocity = 10f;

	public AnimationCurve animationCurve;

	private bool isMoving;

	private int currentTarget;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (isMoving || collision == null || collision.tag != "Player")
			return;
		if (positionsToMoveTo == null || currentTarget >= positionsToMoveTo.Length || positionsToMoveTo[currentTarget] == null)
			return;

		Vector2 targetPos = positionsToMoveTo[currentTarget].position;
		StartCoroutine(LerpPositions(targetPos, 5f));
		currentTarget++;
		if (currentTarget == positionsToMoveTo.Length)
			currentTarget = 0;
		isMoving = true;
	}

	private IEnumerator LerpPositions(Vector2 targetPosition, float duration)
	{
		Vector3 startPos = transform.position;
		Vector3 endPos = new Vector3(targetPosition.x, targetPosition.y, startPos.z);
		float dist = Vector2.Distance(startPos, targetPosition);
		float dur = velocity > 0.01f ? (dist / velocity) : Mathf.Max(0.2f, duration);
		float elapsed = 0f;
		while (elapsed < dur)
		{
			elapsed += Time.deltaTime;
			float t = Mathf.Clamp01(elapsed / dur);
			float eval = (animationCurve != null && animationCurve.length > 0) ? animationCurve.Evaluate(t) : t;
			transform.position = Vector3.LerpUnclamped(startPos, endPos, eval);
			yield return null;
		}
		transform.position = endPos;
		isMoving = false;
	}
}
