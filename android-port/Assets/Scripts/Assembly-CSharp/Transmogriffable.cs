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
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Init()
	{
	}

	public void TransmogrifBall(Transmogriffable ball, Transmogrif grif)
	{
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}
}
