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
		add => m_OnEnterSaveSpot = (Action<SaveSpot>)Delegate.Combine(m_OnEnterSaveSpot, value);
		[CompilerGenerated]
		remove => m_OnEnterSaveSpot = (Action<SaveSpot>)Delegate.Remove(m_OnEnterSaveSpot, value);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision == null) return;
		var spot = collision.GetComponent<SaveSpot>();
		if (spot != null)
		{
			lastSavePosition = spot.transform.position;
			m_OnEnterSaveSpot?.Invoke(spot);
		}
	}
}
