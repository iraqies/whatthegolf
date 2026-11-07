using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OverworldButtonCollider : MonoBehaviour
{
	[CompilerGenerated]
	private Action m_OnBallHit;

	public event Action OnBallHit
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

	private void OnCollisionEnter(Collision collision)
	{
	}
}
