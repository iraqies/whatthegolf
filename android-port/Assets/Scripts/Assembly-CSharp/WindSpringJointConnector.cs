using Core;
using UnityEngine;

public class WindSpringJointConnector : MonoBehaviour
{
	public GameObject golfBall;

	public GameObject target;

	public GameObject fan;

	public Animator animator;

	public float speed = 4f;

	private float targetYPosition;

	private Vector3 targetStartPosition;

	private float defaultShootingThreshold;

	private bool followWindTarget;

	private float originalDrag;

	private Rigidbody golfBallRigidbody;

	private GolfBallShooterExperimental golfBallShooter;

	private GolfBallController golfBallController;

	private static readonly int IsVibrating = Animator.StringToHash("isVibrating");

	private void Start()
	{
		GolfBallController golfBallController = Object.FindObjectOfType<GolfBallController>();
		if (golfBallController != null)
		{
			golfBall = golfBallController.gameObject;
		}
		if (target != null)
		{
			targetStartPosition = target.transform.localPosition;
		}
		if (golfBall != null)
		{
			golfBallShooter = golfBall.GetComponent<GolfBallShooterExperimental>();
			this.golfBallController = golfBall.GetComponent<GolfBallController>();
			if (this.golfBallController != null)
			{
				this.golfBallController.OnPreShoot += ShootOutOfWind;
			}
			Rigidbody component = golfBall.GetComponent<Rigidbody>();
			if (component != null)
			{
				originalDrag = component.drag;
			}
			if (golfBallShooter != null)
			{
				defaultShootingThreshold = golfBallShooter.shootingThreshold;
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || !other.CompareTag("Player"))
		{
			return;
		}
		followWindTarget = true;
		if (target != null)
		{
			target.transform.parent = null;
			Vector3 position = target.transform.position;
			position.y = targetYPosition;
			target.transform.position = position;
			if (fan != null)
			{
				target.transform.parent = fan.transform;
			}
			target.transform.localPosition = targetStartPosition;
		}
		golfBall = other.gameObject;
		golfBallRigidbody = golfBall.GetComponent<Rigidbody>();
		if (golfBallRigidbody != null)
		{
			golfBallRigidbody.velocity = Vector3.zero;
			golfBallRigidbody.angularVelocity = Vector3.zero;
			golfBallRigidbody.drag = 10f;
		}
		if (golfBallShooter != null)
		{
			golfBallShooter.shootingThreshold = 2000f;
		}
		if (animator != null)
		{
			animator.SetBool(IsVibrating, true);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other == null || !other.CompareTag("Player"))
		{
			return;
		}
		if (golfBallShooter != null)
		{
			golfBallShooter.shootingThreshold = defaultShootingThreshold;
		}
		if (golfBallRigidbody != null)
		{
			golfBallRigidbody.drag = originalDrag;
		}
		if (animator != null)
		{
			animator.SetBool(IsVibrating, false);
		}
	}

	public void CloseWind()
	{
		if (golfBallShooter != null)
		{
			golfBallShooter.shootingThreshold = defaultShootingThreshold;
		}
		if (golfBallRigidbody != null)
		{
			golfBallRigidbody.drag = originalDrag;
		}
	}

	private void ShootOutOfWind(Vector3 shoot)
	{
		if (followWindTarget)
		{
			CloseWind();
			followWindTarget = false;
		}
	}

	private void OnDestroy()
	{
		if (golfBallController != null)
		{
			golfBallController.OnPreShoot -= ShootOutOfWind;
		}
	}

	private void OnTriggerStay(Collider other)
	{
		if (other != null && other.CompareTag("Player") && followWindTarget && golfBallRigidbody != null && target != null)
		{
			Vector3 position = Vector3.MoveTowards(golfBallRigidbody.position, target.transform.position, speed * 10f * Time.deltaTime);
			golfBallRigidbody.MovePosition(position);
		}
	}
}
