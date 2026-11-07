using System.Collections.Generic;
using UnityEngine;

public class SortGroupManager : GolfBehaviour
{
	public List<SortByY> sceneSortingGroups;

	public int divideSortingOverFrames;

	[SerializeField]
	private List<SortByY> sortingByYObjects;

	[SerializeField]
	private int maxSortingPerFrame;

	private int offset;

	public override void OnPrePlayOrPreCompile()
	{
	}

	public void PreCache()
	{
	}

	public void UpdateSorting()
	{
	}
}
