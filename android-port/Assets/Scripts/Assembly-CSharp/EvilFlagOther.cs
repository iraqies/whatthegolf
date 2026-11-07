using UnityEngine;

public class EvilFlagOther : MonoBehaviour
{
	public Transform[] positions;

	public float velocity;

	public Rigidbody ball;

	public int fleeLimitTimes;

	public float nextFlee;

	public float fleeDistance;

	public float safeGreenDist;

	public float ballVelocityThreshold;

	public float delay;

	private Rigidbody rigidbody;

	private int currentTarget;

	private float delayTimer;

	public void SetBallVelocityThreshold(float v)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
