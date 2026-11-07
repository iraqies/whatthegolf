using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class OverworldLinkedGoal : GolfBehaviour
{
	[Serializable]
	public class LinkedLevelData
	{
		public LevelData LevelData;

		public List<LevelData> AdditionalLevels;
	}

	public List<OverworldGoal> Flags;

	public List<LinkedLevelData> OrderedLevels;

	private OverworldManager2d Manager;

	private int completed;

	private Dictionary<Collider2D, Collider2D[]> goals;

	private int[] completeOrder;

	[SerializeField]
	private Collider2D circleCollider;

	[SerializeField]
	private Collider2D boxCollider;

	private readonly string saveFormat;

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnlevelAbandoned(OverworldGoal overworldGoal)
	{
	}

	private void OnlevelCompleted(OverworldGoal overworldGoal, bool parUnlocked)
	{
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
