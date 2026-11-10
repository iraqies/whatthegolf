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
			m_OnPress = (Action<OverworldButton>)Delegate.Combine(m_OnPress, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnPress = (Action<OverworldButton>)Delegate.Remove(m_OnPress, value);
		}
	}

	private void Start()
	{
	}

	public void SetText(string text)
	{
		if (missingFlagsText != null)
		{
			missingFlagsText.text = text;
		}
	}

	private void OverworldButton_OnBallHit()
	{
		m_OnPress?.Invoke(this);
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision != null && collision.gameObject.CompareTag("Player"))
		{
			OverworldButton_OnBallHit();
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other != null && other.CompareTag("Player"))
		{
			OverworldButton_OnBallHit();
		}
	}

	public void SetBridgeStatus(bool isActive)
	{
		if (CylinderSide != null)
		{
			Material mat = isActive ? activeSide : inactiveSide;
			if (mat != null)
			{
				CylinderSide.sharedMaterial = mat;
			}
		}
		if (CylinderEnd != null)
		{
			Material mat = isActive ? activeEnd : inactiveEnd;
			if (mat != null)
			{
				CylinderEnd.sharedMaterial = mat;
			}
		}
	}
}
