using System.Collections.Generic;
using Core;
using TMPro;
using UnityEngine;

public class InGameStatsUI : MonoBehaviour
{
	[SerializeField]
	private RectTransform parStrokesTransform;

	[SerializeField]
	private TextMeshProUGUI parStrokesText;

	[SerializeField]
	private RectTransform catsCountTransform;

	[SerializeField]
	private float spacing = 80f;

	private List<RectTransform> elements = new List<RectTransform>();

	private List<RectTransform> activeElements = new List<RectTransform>();

	public void Initialize()
	{
		elements = new List<RectTransform>();
		if (parStrokesTransform != null) elements.Add(parStrokesTransform);
		if (catsCountTransform != null) elements.Add(catsCountTransform);
	}

	public void Load(LevelData levelData)
	{
		if (elements == null || elements.Count == 0)
			Initialize();
		activeElements = new List<RectTransform>();
		if (parStrokesTransform != null)
		{
			parStrokesTransform.gameObject.SetActive(false);
		}
		if (catsCountTransform != null)
		{
			catsCountTransform.gameObject.SetActive(false);
		}
		UpdateElementPositions();
	}

	private void UpdateElementPositions()
	{
		if (activeElements == null) return;
		for (int i = 0; i < activeElements.Count; i++)
		{
			if (activeElements[i] != null)
			{
				Vector2 ap = activeElements[i].anchoredPosition;
				activeElements[i].anchoredPosition = new Vector2(i * spacing, ap.y);
			}
		}
	}
}
