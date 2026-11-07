using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;
using Utility;

public class ArrowShooter2D : GolfBall2DShooterBase
{
	[CompilerGenerated]
	private Action<Arrow2D> m_OnShootArrow;

	public Animator Animator;

	public Transform ArcherTorso;

	public float ShootForce;

	public Transform ArrowStart;

	public Arrow2D ArrowTemplate;

	public int ArrowCount;

	public bool isUsingRandomOffset;

	private ObjectPool<Arrow2D> arrowPool;

	public event Action<Arrow2D> OnShootArrow
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

	private Arrow2D SpawnNewArrow()
	{
		return null;
	}
}
