using System;
using System.Threading.Tasks;
using Core.UI;
using Menu;
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
		if (image == null)
			return;
		if (i == null)
		{
			image.gameObject.SetActive(false);
		}
		else
		{
			image.gameObject.SetActive(true);
			image.sprite = i;
		}
	}

	public Task<bool> ShowMenuAsync(bool rotatedToFakeLandscape, bool handleExitInput, string header, string description, string confirmString = "ID_MENU_UI_YES", string cancelString = "ID_MENU_UI_NO", Sprite img = null, int selectedButtonIndex = 0)
	{
		var tcs = new TaskCompletionSource<bool>();
		ShowMenu(
			rotatedToFakeLandscape,
			handleExitInput,
			header,
			description,
			() => tcs.TrySetResult(true),
			() => tcs.TrySetResult(false),
			confirmString,
			cancelString,
			img,
			selectedButtonIndex);
		return tcs.Task;
	}

	public void ShowMenu(bool rotatedToFakeLandscape, bool handleExitInput, string header, string description, Action confirmAction, Action cancelAction = null, string confirmString = "ID_MENU_UI_YES", string cancelString = "ID_MENU_UI_NO", Sprite img = null, int selectedButtonIndex = 0)
	{
		var tcs = new TaskCompletionSource<bool>();
		SetImage(img);
		Action closeAct = () =>
		{
			cancelAction?.Invoke();
			HideWindow(false, tcs);
		};
		Action confirmAct = () =>
		{
			confirmAction?.Invoke();
			HideWindow(true, tcs);
		};
		Action cancelAct = () =>
		{
			cancelAction?.Invoke();
			HideWindow(false, tcs);
		};
		ShowMenuWindow(rotatedToFakeLandscape, handleExitInput, header, description, confirmString, cancelString, closeAct, confirmAct, cancelAct, selectedButtonIndex);
	}

	public Task ShowInfoAsync(bool rotatedToFakeLandscape, bool handleExitInput, string description, string confirmString = null, string cancelString = null, Sprite image = null)
	{
		var tcs = new TaskCompletionSource<bool>();
		ShowInfo(rotatedToFakeLandscape, handleExitInput, description, () => tcs.TrySetResult(true), confirmString, cancelString, image);
		return tcs.Task;
	}

	public void ShowInfo(bool rotatedToFakeLandscape, bool handleExitInput, string description, Action confirmAction, string confirmString = null, string cancelString = null, Sprite image = null)
	{
		SetImage(image);
		Action closeAct = () =>
		{
			confirmAction?.Invoke();
			HideWindow(false);
		};
		Action confirmAct = () =>
		{
			confirmAction?.Invoke();
			HideWindow(true);
		};
		ShowMenuWindow(rotatedToFakeLandscape, handleExitInput, null, description, confirmString, cancelString, closeAct, confirmAct, null, 0);
	}

	public void ShowMenu(string header, string description, Action confirmAction, Action cancelAction = null, string confirmString = "ID_MENU_UI_OK", string cancelString = "ID_MENU_UI_CANCEL", int selectedButtonIndex = 0)
	{
		ShowMenu(false, false, header, description, confirmAction, cancelAction, confirmString, cancelString, null, selectedButtonIndex);
	}

	public void ShowMenuWithClose(bool rotatedToFakeLandscape, bool handleExitInput, string header, string description, Action confirmAction, Action cancelAction, Action closeAction)
	{
		Action closeAct = () =>
		{
			closeAction?.Invoke();
			HideWindow(false);
		};
		Action confirmAct = () =>
		{
			confirmAction?.Invoke();
			HideWindow(true);
		};
		Action cancelAct = () =>
		{
			cancelAction?.Invoke();
			HideWindow(false);
		};
		ShowMenuWindow(rotatedToFakeLandscape, handleExitInput, header, description, "ID_MENU_UI_YES", "ID_MENU_UI_NO", closeAct, confirmAct, cancelAct, 0);
	}

	public void ShowMenuWithResponse(string header, string description, string positiveResponse, string negativeResponse, Action confirmAction, Action cancelAction = null)
	{
		ShowMenuWithResponse(false, false, header, description, positiveResponse, negativeResponse, confirmAction, cancelAction);
	}

	public void ShowMenuWithResponse(bool rotatedToFakeLandscape, bool handleExitInput, string header, string description, string positiveResponse, string negativeResponse, Action confirmAction, Action cancelAction = null, string confirmString = null, string cancelString = null)
	{
		ShowMenu(rotatedToFakeLandscape, handleExitInput, header, description, confirmAction, cancelAction, confirmString ?? "ID_MENU_UI_YES", cancelString ?? "ID_MENU_UI_NO");
	}

	public void ShowNotificationWindow(string header, string description, Action confirmAction)
	{
		ShowNotificationWindow(false, false, header, description, confirmAction);
	}

	private void ShowNotificationWindow(bool rotatedToFakeLandscape, bool handleExitInput, string header, string description, Action confirmAction)
	{
		Action confirmAct = () =>
		{
			confirmAction?.Invoke();
			HideWindow(true);
		};
		ShowMenuWindow(rotatedToFakeLandscape, handleExitInput, header, description, "ID_MENU_UI_OK", null, confirmAct, confirmAct, null, 0);
	}

	private void ShowMenuWindow(bool rotatedToFakeLandscape, bool handleExitInputFlag, string header, string description, string confirmString, string cancelString, Action closeAction, Action confirmAction, Action cancelAction, int selectedButtonIndex = 0)
	{
		if (scaleRoutine != null)
		{
			StopCoroutine(scaleRoutine);
			scaleRoutine = null;
		}
		if (Menu != null)
		{
			Menu.SetupMenu(rotatedToFakeLandscape, handleExitInputFlag, header, description, closeAction, confirmString, cancelString, confirmAction, cancelAction, selectedButtonIndex);
		}
		gameObject.SetActive(true);
		if (Animator != null)
			Animator.SetTrigger("Show");
		if (UIBackgroundFader.Exists || UIBackgroundFader.Instance != null)
			UIBackgroundFader.Instance.Register();
	}

	public void ForceClose()
	{
		HideWindow(false);
		if (UIBackgroundFader.Exists || UIBackgroundFader.Instance != null)
			UIBackgroundFader.Instance.Deregister();
	}

	public async void HideWindow(bool didSayYes, TaskCompletionSource<bool> finishedClosing = null)
	{
		if (Menu != null)
			Menu.HideWindow(didSayYes);
		if (Animator != null && gameObject.activeInHierarchy)
			Animator.SetTrigger("Hide");
		if (UIBackgroundFader.Exists || UIBackgroundFader.Instance != null)
			UIBackgroundFader.Instance.Deregister();
		await Task.Delay(150);
		if (this != null && gameObject != null)
			gameObject.SetActive(false);
		finishedClosing?.TrySetResult(didSayYes);
	}
}
