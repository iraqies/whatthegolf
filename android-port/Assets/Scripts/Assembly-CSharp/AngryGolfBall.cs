using System.Collections;
using Core;
using UnityEngine;

public class AngryGolfBall : MonoBehaviour
{
	public GolfBallController ballController;

	public Rigidbody2D ballRb;

	public float resetSqrVel;

	public float waitTime;

	public AudioSource flyAudioSource;

	public float flyAudioDelay;

	public Transform CameraFollow;

	public bool lockY;

	public float lockYValue;

	public Vector3 followOffset;

	public float SmoothTime;

	public ExplosionBarrel2D explosionBarrel;

	private Coroutine coroutine;

	private Vector3 startPos;

	private Vector3 tmpVel;

	private void Start()
	{
	}

	private void BallController_OnReset()
	{
	}

	private void BallController_OnShoot(Vector3 obj)
	{
	}

	private IEnumerator ResetAfterShot()
	{
		return null;
	}

	private void Update()
	{
	}
}
