using System;
using System.Threading.Tasks;
using Core.UI;
using UnityEngine;

public class ModalWindow : MonoBehaviour
{
	public BasicMenu Menu;

	public Animator Animator;

	public SVGImage image;

	private Coroutine scaleRoutine;

	public AppleArcadeTextMeshProTextPreprocessor appleArcadeTextMeshProTextPreprocessor;

	public ModalWindowType Type;

	private void SetImage(Sprite i)
	{
	}

	public Task<bool> ShowMenuAsync(bool rotatedToFakeLandscape, bool handleExitInput, string header, string description, string confirmString = "ID_MENU_UI_YES", string cancelString = "ID_MENU_UI_NO", Sprite img = null, int selectedButtonIndex = 0)
	{
		return null;
	}

	public void ShowMenu(bool rotatedToFakeLandscape, bool handleExitInput, string header, string description, Action confirmAction, Action cancelAction = null, string confirmString = "ID_MENU_UI_YES", string cancelString = "ID_MENU_UI_NO", Sprite img = null, int selectedButtonIndex = 0)
	{
	}

	public Task ShowInfoAsync(bool rotatedToFakeLandscape, bool handleExitInput, string description, string confirmString = null, string cancelString = null, Sprite image = null)
	{
		return null;
	}

	public void ShowInfo(bool rotatedToFakeLandscape, bool handleExitInput, string description, Action confirmAction, string confirmString = null, string cancelString = null, Sprite image = null)
	{
	}

	public void ShowMenu(string header, string description, Action confirmAction, Action cancelAction = null, string confirmString = "ID_MENU_UI_OK", string cancelString = "ID_MENU_UI_CANCEL", int selectedButtonIndex = 0)
	{
	}

	public void ShowMenuWithClose(bool rotatedToFakeLandscape, bool handleExitInput, string header, string description, Action confirmAction, Action cancelAction, Action closeAction)
	{
	}

	public void ShowMenuWithResponse(string header, string description, string positiveResponse, string negativeResponse, Action confirmAction, Action cancelAction = null)
	{
	}

	public void ShowMenuWithResponse(bool rotatedToFakeLandscape, bool handleExitInput, string header, string description, string positiveResponse, string negativeResponse, Action confirmAction, Action cancelAction = null, string confirmString = null, string cancelString = null)
	{
	}

	public void ShowNotificationWindow(string header, string description, Action confirmAction)
	{
	}

	private void ShowNotificationWindow(bool rotatedToFakeLandscape, bool handleExitInput, string header, string description, Action confirmAction)
	{
	}

	private void ShowMenuWindow(bool rotatedToFakeLandscape, bool handleExitInputFlag, string header, string description, string confirmString, string cancelString, Action closeAction, Action confirmAction, Action cancelAction, int selectedButtonIndex = 0)
	{
	}

	public void ForceClose()
	{
	}

	public void HideWindow(bool didSayYes, TaskCompletionSource<bool> finishedClosing = null)
	{
	}
}
