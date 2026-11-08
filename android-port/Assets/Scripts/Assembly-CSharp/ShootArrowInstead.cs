using System.Collections;
using System.Collections.Generic;
using Audio;
using CameraStack;
using Core;
using UnityEngine;

public class ShootArrowInstead : GolfBallShooterBase
{
	public Transform ColliderObject;

	public float MaxColliderLength;

	public float MaxVelocity;

	public float MinVelocity;

	public float Spin;

	public float Pitch;

	public GolfBallController OtherController;

	public LayerMask GroundLayer;

	public float GroundCheckSize;

	public Vector2 ColliderResizeRange;

	public List<OnCollisionAudioRemote> collisionAudioToApply;

	public AudioMaterial materialToApply;

	public float startDrag;

	private bool hasShot;

	private CBFollow followCamera;

	private bool firstShot;

	private Vector3 aimDirection;

	private Rigidbody oldRigid;

	private int shotCount;

	private float lastInputTarget;

	private CapsuleCollider spawnedCollider;

	private bool initialized;

	protected override void Awake()
	{
	base.Awake();
	}

	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	protected override void FixedUpdate()
	{
	base.FixedUpdate();
	}

	public override void OnAimStart()
	{
	}

	public override void OnAimUpdate(Vector3 dir, bool onlyAimArrow)
	{
	}

	public override void OnCancel()
	{
	}

	public override void OnShoot(Vector3 dir)
	{
	StandardShoot(dir, 20f, 18f, 5f);
	}
}
