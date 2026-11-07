using System.Collections.Generic;
using Core;
using UnityEngine;

public class FPGFlying : GolfBallShooterBase
{
	public Animator Animator;

	public float RotateSpeed;

	public float ModelRotateSpeed;

	public float SoarThreshold;

	public float FlySpeed;

	public float WalkSpeed;

	public float MaxSpeed;

	public float MaxDiveSpeed;

	public float GroundedDistance;

	public float ModelRotateAngleMax;

	public LayerMask GroundedLayers;

	public Transform Model;

	public Vector2 HeadRanges;

	public float MaxHeight;

	public float ExtraDownForceWhenNotFlying;

	public float TakeOffDotThreshold;

	public ParticleSystem DiveParticles;

	public List<AudioClip> FlyStartClips;

	public AudioSource DiveSource;

	private bool isFlying;

	private bool isSoaring;

	private bool isGrounded;

	private Rigidbody rigid;

	private Vector3 flyDirection;

	private Quaternion startModelRotation;

	private float extraAnimationSpeed;

	private BoxCollider collider;

	private float headPos;

	private Vector3 lastDir;

	private bool lastFrameGrounded;

	private void Start()
	{
	}

	public override void OnAimStart()
	{
	}

	private void Update()
	{
	}

	protected override void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
