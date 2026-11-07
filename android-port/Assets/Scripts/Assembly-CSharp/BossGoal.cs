using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BossGoal : GolfGoal
{
	[CompilerGenerated]
	private new Action<string> m_OnGoal;

	public Animator RobotFaceAnimator;

	public new event Action<string> OnGoal
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

	public override void Complete(string message)
	{
	}

	public override void Complete(string message, float delay)
	{
	}
}
