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
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void OnCollisionEnter2D(Collision2D other)
	{
	}
}
