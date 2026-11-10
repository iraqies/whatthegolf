using System;
using System.Collections;
using Audio;
using Cinemachine;
using Core;
using UnityEngine;

public class SHMUPController : GolfBallShooterBase
{
	public Vector2 Speed = Vector2.one;

	public float MoveWarmupTime = 2f;

	public float AimResetSpeed = 1f;

	public float TurnSpeed = 1f;

	public CinemachineVirtualCamera ShootCamera;

	public Animator GolfAnimator;

	public GameObject FakeGolfBall;

	public Rigidbody GolfBall;

	public float BallForce;

	public Transform FrogTarget;

	public SHMUPFrogKing FrogKing;

	public Animator BoatController;

	public GameObject ColliderContainer;

	public AudioEventAsset sfxEventOnPush;

	public AudioEventAsset sfxEventOnSink;

	public AudioEventAsset sfxEventOnballPickup;

	public AudioEventAsset sfxEventOnShoot;

	public Action OnSinkBefore;

	public Action OnSinkReset;

	public Action OnSinkAfterTransition;

	public Action OnEnterMouth;

	private Vector3 targetBlend;

	private float currentSpeed;

	private float aimDirTarget;

	private float currentAim;

	private float velRef;

	private Vector3 externalForce;

	private bool isSinking;

	private Vector3 startPos;

	private TimeControl timeControl;

	private void Start()
	{
		startPos = transform.position;
		timeControl = FindObjectOfType<TimeControl>();
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		base.OnAimUpdate(boost, onlyAimArrow);
		aimDirTarget = boost.x;
		if (ShootCamera != null && ShootCamera.gameObject.activeSelf)
		{
			targetBlend = boost;
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		ShootBall();
	}

	public override void OnCancel()
	{
	}

	protected override void FixedUpdate()
	{
		if (isSinking)
			return;

		if (FrogKing != null && FrogKing.HitsTaken >= FrogKing.Health)
		{
			currentSpeed = Mathf.MoveTowards(currentSpeed, Speed.y * 0.75f, Time.deltaTime * 5f);
			if (rigidbodyC != null)
			{
				Vector3 pos = rigidbodyC.position + Vector3.forward * (Time.deltaTime * currentSpeed);
				Vector3 rightOffset = Vector3.right * rigidbodyC.position.x;
				pos -= rightOffset * (Time.deltaTime / 3f);
				rigidbodyC.MovePosition(pos);
				rigidbodyC.MoveRotation(Quaternion.RotateTowards(rigidbodyC.rotation, Quaternion.identity, Time.deltaTime * 10f));
			}
			return;
		}

		if (MoveWarmupTime > 0f)
		{
			currentSpeed = Mathf.MoveTowards(currentSpeed, Speed.y, Time.deltaTime / MoveWarmupTime);
		}
		else
		{
			currentSpeed = Speed.y;
		}

		Vector3 sideVec = (externalForce.sqrMagnitude > 0f) ? externalForce : (Vector3.right * currentAim);
		if (rigidbodyC != null)
		{
			Vector3 delta = sideVec * (Time.deltaTime * Speed.x) + Vector3.forward * (Time.deltaTime * currentSpeed);
			rigidbodyC.MovePosition(rigidbodyC.position + delta);
		}

		if (aimDirTarget != 0f && !float.IsNaN(aimDirTarget))
		{
			currentAim = Mathf.MoveTowards(currentAim, aimDirTarget, Time.deltaTime * TurnSpeed);
			if (rigidbodyC != null)
			{
				Vector3 lookDir = new Vector3(currentAim, 0f, 1f).normalized;
				rigidbodyC.MoveRotation(Quaternion.LookRotation(lookDir, Vector3.up));
			}
		}

		aimDirTarget = Mathf.MoveTowards(aimDirTarget, 0f, Time.deltaTime * AimResetSpeed);
		externalForce = Vector3.MoveTowards(externalForce, Vector3.zero, Time.deltaTime * 3f);
	}

	private void Update()
	{
		if (ShootCamera == null || !ShootCamera.gameObject.activeSelf)
			return;

		if (GolfAnimator != null)
		{
			float curBlend = GolfAnimator.GetFloat("Blend");
			float damped = Mathf.SmoothDamp(curBlend, targetBlend.magnitude, ref velRef, 0.2f, float.PositiveInfinity, Time.unscaledDeltaTime);
			GolfAnimator.SetFloat("Blend", Mathf.Min(0.9f, damped));
		}

		if (GolfBallController != null && GolfBallController.GetIsCharging(0))
		{
			if (GolfBallController.GetPlayerAxisDirection(false, "AimHorizontal", "AimVertical").magnitude == 0f)
			{
				targetBlend = Vector3.zero;
			}
		}
	}

	private IEnumerator PlayShootSequence()
	{
		float startVal = (GolfAnimator != null) ? Mathf.Min(0.9f, GolfAnimator.GetFloat("Blend")) : 0f;
		yield return StartCoroutine(pTween.ToRealTime(0.1f, t =>
		{
			if (GolfAnimator != null)
				GolfAnimator.SetFloat("Blend", Mathf.Lerp(startVal, 1f, t));
		}));

		if (FakeGolfBall != null)
			FakeGolfBall.gameObject.SetActive(false);

		if (GolfBall != null && FakeGolfBall != null)
		{
			Rigidbody spawnedBall = Instantiate(GolfBall, FakeGolfBall.transform.position, FakeGolfBall.transform.rotation);
			if (spawnedBall != null)
			{
				spawnedBall.gameObject.SetActive(true);
				Vector3 startBallPos = spawnedBall.position;
				float dist = (FrogTarget != null) ? (FrogTarget.position - transform.position).magnitude : 10f;
				Vector3 targetPos = transform.position + targetBlend.normalized * (dist * 2.5f);
				spawnedBall.velocity = CalculateVelocityForTarget(startBallPos, targetPos, 15f);
				Time.timeScale = 1f;
				if (timeControl != null)
					timeControl.enabled = true;
				if (ShootCamera != null)
					ShootCamera.gameObject.SetActive(false);
				if (BoatController != null)
					BoatController.SetBool("GolfReady", false);
				StartCoroutine(DestroyBall(spawnedBall.gameObject));
				if (FrogKing != null)
					StartCoroutine(FrogKing.WaitForPlayerShot(spawnedBall.gameObject));
			}
		}
	}

	private IEnumerator DestroyBall(GameObject ball)
	{
		while (ball != null && FakeGolfBall != null && ball.transform.position.y > FakeGolfBall.transform.position.y - 10f)
		{
			yield return null;
		}
		if (ball != null)
			ball.SetActive(false);
	}

	public void ShootBall()
	{
		if (ShootCamera != null && ShootCamera.gameObject.activeSelf)
		{
			StartCoroutine(PlayShootSequence());
			if (sfxEventOnShoot != null)
				sfxEventOnShoot.Play(transform.position, 1f, 1f, false);
		}
	}

	public void CollectedBalls()
	{
		if (sfxEventOnballPickup != null)
			sfxEventOnballPickup.Play(transform.position, 1f, 1f, false);
		if (BoatController != null)
			BoatController.SetBool("GolfReady", true);
		if (FakeGolfBall != null)
			FakeGolfBall.gameObject.SetActive(true);
		if (GolfBallController != null)
			GolfBallController.StopAiming();
		if (ShootCamera != null)
			ShootCamera.gameObject.SetActive(true);
		if (timeControl != null)
			timeControl.enabled = false;
		Time.timeScale = 0f;
	}

	private IEnumerator SinkRoutine(float initialWaitTime, Vector3 sinkDirection, float angularVelocity, float waitTimeBeforeTransition, float moveTime)
	{
		OnSinkBefore?.Invoke();
		yield return new WaitForSeconds(initialWaitTime);

		if (AudioManager.Instance != null && AudioManager.Instance.rumbleManager != null && AudioManager.Instance.rumbleManager.LongBuildupRumble != null)
		{
			AudioManager.Instance.rumbleManager.LongBuildupRumble.Play(0, 1f);
		}

		Vector3 startP = (rigidbodyC != null) ? rigidbodyC.position : transform.position;
		Vector3 endP = startP + sinkDirection * 15f;
		yield return StartCoroutine(pTween.To(moveTime, t =>
		{
			if (rigidbodyC != null)
			{
				rigidbodyC.MovePosition(Vector3.Lerp(startP, endP, t));
				rigidbodyC.MoveRotation(Quaternion.Euler(t * angularVelocity, 0f, 0f));
			}
		}));

		yield return new WaitForSeconds(waitTimeBeforeTransition);

		if (LevelManager.Instance != null)
			yield return StartCoroutine(LevelManager.Instance.StartTransition(Color.black));

		transform.position = startPos;
		currentSpeed = 0f;
		OnSinkReset?.Invoke();

		yield return new WaitForSeconds(0.5f);

		if (LevelManager.Instance != null)
			yield return StartCoroutine(LevelManager.Instance.EndTransition(false, 0f));

		OnSinkAfterTransition?.Invoke();
		isSinking = false;
		if (GolfBallController != null)
			GolfBallController.enabled = true;
	}

	private IEnumerator SinkRoutine(SinkBoat settings)
	{
		if (settings != null)
		{
			yield return StartCoroutine(SinkRoutine(settings.InitialWaitTime, settings.SinkDirection, settings.AngularVelocity, settings.WaitTimeBeforeTransition, settings.MoveTime));
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || other.attachedRigidbody == null)
			return;

		if (other.attachedRigidbody.TryGetComponent<PushBoat>(out var push))
		{
			externalForce = push.PushForce;
			if (sfxEventOnPush != null)
				sfxEventOnPush.Play(transform.position, 1f, 1f, false);
		}

		if (other.attachedRigidbody.TryGetComponent<SinkBoat>(out var sink))
		{
			if (sfxEventOnSink != null)
				sfxEventOnSink.Play(transform.position, 1f, 1f, false);
			isSinking = true;
			if (sink.Tentacle != null)
				sink.Tentacle.SetTrigger("Attack");
			if (GolfBallController != null)
			{
				GolfBallController.enabled = false;
				GolfBallController.StopAiming();
			}
			StartCoroutine(SinkRoutine(sink));
		}

		if (other.attachedRigidbody.TryGetComponent<ExplosionBarrel>(out var barrel))
		{
			barrel.Explode(null);
			if (sfxEventOnSink != null)
				sfxEventOnSink.Play(transform.position, 1f, 1f, false);
			isSinking = true;
			if (GolfBallController != null)
			{
				GolfBallController.enabled = false;
				GolfBallController.StopAiming();
			}
			StartCoroutine(SinkRoutine(0f, Vector3.down, 0f, 1f, 0.5f));
		}

		if (other.attachedRigidbody.TryGetComponent<OverworldMouth>(out _))
		{
			OnEnterMouth?.Invoke();
		}
	}

	public Vector3 CalculateVelocityForTarget(Vector3 startPosition, Vector3 target, float initialAngle)
	{
		float g = Physics.gravity.magnitude;
		float rad = initialAngle * ((float)Math.PI / 180f);
		float planarDist = Vector3.Distance(new Vector3(target.x, 0f, target.z), new Vector3(startPosition.x, 0f, startPosition.z));
		float yOffset = startPosition.y - target.y;
		float cos = Mathf.Cos(rad);
		float sin = Mathf.Sin(rad);
		float tan = Mathf.Tan(rad);
		float denom = yOffset + tan * planarDist;
		if (denom <= 0.0001f || Mathf.Abs(cos) <= 0.0001f)
			return (target - startPosition).normalized * 20f;

		float speed = (1f / cos) * Mathf.Sqrt(0.5f * g * planarDist * planarDist / denom);
		Vector3 localVel = new Vector3(0f, sin * speed, cos * speed);
		float angle = Vector3.Angle(Vector3.forward, new Vector3(target.x - startPosition.x, 0f, target.z - startPosition.z));
		if (target.x < startPosition.x)
			angle = -angle;
		return Quaternion.AngleAxis(angle, Vector3.up) * localVel;
	}
}
