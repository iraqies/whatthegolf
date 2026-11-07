using System.Collections;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
	public float distance;

	public Vector2 dir;

	public Rigidbody2D rigid;

	private Vector3 startPos;

	public float delay;

	private bool isMoving;

	private IEnumerator Start()
	{
		return null;
	}

	private void FixedUpdate()
	{
	}
}
