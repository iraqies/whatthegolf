using Core;
using UnityEngine;

public class ActualCarPhysicsHelper : MonoBehaviour
{
	private GolfBallController controller;

	private Rigidbody rigid;

	private float startDrag;

	private float nextDrag;

	private void Start()
	{
		controller = GetComponent<GolfBallController>();
		rigid = GetComponent<Rigidbody>();
		startDrag = rigid.drag;
		controller.OnShoot += Controller_OnShoot;
	}

	private void Controller_OnShoot(Vector3 obj)
	{
		rigid.drag = startDrag;
		nextDrag = Time.time + 0.1f;
	}

	private void FixedUpdate()
	{
		if (controller.IsFPG && controller.IsGrounded && !controller.BlockShooting)
		{
			rigid.drag = Mathf.MoveTowards(rigid.drag, startDrag * 20f, Time.deltaTime * 30f);
			rigid.AddForce(Vector3.down * 1500f * Time.fixedDeltaTime, ForceMode.Acceleration);
			return;
		}
		if (controller.IsFPG && controller.IsGrounded && Time.time > nextDrag)
		{
			rigid.drag = Mathf.MoveTowards(rigid.drag, startDrag * 20f, Time.deltaTime * 30f);
		}
		else if (controller.IsGrounded && Time.time > nextDrag)
		{
			rigid.drag = Mathf.MoveTowards(rigid.drag, startDrag * 8f, Time.deltaTime * 30f);
		}
		else
		{
			rigid.drag = Mathf.MoveTowards(rigid.drag, startDrag, Time.deltaTime * 30f);
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (Time.time > nextDrag)
		{
			Vector3 velocity = rigid.velocity;
			rigid.velocity = new Vector3(velocity.x * 0.8f, velocity.y, velocity.z * 0.8f);
		}
	}
}
