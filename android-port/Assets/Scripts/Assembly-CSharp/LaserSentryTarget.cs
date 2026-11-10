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
			m_OnLasered = (Action)Delegate.Combine(m_OnLasered, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnLasered = (Action)Delegate.Remove(m_OnLasered, value);
		}
	}

	private void Awake()
	{
		rigids = GetComponentsInChildren<Rigidbody>();
	}

	public void Laser(Vector3 position, float radius)
	{
		m_OnLasered?.Invoke();
		if (rigids == null)
		{
			return;
		}
		for (int i = 0; i < rigids.Length; i++)
		{
			if (rigids[i] != null)
			{
				rigids[i].AddExplosionForce(extraExplosionForce, position, radius);
				rigids[i].AddForce(Vector3.up * extraUpForce, ForceMode.Impulse);
			}
		}
	}
}
