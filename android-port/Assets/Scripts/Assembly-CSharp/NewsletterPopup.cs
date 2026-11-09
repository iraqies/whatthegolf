using System.Threading.Tasks;
using Core.UI;
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
		gameObject.SetActive(true);
		tcs?.TrySetResult(true);
	}

	private void ShowPopupWithLinks(Sprite QR, string link, string popupTextID)
	{
		if (!string.IsNullOrEmpty(link))
			Application.OpenURL(link);
		tcs?.TrySetResult(true);
	}

	private void Agree(string link)
	{
		if (!string.IsNullOrEmpty(link))
			Application.OpenURL(link);
		gameObject.SetActive(false);
		tcs?.TrySetResult(true);
	}

	private void Disagree()
	{
		gameObject.SetActive(false);
		tcs?.TrySetResult(false);
	}

	private void EnableInteraction() { }
	private void DisableInteraction() { }
}
