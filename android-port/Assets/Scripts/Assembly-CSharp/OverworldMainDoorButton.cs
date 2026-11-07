using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OverworldMainDoorButton : MonoBehaviour
{
	[CompilerGenerated]
	private Action<OverworldBall2D> m_OnHitWhenInactive;

	[CompilerGenerated]
	private Action<OverworldBall2D> m_OnHitWhenActive;

	[SerializeField]
	private SpriteRenderer spriteRenderer;

	[SerializeField]
	private Sprite inactiveSprite;

	[SerializeField]
	private Sprite activeSprite;

	private bool isActive;

	public bool IsActive
	{
		set
		{
		}
	}

	public event Action<OverworldBall2D> OnHitWhenInactive
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

	public event Action<OverworldBall2D> OnHitWhenActive
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

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void Refresh()
	{
	}
}
