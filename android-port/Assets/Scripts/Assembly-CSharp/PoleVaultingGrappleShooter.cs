using System;
using System.Collections.Generic;
using Core;
using RootMotion.Dynamics;
using UnityEngine;

public class PoleVaultingGrappleShooter : GolfBallShooterBase
{
	[Serializable]
	public class Spiderhook
	{
		public Rigidbody HookRigid;

		public Rigidbody HookAttach;

		public bool HasHit;

		public bool Enabled;

		public bool OnlyThisActive;

		public float HitDotResult;

		private SpringJoint spring;

		public SpringJoint GetSpring()
		{
			return null;
		}
	}

	public List<Spiderhook> SpiderHooks;

	public float HookForwardMovement;

	public float HookSpeed;

	public float HookLength;

	public float SpringTotalPullForce;

	public float ExtraUpwardsPullForce;

	public float HookBreakThreshold;

	public LayerMask HitLayer;

	public PuppetMaster Puppet;

	public Rigidbody PuppetRoot;

	public List<AudioClip> ShootClip;

	public List<AudioClip> ShootHitClip;

	public List<AudioClip> RopeCutClip;

	private int curHandIndex;

	private float resetTimer;

	private void Start()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	StandardShoot(boost, 20f, 18f, 5f);
	}

	protected override void FixedUpdate()
	{
	base.FixedUpdate();
	}

	public override void OnReset()
	{
	}

	private void Reset()
	{
	}
}
