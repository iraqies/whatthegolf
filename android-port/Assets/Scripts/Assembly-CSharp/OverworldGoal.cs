using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;

public class OverworldGoal : MonoBehaviour
{
	public enum States
	{
		Hidden = 0,
		Unplayed = 1,
		Won = 2,
		Crown = 3
	}

	public bool isSkipping;

	public string description;

	public LevelData levelData;

	public List<LevelData> AdditionalLevelData;

	public List<LevelData> ExcludeFromSequence;

	public States state;

	public GameObject visualNotCompleted;

	public GameObject visualWon;

	public GameObject visualCrown;

	public GameObject visualCrownOutline;

	public GameObject visualPole;

	public GameObject visualHole;

	public GameObject activeAnimation;

	public bool DontRotateBasedOnLevel;

	public bool IsStuckToWall;

	public bool dontSnapToGrid;

	public OverworldGoal requireGoalToUnlock;

	[CompilerGenerated]
	private Action<OverworldGoal> m_OnUpdateData;

	[CompilerGenerated]
	private Action<OverworldGoal, Vector3, OverworldBall2D> m_OnHit;

	[CompilerGenerated]
	private Action<OverworldGoal> m_OnCrownWon;

	public bool MoveBallWhenHit;

	public Action<OverworldGoal> PlayerOutOfRangeAgain;

	public bool DontShowActiveCircle;

	public bool isDuplicate;

	public OverworldGoal duplicateReference;

	private Collider2D circleCollider;

	private Collider2D boxCollider;

	private bool canShowIndicator;

	private bool hasUnfinishedContent;

	private Transform playerTransform;

	private float playerSize;

	private bool trackPlayerDistance;

	private Transmogrif.BALLSHAPES currentBallShape;

	private HubSection parentHubSection;

	public HubSection ParentHubSection => null;

	public bool CanShowIndicator
	{
		set
		{
		}
	}

	public event Action<OverworldGoal> OnUpdateData
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

	public event Action<OverworldGoal, Vector3, OverworldBall2D> OnHit
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

	public event Action<OverworldGoal> OnCrownWon
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

	private void Awake()
	{
	}

	public void Init(GridFiller filler)
	{
	}

	public IEnumerator UpdatePlayerTracking(bool force = false)
	{
		return null;
	}

	private void PlayerOutOfRange()
	{
	}

	public void SetNewBallShape(Transmogrif.BALLSHAPES newShape)
	{
	}

	private IEnumerator OneFrameDelayedSetStatus()
	{
		return null;
	}

	public bool IsUnlocked()
	{
		return false;
	}

	public bool IsCompleted()
	{
		return false;
	}

	public bool IsRotated2D()
	{
		return false;
	}

	public List<LevelData> GetAllGoalLevels()
	{
		return null;
	}

	public bool HasChallenges()
	{
		return false;
	}

	public bool IsVisible()
	{
		return false;
	}

	public bool IsFullyCompleted()
	{
		return false;
	}

	public void ForceShowCrownOutline()
	{
	}

	public void ForceShowCrown()
	{
	}

	private void RefreshFlag(OverworldGoal other)
	{
	}

	private void RefreshFlag()
	{
	}

	private void RefreshState()
	{
	}

	public void RefreshVisuals()
	{
	}

	public void ReloadData()
	{
	}

	public virtual void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
