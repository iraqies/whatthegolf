using System.Collections;
using Core;
using UnityEngine;

public class AngryGolfBall : MonoBehaviour
{
	public GolfBallController ballController;

	public Rigidbody2D ballRb;

	public float resetSqrVel = 0.25f;

	public float waitTime = 1f;

	public AudioSource flyAudioSource;

	public float flyAudioDelay = 0.2f;

	public Transform CameraFollow;

	public bool lockY;

	public float lockYValue;

	public Vector3 followOffset;

	public float SmoothTime = 0.2f;

	public ExplosionBarrel2D explosionBarrel;

	private Coroutine coroutine;

	private Vector3 startPos;

	private Vector3 tmpVel;

	private void Start()
	{
		startPos = transform.position;
		if (ballController != null)
		{
			ballController.OnShoot += BallController_OnShoot;
			ballController.OnReset += BallController_OnReset;
		}
	}

	private void BallController_OnReset()
	{
		if (coroutine != null)
		{
			StopCoroutine(coroutine);
			coroutine = null;
		}
	}

	private void BallController_OnShoot(Vector3 obj)
	{
		if (ballRb != null)
		{
			ballRb.isKinematic = false;
		}
		if (coroutine != null)
		{
			StopCoroutine(coroutine);
		}
		if (flyAudioSource != null)
		{
			flyAudioSource.Play();
		}
		coroutine = StartCoroutine(ResetAfterShot());
	}

	private IEnumerator ResetAfterShot()
	{
		if (ballController != null)
		{
			ballController.enabled = false;
		}
		float timer = 0f;
		while (timer < waitTime || (ballRb != null && ballRb.velocity.sqrMagnitude > resetSqrVel))
		{
			timer += Time.deltaTime;
			yield return null;
		}
		if (flyAudioSource != null)
		{
			flyAudioSource.Stop();
		}
		if (ballController != null)
		{
			ballController.Reset(0f);
			ballController.enabled = true;
		}
		transform.position = startPos;
		if (ballRb != null)
		{
			ballRb.isKinematic = true;
		}
		if (explosionBarrel != null)
		{
			explosionBarrel.didExplode = false;
			if (explosionBarrel.burnedRender != null)
			{
				explosionBarrel.burnedRender.enabled = false;
			}
			if (explosionBarrel.normalRender != null)
			{
				explosionBarrel.normalRender.enabled = true;
			}
			explosionBarrel.gameObject.SetActive(true);
		}
	}

	private void Update()
	{
		if (CameraFollow == null)
		{
			return;
		}
		if (ballController != null && ballController.enabled)
		{
			CameraFollow.position = startPos + followOffset;
		}
		else
		{
			Vector3 targetPos = transform.position + followOffset;
			if (lockY)
			{
				targetPos.y = lockYValue + followOffset.y;
			}
			CameraFollow.position = Vector3.SmoothDamp(CameraFollow.position, targetPos, ref tmpVel, SmoothTime);
		}
	}
}
