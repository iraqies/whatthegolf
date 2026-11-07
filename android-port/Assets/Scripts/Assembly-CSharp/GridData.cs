using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GridData : ScriptableObject
{
	public int cols;

	public int rows;

	public List<GridIcon> grid;

	public void Set(int x, int y, GridIcon icon)
	{
	}

	public GridIcon Get(int x, int y)
	{
		return null;
	}

	private void UpdateArray(int index)
	{
	}
}
