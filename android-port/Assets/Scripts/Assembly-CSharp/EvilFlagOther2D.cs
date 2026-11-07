using System.Collections;
using UnityEngine;

public class EvilFlagOther2D : MonoBehaviour
{
	public Transform[] positionsToMoveTo;

	public float velocity;

	public AnimationCurve animationCurve;

	private bool isMoving;

	private int currentTarget;

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	private IEnumerator LerpPositions(Vector2 targetPosition, float duration)
	{
		return null;
	}
}
