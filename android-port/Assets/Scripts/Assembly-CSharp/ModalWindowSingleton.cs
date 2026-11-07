using System.Collections.Generic;
using Core;
using Core.UI;
using UnityEngine;

public class ModalWindowSingleton : AddressableSingleton<ModalWindowSingleton>
{
	[SerializeField]
	private List<ModalWindow> _modalWindows;

	public static ModalWindow GetModalWindow(ModalWindowType type)
	{
		return null;
	}

	public static bool IsAnyOpen()
	{
		return false;
	}

	public static void ForceClose()
	{
	}

	private void Awake()
	{
	}

	private void CloseOnRestart()
	{
	}
}
