using System.Threading.Tasks;
using Core;
using Core.UI;
using UnityEngine;

public class WhatTheCarPopup : MonoBehaviour
{
	public Sprite WTC_With_QR;

	public Sprite WTC_Image;

	private string linkToWTC;

	public async Task ShowAndAwait()
	{
		await ShowPopupWithLinks("UI_WTC_PROMO");
	}

	public async void ShowPopup()
	{
		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.DisableInteraction(hide: true);
		}
		await ShowAndAwait();
		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.EnableInteraction();
		}
	}

	private async Task ShowPopupWithLinks(string popupTextID)
	{
		if (RuntimeStoreData.instance != null && (RuntimeStoreData.instance.storeType == Store.Switch || RuntimeStoreData.instance.GetPlatformType(isBuilding: false) == EPlatformType.Switch))
		{
			ModalWindow modalWindow = ModalWindowSingleton.GetModalWindow(ModalWindowType.ImageDefault);
			if (modalWindow != null)
			{
				await modalWindow.ShowInfoAsync(rotatedToFakeLandscape: false, handleExitInput: true, "UI_WTC_PROMO", null, null, WTC_With_QR);
			}
			return;
		}
		ModalWindow modalWindow2 = ModalWindowSingleton.GetModalWindow(ModalWindowType.ImageDefault);
		if (modalWindow2 != null)
		{
			if (await modalWindow2.ShowMenuAsync(rotatedToFakeLandscape: false, handleExitInput: true, null, popupTextID, "UI_OK", "UI_CANCEL", WTC_Image, 0))
			{
				OpenUrl.OpenURL(linkToWTC);
			}
		}
	}

	public WhatTheCarPopup()
	{
		linkToWTC = "https://triband.net/wtc/";
	}
}
