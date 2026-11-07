using System.Collections.Generic;
using UnityEngine;

public class CompleteLevelWhenAllFlagsHit : MonoBehaviour
{
	public List<FlagAppearOnPoleOnCollision> Poles;

	private int count;

	private void Awake()
	{
	}

	private void OnFlagAppeared(FlagAppearOnPoleOnCollision obj)
	{
	}
}
