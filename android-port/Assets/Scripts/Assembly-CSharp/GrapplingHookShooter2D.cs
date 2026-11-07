using System.Collections.Generic;
using Core;
using UnityEngine;

public class GrapplingHookShooter2D : GolfBallShooterExperimental
{
	public GameObject GrapplingHookPrefab;

	public int NumberOfHooks;

	public float GrappleLength;

	public List<AudioClip> RopeReachedMaxLengthClips;

	public AudioSource CreakAudio;

	public new Rigidbody2D RigidbodyOverride;

	public Collider2D ColliderOverride;

	private List<GrapplingHook2D> hookQueue;

	private int nextHookIndex;

	private GrapplingHook2D lastHook;

	private bool firstShot;

	private bool setAffectTime;

	private Rigidbody2D rigid;

	private bool hooksInitialized;

	private void Start()
	{
	}

	public void SetNumberOfHooks(int hooks)
	{
	}

	private void OnCollided(Rigidbody2D rigid)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	private void Update()
	{
	}

	protected override void FixedUpdate()
	{
	}

	public void LateUpdate()
	{
	}

	public override void OnReset()
	{
	}

	private void EnteredPortal(PortalPackage package)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
