using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;
using Utility;

public class ArrowShooter : GolfBallShooterBase
{
	[CompilerGenerated]
	private Action<Arrow3D> m_OnShootArrow;

	public Animator Animator;

	public Transform ArcherTorso;

	public float ShootForce;

	public Transform ArrowStart;

	public Arrow3D ArrowTemplate;

	public int ArrowCount;

	public bool isUsingRandomOffset;

	private ObjectPool<Arrow3D> arrowPool;

	public List<Collider> ignoredColliders;

	private Collider[] ownColliders;

	private string aimAnimParamName;

	private string shootAnimParamName;

	public event Action<Arrow3D> OnShootArrow
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	private void OnHitGoal()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	private IEnumerator ShootArrows(Vector3 boost)
	{
		return null;
	}

	private Arrow3D SpawnNewArrow()
	{
		return null;
	}

	private void InitializeArrow(Arrow3D newArrow)
	{
	}
}
