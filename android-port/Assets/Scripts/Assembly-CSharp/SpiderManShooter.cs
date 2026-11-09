using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class SpiderManShooter : GolfBallShooterBase
{
	[Serializable]
	public class Spiderhook
	{
		public Rigidbody HookRigid;

		public Transform HookAttach;

		public bool HasHit;

		public bool Enabled;

		public bool OnlyThisActive;
	}

	public List<Spiderhook> SpiderHooks;

	public float HookSpeed;

	public float HookHeight;

	public float HookUpBoost;

	public float SpringTotalPullForce;

	public LayerMask KillLayers;

	public List<AudioClip> ShootClip;

	public List<AudioClip> ShootHitClip;

	public List<AudioClip> SwingClip;

	public List<AudioClip> DropClip;

	private int curHandIndex;

	private List<Spiderhook> allHooks;

	private void Start()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, 15f, 5f, 22f, 5f);
	}

	public void ReenableAllHooks()
	{
	}

	public void ShootTowardsPoint(Transform point)
	{
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

	private void OnCollisionEnter(Collision other)
	{
	}
}
