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
			isActive = value;
			Refresh();
		}
	}

	public event Action<OverworldBall2D> OnHitWhenInactive
	{
		[CompilerGenerated]
		add => m_OnHitWhenInactive = (Action<OverworldBall2D>)Delegate.Combine(m_OnHitWhenInactive, value);
		[CompilerGenerated]
		remove => m_OnHitWhenInactive = (Action<OverworldBall2D>)Delegate.Remove(m_OnHitWhenInactive, value);
	}

	public event Action<OverworldBall2D> OnHitWhenActive
	{
		[CompilerGenerated]
		add => m_OnHitWhenActive = (Action<OverworldBall2D>)Delegate.Combine(m_OnHitWhenActive, value);
		[CompilerGenerated]
		remove => m_OnHitWhenActive = (Action<OverworldBall2D>)Delegate.Remove(m_OnHitWhenActive, value);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision == null) return;
		var ball = collision.gameObject.GetComponentInParent<OverworldBall2D>();
		if (ball == null) return;
		if (isActive)
		{
			m_OnHitWhenActive?.Invoke(ball);
		}
		else
		{
			m_OnHitWhenInactive?.Invoke(ball);
			ball.Velocity *= 0.5f;
		}
	}

	private void Refresh()
	{
		if (spriteRenderer != null)
			spriteRenderer.sprite = isActive ? activeSprite : inactiveSprite;
	}
}
