using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventOnChallengeButtons : MonoBehaviour
{
	public enum ButtonCallbackType
	{
		OnAnyPressedDown = 0,
		OnAllPressedDown = 1,
		OnAnyPressedUp = 2,
		OnAllPressedUp = 3
	}

	public ButtonCallbackType DoActionOn;

	public List<ChallengeButton> Buttons;

	public UnityEvent OnAction;

	private void Awake()
	{
	}

	private void OnButtonTrigger(ChallengeButton button)
	{
	}
}
