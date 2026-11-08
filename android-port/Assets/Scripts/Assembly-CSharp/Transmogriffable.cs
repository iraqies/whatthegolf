using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Transmogriffable : MonoBehaviour
{
	[Serializable]
	public class TransmogrifSprites
	{
		public Sprite bright;
		public Sprite dark;
	}

	public Transmogrif.BALLSHAPES shape;

	[CompilerGenerated]
	private Action<Transmogriffable, Transmogrif> m_OnTransmogriffed;

	public TransmogrifSprites sprites;
	public float nextTransmogrifTime;

	public event Action<Transmogriffable, Transmogrif> OnTransmogriffed
	{
		[CompilerGenerated]
		add => m_OnTransmogriffed = (Action<Transmogriffable, Transmogrif>)Delegate.Combine(m_OnTransmogriffed, value);
		[CompilerGenerated]
		remove => m_OnTransmogriffed = (Action<Transmogriffable, Transmogrif>)Delegate.Remove(m_OnTransmogriffed, value);
	}

	public void Init()
	{
		nextTransmogrifTime = Time.time + 0.1f;
	}

	public void TransmogrifBall(Transmogriffable ball, Transmogrif grif)
	{
		m_OnTransmogriffed?.Invoke(ball, grif);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (Time.time <= nextTransmogrifTime || collision == null)
			return;
		var grif = collision.gameObject.GetComponent<Transmogrif>();
		if (grif != null)
		{
			m_OnTransmogriffed?.Invoke(this, grif);
		}
	}
}
