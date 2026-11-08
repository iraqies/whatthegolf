using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OutOfBoundsTrigger : MonoBehaviour
{
	[CompilerGenerated]
	private Action<OutOfBoundsTrigger> m_OnOutOfBounds;

	[SerializeField]
	private List<string> boundsTags = new List<string> { "GolfBall", "Ragdoll", "BoundsTrigger" };

	private bool didTrigger;

	public event Action<OutOfBoundsTrigger> OnOutOfBounds
	{
		[CompilerGenerated]
		add => m_OnOutOfBounds = (Action<OutOfBoundsTrigger>)Delegate.Combine(m_OnOutOfBounds, value);
		[CompilerGenerated]
		remove => m_OnOutOfBounds = (Action<OutOfBoundsTrigger>)Delegate.Remove(m_OnOutOfBounds, value);
	}

	public void Reset()
	{
		didTrigger = false;
	}

	public void OutOfBounds()
	{
		m_OnOutOfBounds?.Invoke(this);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (didTrigger || m_OnOutOfBounds == null || other == null) return;
		if (boundsTags != null && boundsTags.Contains(other.tag))
		{
			m_OnOutOfBounds?.Invoke(this);
		}
	}
}
