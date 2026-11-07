using UnityEngine;

public class OverworldSuperPuttClock : MonoBehaviour
{
	public Rigidbody2D large;

	public Rigidbody2D minor;

	public float largeSpeed;

	public float minorSpeed;

	private Rigidbody2D ball;

	private Vector2 lastBallPos;

	private float totalBallMovement;

	private void Start()
	{
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
	}

	private void FixedUpdate()
	{
	}
}
