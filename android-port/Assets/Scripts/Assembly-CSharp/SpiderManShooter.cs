using System;
using System.Collections.Generic;
using System.Linq;
using CameraStack;
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

	public float HookSpeed = 10f;

	public float HookHeight = 30f;

	public float HookUpBoost = 1f;

	public float SpringTotalPullForce = 20f;

	public LayerMask KillLayers;

	public List<AudioClip> ShootClip;

	public List<AudioClip> ShootHitClip;

	public List<AudioClip> SwingClip;

	public List<AudioClip> DropClip;

	private int curHandIndex;

	private List<Spiderhook> allHooks;

	private void Start()
	{
		allHooks = SpiderHooks;
		if (SpiderHooks != null)
		{
			SpiderHooks = SpiderHooks.Where(h => h != null && h.Enabled).ToList();
			foreach (Spiderhook hook in SpiderHooks)
			{
				if (hook != null && hook.HookRigid != null)
				{
					SpringJoint sj = hook.HookRigid.gameObject.GetComponent<SpringJoint>();
					if (sj != null && SpiderHooks.Count > 0)
					{
						sj.spring = SpringTotalPullForce / SpiderHooks.Count;
					}
				}
			}
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
		if (SpiderHooks == null || SpiderHooks.Count == 0)
			return;
		curHandIndex = Mathf.Clamp(curHandIndex, 0, SpiderHooks.Count - 1);
		Spiderhook hook = SpiderHooks[curHandIndex];
		if (hook != null && hook.HookRigid != null && hook.HookAttach != null)
		{
			hook.HookRigid.transform.rotation = Quaternion.LookRotation(new Vector3(boost.x, HookUpBoost, boost.z));
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

	public void ReenableAllHooks()
	{
		SpiderHooks = allHooks;
		if (SpiderHooks != null)
		{
			foreach (Spiderhook hook in SpiderHooks)
			{
				if (hook != null)
				{
					hook.Enabled = true;
					hook.OnlyThisActive = false;
				}
			}
		}
	}

	public void ShootTowardsPoint(Transform point)
	{
		if (SpiderHooks == null || SpiderHooks.Count == 0 || point == null)
			return;
		curHandIndex = Mathf.Clamp(curHandIndex, 0, SpiderHooks.Count - 1);
		Spiderhook hook = SpiderHooks[curHandIndex];
		if (hook != null && hook.HookRigid != null && hook.HookAttach != null)
		{
			hook.HookRigid.transform.position = hook.HookAttach.position;
			Vector3 dir = (point.position - hook.HookAttach.position).normalized;
			if (dir != Vector3.zero)
				hook.HookRigid.transform.rotation = Quaternion.LookRotation(dir);
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
		int groundMask = 1 << LayerMask.NameToLayer("Ground");
		foreach (Spiderhook hook in SpiderHooks)
		{
			if (hook == null || hook.HasHit || hook.HookRigid == null)
				continue;
			if (hook.HookRigid.position.y >= HookHeight || Physics.CheckSphere(hook.HookRigid.position, 1f, groundMask))
			{
				hook.HasHit = true;
				if (AudioManager.Instance != null && AudioManager.Instance.shortEffects != null && ShootHitClip != null)
				{
					AudioManager.Instance.shortEffects.Play(ShootHitClip);
				}
			}
			else
			{
				Vector3 nextPos = hook.HookRigid.position + hook.HookRigid.transform.forward * (HookSpeed * Time.fixedDeltaTime);
				hook.HookRigid.MovePosition(nextPos);
			}
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
			}
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other == null || other.gameObject == null)
			return;
		int mask = KillLayers;
		if ((mask | (1 << other.gameObject.layer)) == mask)
		{
			Reset();
			if (CameraManager.Instance != null)
				CameraManager.Instance.Shake(0.5f, 20f, 2f);
			if (AudioManager.Instance != null && AudioManager.Instance.shortEffects != null && DropClip != null)
				AudioManager.Instance.shortEffects.Play(DropClip);
		}
	}
}
