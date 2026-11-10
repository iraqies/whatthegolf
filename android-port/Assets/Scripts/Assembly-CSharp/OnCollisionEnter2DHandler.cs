using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OnCollisionEnter2DHandler : MonoBehaviour
{
	[CompilerGenerated]
	private Action<Collision2D> m_OnCollisionEnter2DEvent;

	public event Action<Collision2D> OnCollisionEnter2DEvent
	{
		[CompilerGenerated]
		add => m_OnCollisionEnter2DEvent = (Action<Collision2D>)Delegate.Combine(m_OnCollisionEnter2DEvent, value);
		[CompilerGenerated]
		remove => m_OnCollisionEnter2DEvent = (Action<Collision2D>)Delegate.Remove(m_OnCollisionEnter2DEvent, value);
	}

	public void OnCollisionEnter2D(Collision2D other)
	{
		m_OnCollisionEnter2DEvent?.Invoke(other);
	}
}
