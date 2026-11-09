using UnityEngine;

public class ShortCutPortalBoxEnableOnComputer : MonoBehaviour
{
	public OverworldMainDoorRobot computer;

	public SimplePortal toEnableOnComputerOpen;

	public void Init()
	{
		if (computer != null)
		{
			computer.OnCompleted -= Computer_OnOpen;
			computer.OnCompleted += Computer_OnOpen;
		}
		UpdateStates();
	}

	private void Start()
	{
		Init();
	}

	private void Computer_OnOpen()
	{
		UpdateStates();
	}

	private void Portal_OnPortalEnabledIfDidntStartEnabled()
	{
		UpdateStates();
	}

	private void UpdateStates()
	{
		bool isOpen = computer != null && computer.IsCompleted();
		if (toEnableOnComputerOpen != null && isOpen)
		{
			toEnableOnComputerOpen.OpenPortalFromOtherSide();
		}
		gameObject.SetActive(!isOpen);
	}
}
