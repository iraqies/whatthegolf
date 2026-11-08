using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu2Navigator : MonoBehaviour
{
	[SerializeField] private List<Selectable> left = new List<Selectable>();
	[SerializeField] private List<Selectable> right = new List<Selectable>();
	[SerializeField] private List<Selectable> up = new List<Selectable>();
	[SerializeField] private List<Selectable> down = new List<Selectable>();

	private static Selectable FirstActive(List<Selectable> list)
	{
		if (list == null) return null;
		foreach (var s in list)
			if (s != null && s.IsInteractable() && s.gameObject.activeInHierarchy) return s;
		return null;
	}

	public Selectable FindSelectableOnLeft() => FirstActive(left);
	public Selectable FindSelectableOnRight() => FirstActive(right);
	public Selectable FindSelectableOnTop() => FirstActive(up);
	public Selectable FindSelectableOnBottom() => FirstActive(down);

	public void SortDown(Comparison<Selectable> comparer)
	{
		if (down != null && comparer != null) down.Sort(comparer);
	}
}
