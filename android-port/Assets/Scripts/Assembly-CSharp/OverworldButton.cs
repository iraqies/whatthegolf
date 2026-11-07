using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class OverworldButton : MonoBehaviour
{
	[CompilerGenerated]
	private Action<OverworldButton> m_OnPress;

	public TextMeshPro missingFlagsText;

	public Collider wallCollider;

	public Renderer CylinderSide;

	public Renderer CylinderEnd;

	public Material activeSide;

	public Material activeEnd;

	public Material inactiveSide;

	public Material inactiveEnd;

	public event Action<OverworldButton> OnPress
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

	public void SetText(string text)
	{
	}

	private void OverworldButton_OnBallHit()
	{
	}

	public void SetBridgeStatus(bool isActive)
	{
	}
}
