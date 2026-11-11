using System;
using UnityEngine;

public class CurlingMovableFlag : MonoBehaviour
{
	public bool moveWhenBroomed;

	public float moveDistance = 4f;

	public float moveSpeed = 5f;

	private Rigidbody rbody;

	private Vector3 originPos;

	private Vector3 moveSpeedVector;

	private bool moving;

	private void Start()
	{
		rbody = GetComponent<Rigidbody>();
		originPos = rbody.position;
	}

	private void FixedUpdate()
	{
		if (moving)
		{
			rbody.MovePosition(rbody.position + moveSpeedVector * Time.fixedDeltaTime);
			if (Math.Abs(rbody.position.x - originPos.x) >= moveDistance)
			{
				moving = false;
				moveWhenBroomed = true;
				originPos = rbody.position;
			}
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (moveWhenBroomed && collision.gameObject.layer == LayerMask.NameToLayer("GolfBall"))
		{
			moveSpeedVector = new Vector3((rbody.position.x > collision.rigidbody.position.x) ? moveSpeed : (0f - moveSpeed), 0f, 0f);
			moving = true;
			moveWhenBroomed = false;
		}
	}
}
