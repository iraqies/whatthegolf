using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Chronos;
using UnityEngine;

public class OverworldBallManager : MonoBehaviour
{
	private static OverworldBallManager _Instance;

	[CompilerGenerated]
	private Action<OverworldBall2D> m_OnDeath;

	[CompilerGenerated]
	private Action<Transmogrif.BALLSHAPES> m_OnNewBall;

	[CompilerGenerated]
	private Action<Transmogrif> m_OnTransmoGriffed;

	public OverworldBall2D Ball;

	public float minYVelocity;

	public List<Transmogriffable> balls;

	public GlobalClock clock;

	public OverworldBallFollower ballProxy;

	public Transmogrif.BALLSHAPES currentShape;

	private TimeControl timeControl;

	public static OverworldBallManager Instance => null;

	public static bool HasInstance => false;

	public event Action<OverworldBall2D> OnDeath
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

	public event Action<Transmogrif.BALLSHAPES> OnNewBall
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

	public event Action<Transmogrif> OnTransmoGriffed
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

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	public void Initialize()
	{
	}

	public void Load(Transmogrif.BALLSHAPES shape)
	{
	}

	private void Ball_OnDeath(OverworldBall2D obj)
	{
	}

	public int GetCurrentShapeAsInt()
	{
		return 0;
	}

	private void Transmogriffable_OnTransmogriffed(Transmogriffable ball, Transmogrif grif)
	{
	}

	private IEnumerator TransmogrifRoutine(Transmogriffable ball, Transmogrif grif)
	{
		return null;
	}

	private Transmogriffable ChangeBall(Transmogriffable ball, Transmogrif.BALLSHAPES targetShape)
	{
		return null;
	}
}
