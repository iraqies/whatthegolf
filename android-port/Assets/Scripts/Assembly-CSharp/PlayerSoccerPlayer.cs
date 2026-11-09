using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class PlayerSoccerPlayer : GolfBallShooterBase
{
	public float MoveSpeed = 10f;

	public float ShootForce = 10f;

	public float ShootUpForce = 1f;

	public float SlideForce = 10f;

	public float MaxSpeedSqr = 300f;

	public float MaxSpeedWithBallSqr = 100f;

	public float MaxSlideSpeed = 600f;

	public float SlideTime = 1f;

	public float MinSpeedForSlide = 50f;

	public PlayableSoccerBall Football;

	public RandomAudioClips ShootClips;

	public RandomAudioClips SlideClips;

	public List<PlayerSoccerInfo> Players;

	public Transform CameraFollow;

	public bool AffectTime = true;

	public float ChangeTargetBlockTime = 0.1f;

	public float SidewaysDrag = 1f;

	private float changeTargetTimer;

	private bool hasBall;

	private Rigidbody attatchedBall;

	private FixedJoint attachedJoint;

	private float currentMaxSpeed;

	private float slideTimer;

	private float targetRot;

	private float rotVel;

	private PlayerSoccerInfo currentPlayer;

	private Vector3 curVel;

	private float switchPlayerTimer;

	private Collider collider;

	private void Start()
	{
		collider = GetComponent<Collider>();
		if (Players != null)
		{
			foreach (var p in Players)
			{
				if (p == null) continue;
				p.OnBallRecieved += OnBallRecieved;
				p.OnBallLost += OnBallLost;
			}
			if (Players.Count > 0)
				SetPlayer(Players[0]);
		}
		switchPlayerTimer = 0f;
	}

	private void OnBallLost()
	{
		hasBall = false;
	}

	private void SetPlayer(PlayerSoccerInfo newPlayer)
	{
		if (currentPlayer != null)
		{
			if (currentPlayer.Animator != null)
				currentPlayer.Animator.SetBool("Sliding", false);
			if (currentPlayer.SlideParticles != null)
				currentPlayer.SlideParticles.Stop();
		}
		if (newPlayer != null)
		{
			RigidbodyOverride = newPlayer.Rigidbody;
			currentPlayer = newPlayer;
			switchPlayerTimer = 1f;
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (slideTimer > 0f || rigidbodyC == null)
			return;
		rigidbodyC.AddForce(boost * MoveSpeed * Time.deltaTime, ForceMode.Force);
		if (boost.sqrMagnitude > 1e-6f)
			rigidbodyC.MoveRotation(Quaternion.LookRotation(boost.normalized));

		Vector3 vel = rigidbodyC.velocity;
		Vector3 up = rigidbodyC.transform.up;
		Vector3 proj = up * Vector3.Dot(vel, up);
		rigidbodyC.velocity = Vector3.Lerp(vel, proj, Mathf.Clamp01(SidewaysDrag * Time.deltaTime));
	}

	public override void OnShoot(Vector3 boost)
	{
		if (hasBall)
		{
			if (Football != null)
			{
				Football.Disengage();
				if (Football.Rigidbody != null)
					Football.Rigidbody.velocity = boost * ShootForce + Vector3.up * ShootUpForce;
			}
			hasBall = false;
			if (ShootClips != null)
				ShootClips.PlayRandomClip(null);
			currentMaxSpeed = MaxSpeedSqr;
			if (GolfBallController != null)
				GolfBallController.affectTime = false;
		}
		else if (slideTimer <= 0f && rigidbodyC != null && rigidbodyC.velocity.sqrMagnitude >= MinSpeedForSlide)
		{
			slideTimer = SlideTime;
			if (currentPlayer != null)
				currentPlayer.Slide(boost * SlideForce);
		}
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (Players == null)
			return;

		foreach (var p in Players)
		{
			if (p == null) continue;
			if (p == currentPlayer)
			{
				if (rigidbodyC != null && rigidbodyC.velocity.sqrMagnitude >= currentMaxSpeed)
					rigidbodyC.velocity *= 0.9f;
			}
			else if (p.Rigidbody != null && p.Rigidbody.velocity.sqrMagnitude >= MaxSpeedSqr)
			{
				if (rigidbodyC != null)
					rigidbodyC.velocity *= 0.9f;
			}
		}

		if (slideTimer > 0f)
		{
			slideTimer -= Time.deltaTime;
			if (slideTimer <= 0f && currentPlayer != null && currentPlayer.SlideParticles != null)
				currentPlayer.SlideParticles.Stop();
		}

		if (hasBall)
		{
			currentMaxSpeed = MaxSpeedWithBallSqr;
			if (currentPlayer != null && currentPlayer.Animator != null)
				currentPlayer.Animator.SetBool("Sliding", false);
		}
		else if (slideTimer > 0f)
		{
			currentMaxSpeed = MaxSlideSpeed;
			if (currentPlayer != null && currentPlayer.Animator != null)
				currentPlayer.Animator.SetBool("Sliding", true);
		}
		else
		{
			currentMaxSpeed = MaxSpeedSqr;
			if (currentPlayer != null && currentPlayer.Animator != null)
				currentPlayer.Animator.SetBool("Sliding", false);
		}

		if (CameraFollow != null && rigidbodyC != null)
		{
			if (switchPlayerTimer > 0f)
			{
				CameraFollow.position = Vector3.SmoothDamp(CameraFollow.position, rigidbodyC.position, ref curVel, 0.2f);
				switchPlayerTimer -= Time.deltaTime;
			}
			else
			{
				CameraFollow.position = rigidbodyC.position;
			}
		}

		if (rigidbodyC != null)
			transform.position = rigidbodyC.position;

		foreach (var p in Players)
		{
			if (p == null || p == currentPlayer || p.FieldArea == null || Football == null || Football.Rigidbody == null || p.Rigidbody == null)
				continue;
			Vector3 closest = p.FieldArea.ClosestPoint(Football.Rigidbody.position);
			Vector3 dirFromField = (p.Rigidbody.position - closest).normalized;
			Vector3 targetPos = closest + dirFromField * 10f;
			Vector3 moveDir = (targetPos - p.Rigidbody.position).normalized;
			p.Rigidbody.AddForce(moveDir * MoveSpeed, ForceMode.Force);
			Vector3 lookDir = (Football.Rigidbody.position - p.Rigidbody.position).normalized;
			if (lookDir.sqrMagnitude > 1e-6f)
				p.Rigidbody.MoveRotation(Quaternion.LookRotation(lookDir));
		}
	}

	private void Update()
	{
		if (Football != null)
		{
			var heldBy = Football.GetIsHeldBy();
			if (heldBy != null && heldBy != currentPlayer)
				SetPlayer(heldBy);
		}

		changeTargetTimer -= Time.deltaTime;
		if (!hasBall && changeTargetTimer < 0f && Players != null && Football != null && Football.Rigidbody != null)
		{
			PlayerSoccerInfo closestPlayer = null;
			float bestDist = float.PositiveInfinity;
			for (int i = 0; i < Players.Count; i++)
			{
				var p = Players[i];
				if (p == null || p.Rigidbody == null) continue;
				float d = Vector3.Distance(Football.Rigidbody.position, p.Rigidbody.position);
				if (d < bestDist)
				{
					bestDist = d;
					closestPlayer = p;
				}
			}
			if (closestPlayer != null && closestPlayer != currentPlayer)
			{
				SetPlayer(closestPlayer);
				changeTargetTimer = ChangeTargetBlockTime;
			}
		}
	}

	private void OnBallRecieved()
	{
		hasBall = true;
		slideTimer = 0f;
		if (currentPlayer != null && currentPlayer.SlideParticles != null)
			currentPlayer.SlideParticles.Stop();
		if (AffectTime && GolfBallController != null)
			GolfBallController.affectTime = true;
	}
}
