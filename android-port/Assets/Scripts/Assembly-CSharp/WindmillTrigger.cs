using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WindmillTrigger : MonoBehaviour
{
	[CompilerGenerated]
	private Action<OverworldBall2D> m_OnTriggered;

	public event Action<OverworldBall2D> OnTriggered
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

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}
}
