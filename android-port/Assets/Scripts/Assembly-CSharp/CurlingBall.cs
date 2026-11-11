using System.Collections;
using Core;
using UnityEngine;

public class CurlingBall : MonoBehaviour
{
	public float force = 10f;

	public Rigidbody broom;

	public GolfBallController broomController;

	public float failSpeed = 5f;

	private Rigidbody rbody;

	private bool hasStarted;

	private void Start()
	{
		rbody = GetComponent<Rigidbody>();
		StartCoroutine(DelayedStart());
	}

	private void FixedUpdate()
	{
		broom.velocity = new Vector3(broom.velocity.x, broom.velocity.y, rbody.velocity.z);
		if (hasStarted && Level.Instance != null && rbody.velocity.magnitude < failSpeed)
		{
			Level.Instance.Fail(true, true, broomController, 0f, true, "");
		}
	}

	private IEnumerator DelayedStart()
	{
		yield return new WaitForSeconds(2f);
		rbody.AddForce(0f, 0f, force);
		StartCoroutine(DelayBool());
	}

	private IEnumerator DelayBool()
	{
		yield return new WaitForSeconds(1f);
		hasStarted = true;
	}
}
