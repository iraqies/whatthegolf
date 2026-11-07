using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class XmasHeader : MonoBehaviour
{
	public RectTransform Container;

	public RectTransform Landscape;

	public RectTransform LandscapeContainer;

	public RectTransform LandscapeRotated;

	public RectTransform LandscapeRotatedContainer;

	public RectTransform Portrait;

	public RectTransform PortraitContainer;

	public Canvas Canvas;

	public List<GameObject> FakeButtons;

	private RectTransform activeRect;

	public void ShowInMenu()
	{
	}

	public void ToggleHeader(LevelData.WindowType window)
	{
	}

	public void Hide()
	{
	}

	private IEnumerator HideRoutine()
	{
		return null;
	}
}
