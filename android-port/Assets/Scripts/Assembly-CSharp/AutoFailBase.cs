using System;
using UnityEngine;

public abstract class AutoFailBase : MonoBehaviour
{
	public float failStateTime = 0.5f;

	public bool CheckAutoFail;

	public Action OnFail;

	public float m_Timer;

	public virtual void Init()
	{
	}

	public void DecrementFailTimer()
	{
		m_Timer -= Time.deltaTime;
		if (m_Timer <= 0f)
		{
			OnFail?.Invoke();
		}
	}

	public void ResetFailTimer()
	{
		m_Timer = failStateTime;
	}

	public void DoFail()
	{
		OnFail?.Invoke();
	}
}
