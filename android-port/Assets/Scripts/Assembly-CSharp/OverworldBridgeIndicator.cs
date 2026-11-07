using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OverworldBridgeIndicator : MonoBehaviour
{
	[CompilerGenerated]
	private Action<OverworldBridgeIndicator> m_OnOpen;

	[CompilerGenerated]
	private Action<OverworldBridgeIndicator> m_OnChangeCount;

	public bool isOpen;

	public List<OverworldGoal> requireGoals;

	public int requireCountMinus;

	public Transform startPoint;

	public Transform endPoint;

	public ParticleSystem openParticles;

	public GeneratedIsland visualBridge;

	[SerializeField]
	private BoxCollider borderPrefab;

	[SerializeField]
	private BoxCollider groundPrefab;

	public ParticleSystem openParticlesPrefab;

	private float bridgeWidth;

	public event Action<OverworldBridgeIndicator> OnOpen
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

	public event Action<OverworldBridgeIndicator> OnChangeCount
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

	public void Awake()
	{
	}

	private void Goal_OnUpdateData(OverworldGoal obj)
	{
	}

	public int GetFlagsMissingCount()
	{
		return 0;
	}

	private void UpdateLockStatus(bool instant)
	{
	}

	public void TryOpen(bool instant = false)
	{
	}

	public bool CanBeOpened()
	{
		return false;
	}

	private void Unlock(bool instant)
	{
	}

	public void Open(bool instant)
	{
	}

	public void Make()
	{
	}

	private void MakeParticles(GeneratedIsland island, Vector3 dir)
	{
	}

	private void MakeGround(GeneratedIsland island, Vector3 dir)
	{
	}

	private void MakeWalls(GeneratedIsland island, Vector3 dir)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
