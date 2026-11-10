using System;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;

public class BusFightPlayer : MonoBehaviour
{
	public bool CanDie = true;

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
			m_OnHitObstacle = (Action<float>)Delegate.Combine(m_OnHitObstacle, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnHitObstacle = (Action<float>)Delegate.Remove(m_OnHitObstacle, value);
		}
	}

	public event Action<float> OnExploded
	{
		[CompilerGenerated]
		add
		{
			m_OnExploded = (Action<float>)Delegate.Combine(m_OnExploded, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnExploded = (Action<float>)Delegate.Remove(m_OnExploded, value);
		}
	}

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		controller = GetComponent<GolfBallController>();
		shooter = GetComponent<GolfCarShooter>();
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (isDead || collision == null)
		{
			return;
		}
		if (collision.gameObject.CompareTag("Hazard") || collision.gameObject.GetComponent<ExplosionBarrel2D>() != null)
		{
			m_OnHitObstacle?.Invoke(10f);
		}
	}

	public void Explode(Vector3 pos)
	{
		if (isDead || !CanDie)
		{
			return;
		}
		isDead = true;
		if (rigid != null)
		{
			rigid.AddExplosionForce(15f, pos, 8f, 2f, ForceMode.VelocityChange);
		}
		m_OnExploded?.Invoke(1f);
	}

	public void Pause()
	{
		if (controller != null)
		{
			controller.DisableShooting();
		}
	}

	public void Resume()
	{
		if (controller != null)
		{
			controller.EnableShooting();
		}
	}
}
