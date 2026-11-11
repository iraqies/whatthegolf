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
		ShowText.text = string.Format(message, currentCounter);
	}

	public void CountUp()
	{
		currentCounter++;
		if (currentCounter >= Goal)
		{
			Level.Instance.Goal.Complete("SHEEP");
		}
		ShowText.text = string.Format(message, currentCounter);
	}

	public void CountDown()
	{
		currentCounter--;
		ShowText.text = string.Format(message, currentCounter);
	}

	private void UpdateText()
	{
		ShowText.text = string.Format(message, currentCounter);
	}
}
