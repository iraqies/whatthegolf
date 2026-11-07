using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DailyChallengeScoreEntry : MonoBehaviour
{
	public TextMeshProUGUI PositionText;

	public TextMeshProUGUI NameText;

	public TextMeshProUGUI ScoreText;

	public Image bagground;

	public CanvasGroup Alpha;

	private static Color? nameColorNormal;

	private bool focus;

	public Image PositionBelow10Image;

	public Image PositionAbove10Image;

	public bool isEvenNumbered;

	private static HashSet<char> legalCharacters;

	private void Start()
	{
	}

	public void SetBaggroundColor(Color col)
	{
	}

	private void Update()
	{
	}

	public void SetNewColor()
	{
	}

	private string ReplaceBadCharacters(string text)
	{
		return null;
	}

	public void SetData(int position, string name, int score, bool focus = false, bool useLocalizedText = false)
	{
	}

	public void Clear()
	{
	}
}
