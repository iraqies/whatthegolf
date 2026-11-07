using Core;
using UnityEngine;

public class WindSpringJointConnector : MonoBehaviour
{
	public GameObject golfBall;

	public GameObject target;

	public GameObject fan;

	public Animator animator;

	public float speed;

	private float targetYPosition;

	private Vector3 targetStartPosition;

	private float defaultShootingThreshold;

	private bool followWindTarget;

	private float originalDrag;

	private Rigidbody golfBallRigidbody;

	private GolfBallShooterExperimental golfBallShooter;

	private GolfBallController golfBallController;

	private static readonly int IsVibrating;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public void CloseWind()
	{
	}

	private void ShootOutOfWind(Vector3 shoot)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}
}
