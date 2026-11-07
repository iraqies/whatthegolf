using System;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;

public class LevelMusic : MonoBehaviour
{
	[CompilerGenerated]
	private Action m_OnIntialized;

	public bool isMoving;

	public float distanceNormalized;

	public bool isAimingAffectingTime;

	public bool isSettingSlowmotionContinuesly;

	public bool isSlowmotion;

	public bool isInitialized;

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

	private GolfBallController ball;

	private GolfGoal goal;

	private float maxDistance;

	private int strokeCount;

	private Level currentLevel;

	private float ballLocateTimer;

	public event Action OnIntialized
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

	public event Action<int> OnShoot
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

	public event Action<int> OnAimtStart
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

	public event Action OnGoal
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

	public event Action OnFail
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

	public event Action OnStart
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

	public event Action<bool> OnAimUpdate
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

	public void InitializeForCurrentLevel(GolfGoal goal, GolfBallController ball, Level level)
	{
	}

	private void CurrentLevel_OnStart()
	{
	}

	private void CurrentLevel_OnReset()
	{
	}

	private void CurrentLevel_OnOutOfBounds()
	{
	}

	private void CurrentLevel_OnGoal(Level.CompletedState s)
	{
	}

	public void OnLevelWillUnload()
	{
	}

	private void Level_OnFail(GolfBallController arg1, string arg2, Level.State state)
	{
	}

	private void Ball_OnShoot(Vector3 obj)
	{
	}

	private void Ball_OnCancel()
	{
	}

	private void Ball_OnAimStart()
	{
	}

	private void Update()
	{
	}
}
