using System.Linq;
using System.Threading.Tasks;
using Core;
using Core.UI;
using I2.Loc;
using UnityEngine;

public class NewsletterPopup : MonoBehaviour
{
	public ExternalLinks linksList;

	public ExternalLinks.LinkType popupLinkType;

	public ModalWindowType modalWindowType;

	private TaskCompletionSource<bool> tcs;

	private bool _shouldEnableInteraction;

	public async Task ShowAndAwait()
	{
		tcs = new TaskCompletionSource<bool>();
		ShowPopup();
		await tcs.Task;
	}

	public void ShowPopup()
	{
		_shouldEnableInteraction = true;
		if (linksList == null)
		{
			tcs?.TrySetResult(false);
			return;
		}
		var store = RuntimeStoreData.instance != null ? RuntimeStoreData.instance.storeType : Store.Arcade;
		var platformLinks = linksList.platforms?.FirstOrDefault(p => p != null && p.platformType == store)
			?? linksList.platforms?.FirstOrDefault(p => p != null && p.links != null && p.links.Count > 0);
		if (platformLinks == null || platformLinks.links == null)
		{
			tcs?.TrySetResult(false);
			return;
		}
		var qrEntry = platformLinks.links.FirstOrDefault(i => i != null && i.typeOfLink == popupLinkType);
		Sprite qr = qrEntry != null ? qrEntry.QRCode : null;
		string url = qrEntry != null ? qrEntry.url : null;
		if (store == Store.Playstation && popupLinkType == ExternalLinks.LinkType.TERMSOFERVICE && !string.IsNullOrEmpty(url))
		{
			string langCode = LocalizationManager.CurrentLanguageCode;
			if (!string.IsNullOrEmpty(langCode))
				url = string.Format(url, langCode.ToLowerInvariant());
		}
		var textList = store == Store.Playstation ? linksList.playstationPopupText : linksList.genericPopupText;
		var textEntry = textList?.FirstOrDefault(i => i != null && i.typeOfLink == popupLinkType);
		string popupTextID = textEntry != null ? textEntry.textID : string.Empty;
		ShowPopupWithLinks(qr, url, popupTextID);
	}

	private void ShowPopupWithLinks(Sprite QR, string link, string popupTextID)
	{
		DisableInteraction();
		var mw = ModalWindowSingleton.GetModalWindow(modalWindowType);
		if (mw != null)
		{
			mw.ShowMenu(
				false,
				true,
				string.Empty,
				popupTextID,
				() => Agree(link),
				Disagree,
				"ID_MENU_UI_YES",
				"ID_MENU_UI_NO",
				QR);
		}
		else
		{
			Agree(link);
		}
	}

	private void Agree(string link)
	{
		if (_shouldEnableInteraction)
			EnableInteraction();
		tcs?.TrySetResult(true);
		if (!string.IsNullOrEmpty(link))
			Application.OpenURL(link);
	}

	private void Disagree()
	{
		if (_shouldEnableInteraction)
			EnableInteraction();
		tcs?.TrySetResult(false);
	}

	private void EnableInteraction()
	{
		if (_shouldEnableInteraction && OverworldManager2d.HasInstance && OverworldManager2d.Instance != null)
			OverworldManager2d.Instance.EnableInteraction();
	}

	private void DisableInteraction()
	{
		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null)
			OverworldManager2d.Instance.DisableInteraction(true);
	}
}
