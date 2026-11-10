using Audio;
using Core;
using UnityEngine;

public class MoonLanderShooter : ShooterBase
{
	[SerializeField]
	private float thrust;

	[SerializeField]
	private float horizontalThrustRatio = 0.1f;

	[SerializeField]
	private float engineLocation = 0.2f;

	[SerializeField]
	private Rigidbody2D rigidbody2D;

	[SerializeField]
	private AudioSource leftAudioSource;

	[SerializeField]
	private AudioSource rightAudioSource;

	[SerializeField]
	private Transform leftFlameTransform;

	[SerializeField]
	private Transform rightFlameTransform;

	[SerializeField]
	private AnimationCurve flameScaleCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);

	[SerializeField]
	private RandomAudioClips crashClips;

	[SerializeField]
	private Transform feetRoot;

	private float left;

	private float right;

	private float left_target;

	private float right_target;

	private float thrustChangeUp = 20f;

	private float thrustChangeDown = 6f;

	private float frameRotationRange;

	private float thrustDuration = 1f;

	private float timer;

	private float minThrust = 0.1f;

	private float explosionForce = 10f;

	private Level level;

	private void Awake()
	{
		level = Level.Instance;
		GolfBallController = GetComponent<GolfBallController>();
	}

	public override void OnShoot(Vector3 boost)
	{
		timer = thrustDuration;
		float rightDot = Vector3.Dot(boost, transform.right);
		float upDot = Vector3.Dot(boost, transform.up);
		float power = Mathf.Lerp(0.3f, 1f, (upDot + 1f) * 0.5f);
		float mag = boost.magnitude;
		left_target = power * Mathf.Lerp(minThrust, 1f, Mathf.InverseLerp(-1f, 0f, rightDot)) * mag;
		right_target = power * Mathf.Lerp(1f, minThrust, Mathf.InverseLerp(0f, 1f, rightDot)) * mag;
	}

	public void FixedUpdate()
	{
		if (timer > 0f)
		{
			timer = Mathf.Max(0f, timer - Time.deltaTime);
		}
		else
		{
			left_target = 0f;
			right_target = 0f;
		}

		float leftSpeed = (left_target > left) ? thrustChangeUp : thrustChangeDown;
		left = Mathf.MoveTowards(left, left_target, leftSpeed * Time.deltaTime);

		float rightSpeed = (right_target > right) ? thrustChangeUp : thrustChangeDown;
		right = Mathf.MoveTowards(right, right_target, rightSpeed * Time.deltaTime);

		if (rigidbody2D != null)
		{
			Vector3 up = transform.up;
			Vector3 pos = transform.position;
			Vector3 rightVec = transform.right;

			Vector2 rightForce = new Vector2(up.x, up.y) * (right * thrust * Time.deltaTime);
			Vector2 rightPos = new Vector2(pos.x + rightVec.x * engineLocation, pos.y + rightVec.y * engineLocation);
			rigidbody2D.AddForceAtPosition(rightForce, rightPos);
			rigidbody2D.AddForce(new Vector2(Vector3.left.x, Vector3.left.y) * (right * thrust * horizontalThrustRatio * Time.deltaTime));

			Vector2 leftForce = new Vector2(up.x, up.y) * (left * thrust * Time.deltaTime);
			Vector2 leftPos = new Vector2(pos.x - rightVec.x * engineLocation, pos.y - rightVec.y * engineLocation);
			rigidbody2D.AddForceAtPosition(leftForce, leftPos);
			rigidbody2D.AddForce(new Vector2(Vector3.right.x, Vector3.right.y) * (left * thrust * horizontalThrustRatio * Time.deltaTime));
		}

		if (leftAudioSource != null)
			leftAudioSource.volume = left * 0.5f;
		if (rightAudioSource != null)
			rightAudioSource.volume = right * 0.5f;
	}

	private void Update()
	{
		if (leftFlameTransform != null)
		{
			leftFlameTransform.localRotation = Quaternion.Euler(0f, 0f, Random.Range(-frameRotationRange, frameRotationRange));
			if (flameScaleCurve != null)
				leftFlameTransform.localScale = Vector3.one * flameScaleCurve.Evaluate(left);
		}
		if (rightFlameTransform != null)
		{
			rightFlameTransform.localRotation = Quaternion.Euler(0f, 0f, Random.Range(-frameRotationRange, frameRotationRange));
			if (flameScaleCurve != null)
				rightFlameTransform.localScale = Vector3.one * flameScaleCurve.Evaluate(right);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision == null || collision.collider == null || collision.otherCollider == null)
			return;
		bool hitGround = collision.collider.CompareTag("Ground");
		bool isFeet = (feetRoot != null && collision.otherCollider.transform.parent == feetRoot);
		if (hitGround && !isFeet)
		{
			Crash();
			return;
		}
		MoonLanderPad pad = collision.collider.GetComponent<MoonLanderPad>();
		if (pad != null)
		{
			pad.Landed(GolfBallController);
		}
	}

	private void Crash()
	{
		if (level != null)
		{
			level.Fail(true, true, GolfBallController, 0f, true, "");
		}
	}
}
