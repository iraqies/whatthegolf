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
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<OverworldArea> OnExitArea
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

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnTriggerEnter(Collider col)
	{
	}

	private void OnTriggerExit(Collider col)
	{
	}
}
