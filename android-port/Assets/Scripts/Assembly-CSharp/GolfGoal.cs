using System;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class GolfGoal : MonoBehaviour
{
	public float winDelay = 0.8f;
	private Action<string> m_OnGoal;
	public string CustomWinTextID;
	private Action<int, string> m_OnGoalProgress;
	public UnityEvent OnGoalEvent = new UnityEvent();
	private bool hasCheated;
	private bool trailerCompleteDetected;
	private bool completed;

	public bool TrailerDelayMode { get; set; }

	public event Action<string> OnGoal
	{
		add => m_OnGoal = (Action<string>)Delegate.Combine(m_OnGoal, value);
		remove => m_OnGoal = (Action<string>)Delegate.Remove(m_OnGoal, value);
	}

	public event Action<int, string> OnGoalProgress
	{
		add => m_OnGoalProgress = (Action<int, string>)Delegate.Combine(m_OnGoalProgress, value);
		remove => m_OnGoalProgress = (Action<int, string>)Delegate.Remove(m_OnGoalProgress, value);
	}

	public virtual void Complete() => Complete(GetWinString());

	public virtual void Complete(float delay) => Complete(GetWinString(), delay);

	protected virtual string GetWinString() => !string.IsNullOrEmpty(CustomWinTextID) ? CustomWinTextID : string.Empty;

	public void GoalProgress(int playerIndex) => m_OnGoalProgress?.Invoke(playerIndex, string.Empty);

	public virtual void Complete(string message) => DoComplete(message, null);

	public virtual void Complete(string message, float delay) => DoComplete(message, delay);

	private void DoComplete(string message, float? delay)
	{
		if (completed) return;
		completed = true;
		OnGoalEvent?.Invoke();
		m_OnGoal?.Invoke(message);
		if (Level.HasInstance)
			Level.Instance.Complete(message, delay ?? winDelay);
	}

	private void CompleteTrailerMode(string message) => DoComplete(message, winDelay);

	public void Reset() => completed = false;
}
