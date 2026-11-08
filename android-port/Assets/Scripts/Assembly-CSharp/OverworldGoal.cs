using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;
using UnityEngine.Tilemaps;

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
	public List<LevelData> AdditionalLevelData = new List<LevelData>();
	public List<LevelData> ExcludeFromSequence = new List<LevelData>();
	public States state = States.Unplayed;
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

	private Action<OverworldGoal> m_OnUpdateData;
	private Action<OverworldGoal, Vector3, OverworldBall2D> m_OnHit;
	private Action<OverworldGoal> m_OnCrownWon;

	public bool MoveBallWhenHit = true;
	public Action<OverworldGoal> PlayerOutOfRangeAgain;
	public bool DontShowActiveCircle;
	public bool isDuplicate;
	public OverworldGoal duplicateReference;

	private Collider2D circleCollider;
	private Collider2D boxCollider;
	private bool canShowIndicator = true;
	private bool hasUnfinishedContent;
	private Transform playerTransform;
	private float playerSize;
	private bool trackPlayerDistance;
	private Transmogrif.BALLSHAPES currentBallShape;
	private HubSection parentHubSection;

	public HubSection ParentHubSection => parentHubSection != null ? parentHubSection : (parentHubSection = GetComponentInParent<HubSection>());
	public bool CanShowIndicator { set => canShowIndicator = value; }

	public event Action<OverworldGoal> OnUpdateData
	{
		add => m_OnUpdateData = (Action<OverworldGoal>)Delegate.Combine(m_OnUpdateData, value);
		remove => m_OnUpdateData = (Action<OverworldGoal>)Delegate.Remove(m_OnUpdateData, value);
	}

	public event Action<OverworldGoal, Vector3, OverworldBall2D> OnHit
	{
		add => m_OnHit = (Action<OverworldGoal, Vector3, OverworldBall2D>)Delegate.Combine(m_OnHit, value);
		remove => m_OnHit = (Action<OverworldGoal, Vector3, OverworldBall2D>)Delegate.Remove(m_OnHit, value);
	}

	public event Action<OverworldGoal> OnCrownWon
	{
		add => m_OnCrownWon = (Action<OverworldGoal>)Delegate.Combine(m_OnCrownWon, value);
		remove => m_OnCrownWon = (Action<OverworldGoal>)Delegate.Remove(m_OnCrownWon, value);
	}

	private void Awake()
	{
		if (isSkipping)
			gameObject.SetActive(false);
	}

	public void Init(GridFiller filler)
	{
		if (isSkipping || levelData == null)
		{
			isSkipping = true;
			gameObject.SetActive(false);
			return;
		}

		parentHubSection = GetComponentInParent<HubSection>();
		circleCollider = GetComponent<CircleCollider2D>();
		boxCollider = GetComponentInChildren<BoxCollider2D>();

		if (levelData.GetWindowType() == LevelData.WindowType.TwoD && !IsStuckToWall && !DontRotateBasedOnLevel)
		{
			transform.Rotate(0f, 0f, -90f, Space.Self);
		}

		if (IsStuckToWall)
		{
			if (circleCollider != null) circleCollider.enabled = false;
			if (boxCollider != null) boxCollider.enabled = true;
		}

		if (filler != null)
		{
			Tilemap groundMap = filler.currentGroundMap;
			Tilemap refMap = filler.groundMap != null ? filler.groundMap : groundMap;
			if (groundMap != null && refMap != null)
			{
				Vector3 cellSize = refMap.cellSize;
				Vector3 pos = transform.position;
				Vector3 lookupPos = new Vector3(pos.x + cellSize.x * 0.25f, pos.y + cellSize.x * 0.25f, pos.z);
				Vector3Int cell = groundMap.WorldToCell(lookupPos);
				Vector3 snapped = groundMap.CellToWorld(cell);
				if (!dontSnapToGrid)
					transform.position = snapped;
			}
		}

		if (IsStuckToWall && !dontSnapToGrid)
		{
			transform.position += transform.forward * 0.05f;
		}

		if (visualHole != null)
			visualHole.SetActive(!IsStuckToWall);

		if (requireGoalToUnlock != null)
		{
			requireGoalToUnlock.OnUpdateData -= RefreshFlag;
			requireGoalToUnlock.OnUpdateData += RefreshFlag;
		}

		state = States.Unplayed;
		RefreshState();

		if (gameObject.activeSelf && requireGoalToUnlock != null)
			StartCoroutine(OneFrameDelayedSetStatus());
	}

	public IEnumerator UpdatePlayerTracking(bool force = false)
	{
		yield break;
	}

	private void PlayerOutOfRange() => PlayerOutOfRangeAgain?.Invoke(this);
	public void SetNewBallShape(Transmogrif.BALLSHAPES newShape) => currentBallShape = newShape;

	private IEnumerator OneFrameDelayedSetStatus()
	{
		yield return null;
		RefreshState();
		RefreshVisuals();
	}

	public bool IsUnlocked()
	{
		if (requireGoalToUnlock == null) return true;
		return requireGoalToUnlock.IsCompleted();
	}

	public bool IsCompleted() => levelData != null && levelData.IsCompletedInSaveGame;

	public bool IsRotated2D()
	{
		return PlatformSettings.IsMobile && levelData != null && levelData.GetWindowType() == LevelData.WindowType.TwoD;
	}

	public List<LevelData> GetAllGoalLevels()
	{
		var res = new List<LevelData>();
		if (levelData != null) res.Add(levelData);
		if (AdditionalLevelData != null)
		{
			foreach (var l in AdditionalLevelData)
				if (l != null && !res.Contains(l)) res.Add(l);
		}
		if (ExcludeFromSequence != null)
		{
			foreach (var ex in ExcludeFromSequence)
				if (ex != null) res.Remove(ex);
		}
		return res;
	}

	public bool HasChallenges() => AdditionalLevelData != null && AdditionalLevelData.Count > 0;
	public bool IsVisible() => state != States.Hidden;

	public bool IsFullyCompleted()
	{
		var all = GetAllGoalLevels();
		if (all == null || all.Count == 0) return false;
		for (int i = 0; i < all.Count; i++)
		{
			if (all[i] == null || !all[i].IsCompletedInSaveGame)
				return false;
		}
		return true;
	}

	public void ForceShowCrownOutline()
	{
		if (visualCrownOutline != null) visualCrownOutline.SetActive(true);
	}

	public void ForceShowCrown()
	{
		state = States.Crown;
		RefreshVisuals();
		m_OnCrownWon?.Invoke(this);
	}

	private void RefreshFlag(OverworldGoal other) => RefreshFlag();

	private void RefreshFlag()
	{
		RefreshState();
		RefreshVisuals();
	}

	private void RefreshState()
	{
		if (requireGoalToUnlock != null && !requireGoalToUnlock.IsCompleted())
		{
			state = States.Hidden;
		}
		else if (IsFullyCompleted())
		{
			state = States.Crown;
		}
		else if (IsCompleted())
		{
			state = States.Won;
		}
		else
		{
			state = States.Unplayed;
		}
	}

	public void RefreshVisuals()
	{
		if (isSkipping || gameObject == null || !gameObject.activeInHierarchy)
			return;

		if (visualPole != null)
			visualPole.SetActive(state != States.Hidden);
		if (visualWon != null)
			visualWon.SetActive(state == States.Won || state == States.Crown);
		if (visualNotCompleted != null)
			visualNotCompleted.SetActive(state != States.Won && state != States.Crown);
		if (visualCrown != null)
			visualCrown.SetActive(state == States.Crown);
		if (visualCrownOutline != null)
		{
			bool showOutline = state != States.Crown && SaveGame.CrownAwarenessMode;
			visualCrownOutline.SetActive(showOutline);
		}
		if (activeAnimation != null)
		{
			bool showActive = state == States.Unplayed && canShowIndicator && !DontShowActiveCircle;
			activeAnimation.SetActive(showActive);
		}
	}

	public void ReloadData()
	{
		RefreshState();
		RefreshVisuals();
		m_OnUpdateData?.Invoke(this);
	}

	public virtual void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision == null || collision.collider == null) return;
		var ball = collision.collider.GetComponentInParent<OverworldBall2D>();
		if (ball != null)
		{
			m_OnHit?.Invoke(this, collision.transform.position, ball);
		}
	}

	private void OnDrawGizmosSelected() { }
}
