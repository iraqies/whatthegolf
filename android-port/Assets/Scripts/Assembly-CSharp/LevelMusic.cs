using System;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;

public class LevelMusic : MonoBehaviour
{
	public enum LevelMusicPreset
	{
		Undefined = 0,
		Silent = 10,
		Lab = 20,
		Green = 30,
		Sport = 40,
		Gravity = 50,
		Toast = 60,
		Blue = 70,
		Portal = 80,
		Secret = 90,
		Factory = 100,
		Desert = 110,
		Western = 120,
		Winter = 130,
		Hell = 140,
		Space = 150,
		Computer = 160
	}

	[CompilerGenerated]
	private Action m_OnIntialized;

	public bool isMoving;

	public float distanceNormalized;

	public bool isAimingAffectingTime;

	public bool isSettingSlowmotionContinuesly;

	public bool isSlowmotion;

	public bool isInitialized;

	public bool initialized
	{
		get => isInitialized;
		set => isInitialized = value;
	}

	public LevelMusicPreset musicPreset;

	public float intensity;

	public bool overrideLevelState;

	public string customWwiseMusicState;

	[CompilerGenerated]
	private Action<int> m_OnShoot;

	[CompilerGenerated]
	private Action<int> m_OnAimtStart;

	[CompilerGenerated]
	private Action m_OnGoal;

	[CompilerGenerated]
	private Action m_OnFail;

	[CompilerGenerated]
	private Action m_OnStart;

	[CompilerGenerated]
	private Action<bool> m_OnAimUpdate;

	public GolfBallController ball;

	public GolfGoal goal;

	private float maxDistance;

	private int strokeCount;

	private Level currentLevel;

	private float ballLocateTimer;

	public float BallDistanceToGoal => (goal != null && ball != null) ? (goal.transform.position - ball.transform.position).magnitude : 0f;

	public event Action OnIntialized
	{
		[CompilerGenerated]
		add => m_OnIntialized = (Action)Delegate.Combine(m_OnIntialized, value);
		[CompilerGenerated]
		remove => m_OnIntialized = (Action)Delegate.Remove(m_OnIntialized, value);
	}

	public event Action<int> OnShoot
	{
		[CompilerGenerated]
		add => m_OnShoot = (Action<int>)Delegate.Combine(m_OnShoot, value);
		[CompilerGenerated]
		remove => m_OnShoot = (Action<int>)Delegate.Remove(m_OnShoot, value);
	}

	public event Action<int> OnAimtStart
	{
		[CompilerGenerated]
		add => m_OnAimtStart = (Action<int>)Delegate.Combine(m_OnAimtStart, value);
		[CompilerGenerated]
		remove => m_OnAimtStart = (Action<int>)Delegate.Remove(m_OnAimtStart, value);
	}

	public event Action OnGoal
	{
		[CompilerGenerated]
		add => m_OnGoal = (Action)Delegate.Combine(m_OnGoal, value);
		[CompilerGenerated]
		remove => m_OnGoal = (Action)Delegate.Remove(m_OnGoal, value);
	}

	public event Action OnFail
	{
		[CompilerGenerated]
		add => m_OnFail = (Action)Delegate.Combine(m_OnFail, value);
		[CompilerGenerated]
		remove => m_OnFail = (Action)Delegate.Remove(m_OnFail, value);
	}

	public event Action OnStart
	{
		[CompilerGenerated]
		add => m_OnStart = (Action)Delegate.Combine(m_OnStart, value);
		[CompilerGenerated]
		remove => m_OnStart = (Action)Delegate.Remove(m_OnStart, value);
	}

	public event Action<bool> OnAimUpdate
	{
		[CompilerGenerated]
		add => m_OnAimUpdate = (Action<bool>)Delegate.Combine(m_OnAimUpdate, value);
		[CompilerGenerated]
		remove => m_OnAimUpdate = (Action<bool>)Delegate.Remove(m_OnAimUpdate, value);
	}

	public void InitializeForCurrentLevel(GolfGoal goal, GolfBallController ball, Level level)
	{
		this.goal = goal;
		this.ball = ball;
		currentLevel = level;
		if (goal != null && ball != null)
		{
			maxDistance = Vector3.Distance(goal.transform.position, ball.transform.position);
		}
		if (ball != null)
		{
			ball.OnAimStart -= Ball_OnAimStart;
			ball.OnAimStart += Ball_OnAimStart;
			ball.OnCancel -= Ball_OnCancel;
			ball.OnCancel += Ball_OnCancel;
			ball.OnShoot -= Ball_OnShoot;
			ball.OnShoot += Ball_OnShoot;
		}
		if (currentLevel != null)
		{
			currentLevel.OnFail -= Level_OnFail;
			currentLevel.OnFail += Level_OnFail;
			currentLevel.OnComplete -= CurrentLevel_OnGoal;
			currentLevel.OnComplete += CurrentLevel_OnGoal;
			currentLevel.OnOutOfBounds -= CurrentLevel_OnOutOfBounds;
			currentLevel.OnOutOfBounds += CurrentLevel_OnOutOfBounds;
			currentLevel.OnStart -= CurrentLevel_OnStart;
			currentLevel.OnStart += CurrentLevel_OnStart;
			currentLevel.OnReset -= CurrentLevel_OnReset;
			currentLevel.OnReset += CurrentLevel_OnReset;
		}
		strokeCount = 0;
		m_OnIntialized?.Invoke();
		isInitialized = true;
	}

	public void OnLevelWillUnload()
	{
		if (ball != null)
		{
			ball.OnAimStart -= Ball_OnAimStart;
			ball.OnCancel -= Ball_OnCancel;
			ball.OnShoot -= Ball_OnShoot;
		}
		if (currentLevel != null)
		{
			currentLevel.OnFail -= Level_OnFail;
			currentLevel.OnComplete -= CurrentLevel_OnGoal;
			currentLevel.OnOutOfBounds -= CurrentLevel_OnOutOfBounds;
			currentLevel.OnStart -= CurrentLevel_OnStart;
			currentLevel.OnReset -= CurrentLevel_OnReset;
		}
		m_OnAimUpdate?.Invoke(false);
	}

	private void CurrentLevel_OnReset()
	{
		strokeCount = 0;
	}

	private void CurrentLevel_OnStart()
	{
		strokeCount = 0;
		m_OnStart?.Invoke();
	}

	private void CurrentLevel_OnOutOfBounds()
	{
		strokeCount = 0;
	}

	private void CurrentLevel_OnGoal(Level.CompletedState s)
	{
		strokeCount = 0;
		m_OnGoal?.Invoke();
	}

	private void Level_OnFail(GolfBallController arg1, string arg2, Level.State state)
	{
		strokeCount = 0;
		if (state is Level.FailState failState)
		{
			if (failState.PlayFailSFX)
				m_OnFail?.Invoke();
		}
		else
		{
			m_OnFail?.Invoke();
		}
	}

	private void Ball_OnCancel()
	{
		m_OnAimUpdate?.Invoke(false);
	}

	private void Ball_OnAimStart()
	{
		m_OnAimUpdate?.Invoke(true);
		m_OnAimtStart?.Invoke(strokeCount);
	}

	private void Ball_OnShoot(Vector3 obj)
	{
		m_OnShoot?.Invoke(strokeCount);
		strokeCount++;
		m_OnAimUpdate?.Invoke(false);
	}

	private void Update()
	{
		if (!isInitialized) return;
		if (goal != null && ball != null && maxDistance > 0.001f)
		{
			float dist = Vector3.Distance(goal.transform.position, ball.transform.position);
			distanceNormalized = 1f - Mathf.Clamp01(dist / maxDistance);
			isMoving = ball.Velocity.magnitude > 0.1f;
		}
	}
}
