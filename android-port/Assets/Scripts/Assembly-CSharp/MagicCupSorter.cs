using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicCupSorter : MonoBehaviour
{
	public List<Transform> ShowPositions;

	public List<Transform> HidePositions;

	public List<MagicCup> MagicCups;

	public int Iterations;

	public float Speed;

	public float MoveRange;

	private bool routineRunning;

	private IEnumerator Start()
	{
		return null;
	}

	private IEnumerator SortRoutine()
	{
		return null;
	}

	private IEnumerator SingleSortRoutine()
	{
		return null;
	}

	public void TryShow(MagicCup cupHit)
	{
	}

	private IEnumerator ToggleCup(MagicCup cupHit, bool showContents)
	{
		return null;
	}
}
