using System;
using System.Collections.Generic;
using System.Linq;
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

		public bool Enabled = true;

		public bool OnlyThisActive;

		public float HitDotResult;

		private SpringJoint spring;

		public SpringJoint GetSpring()
		{
			if (spring == null && HookRigid != null)
			{
				spring = HookRigid.GetComponent<SpringJoint>();
			}
			return spring;
		}
	}

	public List<Spiderhook> SpiderHooks;

	public float HookForwardMovement = 10f;

	public float HookSpeed = 10f;

	public float HookLength = 30f;

	public float SpringTotalPullForce = 20f;

	public float ExtraUpwardsPullForce = 10f;

	public float HookBreakThreshold = 0.2f;

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
		if (SpiderHooks != null)
		{
			SpiderHooks = SpiderHooks.Where(h => h != null && h.Enabled).ToList();
			foreach (Spiderhook hook in SpiderHooks)
			{
				SpringJoint sj = hook.GetSpring();
				if (sj != null && SpiderHooks.Count > 0)
				{
					sj.spring = SpringTotalPullForce / SpiderHooks.Count;
				}
			}
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		if (SpiderHooks == null || SpiderHooks.Count == 0)
			return;
		curHandIndex = Mathf.Clamp(curHandIndex, 0, SpiderHooks.Count - 1);
		if (Puppet != null && Puppet.state == PuppetMaster.State.Alive && SpiderHooks[curHandIndex] != null && SpiderHooks[curHandIndex].HasHit)
			return;

		base.OnShoot(boost);
		Spiderhook hook = SpiderHooks[curHandIndex];
		if (hook != null && hook.HookRigid != null && hook.HookAttach != null)
		{
			Vector3 flatBoost = new Vector3(0f, boost.y, boost.z).normalized;
			if (flatBoost != Vector3.zero)
				hook.HookRigid.transform.rotation = Quaternion.LookRotation(flatBoost);
			hook.HookRigid.transform.position = hook.HookAttach.position;
			hook.HookRigid.gameObject.SetActive(true);
			hook.HasHit = false;
			if (hook.OnlyThisActive)
			{
				for (int i = 0; i < SpiderHooks.Count; i++)
				{
					if (i != curHandIndex && SpiderHooks[i] != null)
					{
						SpiderHooks[i].HasHit = false;
						if (SpiderHooks[i].HookRigid != null && SpiderHooks[i].HookAttach != null)
						{
							SpiderHooks[i].HookRigid.position = SpiderHooks[i].HookAttach.position;
							SpiderHooks[i].HookRigid.gameObject.SetActive(false);
						}
					}
				}
			}
		}
		curHandIndex = (curHandIndex + 1) % SpiderHooks.Count;
		if (AudioManager.Instance != null && AudioManager.Instance.shortEffects != null && ShootClip != null)
		{
			AudioManager.Instance.shortEffects.Play(ShootClip);
		}
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (SpiderHooks == null)
			return;

		foreach (Spiderhook hook in SpiderHooks)
		{
			if (hook == null || hook.HookRigid == null)
				continue;

			if (!hook.HasHit && hook.HookRigid.gameObject.activeSelf)
			{
				if (Physics.CheckSphere(hook.HookRigid.position, 0.5f, HitLayer))
				{
					hook.HasHit = true;
					if (AudioManager.Instance != null && AudioManager.Instance.shortEffects != null && ShootHitClip != null)
					{
						AudioManager.Instance.shortEffects.Play(ShootHitClip);
					}
					SpringJoint sj = hook.GetSpring();
					if (sj != null)
						sj.connectedBody = hook.HookAttach;

					if (Puppet != null && Puppet.behaviours != null)
					{
						foreach (BehaviourBase b in Puppet.behaviours)
						{
							if (b is BehaviourPuppet bp)
								bp.SetState(BehaviourPuppet.State.Unpinned);
						}
					}

					if (hook.HookAttach != null)
					{
						Vector3 dir = (hook.HookRigid.position - hook.HookAttach.position).normalized;
						hook.HitDotResult = Vector3.Dot(Vector3.forward, dir);
					}
				}
				else if (PuppetRoot != null)
				{
					Vector3 rootVel = PuppetRoot.velocity;
					Vector3 pos = hook.HookRigid.position + new Vector3(0f, 0f, rootVel.z * HookForwardMovement) + hook.HookRigid.transform.forward * (HookSpeed * Time.fixedDeltaTime);
					hook.HookRigid.MovePosition(pos);
				}

				if (hook.HookAttach != null && Vector3.Distance(hook.HookRigid.position, hook.HookAttach.position) > HookLength)
				{
					if (AudioManager.Instance != null && AudioManager.Instance.shortEffects != null && RopeCutClip != null)
					{
						AudioManager.Instance.shortEffects.Play(RopeCutClip);
					}
					Reset();
				}
			}

			if (hook.HasHit && hook.HookAttach != null)
			{
				Vector3 dir = (hook.HookAttach.position - hook.HookRigid.position).normalized;
				if (dir.z >= HookBreakThreshold)
				{
					if (AudioManager.Instance != null && AudioManager.Instance.shortEffects != null && RopeCutClip != null)
					{
						AudioManager.Instance.shortEffects.Play(RopeCutClip);
					}
					Reset();
					resetTimer = 1f;
				}
				Vector3 pullDir = (Vector3.up + Vector3.forward).normalized;
				hook.HookAttach.AddForce(pullDir * ExtraUpwardsPullForce);
			}
		}

		if (resetTimer > 0f)
		{
			resetTimer -= Time.deltaTime;
		}
	}

	public override void OnReset()
	{
		base.OnReset();
		Reset();
	}

	private void Reset()
	{
		if (SpiderHooks == null)
			return;
		foreach (Spiderhook hook in SpiderHooks)
		{
			if (hook != null)
			{
				hook.HasHit = false;
				if (hook.HookRigid != null && hook.HookAttach != null)
				{
					hook.HookRigid.position = hook.HookAttach.position;
					hook.HookRigid.gameObject.SetActive(false);
				}
				SpringJoint sj = hook.GetSpring();
				if (sj != null)
					sj.connectedBody = null;
			}
		}
	}
}
