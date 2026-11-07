using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SaveSlotInfo : MonoBehaviour
{
	public TextMeshProUGUI timePlayedText;

	public TextMeshProUGUI lastPlayedText;

	public TextMeshProUGUI progressText;

	public Transform flagVisualContainer;

	public UnityAction ResetEvent;

	public Button ResetButton;

	private int currentSelectedSave;

	public void InstantiateFlagVisual(GameObject flagObject)
	{
	}

	public void Show(int slotIndex)
	{
	}

	private void ResetValues()
	{
	}

	private string LastTimePlayed()
	{
		return null;
	}

	private bool CanBeReset()
	{
		return false;
	}

	private string TimePlayed()
	{
		return null;
	}

	public static string TotalPercentageComplete(int s)
	{
		return null;
	}
}
