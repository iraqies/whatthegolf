using System.Collections.Generic;
using Core;
using UnityEngine;

public class GrapplingHookShooter : GolfBallShooterExperimental
{
	public GameObject GrapplingHookPrefab;

	public int NumberOfHooks;

	public float GrappleLength;

	public float ObjectThrowSpeed;

	public Vector3 forceShot;

	[SerializeField]
	private float pullMinDistance;

	public List<AudioClip> RopeReachedMaxLengthClips;

	public AudioSource CreakAudio;

	private List<GrapplingHook> hookQueue;

	private int nextHookIndex;

	private GrapplingHook lastHook;

	private bool firstShot;

	private bool setAffectTime;

	private void Start()
	{
	}

	private void OnCollided(Rigidbody rigid)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
	}

	private void Update()
	{
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
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
}
