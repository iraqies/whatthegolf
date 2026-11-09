using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;
using Utility;

public class JavelinShooter : GolfBall2DShooterBase
{
	[CompilerGenerated]
	private Action<Javelin> m_OnShootJavelin;

	public float ShootForce;

	public Transform javelinStart;

	public Javelin javelinTemplate;

	public int javelinCount;

	public bool isUsingRandomOffset;

	private ObjectPool<Javelin> javelinPool;

	public GolfBallController horseController;

	private GolfBallController catController;

	public event Action<Javelin> OnShootJavelin
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

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, 15f, 5f, (ShootForce > 0f ? ShootForce : 22f), 5f);
	}

	private IEnumerator ShootJavelins(Vector3 boost)
	{
		return null;
	}

	private Javelin SpawnNewJavelin()
	{
		return null;
	}
}
