using System.Collections;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
	public float distance = 15f;

	public Vector2 dir;

	public Rigidbody2D rigid;

	private Vector3 startPos;

	public float delay;

	private bool isMoving;

	private IEnumerator Start()
	{
		startPos = transform.position;
		yield return new WaitForSeconds(delay);
		isMoving = true;
	}

	private void FixedUpdate()
	{
		if (!isMoving || rigid == null)
			return;
		rigid.velocity = dir;
		if (Vector3.Distance(startPos, transform.position) > distance)
		{
			rigid.position = new Vector2(startPos.x, startPos.y);
			transform.position = startPos;
		}
	}
}
