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
	private float spacing;

	private List<RectTransform> elements;

	private List<RectTransform> activeElements;

	public void Initialize()
	{
	}

	public void Load(LevelData levelData)
	{
	}

	private void UpdateElementPositions()
	{
	}
}
