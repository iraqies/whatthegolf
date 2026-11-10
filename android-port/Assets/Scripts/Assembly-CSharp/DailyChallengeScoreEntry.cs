using System.Collections.Generic;
using System.Text;
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

	private static HashSet<char> legalCharacters = new HashSet<char>("abcdefghijklmnopqrstuvwxyz0123456789 _-.".ToCharArray());

	private void Start()
	{
		if (!nameColorNormal.HasValue && NameText != null)
		{
			nameColorNormal = NameText.color;
		}
	}

	public void SetBaggroundColor(Color col)
	{
		if (bagground != null)
		{
			bagground.color = col;
		}
	}

	private void Update()
	{
		if (focus && nameColorNormal.HasValue && NameText != null)
		{
			bool useWhite = Mathf.CeilToInt(Time.time * 4f) % 2 != 0;
			NameText.color = useWhite ? Color.white : nameColorNormal.Value;
		}
	}

	public void SetNewColor()
	{
	}

	private string ReplaceBadCharacters(string text)
	{
		if (string.IsNullOrEmpty(text))
			return "";

		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < text.Length; i++)
		{
			char c = text[i];
			if (legalCharacters != null && legalCharacters.Contains(char.ToLower(c)))
			{
				sb.Append(c);
			}
			else
			{
				sb.Append('_');
			}
		}
		return sb.ToString();
	}

	public void SetData(int position, string name, int score, bool focus = false, bool useLocalizedText = false)
	{
		this.focus = focus;
		if (NameText != null)
		{
			if (!focus && nameColorNormal.HasValue)
			{
				NameText.color = nameColorNormal.Value;
			}
			if (!string.IsNullOrEmpty(name))
			{
				if (useLocalizedText)
				{
					var loc = NameText.gameObject.GetComponent<TextMeshProLocalized>();
					if (loc != null)
					{
						loc.ChangeText(name);
					}
				}
				else
				{
					NameText.isRightToLeftText = false;
					NameText.text = ReplaceBadCharacters(name);
				}
			}
		}
		if (ScoreText != null)
		{
			ScoreText.text = score >= 1 ? score.ToString() : "";
		}
		if (PositionText != null)
		{
			PositionText.text = position >= 1 ? position.ToString() : "";
			if (PositionAbove10Image != null && PositionBelow10Image != null)
			{
				if (position < 10)
				{
					PositionAbove10Image.enabled = false;
					PositionBelow10Image.enabled = true;
				}
				else
				{
					PositionAbove10Image.enabled = true;
					PositionBelow10Image.enabled = false;
				}
			}
		}
	}

	public void Clear()
	{
		if (NameText != null)
			NameText.text = "";
		if (ScoreText != null)
			ScoreText.text = "";
		if (PositionText != null)
			PositionText.text = "";
		if (Alpha != null)
			Alpha.alpha = 0f;
	}
}
