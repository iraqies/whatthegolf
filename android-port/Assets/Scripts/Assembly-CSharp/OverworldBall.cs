using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OverworldBall : MonoBehaviour
{
	[CompilerGenerated]
	private Action<OverworldArea> m_OnEnterArea;

	[CompilerGenerated]
	private Action<OverworldArea> m_OnExitArea;

	public float clampYPosition;

	private Rigidbody rigid;

	public event Action<OverworldArea> OnEnterArea
	{
		[CompilerGenerated]
		add
		{
			m_OnEnterArea = (Action<OverworldArea>)Delegate.Combine(m_OnEnterArea, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnEnterArea = (Action<OverworldArea>)Delegate.Remove(m_OnEnterArea, value);
		}
	}

	public event Action<OverworldArea> OnExitArea
	{
		[CompilerGenerated]
		add
		{
			m_OnExitArea = (Action<OverworldArea>)Delegate.Combine(m_OnExitArea, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnExitArea = (Action<OverworldArea>)Delegate.Remove(m_OnExitArea, value);
		}
	}

	private void Start()
	{
		rigid = GetComponent<Rigidbody>();
	}

	private void FixedUpdate()
	{
		if (rigid != null && rigid.position.y > clampYPosition)
		{
			Vector3 pos = rigid.position;
			pos.y = clampYPosition;
			rigid.MovePosition(pos);
		}
	}

	private void OnTriggerEnter(Collider col)
	{
		if (col == null)
		{
			return;
		}
		OverworldArea component = col.GetComponent<OverworldArea>();
		if (component != null)
		{
			m_OnEnterArea?.Invoke(component);
		}
	}

	private void OnTriggerExit(Collider col)
	{
		if (col == null)
		{
			return;
		}
		OverworldArea component = col.GetComponent<OverworldArea>();
		if (component != null)
		{
			m_OnExitArea?.Invoke(component);
		}
	}
}
