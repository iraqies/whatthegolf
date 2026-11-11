using Core;
using UnityEngine;
using UnityEngine.UI;

public class WinCounter : MonoBehaviour
{
	public int Goal;

	public Text ShowText;

	public string message = "{0}\nsheep caught";

	private int currentCounter;

	private void Start()
	{
		UpdateText();
	}

	public void CountUp()
	{
		currentCounter++;
		if (currentCounter >= Goal && Level.Instance != null && Level.Instance.Goal != null)
		{
			Level.Instance.Goal.GoalReached(gameObject);
		}
		UpdateText();
	}

	public void CountDown()
	{
		currentCounter--;
		UpdateText();
	}

	private void UpdateText()
	{
		if (ShowText != null)
		{
			ShowText.text = string.Format(message, currentCounter);
		}
	}
}
