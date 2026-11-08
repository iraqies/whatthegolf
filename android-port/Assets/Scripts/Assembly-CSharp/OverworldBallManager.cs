using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
	public float minYVelocity = 3f;
	public List<Transmogriffable> balls = new List<Transmogriffable>();
	public GlobalClock clock;
	public OverworldBallFollower ballProxy;
	public Transmogrif.BALLSHAPES currentShape;
	private TimeControl timeControl;

	public static OverworldBallManager Instance => _Instance;
	public static bool HasInstance => _Instance != null;

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

	private void Awake()
	{
		_Instance = this;
	}

	public void Initialize()
	{
		_Instance = this;
		if (ballProxy == null)
			ballProxy = FindObjectOfType<OverworldBallFollower>();
		if (Ball == null)
			Ball = FindObjectOfType<OverworldBall2D>();
		if (Ball != null)
		{
			Ball.Init();
			if (ballProxy != null)
				ballProxy.SetTarget(Ball.transform);
			var tm = Ball.GetComponent<Transmogriffable>();
			if (tm != null)
			{
				tm.OnTransmogriffed -= Transmogriffable_OnTransmogriffed;
				tm.OnTransmogriffed += Transmogriffable_OnTransmogriffed;
				currentShape = tm.shape;
			}
			Ball.OnDeath -= Ball_OnDeath;
			Ball.OnDeath += Ball_OnDeath;
			Ball.ClearTrail();
		}
	}

	public void Load(Transmogrif.BALLSHAPES shape)
	{
		Initialize();
		if (Ball == null)
			return;
		if (currentShape == shape)
		{
			if (ballProxy != null)
				ballProxy.SetTarget(Ball.transform);
			Ball.ClearTrail();
			m_OnNewBall?.Invoke(currentShape);
			return;
		}
		Vector3 pos = Ball.transform.position;
		Ball.OnDeath -= Ball_OnDeath;
		var curTm = Ball.GetComponent<Transmogriffable>();
		var newTm = ChangeBall(curTm, shape);
		if (newTm != null)
		{
			newTm.transform.position = pos;
			newTm.Init();
			Ball = newTm.GetComponent<OverworldBall2D>();
			if (Ball != null)
			{
				Ball.Init();
				if (ballProxy != null)
					ballProxy.SetTarget(Ball.transform);
				Ball.ClearTrail();
				Ball.OnDeath -= Ball_OnDeath;
				Ball.OnDeath += Ball_OnDeath;
			}
			newTm.OnTransmogriffed -= Transmogriffable_OnTransmogriffed;
			newTm.OnTransmogriffed += Transmogriffable_OnTransmogriffed;
		}
		m_OnNewBall?.Invoke(currentShape);
	}

	private void Ball_OnDeath(OverworldBall2D obj) => m_OnDeath?.Invoke(obj);
	public int GetCurrentShapeAsInt() => (int)currentShape;

	private void Transmogriffable_OnTransmogriffed(Transmogriffable ball, Transmogrif grif)
	{
		StartCoroutine(TransmogrifRoutine(ball, grif));
	}

	private IEnumerator TransmogrifRoutine(Transmogriffable ball, Transmogrif grif)
	{
		if (ball == null || grif == null)
			yield break;
		m_OnTransmoGriffed?.Invoke(grif);
		Vector3 startPos = ball.transform.position;
		Quaternion startRot = ball.transform.rotation;
		var startSprites = ball.sprites;
		ball.OnTransmogriffed -= Transmogriffable_OnTransmogriffed;
		if (Ball != null)
			Ball.OnDeath -= Ball_OnDeath;

		var newTm = ChangeBall(ball, grif.targetShape);
		if (newTm != null)
		{
			newTm.transform.position = (grif.UseTargetPosition && grif.targetPosition != null) ? grif.targetPosition.position : startPos;
			newTm.transform.rotation = (grif.UseTargetPosition && grif.targetPosition != null) ? grif.targetPosition.rotation : startRot;
			newTm.Init();
			newTm.OnTransmogriffed -= Transmogriffable_OnTransmogriffed;
			newTm.OnTransmogriffed += Transmogriffable_OnTransmogriffed;
			Ball = newTm.GetComponent<OverworldBall2D>();
			if (Ball != null)
			{
				Ball.Init();
				Ball.OnDeath -= Ball_OnDeath;
				Ball.OnDeath += Ball_OnDeath;
				if (ballProxy != null)
					ballProxy.SetTarget(Ball.transform);
			}
			newTm.nextTransmogrifTime = Time.time + grif.delay + 0.2f;
			m_OnNewBall?.Invoke(grif.targetShape);
			if (grif.isAnimatedGrif)
			{
				if (grif.sfxOnEnter != null && AudioManager.Instance != null)
					grif.sfxOnEnter.Play(AudioManager.Instance.sfx, Vector3.zero, 0f);
				grif.PlayAnimation(startSprites, newTm.sprites);
			}
			if (grif.delay > 0f)
				yield return new WaitForSecondsRealtime(Mathf.Max(0.05f, grif.delay));
			if (Ball != null)
			{
				Ball.ShowAndEnable();
				if (grif.AddForceOnTransmogrif && Ball.rigidBody != null)
				{
					Ball.rigidBody.velocity = grif.outVelocity + new Vector2(0f, grif.outYVelocity);
					Ball.rigidBody.angularVelocity = grif.outAngularVelocity;
				}
			}
			if (grif.sfxOnExit != null && AudioManager.Instance != null)
				grif.sfxOnExit.Play(AudioManager.Instance.sfx, Vector3.zero, 0f);
		}
	}

	private Transmogriffable ChangeBall(Transmogriffable ball, Transmogrif.BALLSHAPES targetShape)
	{
		if (balls == null || balls.Count == 0)
		{
			currentShape = targetShape;
			return ball;
		}
		Transmogriffable prefab = balls.FirstOrDefault(b => b != null && b.shape == targetShape) ?? balls[0];
		if (prefab == null)
		{
			currentShape = targetShape;
			return ball;
		}
		if (ball != null)
			Destroy(ball.gameObject);
		currentShape = targetShape;
		return Instantiate(prefab);
	}
}
