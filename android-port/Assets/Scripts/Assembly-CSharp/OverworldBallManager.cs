using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Chronos;
using UnityEngine;

public class OverworldBallManager : MonoBehaviour
{
	private static OverworldBallManager _Instance;
	private Action<OverworldBall2D> m_OnDeath;
	private Action<Transmogrif.BALLSHAPES> m_OnNewBall;
	private Action<Transmogrif> m_OnTransmoGriffed;

	public OverworldBall2D Ball;
	public float minYVelocity;
	public List<Transmogriffable> balls = new List<Transmogriffable>();
	public GlobalClock clock;
	public OverworldBallFollower ballProxy;
	public Transmogrif.BALLSHAPES currentShape;
	private TimeControl timeControl;

	public static OverworldBallManager Instance => _Instance != null ? _Instance : (_Instance = FindObjectOfType<OverworldBallManager>());
	public static bool HasInstance => Instance != null;

	public event Action<OverworldBall2D> OnDeath
	{
		add => m_OnDeath = (Action<OverworldBall2D>)Delegate.Combine(m_OnDeath, value);
		remove => m_OnDeath = (Action<OverworldBall2D>)Delegate.Remove(m_OnDeath, value);
	}

	public event Action<Transmogrif.BALLSHAPES> OnNewBall
	{
		add => m_OnNewBall = (Action<Transmogrif.BALLSHAPES>)Delegate.Combine(m_OnNewBall, value);
		remove => m_OnNewBall = (Action<Transmogrif.BALLSHAPES>)Delegate.Remove(m_OnNewBall, value);
	}

	public event Action<Transmogrif> OnTransmoGriffed
	{
		add => m_OnTransmoGriffed = (Action<Transmogrif>)Delegate.Combine(m_OnTransmoGriffed, value);
		remove => m_OnTransmoGriffed = (Action<Transmogrif>)Delegate.Remove(m_OnTransmoGriffed, value);
	}

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		_Instance = null;
	}

	public void Initialize()
	{
		_Instance = this;
		if (Ball == null) Ball = FindObjectOfType<OverworldBall2D>();
		if (Ball != null)
		{
			Ball.Init();
			Ball.OnDeath -= Ball_OnDeath;
			Ball.OnDeath += Ball_OnDeath;
		}
	}

	public void Load(Transmogrif.BALLSHAPES shape)
	{
		currentShape = shape;
		Initialize();
	}

	private void Ball_OnDeath(OverworldBall2D obj) => m_OnDeath?.Invoke(obj);
	public int GetCurrentShapeAsInt() => (int)currentShape;
	private void Transmogriffable_OnTransmogriffed(Transmogriffable ball, Transmogrif grif) => m_OnTransmoGriffed?.Invoke(grif);

	private IEnumerator TransmogrifRoutine(Transmogriffable ball, Transmogrif grif)
	{
		yield break;
	}

	private Transmogriffable ChangeBall(Transmogriffable ball, Transmogrif.BALLSHAPES targetShape) => ball;
}
