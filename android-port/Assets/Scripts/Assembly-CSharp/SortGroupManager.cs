using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SortGroupManager : GolfBehaviour
{
	public List<SortByY> sceneSortingGroups = new List<SortByY>();
	public int divideSortingOverFrames = 5;
	[SerializeField] private List<SortByY> sortingByYObjects;
	[SerializeField] private int maxSortingPerFrame = 10;
	private int offset;

	public override void OnPrePlayOrPreCompile()
	{
	}

	public void PreCache()
	{
		var all = GetComponentsInChildren<SortByY>(true);
		sortingByYObjects = new List<SortByY>(all);
		if (sceneSortingGroups == null)
			sceneSortingGroups = new List<SortByY>();
		else
			sceneSortingGroups.Clear();
		for (int i = 0; i < sortingByYObjects.Count; i++)
		{
			var s = sortingByYObjects[i];
			if (s == null) continue;
			var sg = s.GetComponent<SortingGroup>();
			if (sg != null)
			{
				s.group = sg;
				sceneSortingGroups.Add(s);
			}
		}
		int div = divideSortingOverFrames > 0 ? divideSortingOverFrames : 5;
		maxSortingPerFrame = Mathf.Max(1, sceneSortingGroups.Count / div);
	}

	public void UpdateSorting()
	{
		if (sceneSortingGroups == null || sceneSortingGroups.Count == 0)
			return;
		int count = sceneSortingGroups.Count;
		int toSort = maxSortingPerFrame > 0 ? maxSortingPerFrame : Mathf.Max(1, count / 5);
		int start = offset;
		int end = start + toSort;
		offset = end;
		for (int i = start; i < end; i++)
		{
			int idx = ((i % count) + count) % count;
			var s = sceneSortingGroups[idx];
			if (s != null && s.isSorting && s.group != null)
			{
				s.group.sortingOrder = Mathf.RoundToInt(s.transform.position.y * -5f) + 5000;
			}
		}
	}
}
