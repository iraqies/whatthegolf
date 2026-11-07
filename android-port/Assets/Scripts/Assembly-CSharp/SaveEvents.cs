using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SaveEvents : MonoBehaviour
{
	public Vector3 lastSavePosition;

	[CompilerGenerated]
	private Action<SaveSpot> m_OnEnterSaveSpot;

	public event Action<SaveSpot> OnEnterSaveSpot
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
