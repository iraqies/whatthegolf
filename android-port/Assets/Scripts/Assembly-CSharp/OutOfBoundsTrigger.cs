using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OutOfBoundsTrigger : MonoBehaviour
{
	[CompilerGenerated]
	private Action<OutOfBoundsTrigger> m_OnOutOfBounds;

	[SerializeField]
	private List<string> boundsTags;

	private bool didTrigger;

	public event Action<OutOfBoundsTrigger> OnOutOfBounds
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

	public void Reset()
	{
	}

	public void OutOfBounds()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
