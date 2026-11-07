using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu2Navigator : MonoBehaviour
{
	[SerializeField]
	private List<Selectable> left;

	[SerializeField]
	private List<Selectable> right;

	[SerializeField]
	private List<Selectable> up;

	[SerializeField]
	private List<Selectable> down;

	public Selectable FindSelectableOnLeft()
	{
		return null;
	}

	public Selectable FindSelectableOnRight()
	{
		return null;
	}

	public Selectable FindSelectableOnTop()
	{
		return null;
	}

	public Selectable FindSelectableOnBottom()
	{
		return null;
	}

	public void SortDown(Comparison<Selectable> comparer)
	{
	}
}
