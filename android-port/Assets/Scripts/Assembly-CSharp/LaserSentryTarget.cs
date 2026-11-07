using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LaserSentryTarget : MonoBehaviour
{
	[CompilerGenerated]
	private Action m_OnLasered;

	public float extraExplosionForce;

	public float extraUpForce;

	private Rigidbody[] rigids;

	public event Action OnLasered
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

	public void Laser(Vector3 position, float radius)
	{
	}
}
