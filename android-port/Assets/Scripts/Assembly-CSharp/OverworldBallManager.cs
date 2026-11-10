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

	public OverworldBall2D ball
	{
		get
		{
			return Ball;
		}
		set
		{
			Ball = value;
		}
	}

	public static OverworldBallManager Instance
	{
		get
		{
			if (_Instance == null)
			{
				_Instance = UnityEngine.Object.FindObjectOfType<OverworldBallManager>();
			}
			return _Instance;
		}
	}

	public static bool HasInstance => _Instance != null;

	public event Action<OverworldBall2D> OnDeath
	{
		[CompilerGenerated]
		add
		{
			m_OnDeath = (Action<OverworldBall2D>)Delegate.Combine(m_OnDeath, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnDeath = (Action<OverworldBall2D>)Delegate.Remove(m_OnDeath, value);
		}
	}

	public event Action<Transmogrif.BALLSHAPES> OnNewBall
	{
		[CompilerGenerated]
		add
		{
			m_OnNewBall = (Action<Transmogrif.BALLSHAPES>)Delegate.Combine(m_OnNewBall, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnNewBall = (Action<Transmogrif.BALLSHAPES>)Delegate.Remove(m_OnNewBall, value);
		}
	}

	public event Action<Transmogrif> OnTransmoGriffed
	{
		[CompilerGenerated]
		add
		{
			m_OnTransmoGriffed = (Action<Transmogrif>)Delegate.Combine(m_OnTransmoGriffed, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnTransmoGriffed = (Action<Transmogrif>)Delegate.Remove(m_OnTransmoGriffed, value);
		}
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
		{
			GameObject gameObject = GameObject.Find("BallFollower");
			if (gameObject != null)
			{
				ballProxy = gameObject.GetComponentInParent<OverworldBallFollower>();
			}
			if (ballProxy == null)
			{
				ballProxy = UnityEngine.Object.FindObjectOfType<OverworldBallFollower>();
			}
		}
		if (Ball == null)
		{
			GameObject gameObject2 = GameObject.Find("Ball");
			if (gameObject2 != null)
			{
				Ball = gameObject2.GetComponentInParent<OverworldBall2D>();
			}
			if (Ball == null)
			{
				Ball = UnityEngine.Object.FindObjectOfType<OverworldBall2D>();
			}
		}
		if (Ball != null)
		{
			if (ballProxy != null)
			{
				ballProxy.SetTarget(Ball.GetComponent<Transform>());
			}
			Transmogriffable component = Ball.GetComponent<Transmogriffable>();
			if (component != null)
			{
				component.OnTransmogriffed -= Transmogriffable_OnTransmogriffed;
				component.OnTransmogriffed += Transmogriffable_OnTransmogriffed;
				currentShape = component.shape;
			}
			Ball.OnDeath -= Ball_OnDeath;
			Ball.OnDeath += Ball_OnDeath;
			Ball.ClearTrail();
		}
	}

	public void Load(Transmogrif.BALLSHAPES shape)
	{
		if (Ball == null)
		{
			Initialize();
		}
		if (Ball == null)
		{
			return;
		}
		Vector3 position = Ball.transform.position;
		Ball.OnDeath -= Ball_OnDeath;
		Transmogriffable component = Ball.GetComponent<Transmogriffable>();
		Transmogriffable transmogriffable = ChangeBall(component, shape);
		if (transmogriffable != null)
		{
			transmogriffable.transform.position = position;
			transmogriffable.Init();
			Ball = transmogriffable.GetComponent<OverworldBall2D>();
			if (Ball != null)
			{
				if (ballProxy != null)
				{
					ballProxy.SetTarget(Ball.GetComponent<Transform>());
				}
				Ball.ClearTrail();
				Ball.OnDeath -= Ball_OnDeath;
				Ball.OnDeath += Ball_OnDeath;
			}
			transmogriffable.OnTransmogriffed -= Transmogriffable_OnTransmogriffed;
			transmogriffable.OnTransmogriffed += Transmogriffable_OnTransmogriffed;
		}
		m_OnNewBall?.Invoke(currentShape);
	}

	private void Ball_OnDeath(OverworldBall2D obj)
	{
		m_OnDeath?.Invoke(obj);
	}

	public int GetCurrentShapeAsInt()
	{
		return Array.IndexOf(Enum.GetValues(typeof(Transmogrif.BALLSHAPES)), currentShape);
	}

	private void Transmogriffable_OnTransmogriffed(Transmogriffable ball, Transmogrif grif)
	{
		StartCoroutine(TransmogrifRoutine(ball, grif));
	}

	private IEnumerator TransmogrifRoutine(Transmogriffable ball, Transmogrif grif)
	{
		if (ball == null || grif == null)
		{
			yield break;
		}
		m_OnTransmoGriffed?.Invoke(grif);
		Transmogriffable.TransmogrifSprites sprites = ball.sprites;
		Vector3 startPos = ball.transform.position;
		Quaternion rotation = ball.transform.rotation;
		if (Ball != null)
		{
			Ball.OnDeath -= Ball_OnDeath;
			if (Ball.controller != null)
			{
				Ball.controller.CancelShooting();
				Ball.controller.enabled = false;
			}
			Ball.enabled = false;
		}
		ball.OnTransmogriffed -= Transmogriffable_OnTransmogriffed;
		Rigidbody2D component = ball.GetComponent<Rigidbody2D>();
		if (component != null)
		{
			_ = component.velocity;
		}
		Transmogriffable transmogriffable = ChangeBall(ball, grif.targetShape);
		if (transmogriffable == null)
		{
			yield break;
		}
		transmogriffable.transform.position = ((grif.UseTargetPosition && grif.targetPosition != null) ? grif.targetPosition.position : startPos);
		transmogriffable.transform.rotation = ((grif.UseTargetPosition && grif.targetPosition != null) ? grif.targetPosition.rotation : rotation);
		transmogriffable.Init();
		transmogriffable.OnTransmogriffed += Transmogriffable_OnTransmogriffed;
		Ball = transmogriffable.GetComponent<OverworldBall2D>();
		transmogriffable.nextTransmogrifTime = Time.time + grif.delay + 0.2f;
		Transmogriffable.TransmogrifSprites sprites2 = transmogriffable.sprites;
		m_OnNewBall?.Invoke(grif.targetShape);
		if (grif.isAnimatedGrif)
		{
			if (grif.sfxOnEnter != null && AudioManager.Instance != null)
			{
				grif.sfxOnEnter.Play(AudioManager.Instance.sfx, Vector3.zero, 0f);
			}
			grif.PlayAnimation(sprites, sprites2);
			yield return null;
			if (Ball != null)
			{
				Ball.HideAndStop(true);
			}
			yield return pTween.To(0.2f, delegate(float t)
			{
				if (Ball != null)
				{
					Vector3 b = ((grif.UseTargetPosition && grif.targetPosition != null) ? grif.targetPosition.position : grif.transform.position);
					Ball.transform.position = Vector3.Lerp(startPos, b, t);
				}
			});
			if (grif.delay > 0f)
			{
				yield return new WaitForSecondsRealtime(grif.delay - 0.2f);
			}
			if (grif.sfxOnExit != null && AudioManager.Instance != null)
			{
				grif.sfxOnExit.Play(AudioManager.Instance.sfx, Vector3.zero, 0f);
			}
			yield return new WaitForSecondsRealtime(0.2f);
		}
		if (Ball != null)
		{
			Ball.ShowAndEnable();
			Ball.SetColliders(false);
			if (grif.AddForceOnTransmogrif && Ball.rigidBody != null)
			{
				Ball.rigidBody.velocity = grif.outVelocity + new Vector2(0f, grif.outYVelocity);
				Ball.rigidBody.angularVelocity = grif.outAngularVelocity;
			}
			Ball.OnDeath += Ball_OnDeath;
			if (ballProxy != null)
			{
				ballProxy.SetTarget(Ball.GetComponent<Transform>());
			}
		}
		yield return new WaitForSecondsRealtime(grif.TimeBeforeColliderReenable);
		if (Ball != null)
		{
			Ball.SetColliders(true);
		}
	}

	private Transmogriffable ChangeBall(Transmogriffable ball, Transmogrif.BALLSHAPES targetShape)
	{
		if (ball != null)
		{
			UnityEngine.Object.Destroy(ball.gameObject);
		}
		if (balls == null || balls.Count == 0)
		{
			currentShape = targetShape;
			return null;
		}
		Transmogriffable original = balls[0];
		foreach (Transmogriffable ball2 in balls)
		{
			if (ball2 != null && ball2.shape == targetShape)
			{
				original = ball2;
				break;
			}
		}
		currentShape = targetShape;
		return UnityEngine.Object.Instantiate(original);
	}
}
