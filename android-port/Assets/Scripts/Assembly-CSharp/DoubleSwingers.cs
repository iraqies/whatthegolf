using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class DoubleSwingers : GolfBallShooterBase
{
	public List<Rigidbody> Swingers;

	public float RotateSpeed;

	public List<Joint> FixedJoints;

	public Rigidbody Pole;

	public float GroundCheckDist;

	public LayerMask GroundMask;

	public float SwingWarmupSpeed;

	public ClipSettingsCollection SwitchClip;

	public ClipSettingsCollection FailClip;

	public AudioSource MoveSource;

	private int currentSwinger;

	private int swingDirection;

	private Dictionary<Rigidbody, Quaternion> baseRotations;

	private Dictionary<Rigidbody, List<Rigidbody>> swingerRigidbodies;

	private bool isSwinging;

	private DoubleSwingersPlatform currentPlatform;

	private Vector3 platformOffset;

	private float swingWarmup;

	private IEnumerator Start()
	{
		return null;
	}

	public override void OnShoot(Vector3 boost)
	{
	StandardShoot(boost, 20f, 18f, 5f);
	}

	protected override void FixedUpdate()
	{
	base.FixedUpdate();
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	private void SwitchSwinger(int nextSwinger)
	{
	}
}
