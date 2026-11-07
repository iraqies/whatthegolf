using System.Collections;
using Core;
using UnityEngine;

public class CurlingBall : MonoBehaviour
{
	public float force;

	public Rigidbody broom;

	public GolfBallController broomController;

	public float failSpeed;

	private Rigidbody rbody;

	private bool hasStarted;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private IEnumerator DelayedStart()
	{
		return null;
	}

	private IEnumerator DelayBool()
	{
		return null;
	}
}
