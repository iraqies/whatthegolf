using System;
using UnityEngine;

public abstract class AutoFailBase : MonoBehaviour
{
	public float failStateTime;

	public bool CheckAutoFail;

	public Action OnFail;

	public float m_Timer;

	public virtual void Init()
	{
	}

	public void DecrementFailTimer()
	{
	}

	public void ResetFailTimer()
	{
	}

	public void DoFail()
	{
	}
}
