using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class GolfGoal : MonoBehaviour
{
	public float winDelay;

	[CompilerGenerated]
	private Action<string> m_OnGoal;

	public string CustomWinTextID;

	[CompilerGenerated]
	private Action<int, string> m_OnGoalProgress;

	public UnityEvent OnGoalEvent;

	private bool hasCheated;

	private bool trailerCompleteDetected;

	private bool completed;

	public bool TrailerDelayMode { get; set; }

	public event Action<string> OnGoal
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

	public event Action<int, string> OnGoalProgress
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

	public virtual void Complete()
	{
	}

	public virtual void Complete(float delay)
	{
	}

	protected virtual string GetWinString()
	{
		return null;
	}

	public void GoalProgress(int playerIndex)
	{
	}

	public virtual void Complete(string message)
	{
	}

	public virtual void Complete(string message, float delay)
	{
	}

	private void DoComplete(string message, float? delay)
	{
	}

	private void CompleteTrailerMode(string message)
	{
	}

	public void Reset()
	{
	}
}
