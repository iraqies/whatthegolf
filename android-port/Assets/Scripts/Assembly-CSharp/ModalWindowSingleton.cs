using System.Collections.Generic;
using System.Linq;
using Core;
using Core.UI;
using UnityEngine;

public class ModalWindowSingleton : AddressableSingleton<ModalWindowSingleton>
{
	[SerializeField]
	private List<ModalWindow> _modalWindows;

	public static ModalWindow GetModalWindow(ModalWindowType type)
	{
		if (Instance == null)
			return null;
		if (Instance.gameObject != null)
			Instance.gameObject.SetActive(true);
		if (Instance._modalWindows == null)
			return null;
		return Instance._modalWindows.FirstOrDefault(w => w != null && w.Type == type) ?? Instance._modalWindows.FirstOrDefault(w => w != null);
	}

	public static bool IsAnyOpen()
	{
		if (Instance == null || Instance._modalWindows == null)
			return false;
		return Instance._modalWindows.Any(w => w != null && w.gameObject != null && w.gameObject.activeSelf);
	}

	public static void ForceClose()
	{
		if (Instance == null || Instance._modalWindows == null)
			return;
		foreach (var w in Instance._modalWindows)
		{
			if (w != null)
				w.ForceClose();
		}
	}

	private void Awake()
	{
		SoftRestart.onRestart += CloseOnRestart;
	}

	private void OnDestroy()
	{
		SoftRestart.onRestart -= CloseOnRestart;
	}

	private void CloseOnRestart()
	{
		if (_modalWindows == null)
			return;
		foreach (var w in _modalWindows)
		{
			if (w != null && w.gameObject != null && w.gameObject.activeSelf)
				w.HideWindow(false);
		}
	}
}
