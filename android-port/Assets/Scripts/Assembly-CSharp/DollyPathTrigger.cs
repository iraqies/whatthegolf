using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DollyPathTrigger : MonoBehaviour
{
	[CompilerGenerated]
	private Action<SecondaryDollyPath> m_OnDollyPathEnter;

	[CompilerGenerated]
	private Action<SecondaryDollyPath> m_OnDollyPathExit;

	public event Action<SecondaryDollyPath> OnDollyPathEnter
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

	public event Action<SecondaryDollyPath> OnDollyPathExit
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

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private bool GetPathOnTrigger(Collider other, out SecondaryDollyPath path)
	{
		path = null;
		return false;
	}
}
