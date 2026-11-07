using System;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;

public class BusFightPlayer : MonoBehaviour
{
	public bool CanDie;

	[CompilerGenerated]
	private Action<float> m_OnHitObstacle;

	[CompilerGenerated]
	private Action<float> m_OnExploded;

	private bool isDead;

	private Rigidbody rigid;

	private GolfBallController controller;

	private GolfCarShooter shooter;

	public event Action<float> OnHitObstacle
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

	public event Action<float> OnExploded
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

	private void Awake()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	public void Explode(Vector3 pos)
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}
}
